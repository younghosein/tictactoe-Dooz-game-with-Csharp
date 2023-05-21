using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppXO
{
    public partial class FormXO : Form
    {
        public FormXO()
        {
            InitializeComponent();
        }
        int [,] array=new int[3,3];
        int ap = 1;
        void tp()
        {
            if (ap == 1)
            {
                ap = 2;
                lblPlayer.Text = "Player O";
            }
            else if (ap == 2)
            {
                ap = 1;
                lblPlayer.Text = "Player X";
            }
        }
        void clear()
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 0;
                }
                btn00.Text = "";
                btn01.Text = "";
                btn02.Text = "";
                btn10.Text = "";
                btn11.Text = "";
                btn12.Text = "";
                btn20.Text = "";
                btn21.Text = "";
                btn22.Text = "";
            }
        }
        void win(string a)
        {
            //Line
            if(btn00.Text==a&& btn01.Text == a && btn02.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
            else if (btn10.Text == a && btn11.Text == a && btn12.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
            else if (btn20.Text == a && btn21.Text == a && btn22.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
            //Col
            else if (btn00.Text == a && btn10.Text == a && btn20.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
            else if (btn01.Text == a && btn11.Text == a && btn21.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
            else if (btn02.Text == a && btn12.Text == a && btn22.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
            //R_A
            else if (btn00.Text == a && btn11.Text == a && btn22.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
            //R_F
            else if (btn02.Text == a && btn11.Text == a && btn20.Text == a)
            {
                MessageBox.Show(text: "Player " + a + " won the game");
                clear();
            }
        }
        void nowin()
        {
            string s = (btn00.Text + btn01.Text + btn02.Text + btn10.Text + btn11.Text + btn12.Text + btn20.Text + btn21.Text + btn22.Text);
            if (s.Length == 9)
            {
                MessageBox.Show(text: "The game had no winner");
                clear();
            }
        }
        void XO(Button btn,int p,int x,int y)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = p;
                if (p == 1)
                {
                    btn.Text = "X";
                }
                else if (p == 2)
                {
                    btn.Text = "O";
                }
                tp();
                win(a: "X");
                win(a: "O");
                nowin();
            }
        }
        private void FormXO_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 0;
                }
            }
        }

        private void Btn00_Click(object sender, EventArgs e)
        {
            XO(btn00, ap, 0, 0);
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            XO(btn01, ap, 0, 1);
        }

        private void Btn02_Click(object sender, EventArgs e)
        {
            XO(btn02, ap, 0, 2);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            XO(btn10, ap, 1, 0);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            XO(btn11, ap, 1, 1);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            XO(btn12, ap, 1, 2);
        }

        private void Btn20_Click(object sender, EventArgs e)
        {
            XO(btn20, ap, 2, 0);
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            XO(btn21, ap, 2, 1);
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            XO(btn22, ap, 2, 2);
        }

        private void BtnNewgame_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
