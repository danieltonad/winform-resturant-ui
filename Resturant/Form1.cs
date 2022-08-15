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
    public partial class Form1 : Form
    {
      
       
        public Form1()
        {
            InitializeComponent();
            login1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void login1_Load(object sender, EventArgs e)
        {
            
        }
        public static bool ai = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            login1.BringToFront();
            ai = true;
            label3.Visible = true;
            label4.Visible = false;


            if (login.username == "Username" || login.pwd == "Password" || login.username == "" || login.pwd == "" || login.username == null || login.pwd == null)
            {
                
                MessageBox.Show("Please Input Username and Passowrd","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
                
            }
            else
            {
                if (ai && login.username != "Username" && login.pwd != "Password")
                {
                    this.Hide();
                    main ya = new main();
                    ya.ShowDialog();
                }
                else
                {
                    //login1.BringToFront();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup1.BringToFront();
            ai = false;
            label3.Visible = false;
            label4.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
