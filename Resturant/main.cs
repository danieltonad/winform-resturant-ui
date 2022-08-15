using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            side.Height = button1.Height;
            side.Top = button1.Top;
            home1.BringToFront();
            nav.AutoScroll = false;

        }
 

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            side.Height = button1.Height;
            side.Top = button1.Top;
            home1.BringToFront();
            nav.AutoScroll = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            side.Height = button2.Height;
            side.Top = button2.Top;
            eat1.BringToFront();
            nav.AutoScroll = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            side.Height = button3.Height;
            side.Top = button3.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            side.Height = button5.Height;
            side.Top = button5.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            side.Height = button4.Height;
            side.Top = button4.Top;
        }

        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
