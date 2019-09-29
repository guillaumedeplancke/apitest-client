using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APITestCommon;

namespace APITestClient2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.lblRandomInt.Text = "Random: " + VersionAPI.getRandomInteger();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.lblRandomInt.Text = "Random: " + VersionAPI.getRandomInteger();
        }
    }
}