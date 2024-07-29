using Newtonsoft.Json;
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
    public partial class ViewSetting : Form
    {
        public Font font;
        public Font tmpFont;

        public Color colorBackgroundMatch;
        public Color colorBackgroundLeague;
        public Color colorBlinkOfGoal;
        public Color colorTextColorLeague;
        public Color colorTextColorHour;
        public Color colorFinalScore;
        public Color colorPartialScore;
        public Color colorBackgroundRowGoal;
        public Color colorTextColorMatch;

        public int intervalMatch;
        public int intervalGetData;

        public int screenWidth;
        public int screenHeight;

        public string user;
        public int pageNumber;
        public ViewSetting()
        {
            InitializeComponent();
        }
        public ViewSetting(Color backgroundMatch, Color backgroundLeague, Color blinkOfGoal, Color textColorLeague, 
            Color textColorHour, Color finalScore, Color particalScore, Color backgroundRowGoal, Color textColorMatch, 
            Font viewFont, int intervalMatchTime, int getData, string userName, int number, int w, int h)
        {
            InitializeComponent();

            user = userName;
            pageNumber = number;

            intervalMatch = intervalMatchTime;
            intervalGetData = getData;

            font = viewFont;
            tmpFont = viewFont;

            colorBackgroundMatch = backgroundMatch;
            colorBackgroundLeague = backgroundLeague;
            colorBlinkOfGoal = blinkOfGoal;
            colorTextColorLeague = textColorLeague;
            colorTextColorHour = textColorHour;
            colorFinalScore = finalScore;
            colorPartialScore = particalScore;
            colorBackgroundRowGoal = backgroundRowGoal;
            colorTextColorMatch = textColorMatch;

            BtnCampionColor.BackColor = colorBackgroundLeague;
            BtnMatchColor.BackColor = colorBackgroundMatch;
            BtnColorCampionship.BackColor = colorTextColorLeague;
            BtnGoalFlashing.BackColor = colorBlinkOfGoal;
            BtnNotNow.BackColor = colorTextColorHour;
            BtnResult.BackColor = colorFinalScore;
            BtnPartial.BackColor = colorPartialScore;
            BtnHighlight.BackColor = colorBackgroundRowGoal;
            BtnSquad.BackColor = colorTextColorMatch;

            BoxIntervalSecond.Value = intervalMatch;
            GetDataTime.Value = intervalGetData;
            TbxFont.Text = font.FontFamily.Name + ", " + font.Size.ToString() + "pt";

            screenWidth = w;
            screenHeight = h;
            if (screenWidth == 1024)
            {
                RadioFirstResolution.Checked = true;
            }
            else if (screenWidth == 1280)
            {
                RadioSecondResolution.Checked = true;
            }
            else
            {
                RadioThirdResolution.Checked = true;
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            intervalMatch = ((int)BoxIntervalSecond.Value);
            intervalGetData = ((int)GetDataTime.Value);

            if (RadioFirstResolution.Checked)
            {
                screenWidth = 1024;
                screenHeight = 768;
            }
            else if (RadioSecondResolution.Checked)
            {
                screenWidth = 1280;
                screenHeight = 720;
            }
            else
            {
                screenWidth = 1440;
                screenHeight = 900;
            }

            TbxFont.Text = font.FontFamily.Name + ", " + font.Size.ToString() + "pt";

            font = tmpFont;

            colorBackgroundLeague = BtnCampionColor.BackColor;
            colorBackgroundMatch = BtnMatchColor.BackColor;
            colorTextColorLeague = BtnColorCampionship.BackColor;
            colorBlinkOfGoal = BtnGoalFlashing.BackColor;
            colorTextColorHour = BtnNotNow.BackColor;
            colorFinalScore = BtnResult.BackColor;
            colorPartialScore = BtnPartial.BackColor;
            colorBackgroundRowGoal = BtnHighlight.BackColor;
            colorTextColorMatch = BtnSquad.BackColor;

            SettingJson settingJson = new SettingJson();
            settingJson.RefreshPageTime = intervalMatch;
            settingJson.GetDataTime = intervalGetData;
            settingJson.font = font;
            settingJson.BackgroundLeague = colorBackgroundLeague;
            settingJson.BackgroundMatch = colorBackgroundMatch;
            settingJson.TextColorLeague = colorTextColorLeague;
            settingJson.BlinkOfGoal = colorBlinkOfGoal;
            settingJson.TextColorHour = colorTextColorHour;
            settingJson.FinalScore = colorFinalScore;
            settingJson.PartialScore = colorPartialScore;
            settingJson.BackgroundRowGoal = colorBackgroundRowGoal;
            settingJson.TextColorMatch = colorTextColorMatch;
            settingJson.ScreenWidth = screenWidth;
            settingJson.ScreenHeight = screenHeight;

            string json = JsonConvert.SerializeObject(settingJson);
            string fileName = "setting_" + user + "_" + pageNumber.ToString() + ".json";
            System.IO.File.WriteAllText(fileName, json);

            Hide();
        }

        private void BtnCampionColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnCampionColor.BackColor = dialog.Color;
        }

        private void BtnMatchColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnMatchColor.BackColor = dialog.Color;
        }

        private void BtnGoalFlashing_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnGoalFlashing.BackColor = dialog.Color;
        }

        private void BtnColorCampionship_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnColorCampionship.BackColor = dialog.Color;
        }

        private void BtnNotNow_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnNotNow.BackColor = dialog.Color;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnResult.BackColor = dialog.Color;
        }

        private void BtnPartial_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnPartial.BackColor = dialog.Color;
        }

        private void SelectFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            tmpFont = fontDialog.Font;
        }

        private void BtnSquad_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnSquad.BackColor = dialog.Color;
        }

        private void BtnHighlight_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            BtnHighlight.BackColor = dialog.Color;
        }
    }
}
