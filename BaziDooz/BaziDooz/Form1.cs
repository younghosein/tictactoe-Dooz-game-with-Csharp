using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaziDooz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] Array = new int[3, 3];
        static int roundNumber = 0;
        int player1 = 1;
        int player2 = 2;
        int player1Score = 0;
        int player2Score = 0;

        private bool checkWinner(int player)
        {
            // check rows
            if (Array[0, 0] == player && Array[0, 1] == player && Array[0, 2] == player) { return true; }
            if (Array[1, 0] == player && Array[1, 1] == player && Array[1, 2] == player) { return true; }
            if (Array[2, 0] == player && Array[2, 1] == player && Array[2, 2] == player) { return true; }

            // check columns
            if (Array[0, 0] == player && Array[1, 0] == player && Array[2, 0] == player) { return true; }
            if (Array[0, 1] == player && Array[1, 1] == player && Array[2, 1] == player) { return true; }
            if (Array[0, 2] == player && Array[1, 2] == player && Array[2, 2] == player) { return true; }

            // check diags
            if (Array[0, 0] == player && Array[1, 1] == player && Array[2, 2] == player) { return true; }
            if (Array[0, 2] == player && Array[1, 1] == player && Array[2, 0] == player) { return true; }
            return false;
        }

        private void MessageBox_chechwinner(int a)
        {
            if (checkWinner(a))
            {
                if (a == 1)
                {
                    MessageBox.Show("Player 1 Wins :)");
                }
                else
                {
                    MessageBox.Show("Player 2 Wins :)");
                }

            }
            else
            {
                if (roundNumber == 9)
                {
                    MessageBox.Show("Game Over :(");
                }
            }

        }

        private void reset()
        {
            btn1.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn2.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn3.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn4.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn5.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn6.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn7.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn8.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);
            btn9.FlatAppearance.BorderColor = Color.FromArgb(20, 50, 100);

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Array[i, j] = 0;
                }
            }
            roundNumber = 0;
        }

        private int finally1(int b)
        {
            MessageBox_chechwinner(b);

            if (checkWinner(b))
            {
                if (b == 1)
                {
                    player1Score++;
                }
                if (b == 2)
                {
                    player2Score++;
                }

                updateScoreTextbox();

                reset();
            }
            if (roundNumber == 9)
            {
                reset();
            }
            return 1;
        }

        private void updateScoreTextbox()
        {
            lblP1.Text = player1Score.ToString();
            lblP2.Text = player2Score.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblP1.Text = "0";
            lblP2.Text = "0";
            player1Score = 0;
            player2Score = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[0, 0] == 1 || Array[0, 0] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[0, 0] = player1;
                    btn1.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[0, 0] = player2;
                    btn1.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[0, 0];
                finally1(z);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[0, 1] == 1 || Array[0, 1] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[0, 1] = player1;
                    btn2.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[0, 1] = player2;
                    btn2.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[0, 1];
                finally1(z);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[0, 2] == 1 || Array[0, 2] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[0, 2] = player1;
                    btn3.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[0, 2] = player2;
                    btn3.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[0, 2];
                finally1(z);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[1, 0] == 1 || Array[1, 0] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[1, 0] = player1;
                    btn4.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[1, 0] = player2;
                    btn4.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[1, 0];
                finally1(z);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[1, 1] == 1 || Array[1, 1] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[1, 1] = player1;
                    btn5.FlatAppearance.BorderColor = Color.MediumSlateBlue;

                }
                else
                {
                    Array[1, 1] = player2;
                    btn5.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[1, 1];
                finally1(z);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[1, 2] == 1 || Array[1, 2] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[1, 2] = player1;
                    btn6.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[1, 2] = player2;
                    btn6.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[1, 2];
                finally1(z);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[2, 0] == 1 || Array[2, 0] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[2, 0] = player1;
                    btn7.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[2, 0] = player2;
                    btn7.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[2, 0];
                finally1(z);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[2, 1] == 1 || Array[2, 1] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[2, 1] = player1;

                    btn8.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[2, 1] = player2;
                    btn8.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[2, 1];
                finally1(z);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //پر بودن
            if (Array[2, 2] == 1 || Array[2, 2] == 2)
            {
                return;
            }
            else
            {
                roundNumber++;
                if (roundNumber % 2 == 1)
                {
                    Array[2, 2] = player1;
                    btn9.FlatAppearance.BorderColor = Color.MediumSlateBlue;
                }
                else
                {
                    Array[2, 2] = player2;
                    btn9.FlatAppearance.BorderColor = Color.DarkOrchid;
                }

                int z = Array[2, 2];
                finally1(z);
            }
        }
    }
}
