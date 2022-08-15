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
    class placeholder
    {
        public static void click(TextBox textbox,string Default,string text)
        {
            
            if(text == Default)
            {
               textbox.Clear();
            }else
            {
                textbox.Text = text;
            }
           
        }

        public static void click_pass(TextBox textbox, string Default, string text)
        {
            if (text == Default)
            {
                textbox.Clear();
                textbox.PasswordChar = '*';
            }
            else
            {
                textbox.PasswordChar = '*';
                textbox.Text = text;
            }
        }

        public static void leave(TextBox textbox, string Default,string text)
        {
            if(text == "")
            {
                textbox.Text = Default;
            }else 
            {
                textbox.Text = textbox.Text;
            }
            
        }

        public static void leave_pass(TextBox textbox, string Default, string text)
        {
            if (text == "")
            {
                textbox.PasswordChar = default(char);
                textbox.Text = Default;
            }
            else
            {
                textbox.Text = text;
            }
        }

    }
}
