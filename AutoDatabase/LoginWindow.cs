using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoDatabase.Utilities;

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


        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            using (var context = new AutoShopEntities())
            {
                User user = context.Users.FirstOrDefault(x => x.Username == username);
                if (user != null)
                {
                    if (PasswordHashing.isPasswordCorret(password, user.PasswordHash))
                    {
                        
                        if (user.IsAdmin)
                        {
                            // Log in Admin
                            new MainForm(user).Show();
                        }
                        else
                        {
                            // Log in user
                            new InitialWindow(user).Show();
                        }
                        this.Close();
                    }
                    else
                    {
                        // Display incorrect password notif
                    }
                }
                else
                {
                    // Display User not found notif
                }
            }
        }


    }
}
