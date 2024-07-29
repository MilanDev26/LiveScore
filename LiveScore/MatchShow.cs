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
    public partial class MatchShow : UserControl
    {
        public MatchShow()
        {
            InitializeComponent();
        }
        public MatchShow(int w, Match match, Color colorBackgroundMatch, Color colorTextColorMatch, Color colorFinalScore, Color colorPartialScore, Color colorTextColorHour, Color colorBlinkOfGoal, Font font, int timeViewBlink)
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
                (int)(0.16 * Width),
                matchStatus.Location.Y
                );
            homeTeam.Location = new Point(
                (int)(0.29 * Width),
                homeTeam.Location.Y
                );
            awayTeam.Location = new Point(
                (int)(0.51 * Width),
                awayTeam.Location.Y
                );
            matchResult.Location = new Point(
                (int)(0.78 * Width),
                matchResult.Location.Y
                );
            HalfResult.Location = new Point(
                (int)(0.9 * Width),
                HalfResult.Location.Y
                );
            if (Width == 625)
            {
                homeTeam.Location = new Point(
                   (int)(0.29 * Width) + 15,
                   homeTeam.Location.Y
                   );
                awayTeam.Location = new Point(
                (int)(0.51 * Width) - 15,
                awayTeam.Location.Y
                );
            }
            if (Width == 705)
            {
                homeTeam.Location = new Point(
                   (int)(0.29 * Width) + 20,
                   homeTeam.Location.Y
                   );
                awayTeam.Location = new Point(
                (int)(0.51 * Width) - 20,
                awayTeam.Location.Y
                );
            }
            BackColor = colorBackgroundMatch;
            homeTeam.ForeColor = colorTextColorMatch;
            awayTeam.ForeColor = colorTextColorMatch;
            matchResult.ForeColor = colorFinalScore;
            HalfResult.ForeColor = colorPartialScore;
            matchStatus.ForeColor = colorPartialScore;
            matchTime.ForeColor = colorTextColorHour;
            matchStatus.ForeColor = colorTextColorHour;
            matchStatus.Hide();

            matchTime.Font = font;
            homeTeam.Font = font;
            awayTeam.Font = font;
            matchResult.Font = font;
            HalfResult.Font = font;
            matchStatus.Font = font;

            matchTime.Text = match.match_time;
            homeTeam.Text = match.match_hometeam_name;
            awayTeam.Text = match.match_awayteam_name;
            PBoxMatchState.SizeMode = PictureBoxSizeMode.StretchImage;

            if (match.match_live == "1" && !match.match_status.Equals("Finished"))
            {
                if (timeViewBlink > 0)
                    BackColor = colorBlinkOfGoal;
                matchStatus.Show();
                matchStatus.Text = match.match_status + "°";
                if (match.match_status.Equals("Result"))
                    matchStatus.Text = "Finale.";
                if (match.match_status.Equals("Half Time"))
                    matchStatus.Text = "1° Tempo";
                matchResult.Text = match.match_hometeam_score + "-" + match.match_awayteam_score;
                matchResult.ForeColor = colorFinalScore;
                HalfResult.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                HalfResult.ForeColor = colorPartialScore;
                PBoxMatchState.Image = Image.FromFile(@"Resources/Circle_Green.png");
            }
            else
            {
                if (match.match_status.Equals("Finished"))
                {
                    matchStatus.Show();
                    //matchStatus.Text = match.match_status;
                    matchStatus.Text = "Terminata";
                    matchResult.Text = match.match_hometeam_score + "-" + match.match_awayteam_score;
                    matchResult.ForeColor = colorFinalScore;
                    HalfResult.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    HalfResult.ForeColor = colorPartialScore;
                    PBoxMatchState.Image = Image.FromFile(@"Resources/Circle_Red.png");
                }  
                if (match.match_status.Equals("After Pen."))
                {
                    PBoxMatchState.Image = Image.FromFile(@"Resources/Penalty24.png");
                    matchStatus.Show();
                    //matchStatus.Text = match.match_status;
                    matchStatus.Text = "Dopo Rigori.";
                    matchResult.Text = match.match_hometeam_score + "(" + match.match_hometeam_penalty_score + ")-" + 
                                        match.match_awayteam_score + "(" + match.match_awayteam_penalty_score + ")";
                    matchResult.ForeColor = colorFinalScore;
                    HalfResult.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    HalfResult.ForeColor = colorPartialScore;
                }
                if (match.match_status.Equals("After ET"))
                {
                    PBoxMatchState.Image = Image.FromFile(@"Resources/Circle_Red.png");
                    matchStatus.Show();
                    //matchStatus.Text = match.match_status;
                    matchStatus.Text = "Dopo ET";
                    matchResult.Text = match.match_hometeam_score + "-" + match.match_awayteam_score;
                    matchResult.ForeColor = colorFinalScore;
                    HalfResult.Text = "(" + match.match_hometeam_halftime_score + "-" + match.match_awayteam_halftime_score + ")";
                    HalfResult.ForeColor = colorPartialScore;
                }
                if (match.match_status == "")
                {
                    matchResult.Text = "-";
                    matchResult.ForeColor = colorFinalScore;
                    HalfResult.Text = "-";
                    HalfResult.ForeColor = colorPartialScore;
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png"); 
                }
                if (match.match_status == "Postponed")
                {
                    match.match_status = "Post.";
                    matchResult.Text = "Post.";
                    matchResult.ForeColor = colorFinalScore;
                    HalfResult.Text = "Post.";
                    HalfResult.ForeColor = colorPartialScore;
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png");
                }
                if (match.match_status == "Susp.")
                {
                    matchResult.Text = "Sosp.";
                    matchResult.ForeColor = colorFinalScore;
                    HalfResult.Text = "Sosp.";
                    HalfResult.ForeColor = colorPartialScore;
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png");
                }
                if (match.match_status == "Delayed")
                {
                    match.match_status = "Ritardo.";
                    matchResult.Text = "Ritardo.";
                    matchResult.ForeColor = colorFinalScore;
                    HalfResult.Text = "Ritardo.";
                    HalfResult.ForeColor = colorPartialScore;
                    PBoxMatchState.Image = Image.FromFile(@"Resources/monitor2.png");
                }
            }
        }
    }
}
