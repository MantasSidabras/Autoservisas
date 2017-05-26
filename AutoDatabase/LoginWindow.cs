using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
    public partial class LoginWindow : Form
    {
        private bool usernameEntered;
        private bool passwordEntered;

        public LoginWindow()
        {
            InitializeComponent();
            usernameEntered = false;
            passwordEntered = false;
            
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (!usernameEntered)
            {
                usernameEntered = true;
                usernameTextBox.Text = string.Empty;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (!passwordEntered)
            {
                passwordEntered = true;
                passwordTextBox.Text = string.Empty;
                passwordTextBox.UseSystemPasswordChar = true;
            }         
        }
    }
}
