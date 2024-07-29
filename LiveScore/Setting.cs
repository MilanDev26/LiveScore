using Newtonsoft.Json;
using RestSharp;
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
    public partial class Setting : Form
    {
        public List<League> leagueList;
        public string user;
        public int number;
        public Setting(List<League> leagueList, string userName, int num)
        {
            user = userName;
            this.number = num;
            if (leagueList == null)
                this.leagueList = API.GetLeagueList();
            else
                this.leagueList = leagueList;
            InitializeComponent();
            GetData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void GetData()
        {
            foreach(League data in leagueList)
            {
                chkListCountry.Items.Add(data.country_name + ": " + data.league_name);
            }
            for (int count = 0; count < leagueList.Count; count++)
            {
                if (leagueList[count].check_show)
                    chkListCountry.SetItemChecked(count, true);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < leagueList.Count; i++)
            {
                if (!chkListCountry.GetItemChecked(i))
                {
                    leagueList[i].check_show = false;
                }
                else
                    leagueList[i].check_show = true;
            }

            string json = JsonConvert.SerializeObject(leagueList);
            string leagueFileName = "league_setting_" + user + "_" + number.ToString() + ".json";
            System.IO.File.WriteAllText(leagueFileName, json);
            Hide();
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < leagueList.Count; count++)
            {
                chkListCountry.SetItemChecked(count, true);
            }
        }

        private void BtnDeselectAll_Click(object sender, EventArgs e)
        {

            for (int count = 0; count < leagueList.Count; count++)
            {
                chkListCountry.SetItemChecked(count, false);
            }
        }
    }
}
