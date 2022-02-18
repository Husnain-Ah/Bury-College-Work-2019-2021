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

    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
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
                ThereIsAWinner = true;
            else if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "")
                ThereIsAWinner = true;
            else if (c1.Text == c2.Text && c2.Text == c3.Text && c1.Text != "")
                ThereIsAWinner = true;
         
            else if (a1.Text == b1.Text && b1.Text == c1.Text && a1.Text != "")
                ThereIsAWinner = true;
            else if (a2.Text == b2.Text && b2.Text == c2.Text && a2.Text != "")
                ThereIsAWinner = true;
            else if (a3.Text == b3.Text && b3.Text == c3.Text && a3.Text != "")
                ThereIsAWinner = true;
       
            else if (a1.Text == b2.Text && b2.Text == c3.Text && a1.Text != "")
                ThereIsAWinner = true;
            else if (a3.Text == b2.Text && b2.Text == c1.Text && a3.Text != "")
                ThereIsAWinner = true;
            



            if (ThereIsAWinner)
            {
                string w = "";
                if (turn)
                    w = "X";
                else w = "O";
                MessageBox.Show("The winner is " + w + "!");
                this.Close();
            }
            else if (turnCount == 9)
            {
                MessageBox.Show("Its a draw!");
            }
        }

        private void A2_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
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
}
