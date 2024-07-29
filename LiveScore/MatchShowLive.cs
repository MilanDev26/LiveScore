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
    public partial class MatchShowLive : UserControl
    {
        public MatchShowLive()
        {
            InitializeComponent();
        }
        public MatchShowLive(int w, Match match, Color colorTextColorLeague , Color colorBackgroundMatch, Color colorTextColorMatch, Color colorFinalScore, Color colorPartialScore, Color colorTextColorHour, Color colorBlinkOfGoal, Font font, int timeViewBlink)
        {
            InitializeComponent();
            float tmpFontSize = this.Font.Size;
            Height = (int)(font.Size / tmpFontSize * Height) + 1;
            Width = w;

            PBoxMatchState.Location = new Point(
                (int)(0.1 * Width),
                PBoxMatchState.Location.Y
                );
            matchStatus.Location = new Point(
                (int)(0.15 * Width),
                matchStatus.Location.Y
                );
            leagueName.Location = new Point(
                (int)(0.25 * Width),
                matchStatus.Location.Y
                );
            homeTeam.Location = new Point(
                (int)(0.56 * Width),
                homeTeam.Location.Y
                );
            result.Location = new Point(
                (int)(0.7 * Width),
                result.Location.Y
                );
            awayTeam.Location = new Point(
                (int)(0.75 * Width),
                awayTeam.Location.Y
                );
            halfScore.Location = new Point(
                (int)(0.91 * Width),
                halfScore.Location.Y
                );

            matchTime.Font = font;
            matchStatus.Font = font;
            leagueName.Font = font;
            homeTeam.Font = font;
            result.Font = font;
            awayTeam.Font = font;
            halfScore.Font = font;

            matchTime.Text = match.match_time;
            matchStatus.Text = match.match_status;
            leagueName.Text = match.country_name + ": " + match.league_name;
            homeTeam.Text = match.match_hometeam_name;
            result.Text = match.match_hometeam_score + "-" + match.match_awayteam_score;
            awayTeam.Text = match.match_awayteam_name;
            PBoxMatchState.SizeMode = PictureBoxSizeMode.StretchImage;

            if (match.match_live == "1" && !match.match_status.Equals("Finished"))
            {
                halfScore.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                PBoxMatchState.Image = Image.FromFile(@"Resources/Circle_Green.png");
                matchStatus.Text = match.match_status + "°";
                if (match.match_status.Equals("Half Time"))
                    matchStatus.Text = "1° Tempo";
            }
            else
            {
                halfScore.Text = "-";
                if (match.match_status.Equals("Finished"))
                {
                    halfScore.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    PBoxMatchState.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    //matchStatus.Text = "Finished";
                    matchStatus.Text = "Terminata";
                }
                if (match.match_status.Equals("After ET"))
                {
                    halfScore.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    PBoxMatchState.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    //Text = "After ET";
                    matchStatus.Text = "Dopo ET";
                }
                if (match.match_status.Equals("After Pen."))
                {
                    result.Text = match.match_hometeam_score + "(" + match.match_hometeam_penalty_score + ")-" + 
                                    match.match_awayteam_score + "(" + match.match_awayteam_penalty_score + ")";
                    halfScore.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    PBoxMatchState.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    //matchStatus.Text = "After Pen.";
                    matchStatus.Text = "Dopo Rigori.";

                }
                if (match.match_status == "")
                {
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png");
                    matchStatus.Text = "-";
                }
                if (match.match_status == "Postponed")
                {
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png");
                    matchStatus.Text = "Post.";
                }
                if (match.match_status == "Susp.")
                {
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png");
                    matchStatus.Text = "Sosp.";
                }
                if (match.match_status == "Delayed")
                {
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png");
                    matchStatus.Text = "Ritardo";
                }
            }

            matchTime.ForeColor = colorTextColorHour;
            matchStatus.ForeColor = colorTextColorHour;
            result.ForeColor = colorFinalScore;
            halfScore.ForeColor = colorPartialScore;
            leagueName.ForeColor = colorTextColorLeague;
            homeTeam.ForeColor = colorTextColorMatch;
            awayTeam.ForeColor = colorTextColorMatch;
            if (timeViewBlink > 0)
            {
                BackColor = colorBlinkOfGoal;
            }
            else
                BackColor = colorBackgroundMatch;
        }
    }
}
