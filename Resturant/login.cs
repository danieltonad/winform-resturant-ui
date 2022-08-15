using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Resturant
{
    public partial class login : UserControl
    {
        public static string username, pwd;
        public login()
        {
            InitializeComponent();
           
           
        

            //login_username.GotFocus += GotFocus.EventHandle(RemoveText);




        }

        public void RemoveText(object Sender, EventArgs e)
        {

        }
        public void AddText(object Sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
             pwd = login_password.Text;
        }

        private void login_password_Click(object sender, EventArgs e)
        {

            placeholder.click_pass(login_password, "Password", login_password.Text);
            

        }
        

        private void login_username_Click(object sender, EventArgs e)
        {
            placeholder.click(login_username, "Username", login_username.Text);
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_username_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void login_username_Leave(object sender, EventArgs e)
        {
            placeholder.leave(login_username, "Username", login_username.Text);
        }

        private void login_password_Leave(object sender, EventArgs e)
        {
            placeholder.leave_pass(login_password, "Password", login_password.Text);
        }

        private void login_username_TextChanged_1(object sender, EventArgs e)
        {
            username= login_username.Text;
            
        }

        private void login_username_MouseLeave(object sender, EventArgs e)
        {
           
        }

        

    }

    
}
