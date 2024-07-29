using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveScore
{
    public class League
    {
        public string country_id { get; set; }
        public string country_name { get; set; }
        public string league_id { get; set; }
        public string league_name { get; set; }
        public string league_season { get; set; }
        public string league_logo { get; set; }
        public string country_logo { get; set; }
        public bool check_show { get; set; } = true;
    }
}
