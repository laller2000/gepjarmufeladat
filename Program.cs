using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vizsgautvonalterv
{
    static class Program
    {
        public static MySqlCommand sql = null;
        public static MySqlConnection conn = null;
        public static Form form_gepjarmu = null;
        public static Form form_gepjarmufelvesz = null;
        public static Form form_utvonal = null;
        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "gepjarmuutvonal";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException myex)
            {
                Console.WriteLine("Sikertelen kapcsolat!"+myex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_gepjarmu = new Form_Gepjarmu();
            form_gepjarmufelvesz = new Form_Gepjarmufelvesz();
            form_utvonal = new Form_Utvonal();
            Application.Run(form_gepjarmu);
        }
    }
}
