using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveScore
{
    public partial class LeagueShow : UserControl
    {
        public LeagueShow(int w, string leagueName, Color backColor, Color textColor, Font font, bool liveStatus)
        {
            InitializeComponent();
            this.BackColor = backColor;
            label1.ForeColor = textColor;
            label1.Text = leagueName;
            Width = w;

            float tmpFontSize = label1.Font.Size;
            Height = (int)((font.Size / tmpFontSize) * Height);

            label1.Font = font;
        }
    }
}
