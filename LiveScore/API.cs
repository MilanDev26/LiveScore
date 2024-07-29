using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveScore
{
    public class API
    {
        public static int showNum = 0;
        public static int TimeInt(string time)
        {
            var times = time.Split('+');
            var val = int.Parse(times[0]) * 1000;
            if (times.Length > 1) val += int.Parse(times[1]);
            return val;
        }
        public static List<League> GetLeagueList()
        {
            List<League> returnValue = new List<League>();
            string url = "https://apiv3.apifootball.com";
            var client = new RestClient(url);
            var request = new RestRequest("/", Method.Get);
            request.AddQueryParameter("action", "get_leagues");
            request.AddQueryParameter("APIkey", "9e4e769e1e5118819752cc55b38e800297b9a7f572e27d277f66ec24b6c98e95");

            RestResponse response = null;
            var asyncTask = System.Threading.Tasks.Task.Run(async () =>
            {
                response = await client.ExecuteAsync(request);
            });

            asyncTask.Wait();

            var output = response.Content;
            if (output.Contains("error"))
                return null;
            returnValue = JsonConvert.DeserializeObject<List<League>>(output);
            returnValue = returnValue.OrderBy(i => i.country_name).
             ThenBy(i => i.league_name).ToList();
            return returnValue;
        }

        public static Task<List<Match>> GetMatches(League league, string date)
        {
            string url = "https://apiv3.apifootball.com";
            var client = new RestClient(url);
            var request = new RestRequest("/", Method.Get);
            request.AddParameter("action", "get_events");
            request.AddParameter("from", date);
            request.AddParameter("to", date);
            request.AddParameter("APIkey", "9e4e769e1e5118819752cc55b38e800297b9a7f572e27d277f66ec24b6c98e95");


            return client.ExecuteAsync(request).ContinueWith(task =>
            {
                var response = task.Result;

                var output = response.Content;
                if (output == null)
                {
                    return null;
                }
                if (output.ToString().Contains("error"))
                {
                    return null;
                }
                if (output.ToString().Contains("<html"))
                    return null;
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(output);
                matches = matches.OrderBy(i => i.country_name).
                 ThenBy(i => i.league_name).
                 ThenBy(i => i.match_time).ToList();
                return matches;
            });
        }
    }
}
