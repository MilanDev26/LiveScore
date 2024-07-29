using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveScore
{
    public class Match
    {
        public string match_id { get; set; }
        public string country_id { get; set; }
        public string country_name { get; set; }
        public string league_id { get; set; }
        public string league_name { get; set; }
        public string match_date { get; set; }
        public string match_status { get; set; }
        public string match_time { get; set; }
        public string match_hometeam_id { get; set; }
        public string match_hometeam_name { get; set; }
        public string match_hometeam_score { get; set; }
        public string match_awayteam_id { get; set; }
        public string match_awayteam_name { get; set; }
        public string match_awayteam_score { get; set; }
        public string match_hometeam_halftime_score { get; set; }
        public string match_awayteam_halftime_score { get; set; }
        public string match_hometeam_extra_score { get; set; }
        public string match_awayteam_extra_score { get; set; }
        public string match_hometeam_penalty_score { get; set; }
        public string match_awayteam_penalty_score { get; set; }
        public string match_hometeam_ft_score { get; set; }
        public string match_awayteam_ft_score { get; set; }
        public string match_hometeam_system { get; set; }
        public string match_awayteam_system { get; set; }
        public string match_live { get; set; }
        public string match_round { get; set; }
        public string match_stadium { get; set; }
        public string match_referee { get; set; }
        public string team_home_badge { get; set; }
        public string team_away_badge { get; set; }
        public string league_logo { get; set; }
        public string country_logo { get; set; }
        public string league_year { get; set; }
        public string fk_stage_key { get; set; }
        public string stage_name { get; set; }
        public DateTime? score_updated_time { get; set; }
        public List<Score> goalscorer { get; set; }
        public List<Card> cards { get; set; }
        public static int ALL { get; set; } = 0;
        public static int FINISHED { get; set; } = 1;
        public static int NO_STARTED { get; set; } = 2;
        public static int LIVE { get; set; } = 3;
    }
}
