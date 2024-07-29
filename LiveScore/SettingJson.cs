using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveScore
{
    public class SettingJson
    {
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public int RefreshPageTime { get; set; }
        public int GetDataTime { get; set; }
        public Font font { get; set; }
        public Color BackgroundMatch { get; set; }
        public Color BackgroundLeague{ get; set; }
        public Color BlinkOfGoal{ get; set; }
        public Color TextColorLeague{ get; set; }
        public Color TextColorHour{ get; set; }
        public Color FinalScore{ get; set; }
        public Color PartialScore{ get; set; }
        public Color BackgroundRowGoal{ get; set; }
        public Color TextColorMatch{ get; set; }
    }
}
