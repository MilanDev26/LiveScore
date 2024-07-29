using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveScore
{
    public partial class Form2 : Form
    {
        public int screenWidth;
        public int screenHeight;

        private string user;
        private int pageNumber;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public string strBanner;
        public List<League> leagueList = null;
        public List<Match> matchList;
        public List<Match> prevMatchList;
        public string matchDate;
        bool initialized = false;
        bool showOrhide = false;
        bool viewLeagueName = true;
        bool viewScore = false;

        public Font font;

        public Color colorBackgroundMatch;
        public Color colorBackgroundLeague;
        public Color colorBlinkOfGoal;
        public Color colorTextColorLeague;
        public Color colorTextColorHour;
        public Color colorFinalScore;
        public Color colorPartialScore;
        public Color colorBackgroundRowGoal;
        public Color colorTextColorMatch;

        int currentPos;
        int viewStatus;
        int intervalTime;
        int intervalGetData;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string banner, string userName, int number)
        {
            InitializeComponent();
            
            user = userName;
            pageNumber = number;

            this.MouseDown += new MouseEventHandler(Form2_MouseDown);
            this.MouseMove += new MouseEventHandler(Form2_MouseMove);
            this.MouseUp += new MouseEventHandler(Form2_MouseUp);

            label1.MouseDown += new MouseEventHandler(Form2_MouseDown);
            label1.MouseMove += new MouseEventHandler(Form2_MouseMove);
            label1.MouseUp += new MouseEventHandler(Form2_MouseUp);

            currentPos = 0;
            viewStatus = Match.ALL;

            string fileName = "setting_" + user + "_" + number.ToString() + ".json";
            ReadSettingFile(fileName);

            string leagueFileName = "league_setting_" + user + "_" + number.ToString() + ".json";
            ReadLeagueSetting(leagueFileName);

            Width = screenWidth;
            Height = screenHeight;
            
            GetMatchTimer.Stop();
            LeagueTimer.Stop();

            LeagueTimer.Interval = intervalTime;
            GetMatchTimer.Interval = intervalGetData;

            GetMatchTimer.Start();
            LeagueTimer.Start();

            strBanner = banner;
            if (strBanner != null)
                label1.Text = strBanner;
            else
                label1.Text = "www.SoftForBet.com www.SoftForBet.com www.SoftForBet.com www.SoftForBet.com";
            PickerMatchDate.Text = DateTime.Today.ToString();
            matchDate = DateTime.Today.ToString("yyyy-MM-dd");
        }
        public void ReadSettingFile(string fileName)
        {
            try 
            {
                string json = File.ReadAllText(fileName);
                SettingJson settingJson = JsonConvert.DeserializeObject<SettingJson>(json);

                intervalTime = settingJson.RefreshPageTime * 1000;
                intervalGetData = settingJson.GetDataTime * 1000;

                font = settingJson.font;

                colorBackgroundLeague = settingJson.BackgroundLeague;
                colorBackgroundMatch = settingJson.BackgroundMatch;
                colorTextColorLeague = settingJson.TextColorLeague;
                colorFinalScore = settingJson.FinalScore;
                colorPartialScore = settingJson.PartialScore;
                colorTextColorHour = settingJson.TextColorHour;
                colorBackgroundRowGoal = settingJson.BackgroundRowGoal;
                colorTextColorMatch = settingJson.TextColorMatch;
                colorBlinkOfGoal = settingJson.BlinkOfGoal;

                screenWidth = settingJson.ScreenWidth;
                screenHeight = settingJson.ScreenHeight;
            }
            catch (Exception e)
            {
                intervalTime = 3000;
                intervalGetData = 3000;
                
                font = new Font(FontFamily.GenericSansSerif, 8.25f);

                colorBackgroundLeague = Color.FromArgb(250, 140, 0);
                colorBackgroundMatch = Color.FromArgb(0, 0, 0);
                colorTextColorLeague = Color.FromArgb(255, 255, 255);
                colorFinalScore = Color.FromArgb(255, 215, 0);
                colorPartialScore = Color.FromArgb(218, 165, 32);
                colorTextColorHour = Color.FromArgb(255, 150, 0);
                colorBackgroundRowGoal = Color.FromArgb(0, 255, 0);
                colorTextColorMatch = Color.FromArgb(255, 255, 255);
                colorBlinkOfGoal = Color.FromArgb(255, 215, 0);

                screenWidth = 1024;
                screenHeight = 768;
            }
            
        }
        public void ReadLeagueSetting(string fileName)
        {
            try
            {
                string json = File.ReadAllText(fileName);
                leagueList = JsonConvert.DeserializeObject<List<League>>(json);
            }
            catch (Exception e)
            {
                leagueList = null;
            }
        }
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        public int GetMatchShowSize()
        {
            MatchShow match = new MatchShow();
            return match.Size.Height;
        }
        public int GetLeagueShowSize()
        {
            LeagueShow league = new LeagueShow(screenWidth, "", Color.Black, Color.Black, font, true);
            return league.Size.Height;
        }
        private void BtnSetting_Click(object sender, EventArgs e)
        {
            LeagueTimer.Stop();
            GetMatchTimer.Stop();
            Setting setting = new Setting(leagueList, user, pageNumber);
            setting.ShowDialog();
            leagueList = setting.leagueList;

            GetMatchTimer.Start();
            LeagueTimer.Start();
        }
        private void BtnViewSetting_Click(object sender, EventArgs e)
        {
            LeagueTimer.Stop();
            GetMatchTimer.Stop();
            ViewSetting viewSetting = new ViewSetting(
                colorBackgroundMatch,
                colorBackgroundLeague,
                colorBlinkOfGoal,
                colorTextColorLeague,
                colorTextColorHour,
                colorFinalScore,
                colorPartialScore,
                colorBackgroundRowGoal,
                colorTextColorMatch,
                font,
                intervalTime / 1000,
                intervalGetData / 1000, user, pageNumber,
                screenWidth,
                screenHeight) ;
            viewSetting.ShowDialog();

            FLPanelLeft.Controls.Clear();
            FLPanelRight.Controls.Clear();
            FLPanelShowLiveMatchByTime.Controls.Clear();

            colorBackgroundMatch = viewSetting.colorBackgroundMatch;
            colorBackgroundLeague = viewSetting.colorBackgroundLeague;
            colorBlinkOfGoal = viewSetting.colorBlinkOfGoal;
            colorTextColorLeague = viewSetting.colorTextColorLeague;
            colorTextColorHour = viewSetting.colorTextColorHour;
            colorFinalScore = viewSetting.colorFinalScore;
            colorPartialScore = viewSetting.colorPartialScore;
            colorBackgroundRowGoal = viewSetting.colorBackgroundRowGoal;
            colorTextColorMatch = viewSetting.colorTextColorMatch;

            font = viewSetting.font;
            
            intervalTime = viewSetting.intervalMatch * 1000;
            intervalGetData = viewSetting.intervalGetData * 1000;

            screenWidth = viewSetting.screenWidth;
            screenHeight = viewSetting.screenHeight;

            Width = screenWidth;
            Height = screenHeight;

            LeagueTimer.Interval = intervalTime;
            LeagueTimer.Start();

            GetMatchTimer.Interval = intervalGetData;
            GetMatchTimer.Start();
        }
        public void Form2_Load(object sender, EventArgs e)
        {
            //matchList = API.GetMatches(null, matchDate);

            viewStatus = 0;
            currentPos = 0;
            LeagueTimer.Interval = intervalTime;

            GetMatchTimer.Start();
            LeagueTimer.Start();

            FLPanelShowLiveMatchByTime.Hide();
            initialized = true;
        }
        public int AddMatchData(FlowLayoutPanel fLPanel)
        {
            fLPanel.Controls.Clear();
            int matchShowSize = GetMatchShowSize();
            int leagueShowSize = GetLeagueShowSize();
            int flHeight = fLPanel.Size.Height;
            string country = "";
            string league = "";
            int currentSize = leagueShowSize;
            List<Match> tmpMatchList = new List<Match>();

            if (matchList == null)
                return 0;
            int cnt;
            if (viewStatus == 0)
            {
                tmpMatchList = matchList;
            }
            else if (viewStatus == 1)
            {
                tmpMatchList = matchList.FindAll(i => i.match_status.Equals("Finished") ||
                                                i.match_status.Equals("After Pen.") ||
                                                i.match_status.Equals("After ET"));
            }
            else if (viewStatus == 2)
            {
                tmpMatchList = matchList.FindAll(i => i.match_status.Equals("") && i.match_live == "0");
            }
            else
            {
                tmpMatchList = matchList.FindAll(i => i.match_live == "1" && !i.match_status.Equals("Finished"));
            }
            if (tmpMatchList == null)
            {
                return 0;
            }
            if (currentPos >= tmpMatchList.Count) currentPos = 0;
            if (currentPos == 0 && fLPanel.Name == "FLPanelRight")
                return 0;

            List<Control> valueList = new List<Control>();

            for (cnt = currentPos; cnt < tmpMatchList.Count; cnt++)
            {
                if (leagueList != null)
                {
                    League currentLeague = leagueList.Find(i => i.country_id == tmpMatchList[cnt].country_id 
                                                                && i.league_id == tmpMatchList[cnt].league_id);
                    if (currentLeague == null)
                        continue;
                    if (!currentLeague.check_show)
                        continue;
                }

                if (!country.Equals(tmpMatchList[cnt].country_name) || !league.Equals(tmpMatchList[cnt].league_name))
                {
                    currentSize += leagueShowSize;
                    if (currentSize > flHeight - matchShowSize - leagueShowSize)
                        break;
                    var match = tmpMatchList[cnt];
                    LeagueShow leagueShow = new LeagueShow(fLPanel.Width, match.country_name + ": " + match.league_name, colorBackgroundLeague, 
                        colorTextColorLeague, font, true);
                    valueList.Add(leagueShow);
                    country = tmpMatchList[cnt].country_name;
                    league = tmpMatchList[cnt].league_name;
                }
                currentSize += matchShowSize;
                if (currentSize > flHeight)
                    break;

                int timeViewBlink = 0;
                Match currentMatch = tmpMatchList[cnt];

                if (prevMatchList != null)
                {
                    Match prevMatch = prevMatchList.Find(i => i.match_id == currentMatch.match_id);

                    if (prevMatch != null)
                    {
                        int preGoalCnt = prevMatch.goalscorer.Count;

                        if (preGoalCnt < currentMatch.goalscorer.Count)
                        {
                            matchList.Find(s => s.match_id == currentMatch.match_id).score_updated_time = DateTime.Now;
                            timeViewBlink = 5000;
                            SoundPlayer player = new SoundPlayer();
                            player.Stop();
                            player.SoundLocation = @"Resources/Referee-Whistle3.wav";
                            player.Play();
                        }
                        else
                        {
                            DateTime? dt = prevMatch.score_updated_time;
                            if (dt != null)
                            {
                                double diff = DateTime.Now.Subtract(dt.Value).TotalSeconds;
                                if (diff < 5)
                                {
                                    timeViewBlink = (int)(5 - diff) * 1000;
                                }
                                else
                                {
                                    matchList.Find(s => s.match_id == currentMatch.match_id).score_updated_time = null;
                                }
                            }
                        }
                    }
                }
                MatchShow matchShow = new MatchShow(fLPanel.Width, currentMatch, 
                    colorBackgroundMatch, colorTextColorMatch, colorFinalScore, colorPartialScore, colorTextColorHour, colorBlinkOfGoal, font, timeViewBlink);
                valueList.Add(matchShow);
            }
            fLPanel.Controls.AddRange(valueList.ToArray());

            return cnt;
        }
        public int AddMatchDataOnLive(FlowLayoutPanel fLPanel)
        {
            fLPanel.Controls.Clear();
            int matchShowSize = GetMatchShowSize();
            int leagueShowSize = GetLeagueShowSize();
            int flHeight = fLPanel.Size.Height;

            int currentSize = leagueShowSize;
            if (!viewLeagueName)
                currentSize = 0;

            List<Match> tmpMatchList = new List<Match>();
            if (matchList == null)
                return 0;
            if (viewStatus == 0)
            {
                tmpMatchList = matchList;
            }
            else if (viewStatus == 1)
            {
                tmpMatchList = matchList.FindAll(i => i.match_status.Equals("Finished") || 
                                                i.match_status.Equals("After Pen.") || 
                                                i.match_status.Equals("After ET"));
            }
            else if (viewStatus == 2)
            {
                tmpMatchList = matchList.FindAll(i => i.match_status.Equals("") && i.match_live == "0");
            }
            else
            {
                tmpMatchList = matchList.FindAll(i => i.match_live == "1" && !i.match_status.Equals("Finished"));
            }
            if (tmpMatchList == null)
            {
                return 0;
            }

            tmpMatchList = tmpMatchList.OrderBy(i => i.match_time).
             ThenBy(i => i.country_name).
             ThenBy(i => i.league_name).ToList();
            int cnt;

            if (currentPos >= tmpMatchList.Count) currentPos = 0;
            if (currentPos == 0 && fLPanel.Name == "FLPanelRight")
                return 0;
            List<Control> valueList = new List<Control>();

            for (cnt = currentPos; cnt < tmpMatchList.Count; cnt++)
            {
                if (leagueList != null)
                {
                    League currentLeague = leagueList.Find(i => i.country_id == tmpMatchList[cnt].country_id
                                                                && i.league_id == tmpMatchList[cnt].league_id);
                    if (currentLeague == null)
                        continue;
                    if (!currentLeague.check_show)
                        continue;
                }
                int timeViewBlink = 0;

                Match currentMatch = tmpMatchList[cnt];

                if (prevMatchList != null)
                {
                    Match prevMatch = prevMatchList.Find(i => i.match_id == currentMatch.match_id);

                    if (prevMatch != null)
                    {
                        int preGoalCnt = prevMatch.goalscorer.Count;

                        if (preGoalCnt < currentMatch.goalscorer.Count)
                        {
                            matchList.Find(s => s.match_id == currentMatch.match_id).score_updated_time = DateTime.Now;
                            timeViewBlink = 5000;
                            SoundPlayer player = new SoundPlayer();
                            player.Stop();
                            player.SoundLocation = @"Resources/Referee-Whistle3.wav";
                            player.Play();
                        }
                        else
                        {
                            DateTime? dt = prevMatch.score_updated_time;
                            if (dt != null)
                            {
                                double diff = DateTime.Now.Subtract(dt.Value).TotalSeconds;
                                if (diff < 5)
                                {
                                    timeViewBlink = (int)(5 - diff) * 1000;
                                }
                                else
                                {
                                    matchList.Find(s => s.match_id == currentMatch.match_id).score_updated_time = null;
                                }
                            }
                        }
                    }
                }
                currentSize += matchShowSize;
                if (currentSize > flHeight)
                    break;
               MatchShowLive matchShow = new MatchShowLive(fLPanel.Width, currentMatch, colorTextColorLeague, colorBackgroundMatch,
                   colorTextColorMatch, colorFinalScore, colorPartialScore, colorTextColorHour, colorBlinkOfGoal, font, timeViewBlink);
                valueList.Add(matchShow);
            }

            fLPanel.Controls.AddRange(valueList.ToArray());
            return cnt;
        }
        public int AddMatchDataOnLiveByLeague(FlowLayoutPanel fLPanel)
        {
            fLPanel.Controls.Clear();
            int matchShowSize = GetMatchShowSize();
            int leagueShowSize = GetLeagueShowSize();
            int flHeight = fLPanel.Size.Height;
            string country = "";
            string league = "";
            int currentSize = 0;
            List<Match> tmpMatchList = new List<Match>();

            if (matchList == null)
                return 0;
            if (viewStatus == 0)
            {
                tmpMatchList = matchList;
            }
            else if (viewStatus == 1)
            {
                tmpMatchList = matchList.FindAll(i => i.match_status.Equals("Finished") ||
                                                i.match_status.Equals("After Pen.") ||
                                                i.match_status.Equals("After ET"));
            }
            else if (viewStatus == 2)
            {
                tmpMatchList = matchList.FindAll(i => i.match_status.Equals("") && i.match_live == "0");
            }
            else
            {
                tmpMatchList = matchList.FindAll(i => i.match_live == "1" && !i.match_status.Equals("Finished"));
            }

            int cnt;

            if (tmpMatchList == null)
            {
                return 0;
            }
            
            if (currentPos >= tmpMatchList.Count) currentPos = 0;
            if (currentPos == 0 && fLPanel.Name == "FLPanelRight")
                return 0;

            List<Control> valueList = new List<Control>();

            for (cnt = currentPos; cnt < tmpMatchList.Count; cnt++)
            {
                int goalCnt = tmpMatchList[cnt].goalscorer.Count;

                if (leagueList != null)
                {
                    League currentLeague = leagueList.Find(i => i.country_id == tmpMatchList[cnt].country_id
                                                                && i.league_id == tmpMatchList[cnt].league_id);
                    if (currentLeague == null)
                        continue;
                    if (!currentLeague.check_show)
                        continue;
                }

                if (!country.Equals(tmpMatchList[cnt].country_name) || !league.Equals(tmpMatchList[cnt].league_name))
                {
                    currentSize += leagueShowSize;
                    if (currentSize > flHeight - leagueShowSize - matchShowSize - goalCnt * (matchShowSize - 5))
                    {
                        currentSize -= leagueShowSize;
                        break;
                    }
                    var tmpMatch = tmpMatchList[cnt];
                    
                    LeagueShow leagueShow = new LeagueShow(fLPanel.Width, tmpMatch.country_name + ": " + tmpMatch.league_name, colorBackgroundLeague, colorTextColorLeague, font, false);
                    valueList.Add(leagueShow);

                    country = tmpMatchList[cnt].country_name;
                    league = tmpMatchList[cnt].league_name;
                }

                currentSize += matchShowSize;
                if (currentSize > flHeight - goalCnt * (matchShowSize - 5)) 
                {
                    currentSize -= matchShowSize;
                    break;
                }
                
                int timeViewBlink = 0;
                Match currentMatch = tmpMatchList[cnt];

                if (prevMatchList != null)
                {
                    Match prevMatch = prevMatchList.Find(i => i.match_id == tmpMatchList[cnt].match_id);

                    if (prevMatch != null)
                    {
                        int preGoalCnt = prevMatch.goalscorer.Count;

                        if (preGoalCnt < currentMatch.goalscorer.Count)
                        {
                            matchList.Find(s => s.match_id == currentMatch.match_id).score_updated_time = DateTime.Now;
                            timeViewBlink = 5000;
                            SoundPlayer player = new SoundPlayer();
                            player.Stop();
                            player.SoundLocation = @"Resources/Referee-Whistle3.wav";
                            player.Play();
                        }
                        else
                        {
                            DateTime? dt = prevMatch.score_updated_time;
                            if (dt != null)
                            {
                                double diff = DateTime.Now.Subtract(dt.Value).TotalSeconds;
                                if (diff < 5)
                                {
                                    timeViewBlink = (int)(5 - diff) * 1000;
                                }
                                else
                                {
                                    matchList.Find(s => s.match_id == currentMatch.match_id).score_updated_time = null;
                                }
                            }
                        }
                    }
                }

                MatchShowLiveByLeague match = new MatchShowLiveByLeague(fLPanel.Width, tmpMatchList[cnt], colorBackgroundMatch, colorTextColorMatch, colorFinalScore, colorPartialScore, colorTextColorHour, colorBlinkOfGoal, font, timeViewBlink);
                valueList.Add(match);
                List<ScoreAndFoul> scoreAndFouls = new List<ScoreAndFoul>();
                if (viewScore)
                {
                    List<Score> scoreList = currentMatch.goalscorer;
                    List<Card> cards = currentMatch.cards;
                    foreach(Score eachScore in scoreList)
                    {
                        ScoreAndFoul ss = new ScoreAndFoul();
                        ss.time = eachScore.time;
                        ss.timeInt = API.TimeInt(ss.time);
                        ss.score_info_time = eachScore.score_info_time;
                        ss.home_score = eachScore.home_scorer;
                        ss.away_score = eachScore.away_scorer;
                        ss.info = eachScore.info;
                        ss.check = true;
                        scoreAndFouls.Add(ss);
                    }
                    foreach(Card card in cards)
                    {
                        if (card.card.Equals("yellow card"))
                            continue;
                        ScoreAndFoul ss = new ScoreAndFoul();
                        ss.time = card.time;
                        ss.timeInt = API.TimeInt(ss.time);
                        ss.score_info_time = card.score_info_time;
                        ss.home_fault = card.home_fault;
                        ss.away_fault = card.away_fault;
                        ss.info = card.info;
                        ss.check = false;
                        scoreAndFouls.Add(ss);
                    }
                    scoreAndFouls = scoreAndFouls.OrderBy(i => i.score_info_time).
                                    ThenBy(i => i.timeInt).ToList();
                    foreach (ScoreAndFoul temp in scoreAndFouls)
                    {
                        if (temp.check)
                        {
                            if (temp.home_score != "")
                            {
                                string score = temp.time + "° " + temp.home_score;
                                bool checkPenalty = false;
                                if (temp.info.Equals("Penalty"))
                                    checkPenalty = true;
                                HomeTeamGoal homeTeamGoal = new HomeTeamGoal(fLPanel.Width, score, colorBackgroundRowGoal, colorBlinkOfGoal, timeViewBlink, checkPenalty, temp.check);
                                valueList.Add(homeTeamGoal);
                                currentSize += 15;
                            }
                            if (temp.away_score != "")
                            {
                                string score = temp.time + "° " + temp.away_score;
                                bool checkPenalty = false;
                                if (temp.info.Equals("Penalty"))
                                    checkPenalty = true;
                                AwayTeamGoal awayTeamGoal = new AwayTeamGoal(fLPanel.Width, score, colorBackgroundRowGoal, colorBlinkOfGoal, timeViewBlink, checkPenalty, temp.check);
                                valueList.Add(awayTeamGoal);
                                currentSize += 15;
                            }
                            if (temp.home_score == "" && temp.away_score == "")
                            {
                                if (temp.info.Equals("home"))
                                {
                                    string score = temp.time + "° " + temp.home_score;
                                    HomeTeamGoal homeTeamGoal = new HomeTeamGoal(fLPanel.Width, score, colorBackgroundRowGoal, colorBlinkOfGoal, timeViewBlink, false, temp.check);
                                    valueList.Add(homeTeamGoal);
                                    currentSize += 15;
                                }
                                if (temp.info.Equals("away"))
                                {
                                    string score = temp.time + "° " + temp.away_score;
                                    AwayTeamGoal awayTeamGoal = new AwayTeamGoal(fLPanel.Width, score, colorBackgroundRowGoal, colorBlinkOfGoal, timeViewBlink, false, temp.check);
                                    valueList.Add(awayTeamGoal);
                                    currentSize += 15;
                                }
                            }
                        }
                        else
                        {
                            if (temp.home_fault != "")
                            {
                                string fault = temp.time + "° " + temp.home_fault;
                                HomeTeamGoal home = new HomeTeamGoal(fLPanel.Width, fault, colorBackgroundRowGoal, colorBlinkOfGoal, timeViewBlink, false, temp.check);
                                valueList.Add(home);
                                currentSize += 15;
                            }
                            if (temp.away_fault != "")
                            {
                                string fault = temp.time + "° " + temp.away_fault;
                                AwayTeamGoal away = new AwayTeamGoal(fLPanel.Width, fault, colorBackgroundRowGoal, colorBlinkOfGoal, timeViewBlink, false, temp.check);
                                valueList.Add(away);
                                currentSize += 15;
                            }
                        }
                    }
                }
            }
            fLPanel.Controls.AddRange(valueList.ToArray());
            return cnt;
        }
        private void PickerMatchDate_ValueChanged(object sender, EventArgs e)
        {
            prevMatchList = null;
            LeagueTimer.Stop();
            GetMatchTimer.Stop();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Stop();
            if (!initialized) return;
            FLPanelLeft.Controls.Clear();
            FLPanelRight.Controls.Clear();
            FLPanelShowLiveMatchByTime.Controls.Clear();
            matchDate = PickerMatchDate.Value.ToString("yyyy-MM-dd");
            currentPos = 0;
            viewStatus = Match.ALL;
            GetMatchTimer.Start();
            LeagueTimer.Start();
        }
        private void BtnLive_Click(object sender, EventArgs e)
        {
            FLPanelLeft.Controls.Clear();
            FLPanelRight.Controls.Clear();
            viewStatus = Match.LIVE;
            currentPos = 0;

            LeagueTimer.Start();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Stop();

            FLPanelLeft.Show();
            FLPanelRight.Show();
            tableLayoutPanel3.Show();
            FLPanelShowLiveMatchByTime.Hide();
        }
        private void BtnFinished_Click(object sender, EventArgs e)
        {
            FLPanelLeft.Controls.Clear();
            FLPanelRight.Controls.Clear();
            viewStatus = Match.FINISHED;
            currentPos = 0;

            LeagueTimer.Start();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Stop();

            FLPanelLeft.Show();
            FLPanelRight.Show();
            tableLayoutPanel3.Show();
            FLPanelShowLiveMatchByTime.Hide();
        }
        private void BtnNotStarted_Click(object sender, EventArgs e)
        {
            FLPanelLeft.Controls.Clear();
            FLPanelRight.Controls.Clear();
            viewStatus = Match.NO_STARTED;
            currentPos = 0;

            LeagueTimer.Start();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Stop();

            FLPanelLeft.Show();
            FLPanelRight.Show();
            tableLayoutPanel3.Show();
            FLPanelShowLiveMatchByTime.Hide();
        }
        private void BtnAll_Click(object sender, EventArgs e)
        {
            FLPanelLeft.Controls.Clear();
            FLPanelRight.Controls.Clear();
            viewStatus = Match.ALL;
            currentPos = 0;

            LeagueTimer.Start();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Stop();

            FLPanelLeft.Show();
            FLPanelRight.Show();
            tableLayoutPanel3.Show();
            FLPanelShowLiveMatchByTime.Hide();
        }
        private void BtnHide_Click(object sender, EventArgs e)
        {
            if (!showOrhide)
            {
                BtnAll.Hide();
                BtnLive.Hide();
                BtnFinished.Hide();
                BtnNotStarted.Hide();
                BtnLeagueDetail.Hide();
                BtnLeague.Hide();
                BtnStartEvent.Hide();
                BtnNotAuto.Hide();
                groupBox1.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
                groupBox4.Hide();
                tableLayoutPanel1.Hide();
                BtnSetting.Hide();
                BtnViewSetting.Hide();
                PickerMatchDate.Hide();
                BtnClose.Hide();
                BtnResize.Hide();
                showOrhide = !showOrhide;
                
                tableLayoutPanel3.Location = new Point
                (
                    tableLayoutPanel3.Location.X,
                    tableLayoutPanel3.Location.Y - tableLayoutPanel1.Size.Height
                );
                tableLayoutPanel3.Height = tableLayoutPanel3.Height + tableLayoutPanel1.Size.Height;
                FLPanelLeft.Location = new Point
                (
                    FLPanelLeft.Location.X,
                    FLPanelLeft.Location.Y - tableLayoutPanel1.Size.Height
                );
                FLPanelLeft.Height = FLPanelLeft.Height + tableLayoutPanel1.Size.Height;

                FLPanelRight.Location = new Point
                (
                    FLPanelRight.Location.X,
                    FLPanelRight.Location.Y - tableLayoutPanel1.Size.Height
                );
                FLPanelRight.Height = FLPanelRight.Height + tableLayoutPanel1.Size.Height;

                FLPanelShowLiveMatchByTime.Location = new Point
                (
                    FLPanelShowLiveMatchByTime.Location.X,
                    FLPanelShowLiveMatchByTime.Location.Y - tableLayoutPanel1.Size.Height
                );
                FLPanelShowLiveMatchByTime.Height = FLPanelShowLiveMatchByTime.Height + tableLayoutPanel1.Size.Height;
            }
            else
            {
                BtnAll.Show();
                BtnLive.Show();
                BtnFinished.Show();
                BtnNotStarted.Show();
                BtnLeagueDetail.Show();
                BtnLeague.Show();
                BtnStartEvent.Show();
                BtnNotAuto.Show();
                groupBox1.Show();
                groupBox2.Show();
                groupBox3.Show();
                groupBox4.Show();
                tableLayoutPanel1.Show();
                BtnSetting.Show();
                BtnViewSetting.Show();
                PickerMatchDate.Show();
                BtnClose.Show();
                BtnResize.Show();
                showOrhide = !showOrhide;

                tableLayoutPanel3.Location = new Point
                (
                    tableLayoutPanel3.Location.X,
                    tableLayoutPanel3.Location.Y + tableLayoutPanel1.Size.Height
                );
                tableLayoutPanel3.Height = tableLayoutPanel3.Height - tableLayoutPanel1.Size.Height;

                FLPanelLeft.Location = new Point
                (
                    FLPanelLeft.Location.X,
                    FLPanelLeft.Location.Y + tableLayoutPanel1.Size.Height
                );
                FLPanelLeft.Height = FLPanelLeft.Height - tableLayoutPanel1.Size.Height;

                FLPanelRight.Location = new Point
                (
                    FLPanelRight.Location.X,
                    FLPanelRight.Location.Y + tableLayoutPanel1.Size.Height
                );
                FLPanelRight.Height = FLPanelRight.Height - tableLayoutPanel1.Size.Height;

                FLPanelShowLiveMatchByTime.Location = new Point
                (
                    FLPanelShowLiveMatchByTime.Location.X,
                    FLPanelShowLiveMatchByTime.Location.Y + tableLayoutPanel1.Size.Height
                );
                FLPanelShowLiveMatchByTime.Height = FLPanelShowLiveMatchByTime.Height - tableLayoutPanel1.Size.Height;
            }
        }
        private void LeagueTimer_Tick(object sender, EventArgs e)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            currentPos = AddMatchData(FLPanelLeft);
            
            currentPos = AddMatchData(FLPanelRight);
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed.TotalMilliseconds);
        }
        private void GetMatchTimer_Tick(object sender, EventArgs e)
        {
            API.GetMatches(null, matchDate).ContinueWith(task =>
            {
                prevMatchList = matchList;
                matchList = task.Result;
            });
        }
        private void BtnLeagueDetail_Click(object sender, EventArgs e)
        {
            viewLeagueName = true;
            currentPos = 0;
            viewScore = true;

            LeagueTimer.Stop();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Start();

            FLPanelLeft.Hide();
            FLPanelRight.Hide();
            tableLayoutPanel3.Hide();
            FLPanelShowLiveMatchByTime.Show();
        }
        private void BtnLeague_Click(object sender, EventArgs e)
        {
            viewLeagueName = true;
            currentPos = 0;
            viewScore = false;

            LeagueTimer.Stop();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Start();

            FLPanelLeft.Hide();
            FLPanelRight.Hide();
            tableLayoutPanel3.Hide();
            FLPanelShowLiveMatchByTime.Show();
        }
        private void BtnStartEvent_Click(object sender, EventArgs e)
        {
            viewLeagueName = false;
            currentPos = 0;

            LeagueTimer.Stop();
            GetMatchOnLiveStartEventTimer.Start();
            GetMatchOnLiveByLeaguetimer.Stop();

            FLPanelLeft.Hide();
            FLPanelRight.Hide();
            tableLayoutPanel3.Hide();
            FLPanelShowLiveMatchByTime.Show();
        }
        private void BtnNotAuto_Click(object sender, EventArgs e)
        {
            viewLeagueName = true;
            currentPos = 0;

            LeagueTimer.Start();
            GetMatchOnLiveStartEventTimer.Stop();
            GetMatchOnLiveByLeaguetimer.Stop();
            FLPanelLeft.Show();
            FLPanelRight.Show();
            tableLayoutPanel3.Show();
            FLPanelShowLiveMatchByTime.Hide();
        }
        private void GetMatchOnLiveStartEventTimer_Tick(object sender, EventArgs e)
        {
            currentPos = AddMatchDataOnLive(FLPanelShowLiveMatchByTime);
        }
        private void GetMatchOnLiveByLeaguetimer_Tick(object sender, EventArgs e)
        {
            currentPos = AddMatchDataOnLiveByLeague(FLPanelShowLiveMatchByTime);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            API.showNum--;
            Close();
        }
        private void BtnResize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
