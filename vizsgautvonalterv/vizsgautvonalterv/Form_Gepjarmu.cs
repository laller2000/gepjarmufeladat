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
    public partial class Form_Gepjarmu : Form
    {
        public Form_Gepjarmu()
        {
            InitializeComponent();
        }

        private void Form_Gepjarmu_Load(object sender, EventArgs e)
        {
            dataGridView1_Gepjarmu.ColumnCount = 5;
            dataGridView1_Gepjarmu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Gepjarmu.Columns[0].Name = "rendszam";
            dataGridView1_Gepjarmu.Columns[0].HeaderText = "Rendszám";
            dataGridView1_Gepjarmu.Columns[1].Name = "marka";
            dataGridView1_Gepjarmu.Columns[1].HeaderText = "Márka";
            dataGridView1_Gepjarmu.Columns[2].Name = "tipus";
            dataGridView1_Gepjarmu.Columns[2].HeaderText = "Típus";
            dataGridView1_Gepjarmu.Columns[3].Name = "tulaj_neve";
            dataGridView1_Gepjarmu.Columns[3].HeaderText = "Tulajdonos";
            dataGridView1_Gepjarmu.Columns[4].Name = "fogyasztas";
            dataGridView1_Gepjarmu.Columns[4].HeaderText = "Fogyasztás";
            try
            {
                Program.sql.CommandText = "SELECT `rendszam`, `marka`, `tipus`, `tulaj_neve`, `fogyasztas` FROM `vizsga_gepjarmu` WHERE 1";
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujsor_index = dataGridView1_Gepjarmu.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Gepjarmu.Rows
                            [ujsor_index];
                        ujsor.Cells["rendszam"].Value = dr.GetString("rendszam");
                        ujsor.Cells["marka"].Value = dr.GetString("marka");
                        ujsor.Cells["tipus"].Value = dr.GetString("tipus");
                        ujsor.Cells["tulaj_neve"].Value = dr.GetString("tulaj_neve");
                        ujsor.Cells["fogyasztas"].Value = dr.GetDouble("fogyasztas");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void button1_Ujjarmu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_gepjarmufelvesz.Show();
        }

        private void button2_Adatokfrissites_Click(object sender, EventArgs e)
        {
            dataGridView1_Gepjarmu.ColumnCount = 5;
            dataGridView1_Gepjarmu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Gepjarmu.Columns[0].Name = "rendszam";
            dataGridView1_Gepjarmu.Columns[0].HeaderText = "Rendszám";
            dataGridView1_Gepjarmu.Columns[1].Name = "marka";
            dataGridView1_Gepjarmu.Columns[1].HeaderText = "Márka";
            dataGridView1_Gepjarmu.Columns[2].Name = "tipus";
            dataGridView1_Gepjarmu.Columns[2].HeaderText = "Típus";
            dataGridView1_Gepjarmu.Columns[3].Name = "tulaj_neve";
            dataGridView1_Gepjarmu.Columns[3].HeaderText = "Tulajdonos";
            dataGridView1_Gepjarmu.Columns[4].Name = "fogyasztas";
            dataGridView1_Gepjarmu.Columns[4].HeaderText = "Fogyasztás";
            try
            {
                Program.sql.CommandText = "SELECT `rendszam`, `marka`, `tipus`, `tulaj_neve`, `fogyasztas` FROM `vizsga_gepjarmu` WHERE 1";
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int ujsor_index = dataGridView1_Gepjarmu.Rows.Add();
                        DataGridViewRow ujsor = dataGridView1_Gepjarmu.Rows
                            [ujsor_index];
                        ujsor.Cells["rendszam"].Value = dr.GetString("rendszam");
                        ujsor.Cells["marka"].Value = dr.GetString("marka");
                        ujsor.Cells["tipus"].Value = dr.GetString("tipus");
                        ujsor.Cells["tulaj_neve"].Value = dr.GetString("tulaj_neve");
                        ujsor.Cells["fogyasztas"].Value = dr.GetDouble("fogyasztas");
                    }
                }
            }
            catch (MySqlException myex)
            {
                MessageBox.Show(myex.Message);
                return;
            }
        }

        private void dataGridView1_Gepjarmu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Program.form_utvonal.Show();
        }
    }
}
