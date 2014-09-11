using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    class DBConnection
    {
        public static MySqlConnection Conn;
        private string conString = null;
        public MySqlCommand command = null;

        public DBConnection() {
            conString = "server=localhost;user=root;database=TicTacToe;port=3306;password=";
            Conn = new MySqlConnection(conString);

            try
            {
                OpenConnection();
                MessageBox.Show("Connected!");
                Conn.Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool writeToDB(string query) {

            MySqlCommand command = new MySqlCommand(query, Conn);
            OpenConnection();

            try
            {
                command.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public static MySqlDataReader readFromDB(string query)
        {
            MySqlDataReader DBreader = null;

            OpenConnection();

            MySqlCommand command = new MySqlCommand(query, Conn);
            DBreader = command.ExecuteReader();

            

            return DBreader;

        }

        public DataSet getTable(string query) {

            MySqlDataAdapter dataAdapter = null;

            OpenConnection();

            dataAdapter = new MySqlDataAdapter(query, Conn);

            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }

        public static void OpenConnection() {
            try
            {
                Conn.Close();
                Conn.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Open Connection!!!\n\nException:\n" + ex);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                Conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot Close Connection!!!\n\nException:\n" + ex);
            }
        }
    }

}
