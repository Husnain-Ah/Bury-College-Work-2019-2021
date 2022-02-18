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
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 open = new Form1();
            open.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form11 open = new Form11();
            open.Show();
        }
    }
}
