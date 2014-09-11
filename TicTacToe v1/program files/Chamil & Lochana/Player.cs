using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Player
    {
        string PlayerName = "";
        Token playerToken = 0;
        private int playerScore = 0;
        private static int moveCount = 0;
        private Token[,] tiles = new Token[3, 3];

        public Player(int tk,string name) {
            playerToken = (Token)tk;
            PlayerName = name;
            playerScore = 0;
            moveCount = 0;

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    tiles[i,j] = 0;
                }
            }
        }

        public Token getToken() {
            return playerToken;
        }

        public Token[,] getTiles() {
            return tiles;
        }

        public GameStatus check_Win(int x,int y)
        {
            string Caption = "Congratulations";
            string Message = PlayerName+" Won!!!";
            moveCount++;
            
            for (int i = 0; i < 3; i++)
            {
                if (tiles[x, i] != playerToken)
                    break;
                if (i == 2)
                {
                    MessageBox.Show(Message, Caption);
                    playerScore += 10;
                    return (GameStatus)1;
                }

            }

            for (int i = 0; i < 3; i++)
            {
                if (tiles[i, y] != playerToken)
                    break;
                if (i == 2)
                {
                    MessageBox.Show(Message, Caption);
                    playerScore += 10;
                    return (GameStatus)1;
                }
            }

            if (x == y)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (tiles[i, i] != playerToken)
                        break;
                    if (i == 2)
                    {
                        MessageBox.Show(Message, Caption);
                        playerScore += 10;
                        return (GameStatus)1;
                    }
                }

            }

            for (int i = 0; i < 3; i++)
            {
                if (tiles[i,2 - i] != playerToken)
                    break;
                if (i == 2)
                {
                    MessageBox.Show(Message, Caption);
                    playerScore += 10;
                    return (GameStatus)1;
                }
            }

            if (moveCount == 9)
            {
                MessageBox.Show("Game Drawn");
                return (GameStatus)2;
            }

            return (GameStatus)0;
            
        }

        public int getScore()
        {
            return playerScore;
        }

        public void setScore(int score)
        {
            this.playerScore = score;
        }

        public string getName() {
            return PlayerName;
        }

        public void clearGame() {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tiles[i, j] = 0;
                }
            }
            moveCount = 0;
        }
    }
}
