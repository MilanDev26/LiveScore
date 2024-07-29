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
    public partial class Banner : Form
    {
        public string strBanner;
        public Banner()
        {
            InitializeComponent();
            strBanner = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strBanner = TxtBanner.Text;
            if (strBanner == "")
            {
                MessageBox.Show("Si prega di inserire il Banner.", "Errore");
                return;
            }
            Hide();
        }
    }
}
