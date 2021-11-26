using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotelli
{
    public partial class LoginFM : Form
    {
        public LoginFM()
        {
            InitializeComponent();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            CONNECT yhdista = new CONNECT();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            String kysely = "SELECT * FROM kayttajat WHERE kayttajanimi = @kn AND salasana = @ss";

            komento.CommandText = kysely;
            komento.Connection = yhdista.getConnection();

            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = usernameTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = passwordTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if(taulu.Rows.Count > 0)
            {
                //this.Hide();
                //MainFM mform = new MainFM();
                //mform.Show();
                MessageBox.Show("jeejee");
            } else
            {
                if(usernameTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Käyttäjänimi pakollinen", "Käyttäjänimi puuttuu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if (passwordTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Kirjoita salasana", "Salasana puuttuu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show("Tämä käyttäjänimi tai salasana ei ole olemassa", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
