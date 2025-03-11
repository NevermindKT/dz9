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
            int tempId = logIn(loginTextBox.Text, passwrdTextBox.Text);

            if (tempId >= 0)
            {
                MainForm mainForm = new MainForm(tempId);
                mainForm.ShowDialog();
            }
            else
                MessageBox.Show("Неверный логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public int logIn(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT u.Username, u.Password, u.id
                                 FROM users u";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tempLogin = reader.GetString(0);
                        string tempPassword = reader.GetString(1);
                        int userId = reader.GetInt32(2);

                        if (tempLogin == login && tempPassword == password)
                        {
                            return userId;
                        }
                    }
                }
            }

            return -1;
        }
    }
}