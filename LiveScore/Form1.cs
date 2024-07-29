using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LiveScore
{
    public partial class Form1 : Form
    {
        private int isLogin;
        private int showNum;
        private bool loginSuccessed;
        private MonthCalendar monthCalendar1;
        private string strBanner;
        private string user;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private string cs = "Data Source=.;Initial Catalog=LiveScore;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            isLogin = 0;
            user = "";
            API.showNum = 0;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);

            splitContainer1.Panel1.MouseDown += new MouseEventHandler(Form1_MouseDown);
            splitContainer1.Panel1.MouseMove += new MouseEventHandler(Form1_MouseMove);
            splitContainer1.Panel1.MouseUp += new MouseEventHandler(Form1_MouseUp);

            splitContainer1.Panel2.MouseDown += new MouseEventHandler(Form1_MouseDown);
            splitContainer1.Panel2.MouseMove += new MouseEventHandler(Form1_MouseMove);
            splitContainer1.Panel2.MouseUp += new MouseEventHandler(Form1_MouseUp);

            this.FormClosing += new FormClosingEventHandler(Form_Closing);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the calendar.
            monthCalendar1 = new MonthCalendar();

            // Set the calendar location.
            int posX = splitContainer1.Panel2.Width;
            int posY = splitContainer1.Panel2.Height;
            monthCalendar1.Location = new System.Drawing.Point(posX / 10, (int)(posY * 0.4));
            monthCalendar1.BackColor = SystemColors.Info;
            monthCalendar1.BringToFront();
            monthCalendar1.FirstDayOfWeek = Day.Monday;
            splitContainer1.Panel2.Controls.AddRange(new Control[] { monthCalendar1 });
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Stai per uscire?", "Sicuro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (user != "")
                {
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        con.Open();

                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Parameters.AddWithValue("@user", user);
                            cmd.CommandText = @"update users SET isLogin = '0' where userid=@user";
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //showNum = 3;
            int status = 0;
            DateTime expiration_date = new DateTime();

            user = TxtLogin.Text;
            if (TxtLogin.Text == "")
            {
                MessageBox.Show("Si prega di inserire l'utente o l'e-mail", "Errore");
                return;
            }

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@user", TxtLogin.Text);
                    cmd.CommandText = @"select userid, showNum, expiration_date, enable, isLogin from users where userid=@user";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows == false)
                        {
                            MessageBox.Show("Utente non autenticato!", "Errore");
                            con.Close();
                            return;
                        }
                        while (reader.Read())
                        {
                            isLogin = reader.GetInt32(reader.GetOrdinal("isLogin"));
                            showNum = reader.GetInt32(reader.GetOrdinal("showNum"));
                            expiration_date = reader.GetDateTime(reader.GetOrdinal("expiration_date"));
                            status = reader.GetInt32(reader.GetOrdinal("enable"));
                        }
                    }
                }

                con.Close();
            }

            if (expiration_date < DateTime.Today)
            {
                MessageBox.Show("L'utente è scaduto il " + expiration_date.ToString("yyyy/MM/dd"));
                return;
            }
            if (status == 0)
            {
                MessageBox.Show("L'utente non può utilizzare questa app dall'amministratore!");
                return;
            }
            //if (!user.Equals("TestUser01"))
            //{
            //    MessageBox.Show("Utente non autenticato!", "Errore");
            //    return;
            //}

            if (isLogin > 0)
            {
                MessageBox.Show("L'utente ha già effettuato l'accesso.");
                return;
            }

            TxtLogin.Hide();
            PBoxLogin.Hide();
            BtnLogin.Hide();
            RemoveTVS(showNum);
            loginSuccessed = true;

            user = TxtLogin.Text;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.CommandText = @"update users SET isLogin = '1' where userid=@user";
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        void RemoveTVS(int showNum)
        {
            int cnt = 8;
            cnt--;
            if (cnt >= showNum)
            {
                PBoxShow_8.Visible = false;
                //PBoxShow_8.Hide();
            }

            cnt--;
            if (cnt >= showNum)
            {
                PBoxShow_7.Hide();
            }
            cnt--;
            if (cnt >= showNum)
            {
                PBoxShow_6.Hide();
            }
            cnt--;
            if (cnt >= showNum)
            {
                PBoxShow_5.Hide();
            }
            cnt--;
            if (cnt >= showNum)
            {
                PBoxShow_4.Hide();
            }
            cnt--;
            if (cnt >= showNum)
            {
                PBoxShow_3.Hide();
            }
            cnt--;
            if (cnt >= showNum)
            {
                PBoxShow_2.Hide();
            }
        }
        void AddTVS(int showNum)
        {
            int cnt = 8;
            showNum++;
            if (cnt >= showNum)
            {
                PBoxShow_8.Show();
            }

            showNum++;
            if (cnt >= showNum)
            {
                PBoxShow_7.Show();
            }
            showNum++;
            if (cnt >= showNum)
            {
                PBoxShow_6.Show();
            }
            showNum++;
            if (cnt >= showNum)
            {
                PBoxShow_5.Show();
            }
            showNum++;
            if (cnt >= showNum)
            {
                PBoxShow_4.Show();
            }
            showNum++;
            if (cnt >= showNum)
            {
                PBoxShow_3.Show();
            }
            showNum++;
            if (cnt >= showNum)
            {
                PBoxShow_2.Show();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (user != "")
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@user", TxtLogin.Text);
                        cmd.CommandText = @"update users SET isLogin = '0' where userid=@user";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            PBoxLogin.Show();
            BtnLogin.Show();
            loginSuccessed = false;
            TxtLogin.Show();
            TxtLogin.Text = "";
            TxtLogin.ReadOnly = false;
            AddTVS(showNum);
            API.showNum = 0;
        }
        private void Check(int number)
        {
            if (!loginSuccessed)
            {
                MessageBox.Show("Prima devi autenticarti!", "Errore");
                return;
            }

            if (API.showNum >= showNum)
            {
                MessageBox.Show("Non puoi mostrare la nuova finestra.", "Errore");
                return;
            }
            API.showNum++;

            //string user = "TestUser01";

            Form2 form2 = new Form2(strBanner, TxtLogin.Text, number);
            form2.Show();
        }
        private void PBoxShow_1_Click(object sender, EventArgs e)
        {
            Check(0);
        }
        private void PBoxShow_2_Click(object sender, EventArgs e)
        {
            Check(1);
        }
        private void PBoxShow_3_Click(object sender, EventArgs e)
        {
            Check(2);
        }
        private void PBoxShow_4_Click(object sender, EventArgs e)
        {
            Check(3);
        }
        private void PBoxShow_5_Click(object sender, EventArgs e)
        {
            Check(4);
        }
        private void PBoxShow_6_Click(object sender, EventArgs e)
        {
            Check(5);
        }
        private void PBoxShow_7_Click(object sender, EventArgs e)
        {
            Check(6);
        }
        private void PBoxSHow_8_Click(object sender, EventArgs e)
        {
            Check(7);
        }
        private void BtnAddBanner_Click(object sender, EventArgs e)
        {
            Banner banner = new Banner();
            banner.ShowDialog();
            strBanner = banner.strBanner;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
