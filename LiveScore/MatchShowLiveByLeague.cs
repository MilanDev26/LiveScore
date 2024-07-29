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
    public partial class MatchShowLiveByLeague : UserControl
    {
        public MatchShowLiveByLeague()
        {
            InitializeComponent();
        }
        public MatchShowLiveByLeague(int screenWidth, Match match, Color colorBackgroundMatch, Color colorTextColorMatch, Color colorFinalScore, Color colorPartialScore, Color colorTextColorHour,
            Color colorBlinkColor, Font font, int timeViewBlink)
        {
            InitializeComponent();
            float tmpFontSize = this.Font.Size;
            Height = (int)(font.Size / tmpFontSize * Height) + 1;
            Width = screenWidth;

            pictureBox1.Location = new Point(
                (int)(0.1 * Width),
                pictureBox1.Location.Y
                );
            label1.Location = new Point(
                (int)(0.16 * Width),
                label1.Location.Y
                );
            matchStatus.Location = new Point(
                (int)(0.23 * Width),
                matchStatus.Location.Y
                );
            homeTeam.Location = new Point(
                (int)(0.35 * Width),
                homeTeam.Location.Y
                );
            result.Location = new Point(
                (int)(0.55 * Width),
                result.Location.Y
                );
            awayTeam.Location = new Point(
                (int)(0.72 * Width),
                awayTeam.Location.Y
                );
            halfTime.Location = new Point(
                (int)(0.9 * Width),
                halfTime.Location.Y
                );

            matchTime.Font = font;
            matchStatus.Font = font;
            homeTeam.Font = font;
            awayTeam.Font = font;
            result.Font = font;
            halfTime.Font = font;

            matchTime.Text = match.match_time;
            matchStatus.Text = match.match_status;
            
            homeTeam.Text = match.match_hometeam_name;
            awayTeam.Text = match.match_awayteam_name;
            result.Text = match.match_hometeam_score + "-" + match.match_awayteam_score;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            halfTime.ForeColor = colorPartialScore;

            if (match.match_live == "1" && !match.match_status.Equals("Finished"))
            {
                halfTime.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                pictureBox1.Image = Image.FromFile(@"Resources/Circle_Green.png");
                label1.Text = "live";
                matchStatus.Text = match.match_status + "°";

                if (match.match_status.Equals("Half Time"))
                    matchStatus.Text = "1° Tempo";
            }
            else
            {
                label1.Hide();
                halfTime.Text = "-";
                if (match.match_status.Equals("Finished")) 
                {
                    halfTime.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    pictureBox1.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    label1.Hide();
                    matchStatus.Text = "Terminata";
                }
                if (match.match_status.Equals("Awarded"))
                {
                    halfTime.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    pictureBox1.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    label1.Hide();
                    matchStatus.Text = "Premiata";
                }
                if (match.match_status.Equals("After ET"))
                {
                    halfTime.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    pictureBox1.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    //matchStatus.Text = "After ET";
                    matchStatus.Text = "Dopo ET";
                }
                if (match.match_status.Equals("After Pen."))
                {
                    result.Text = match.match_hometeam_score + "(" + match.match_hometeam_penalty_score + ")-" +
                                    match.match_awayteam_score + "(" + match.match_awayteam_penalty_score + ")";
                    halfTime.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    pictureBox1.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    //matchStatus.Text = "After Pen.";
                    matchStatus.Text = "Dopo Rigori.";
                }
                if (match.match_status == "")
                {
                    pictureBox1.Image = Image.FromFile(@"Resources/monitor2.png");
                    label1.Text = "-";
                }
                if (match.match_status == "Postponed")
                {
                    pictureBox1.Image = Image.FromFile(@"Resources/monitor2.png");
                    label1.Text = "Post.";
                    matchStatus.Text = "Post.";
                }
                if (match.match_status == "Susp.")
                {
                    pictureBox1.Image = Image.FromFile(@"Resources/monitor2.png");
                    //label1.Text = "Susp.";
                    label1.Text = "Sosp.";
                }
                if (match.match_status == "Delayed")
                {
                    pictureBox1.Image = Image.FromFile(@"Resources/monitor2.png");
                    //label1.Text = "Susp.";
                    matchStatus.Text = "Ritardo";
                }
            }

            matchTime.ForeColor = colorTextColorHour;
            matchStatus.ForeColor = colorTextColorHour;
            result.ForeColor = colorFinalScore;
            halfTime.ForeColor = colorPartialScore;
            homeTeam.ForeColor = colorTextColorMatch;
            awayTeam.ForeColor = colorTextColorMatch;
            label1.ForeColor = colorPartialScore;
            if (timeViewBlink > 0)
            {
                BackColor = colorBlinkColor;
            }
            else
            {
                BackColor = colorBackgroundMatch;
            }
        }
    }
}
