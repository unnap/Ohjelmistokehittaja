using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Laskin : Form
    {
        public Laskin()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float lasku = 0;
            float num1 = float.Parse(LukuYksiTB.Text);
            float num2 = float.Parse(LukuKaksiTB.Text);
            switch(LaskutoimitusCB.Text)
            {
                case "+":
                    lasku = num1 + num2;
                    break;
                case "-":
                    lasku = num1 - num2;
                    break;
                case "*":
                    lasku = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        VastausLB.Text = "Nollalla ei voi jakaa";
                        goto HYPPY;
                    } else
                    {
                        lasku = num1 / num2;
                    }
                    break;
            }
            VastausLB.Text = lasku.ToString();
        HYPPY:
            VastausLB.Visible = true;
        }
    }
}
