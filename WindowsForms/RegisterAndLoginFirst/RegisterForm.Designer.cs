namespace RegisterAndLoginFirst
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserName = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            chbxShowPassword = new CheckBox();
            btnRegister = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(110, 63);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(110, 149);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(99, 238);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(137, 21);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(110, 99);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 29);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(110, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 29);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(110, 280);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(100, 29);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // chbxShowPassword
            // 
            chbxShowPassword.AutoSize = true;
            chbxShowPassword.Location = new Point(99, 339);
            chbxShowPassword.Name = "chbxShowPassword";
            chbxShowPassword.Size = new Size(138, 25);
            chbxShowPassword.TabIndex = 6;
            chbxShowPassword.Text = "Show Password";
            chbxShowPassword.UseVisualStyleBackColor = true;
            chbxShowPassword.CheckedChanged += chbxShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(110, 380);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 40);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(263, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(57, 39);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 530);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(chbxShowPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chbxShowPassword;
        private Button btnRegister;
        private Button btnLogin;
    }
}
