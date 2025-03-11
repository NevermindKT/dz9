namespace WinFormsApp2
{
    partial class LoginForm
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
            loginLabel = new Label();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            LogInButton = new Button();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 16F);
            loginLabel.Location = new Point(29, 47);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(66, 30);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Segoe UI", 12F);
            loginTextBox.Location = new Point(181, 47);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(517, 29);
            loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.Location = new Point(181, 112);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(517, 29);
            passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 16F);
            passwordLabel.Location = new Point(29, 112);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(103, 30);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Segoe UI", 14F);
            LogInButton.Location = new Point(556, 166);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(142, 36);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "Log in";
            LogInButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Segoe UI", 14F);
            CreateButton.Location = new Point(181, 166);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(216, 36);
            CreateButton.TabIndex = 5;
            CreateButton.Text = "Create Account";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 225);
            Controls.Add(CreateButton);
            Controls.Add(LogInButton);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button LogInButton;
        private Button CreateButton;
    }
}
