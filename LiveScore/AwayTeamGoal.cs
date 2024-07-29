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
    public partial class AwayTeamGoal : UserControl
    {
        public AwayTeamGoal()
        {
            InitializeComponent();
        }
        public AwayTeamGoal(int w, string score, Color colorGoal, Color blinkOfGoal, int timeViewBlink, bool checkPenalty, bool checkScore)
        {
            InitializeComponent();
            awayTeamScore.Text = score;
            awayTeamScore.ForeColor = colorGoal;
            Width = w;

            awayTeamScore.Location = new Point(
                (int)(0.72 * Width),
                awayTeamScore.Location.Y
                );
            pictureBox1.Location = new Point(
                awayTeamScore.Location.X - 15,
                pictureBox1.Location.Y
                );
            pictureBox2.Location = new Point(
                pictureBox1.Location.X + 6,
                pictureBox2.Location.Y
                );
            pictureBox3.Location = new Point(
                pictureBox1.Location.X + 3,
                pictureBox3.Location.Y
                );

            pictureBox2.Width = pictureBox2.Width > (int)(1.7 * (awayTeamScore.Width)) ? pictureBox2.Width : (int)(1.7 * awayTeamScore.Width);
            pictureBox3.Width = pictureBox2.Width - 6;

            pictureBox2.BackColor = blinkOfGoal;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (checkScore)
            {
                if (checkPenalty)
                    pictureBox1.Image = Image.FromFile(@"Resources/Penalty24.png");
                else
                    pictureBox1.Image = Image.FromFile(@"Resources/Goal24.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"Resources/RedCard24.png");
            }
            if (timeViewBlink > 0)
            {
                pictureBox2.Width = (int)(1.6 * awayTeamScore.Width);
                pictureBox3.Width = pictureBox2.Width - 6;
                Height = 25;
            }
            else
            {
                pictureBox1.Location = new Point(
                    pictureBox1.Location.X, pictureBox1.Location.Y - 5);
                awayTeamScore.Location = new Point(
                    awayTeamScore.Location.X, awayTeamScore.Location.Y - 5);
                Height = 15;
            }

            viewBlink(timeViewBlink > 0);

        }
        public void viewBlink(bool st)
        {
            if (st)
            {
                pictureBox2.Show();
                pictureBox3.Show();
            }
            else
            {
                pictureBox2.Hide();
                pictureBox3.Hide();
            }
        }
    }
}
