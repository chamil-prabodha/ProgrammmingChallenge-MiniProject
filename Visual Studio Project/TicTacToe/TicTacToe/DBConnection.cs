using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace TicTacToe
{
    class DBConnection
    {
        public static MySqlConnection Conn;
        private string conString = null;
        public MySqlCommand command = null;

        public DBConnection() {
            conString = "server=localhost;user=root;port=3306;password=";

            Conn = new MySqlConnection(conString);

            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand("CREATE DATABASE IF NOT EXISTS `TicTacToe`", Conn);
                command.ExecuteNonQuery();
                CloseConnection();
                conString = "server=localhost;user=root;port=3306;database=TicTacToe;password=";
                Conn = new MySqlConnection(conString);

                OpenConnection();
                command = new MySqlCommand("CREATE TABLE IF NOT EXISTS Players(`PlayerName` VARCHAR(50),`Score` INT, PRIMARY KEY(PlayerName));",Conn);
                command.ExecuteNonQuery();

                
                MessageBox.Show("Connected!");
                CloseConnection();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
                
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

        public static DataSet getTable(string query) {

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
