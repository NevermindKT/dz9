namespace WinFormsApp2
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginBox = new TextBox();
            LoginLbl = new Label();
            label1 = new Label();
            passwordBox = new TextBox();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI", 14F);
            loginBox.Location = new Point(156, 12);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(490, 32);
            loginBox.TabIndex = 0;
            // 
            // LoginLbl
            // 
            LoginLbl.AutoSize = true;
            LoginLbl.Font = new Font("Segoe UI", 18F);
            LoginLbl.Location = new Point(12, 12);
            LoginLbl.Name = "LoginLbl";
            LoginLbl.Size = new Size(73, 32);
            LoginLbl.TabIndex = 1;
            LoginLbl.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 14F);
            passwordBox.Location = new Point(156, 71);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(490, 32);
            passwordBox.TabIndex = 2;
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateButton.Location = new Point(12, 128);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(634, 49);
            CreateButton.TabIndex = 6;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 189);
            Controls.Add(CreateButton);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(LoginLbl);
            Controls.Add(loginBox);
            Name = "RegisterForm";
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginBox;
        private Label LoginLbl;
        private Label label1;
        private TextBox passwordBox;
        private Button CreateButton;
    }
}