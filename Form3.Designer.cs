namespace WinFormsApp2
{
    partial class MainForm
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
            pictureBox1 = new PictureBox();
            editButton = new Button();
            WelcomeLbl = new Label();
            nameLbl = new Label();
            pathBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(580, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 173);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 14F);
            editButton.Location = new Point(580, 230);
            editButton.Name = "editButton";
            editButton.Size = new Size(208, 35);
            editButton.TabIndex = 1;
            editButton.Text = "Set profile picture";
            editButton.UseVisualStyleBackColor = true;
            // 
            // WelcomeLbl
            // 
            WelcomeLbl.AutoSize = true;
            WelcomeLbl.Font = new Font("Segoe UI", 18F);
            WelcomeLbl.Location = new Point(12, 44);
            WelcomeLbl.Name = "WelcomeLbl";
            WelcomeLbl.Size = new Size(113, 32);
            WelcomeLbl.TabIndex = 2;
            WelcomeLbl.Text = "Welcome";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 18F);
            nameLbl.Location = new Point(156, 44);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(106, 32);
            nameLbl.TabIndex = 3;
            nameLbl.Text = "<name>";
            // 
            // pathBox
            // 
            pathBox.Location = new Point(580, 197);
            pathBox.Name = "pathBox";
            pathBox.PlaceholderText = "Path to image";
            pathBox.Size = new Size(208, 23);
            pathBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 277);
            Controls.Add(pathBox);
            Controls.Add(nameLbl);
            Controls.Add(WelcomeLbl);
            Controls.Add(editButton);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button editButton;
        private Label WelcomeLbl;
        private Label nameLbl;
        private TextBox pathBox;
    }
}