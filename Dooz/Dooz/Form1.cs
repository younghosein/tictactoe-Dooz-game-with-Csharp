using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dooz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Boolean lblDir = true;
        public int p1Counter = 0, p2Counter = 0;
        char player = 'O', StarterPlayer = 'O';
        public void CheckIfEnd(Button l11, Button l12, Button l13,
            Button l21, Button l22, Button l23, Button l31,
            Button l32, Button l33)
        {
            if (l11.Text == l22.Text && l22.Text == l33.Text && l33.Text != "")
                setBackcolor(l11, l22, l33);
            else if (l11.Text == l12.Text && l12.Text == l13.Text && l13.Text != "")
                setBackcolor(l11, l12, l13);
            else if (l21.Text == l22.Text && l22.Text == l23.Text && l23.Text != "")
                setBackcolor(l21, l22, l23);
            else if (l31.Text == l32.Text && l32.Text == l33.Text && l33.Text != "")
                setBackcolor(l31, l32, l33);
            else if (l13.Text == l22.Text && l22.Text == l31.Text && l31.Text != "")
                setBackcolor(l13, l22, l31);
            else if (l11.Text == l21.Text && l21.Text == l31.Text && l31.Text != "")
                setBackcolor(l11, l21, l31);
            else if (l12.Text == l22.Text && l22.Text == l32.Text && l32.Text != "")
                setBackcolor(l12, l22, l32);
            else if (l13.Text == l23.Text && l23.Text == l33.Text && l33.Text != "")
                setBackcolor(l13, l23, l33);

            Boolean b = true;
            foreach (Button btn in panel1.Controls)
                if (btn.Text == "")
                    b = false;

            if (b == true)
            {
                playAgainButton.Visible = true;
                resultLabel.Text = "******* مساوی *******";
            }

        }

        public void setBackcolor(Button b1, Button b2, Button b3)
        {
            DisplayTheWinner();
            b1.BackColor = Color.Green;
            b2.BackColor = Color.Green;
            b3.BackColor = Color.Green;
        }

        public void DisplayTheWinner()
        {
            if (player == 'X') player = 'O';
            else player = 'X';
            resultLabel.Text = "******  بازیکن " +  player  + " برنده شد  ******";
            playAgainButton.Visible = true;
            timer1.Enabled = true;
            playAgainButton.Select();
            if (player == 'O')
            {
                ++p1Counter;
                player1Label.Text = "امتیاز بازیکن O\n\n [ " + p1Counter + " ]";
            }
            else if (player == 'X')
            {
                ++p2Counter;
                player2Label.Text = "امتیاز بازیکن X\n\n [ " + p2Counter + " ]";
            }
            foreach (Button btn in panel1.Controls)
                btn.Enabled = false;
        }

        public void SwitchPlayer()
        {
            if (player == 'O')
                player = 'X';
            else if (player == 'X')
                player = 'O';

            resultLabel.Text = "نوبت بازیکن " + player;
            CheckIfEnd(l11, l12, l13, l21, l22, l23, l31, l32, l33);
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;
            btn.Text = player.ToString();
            btn.Enabled = false;
            btntemp.Focus();
            SwitchPlayer();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.Enabled = true;
                btn.BackColor = Color.White;
                btn.Text = "";
            }
            if (StarterPlayer == 'O')
                StarterPlayer = 'X';
            else
                StarterPlayer = 'O';
            player = StarterPlayer;
            playAgainButton.Visible = false;
            btntemp.Focus();
            resultLabel.Text = "نوبت بازیکن " + player;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playAgainButton.Visible = false;
            resultLabel.Text = "نوبت بازیکن " + StarterPlayer;
            player1Label.Text = "امتیاز بازیکن O\n\n [ " + p1Counter + " ]";
            player2Label.Text = "امتیاز بازیکن X\n\n [ " + p2Counter + " ]";
            btntemp.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblDir)
                if (myLabel.Left < this.Width - myLabel.Width)
                    myLabel.Left = myLabel.Left + 7;
                else
                    lblDir = false;
            else
                if (myLabel.Left > 0)
                    myLabel.Left = myLabel.Left - 7;
                else
                    lblDir = true;
        }
    }
}
