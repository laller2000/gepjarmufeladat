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
    public partial class Form_Utvonal : Form
    {
         static List<Vizsga_Gepjarmu> gepjarmuk = new List<Vizsga_Gepjarmu>();
        static List<Vizsga_Utvonal> utvonalak = new List<Vizsga_Utvonal>();
        int osszeskm = 0;
        double uzemanyagmennyiseg=0;
        public Form_Utvonal()
        {
            InitializeComponent();
        }

        private void Form_Utvonal_Load(object sender, EventArgs e)
        {
            dataGridView1_Utvonal.ColumnCount = 3;
            dataGridView1_Utvonal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Utvonal.Columns[0].Name = "honnan";
            dataGridView1_Utvonal.Columns[0].HeaderText = "Indulás";
            dataGridView1_Utvonal.Columns[1].Name = "Hova";
            dataGridView1_Utvonal.Columns[1].HeaderText = "Érkezés";
            dataGridView1_Utvonal.Columns[2].Name = "km";
            dataGridView1_Utvonal.Columns[2].HeaderText = "Megtett km";
            try
            {
                Program.sql.CommandText = "SELECT  `honnan`, `hova`, `km` FROM `vizsga_utvonal` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int uj_sor_indexe = dataGridView1_Utvonal.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Utvonal.Rows
                            [uj_sor_indexe];
                        ujsor.Cells["honnan"].Value = dr.GetString("honnan");
                        ujsor.Cells["hova"].Value = dr.GetString("hova");
                        ujsor.Cells["km"].Value = dr.GetInt32("km");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
            GepjarmukListaFeltoltese();
            UtvonalakListaFelotltese();
            for (int i = 0; i < utvonalak.Count; i++)
            {
                osszeskm += utvonalak[i].Km;
            }
            for (int i = 0; i < gepjarmuk.Count; i++)
            {
                for (int j = 0; j < utvonalak.Count; j++)
                {
                    uzemanyagmennyiseg += osszeskm * gepjarmuk[i].Fogyasztas / 100;
                }
            }
            textBox1_Osszeskm.Text = osszeskm.ToString();
            textBox2_Osszesfogyasztas.Text = uzemanyagmennyiseg.ToString();
            
        }
        private void GepjarmukListaFeltoltese()
        {
            gepjarmuk.Clear();
            try
            {
                Program.sql.CommandText = "SELECT `rendszam`, `marka`, `tipus`, `tulaj_neve`, `fogyasztas` FROM `vizsga_gepjarmu` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    gepjarmuk.Add(new Vizsga_Gepjarmu(dr.GetString("rendszam"),dr.GetString("marka"),dr.GetString("tipus"),dr.GetString("tulaj_neve"),dr.GetDouble("fogyasztas")));
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }
        private void UtvonalakListaFelotltese()
        {
            utvonalak.Clear();
            try
            {
                Program.sql.CommandText = "SELECT `id`, `gepjarmuID`, `honnan`, `hova`, `km` FROM `vizsga_utvonal` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        utvonalak.Add(new Vizsga_Utvonal(dr.GetInt32("id"),dr.GetString("gepjarmuID"),dr.GetString("honnan"),dr.GetString("hova"),dr.GetInt32("km")));
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }
    }
}
