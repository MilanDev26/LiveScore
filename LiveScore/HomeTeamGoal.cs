using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveScore
{
    public partial class HomeTeamGoal : UserControl
    {
        public HomeTeamGoal()
        {
            InitializeComponent();
        }
        public HomeTeamGoal(int w, string scoreName, Color result, Color blinkOfGoal, int timeViewBlink, bool checkPenalty, bool checkScore)
        {
            InitializeComponent();
            score.Text = scoreName;
            score.ForeColor = result;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Width = w;

            score.Location = new Point(
                (int)(0.35 * Width),
                score.Location.Y
                );
            pictureBox1.Location = new Point(
                score.Location.X - 15,
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

            if (checkScore)
            {
                if (checkPenalty)
                {
                    pictureBox1.Image = Image.FromFile(@"Resources/Penalty24.png");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"Resources/Goal24.png");
                }
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"Resources/RedCard24.png");
            }

            if (timeViewBlink > 0)
            {
                pictureBox2.Width = pictureBox2.Width > (int)(1.7 * (score.Width)) ? pictureBox2.Width : (int)(1.7 * score.Width);
                pictureBox3.Width = pictureBox2.Width - 6;
                Height = 25;
            }
            else
            {
                pictureBox1.Location = new Point(
                    pictureBox1.Location.X, pictureBox1.Location.Y - 5);
                score.Location = new Point(
                    score.Location.X, score.Location.Y - 5);
                Height = 15;
            }
            pictureBox2.BackColor = blinkOfGoal;

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
