using RegisterAndLoginFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegisterAndLoginFirst
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            registerForm.FormClosed += (sender, e) => this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using UserContext userContext = new UserContext();
            if (!userContext.Users.Any(x=> x.Username == txtUserName.Text) )
            {
                MessageBox.Show("Invalid username",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if (!userContext.Users.Any(x=> x.Password == txtPassword.Text))
            {
                MessageBox.Show("Invalid password",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Successful login",
                             "Login",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
        }
    }
}
