using RegisterAndLoginFirst.Helpers;
using RegisterAndLoginFirst.Models;
using RegisterAndLoginFirst.Repository;

namespace RegisterAndLoginFirst
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }


        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.FormClosed += (sender, e) => this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!EventRegisterHelper.IsEverythingWriten(txtUserName.Text, txtPassword.Text, txtConfirmPassword.Text))
            {
                MessageBox.Show("Invalid input",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!EventRegisterHelper.IsPasswordsCorrectLength(txtPassword.Text, txtConfirmPassword.Text))
            {
                MessageBox.Show("Invalid password lenght",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            if (!EventRegisterHelper.IsPasswordsMatched(txtPassword.Text, txtConfirmPassword.Text))
            {
                MessageBox.Show("Invalid password match",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            using UserContext userContext = new UserContext();
            UserRepository userRepository = new UserRepository(userContext);
            User user = new User()
            {
                Username = txtUserName.Text,
                Password = txtPassword.Text,
            };

            if (userContext.Users.Any(x=> x.Username == user.Username))
            {
                MessageBox.Show("This username exists",
                          "Error",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                return;
            }

            userRepository.Add(user);

            MessageBox.Show("Sucsesfull register",
                          "Sucsesfull",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.FormClosed += (sender, e) => this.Close();

        }
    }
}
