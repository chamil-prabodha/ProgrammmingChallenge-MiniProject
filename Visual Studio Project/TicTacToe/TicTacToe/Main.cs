using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TicTacToe.Properties;
using MySql.Data.MySqlClient;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private Player a,b,CurrentPlayer;
        private int plays = 0;
        DBConnection connection;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modeSelect.SelectedItem = "Human";
            try
            {
                connection = new DBConnection();
            }
            catch (Exception)
            {
                this.Close();
            }

            button_Disable();
            label_PlayCount.Text = plays.ToString();

            
        }

        private void modeSelect_changed(object sender, EventArgs e)
        {
            if (modeSelect.Text == "Computer")
            {
                txtPlayer_2.Enabled = false;
                add_Player2.Enabled = false;
                if (!listBox_CurrPlayers.Items.Equals("Computer"))
                {
                    listBox_CurrPlayers.Items.Clear();
                    listBox_CurrPlayers.Items.Add("Computer");
                }
                

            }

            else if(modeSelect.Text == "Human")
            {
                txtPlayer_2.Enabled = true;
                add_Player2.Enabled = true;
                if (listBox_CurrPlayers.Items.Equals("Computer"))
                    listBox_CurrPlayers.Items.Clear();
            }

            else
            {
                button_Disable();
                txtPlayer_1.Enabled = false;
                add_Player1.Enabled = false;
                txtPlayer_2.Enabled = false;
                add_Player2.Enabled = false;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Image==null)
            {
                button1.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[0, 0] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(0, 0) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }

                //button1.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Image == null)
            {
                button2.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[0,1] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(0, 1) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button2.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Image == null)
            {
                button3.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[0, 2] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(0, 2) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button3.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Image == null)
            {
                button4.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[1, 0] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(1, 0) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button4.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Image == null)
            {
                button5.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[1, 1] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(1, 1) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button5.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Image == null)
            {
                button6.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[1, 2] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(1, 2) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button6.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Image == null)
            {
                button7.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[2, 0] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(2, 0) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button7.Enabled = false;
            }
            if (CurrentPlayer == a)
                CurrentPlayer = b;
            else
                CurrentPlayer = a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Image == null)
            {
                button8.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[2, 1] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(2, 1) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button8.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Image == null)
            {
                button9.Image = CurrentPlayer.tokenToImage(CurrentPlayer.getToken());
                CurrentPlayer.getTiles()[2, 2] = CurrentPlayer.getToken();
                if (CurrentPlayer.check_Win(2, 2) == (GameStatus)1)
                {
                    listBox_CurrPlayers.FindItemWithText(CurrentPlayer.getName()).SubItems[2].Text = CurrentPlayer.getScore().ToString();
                    DBConnection.writeToDB("UPDATE `Players` SET `Score` =" + CurrentPlayer.getScore().ToString() + " WHERE `PlayerName` ='" + CurrentPlayer.getName() + "'");
                    button_Disable();
                }
                //button9.Enabled = false;
                if (CurrentPlayer == a)
                    CurrentPlayer = b;
                else
                    CurrentPlayer = a;
            }
            
        }

       

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        public void button_Enable() {
            button1.Enabled = true;
            button1.Image = null;

            button2.Enabled = true;
            button2.Image = null;

            button3.Enabled = true;
            button3.Image = null;

            button4.Enabled = true;
            button4.Image = null;

            button5.Enabled = true;
            button5.Image = null;

            button6.Enabled = true;
            button6.Image = null;

            button7.Enabled = true;
            button7.Image = null;

            button8.Enabled = true;
            button8.Image = null;

            button9.Enabled = true;
            button9.Image = null;
        }

        public void button_Disable()
        {
            button1.Enabled = false;
            button1.Image = null;

            button2.Enabled = false;
            button2.Image = null;

            button3.Enabled = false;
            button3.Image = null;

            button4.Enabled = false;
            button4.Image = null;

            button5.Enabled = false;
            button5.Image = null;

            button6.Enabled = false;
            button6.Image = null;

            button7.Enabled = false;
            button7.Image = null;

            button8.Enabled = false;
            button8.Image = null;

            button9.Enabled = false;
            button9.Image = null;
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            
            if (a!=null &&  b!=null)
            {
                button_Enable();
                a.clearGame();
                b.clearGame();
                CurrentPlayer = a;
                plays++;
                label_PlayCount.Text = plays.ToString();
            }
            
        }

        private void btn_NewRally_Click(object sender, EventArgs e)
        {
            button_Disable();
            add_Player1.Enabled = true;
            add_Player2.Enabled = true;
            txtPlayer_1.Clear();
            txtPlayer_2.Clear();
            listBox_CurrPlayers.Items.Clear();
            
            CurrentPlayer = a;

            plays = 0;
            label_PlayCount.Text = plays.ToString();
        }

        private void add_Player1_Click(object sender, EventArgs e)
        {
            if (listBox_CurrPlayers.Items.Count < 2 && txtPlayer_1.Text != "")
            {
                string addPlayer = "INSERT into `players` VALUES('" + txtPlayer_1.Text + "','0')";
                if (DBConnection.writeToDB(addPlayer))
                {
                    a = new Player(1, txtPlayer_1.Text);
                    ListViewItem player1 = new ListViewItem(txtPlayer_1.Text);
                    player1.SubItems.Add("X");
                    player1.SubItems.Add("0");
                    listBox_CurrPlayers.Items.Add(player1);

                    CurrentPlayer = a;
                    add_Player1.Enabled = false;

                    if (listBox_CurrPlayers.Items.Count == 2)
                    {
                        button_Enable();
                        plays = 1;
                        label_PlayCount.Text = plays.ToString();
                    }
                }

                else
                {
                    MeBox message = new MeBox();
                    if (message.ShowDialog() == DialogResult.OK)
                    {
                        string getScore = "SELECT score FROM `Players` WHERE `PlayerName` ='" + txtPlayer_1.Text + "'";
                        
                        MySqlDataReader reader = DBConnection.readFromDB(getScore);

                        a = new Player(1, txtPlayer_1.Text);
                        ListViewItem player1 = new ListViewItem(txtPlayer_1.Text);

                        string score = "0";
                        
                        if(reader.Read())
                        {
                            score = reader.GetInt32(0).ToString();
                            a.setScore(Int32.Parse(score));
                        }

                        player1.SubItems.Add("X");
                        player1.SubItems.Add(score);
                        listBox_CurrPlayers.Items.Add(player1);

                        CurrentPlayer = a;
                        add_Player1.Enabled = false;

                        if (listBox_CurrPlayers.Items.Count == 2)
                        {
                            button_Enable();
                            plays = 1;
                            label_PlayCount.Text = plays.ToString();
                        }
                    }

                    
                }

                
            }

            
            
        }

        private void add_Player2_Click(object sender, EventArgs e)
        {
            if (listBox_CurrPlayers.Items.Count < 2 && txtPlayer_2.Text != "")
            {
                string addPlayer = "INSERT into `players` VALUES('" + txtPlayer_2.Text + "','0')";
                if (DBConnection.writeToDB(addPlayer))
                {
                    b = new Player(2, txtPlayer_2.Text);
                    ListViewItem player2 = new ListViewItem(txtPlayer_2.Text);
                    player2.SubItems.Add("O");
                    player2.SubItems.Add("0");
                    listBox_CurrPlayers.Items.Add(player2);

                    CurrentPlayer = a;
                    add_Player2.Enabled = false;

                    if (listBox_CurrPlayers.Items.Count == 2)
                    {
                        button_Enable();
                        plays = 1;
                        label_PlayCount.Text = plays.ToString();
                    }
                }

                else {

                    MeBox message = new MeBox();
                    if (message.ShowDialog() == DialogResult.OK)
                    {
                        string getScore = "SELECT `Score` FROM `Players` WHERE `PlayerName` ='" + txtPlayer_2.Text + "'";
                        
                        MySqlDataReader reader = DBConnection.readFromDB(getScore);
                        b = new Player(2, txtPlayer_2.Text);
                        
                        ListViewItem player2 = new ListViewItem(txtPlayer_2.Text);
                        
                        string score = "0";

                        if (reader.Read())
                        {
                            score = reader.GetInt32(0).ToString();
                            b.setScore(Int32.Parse(score));
                        }

                        player2.SubItems.Add("O");
                        player2.SubItems.Add(score);
                        listBox_CurrPlayers.Items.Add(player2);

                        CurrentPlayer = a;
                        add_Player2.Enabled = false;

                        if (listBox_CurrPlayers.Items.Count == 2)
                        {
                            button_Enable();
                            plays = 1;
                            label_PlayCount.Text = plays.ToString();
                        }
                    }
                    
                }
            }

            
        }

        private void playerScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPlayers playersTable = new ViewPlayers();
            playersTable.Show();

        }

        
        
    }
}
