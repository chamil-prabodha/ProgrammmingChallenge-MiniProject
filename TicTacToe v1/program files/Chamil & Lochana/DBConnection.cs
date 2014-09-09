using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DBConnection
    {
        public static MySqlConnection Conn;
        private string conString = null;

        public DBConnection() {
            conString = "server=localhost;user=root;port=3306;password=";
            Conn = new MySqlConnection(conString);

            try
            {
                Conn.Open();
                MessageBox.Show("Connected!");
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
