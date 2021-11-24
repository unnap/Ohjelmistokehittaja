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

namespace Opiskelijat
{
    public partial class OpiskelijatFM : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();

        public OpiskelijatFM()
        {
            InitializeComponent();
        }

        private void OpiskelijatFM_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            OidTB.Text = "";
            ENimiTB.Text = "";
            SNimiTB.Text = "";
            PuhelinTB.Text = "";
            EMailTB.Text = "";
            ONroTB.Text = "";
        }


        private void TallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = ENimiTB.Text;
            String snimi = SNimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String email = EMailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OidTB.Text = "";
                    ENimiTB.Text = "";
                    SNimiTB.Text = "";
                    PuhelinTB.Text = "";
                    EMailTB.Text = "";
                    ONroTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            int oid = Int32.Parse(OidTB.Text);
            String enimi = ENimiTB.Text;
            String snimi = SNimiTB.Text;
            String puhelin = PuhelinTB.Text;
            String email = EMailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);
            

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OidTB.Text = "";
                    ENimiTB.Text = "";
                    SNimiTB.Text = "";
                    PuhelinTB.Text = "";
                    EMailTB.Text = "";
                    ONroTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }


        private void PoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = OidTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhjennaBT.PerformClick();
        }

        private void TietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OidTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            ENimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SNimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhelinTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            EMailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            ONroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
