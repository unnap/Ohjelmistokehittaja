using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkaLaskin
{
    public partial class BDayLaskinFM : Form
    {
        public BDayLaskinFM()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttarit = bdayDT.Value;
            DateTime today = DateTime.Now;
            vuodetLB.Text = today.Year - synttarit.Year + " vuotta";
            vuodetLB.Visible = true;
            kuukaudetLB.Text = today.Month - synttarit.Month + " kuukautta";
            kuukaudetLB.Visible = true;
            paivatLB.Text = Math.Round((today - synttarit).TotalDays) + " päivää";
            paivatLB.Visible = true;
            tunnitLB.Text = Math.Round((today - synttarit).TotalHours) + " tuntia";
            tunnitLB.Visible = true;
            minuutitLB.Text = Math.Round((today - synttarit).TotalMinutes) +  " minuuttia";
            minuutitLB.Visible = true;
            sekunnitLB.Text = Math.Round((today - synttarit).TotalSeconds) + " sekuntia";
            sekunnitLB.Visible = true;
        }
    }
}
