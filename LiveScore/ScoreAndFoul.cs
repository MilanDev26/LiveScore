using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveScore
{
    public class ScoreAndFoul
    {
        public string time { get; set; }
        public int timeInt { get; set; }
        public string home_score { get; set; }
        public string away_score { get; set; }
        public string info { get; set; }
        public string score_info_time { get; set; }
        public string home_fault { get; set; }
        public string away_fault { get; set; }
        public bool check { get; set; }
    }
}
