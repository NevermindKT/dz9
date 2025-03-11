using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;Database=Users;Trusted_Connection=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();

            LogInButton.Click += LogInButton_Click;
            CreateButton.Click += CreateButton_Click;
        }

        private void CreateButton_Click(object? sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LogInButton_Click(object? sender, EventArgs e)
        {
            int tempId = logIn(loginTextBox.Text, passwordTextBox.Text);

            //MessageBox.Show($"{tempId}", "aaa", MessageBoxButtons.OK);

            if (tempId >= 0)
            {
                MainForm mainForm = new MainForm(tempId);
                this.Hide();
                mainForm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Неверный логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int logIn(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT id, Password FROM users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", login);
                    
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string storedPassword = reader.GetString(1);

                            if (BCrypt.Net.BCrypt.Verify(password,storedPassword))
                            {
                                return id;
                            }
                        }
                    }
                }
            }

            return -1;
        }
    }
}