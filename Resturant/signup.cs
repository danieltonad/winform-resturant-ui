using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class signup : UserControl
    {
        public signup()
        {
            InitializeComponent();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            placeholder.click(first_name, "First name", first_name.Text);
        }

        private void first_name_Leave(object sender, EventArgs e)
        {
            placeholder.leave(first_name, "First name", first_name.Text);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            placeholder.click_pass(password, "Password", password.Text);
        }

        private void password_Leave(object sender, EventArgs e)
        {
            placeholder.leave_pass(password, "Password", password.Text);
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void middle_name_Click(object sender, EventArgs e)
        {
            placeholder.click(middle_name, "Middle name", middle_name.Text);
        }

        private void middle_name_Leave(object sender, EventArgs e)
        {
            placeholder.leave(middle_name, "Middle name", middle_name.Text);
        }

        private void last_name_Leave(object sender, EventArgs e)
        {
            placeholder.leave(last_name, "Last name", last_name.Text);
        }

        private void last_name_Click(object sender, EventArgs e)
        {
            placeholder.click(last_name, "Last name", last_name.Text);
        }

        private void phone_no_Leave(object sender, EventArgs e)
        {
            placeholder.leave(phone_no, "Phone number", phone_no.Text);
        }

        private void phone_no_Click(object sender, EventArgs e)
        {
            placeholder.click(phone_no, "Phone number", phone_no.Text);
        }

        private void email_Leave(object sender, EventArgs e)
        {
            placeholder.leave(email, "Email Address", email.Text);
        }

        private void email_Click(object sender, EventArgs e)
        {
            placeholder.click(email, "Email Address", email.Text);
        }

        private void uid_Leave(object sender, EventArgs e)
        {
            placeholder.leave(uid, "Username", uid.Text);
        }

        private void uid_Click(object sender, EventArgs e)
        {
            placeholder.click(uid, "Username", uid.Text);
        }
    }
}
