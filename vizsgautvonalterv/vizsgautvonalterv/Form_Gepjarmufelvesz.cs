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

namespace vizsgautvonalterv
{
    public partial class Form_Gepjarmufelvesz : Form
    {
        public Form_Gepjarmufelvesz()
        {
            InitializeComponent();
        }

        private void button1_Rogzit_Click(object sender, EventArgs e)
        {
            string rendszam=textBox1_Rendszam.Text.ToString();
            string marka=textBox2_Marka.Text.ToString();
            string tipus=textBox3_Tipus.Text.ToString();
            string tulaj_neve=textBox4_Tulajdonos.Text.ToString();
            double fogyasztas=Convert.ToDouble(textBox5_Fogyasztas.Text.ToString());
            if (String.IsNullOrEmpty(rendszam))
            {
                MessageBox.Show("Nem töltötted ki a rendszam mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(marka))
            {
                MessageBox.Show("Nem töltötted ki a marka mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(tipus))
            {
                MessageBox.Show("Nem töltötted ki a tipus mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(tulaj_neve))
            {
                MessageBox.Show("Nem töltötted ki a tulajdonos mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(fogyasztas.ToString()))
            {
                MessageBox.Show("Nem töltötted ki a fogyasztas mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Program.sql.CommandText = "INSERT INTO `vizsga_gepjarmu`(`rendszam`, `marka`, `tipus`, `tulaj_neve`, `fogyasztas`) VALUES ('"+rendszam+"','"+marka+"','"+tipus+"','"+tulaj_neve+"','"+fogyasztas+"')";
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            MessageBox.Show("Sikeres rögzítés!");
            textBox1_Rendszam.Text = "";
            textBox2_Marka.Text = "";
            textBox3_Tipus.Text = "";
            textBox4_Tulajdonos.Text = "";
            textBox5_Fogyasztas.Text = "";
            this.Hide();
            Program.form_gepjarmu.Show();
        }
    }
}
