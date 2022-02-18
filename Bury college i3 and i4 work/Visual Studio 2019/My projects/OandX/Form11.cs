using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OandX
{
    public partial class Form11 : Form
    {
        bool turn = true;
        int turnCount = 0;

        int scoreX = 0;
        int scoreO = 0;
        int scoreD = 0;

        public Form11()
        {
            InitializeComponent();
        }

        private void A1_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        public void check()
        {
            bool ThereIsAWinner = false;

            if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text != "")
            { ThereIsAWinner = true; }
            else if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "")
            { ThereIsAWinner = true; }
            else if (c1.Text == c2.Text && c2.Text == c3.Text && c1.Text != "")
            { ThereIsAWinner = true; }
            else if (a1.Text == b1.Text && b1.Text == c1.Text && a1.Text != "")
            { ThereIsAWinner = true; }
            else if (a2.Text == b2.Text && b2.Text == c2.Text && a2.Text != "")
            { ThereIsAWinner = true; }
            else if (a3.Text == b3.Text && b3.Text == c3.Text && a3.Text != "")
            { ThereIsAWinner = true; }
            else if (a1.Text == b2.Text && b2.Text == c3.Text && a1.Text != "")
            { ThereIsAWinner = true; }
            else if (a3.Text == b2.Text && b2.Text == c1.Text && a3.Text != "")
            { ThereIsAWinner = true; }




            if (ThereIsAWinner)
            {
                string w = "";
                if (turn)
                {
                    w = "X";
                    scoreX = scoreX + 1;
                    MessageBox.Show("The winner is " + w + "! - X Score = " + scoreX);
                }
                else
                {
                    w = "O";
                    scoreO = scoreO + 1;
                    MessageBox.Show("The winner is " + w + "! - O Score = " + scoreO);
                }

                if (scoreX == 2)
                {
                    MessageBox.Show("The winner is " + w + "!");
                }
                else if (scoreO == 2)
                {
                    MessageBox.Show("The winner is " + w + "!");
                }
                else if (scoreX == 1 && scoreO == 1 && scoreD == 1)
                {
                    MessageBox.Show("Draw, there is no winner");
                }
                else
                {
                    turnCount = 0;

                    a1.Text = "";
                    a1.Enabled = true;

                    a2.Text = "";
                    a2.Enabled = true;

                    a3.Text = "";
                    a3.Enabled = true;

                    b1.Text = "";
                    b1.Enabled = true;

                    b2.Text = "";
                    b2.Enabled = true;

                    b3.Text = "";
                    b3.Enabled = true;

                    c1.Text = "";
                    c1.Enabled = true;

                    c2.Text = "";
                    c2.Enabled = true;

                    c3.Text = "";
                    c3.Enabled = true;

                }
            }
            else if (turnCount == 9)
            {
                scoreD = scoreD + 1;
                MessageBox.Show("Its a draw!");
            }
        }
                             
        private void A2_Click_1(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void A3_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void B1_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void B2_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void B3_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void C1_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void C2_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void C3_Click(object sender, EventArgs e)
        {

            try
            {
                Button b = (Button)sender;

                if (turn == true)
                {
                    b.Text = "O";
                    pictureBox2.BackColor = Color.DeepPink;
                    pictureBox3.BackColor = Color.White;


                }
                else
                {
                    b.Text = "X";
                    pictureBox3.BackColor = Color.Yellow;
                    pictureBox2.BackColor = Color.White;

                }
                turn = !turn;
                turnCount++;
                b.Enabled = false;
                check();
            }
            catch { }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
