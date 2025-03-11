using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp2
{
    public partial class RegisterForm: Form
    {
        private string connectionString = "Server=localhost;Database=Users;Trusted_Connection=True;TrustServerCertificate=True;";

        public RegisterForm()
        {
            InitializeComponent();

            CreateButton.Click += CreateButton_Click;
        }

        private void CreateButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Введите все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                CreateUser(loginBox.Text, passwordBox.Text);
                this.Close();
            }
        }

        public void CreateUser(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                string query = $@"INSERT INTO users (Username, Password) VALUES (@Username, @Password)";
                using (SqlCommand command = new SqlCommand(query, connection)) 
                {
                    command.Parameters.AddWithValue("@Username", login);
                    command.Parameters.AddWithValue("@Password", hashedPassword);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ошибка регистрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}