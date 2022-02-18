using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreasureHunt
{
    public partial class Form2 : Form
    {
        public static string[] treasureGrid = new string[9];
        public static string treasurePosition = "-1-";
        public static int clickCounter = 0;
        public static int timeLeft = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timeLeft = 15;
            timer1.Enabled = true;

            clickCounter = 0;

            Button1.Enabled = true;
            Button1.Text = "-1-";
            Button2.Enabled = true;
            Button2.Text = "-2-";
            Button3.Enabled = true;
            Button3.Text = "-3-";

            Button4.Enabled = true;
            Button4.Text = "-4-";
            Button5.Enabled = true;
            Button5.Text = "-5-";
            Button6.Enabled = true;
            Button6.Text = "-6-";

            Button7.Enabled = true;
            Button7.Text = "-7-";
            Button8.Enabled = true;
            Button8.Text = "-8-";
            Button9.Enabled = true;
            Button9.Text = "-9-";

            treasureGrid[0] = "-1-";
            treasureGrid[1] = "-2-";
            treasureGrid[2] = "-3-";
            treasureGrid[3] = "-4-";
            treasureGrid[4] = "-5-";
            treasureGrid[5] = "-6-";
            treasureGrid[6] = "-7-";
            treasureGrid[7] = "-8-";
            treasureGrid[8] = "-9-";

            Random rnd = new Random();
            treasurePosition = treasureGrid[rnd.Next(9)];

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            clickCounter++;
            ClickLabel.Text = clickCounter.ToString();

            if (treasurePosition == (sender as Button).Text)
            {
                (sender as Button).Image = TreasureHunt.Properties.Resources.D3_1_2_Treasure_Image;
                string message = "You found the treasure in " + clickCounter.ToString();
                timer1.Enabled = false;
                MessageBox.Show(message, "Winner");
                this.Close();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft - 1;

            TimeLabel.Text = timeLeft.ToString();

            if (timeLeft == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("YOu ran out of time", "Game Over");
                this.Close();
            }
        }
    }
}
