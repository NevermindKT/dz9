using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm: Form
    {
        private string connectionString = "Server=localhost;Database=Users;Trusted_Connection=True;TrustServerCertificate=True;";
        private int id;

        public MainForm(int id)
        {
            InitializeComponent();
            this.id = id;

            nameLbl.Text = GetName(id);
            pictureBox1.Image = GetImage(id);

            editButton.Click += EditButton_Click;
        }

        private void EditButton_Click(object? sender, EventArgs e)
        {
            Image img = Image.FromFile(pathBox.Text + ".png");

            pictureBox1.Image = SetImage(id, img);
        }

        public string GetName(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"SELECT u.Username
                                  FROM users u WHERE u.id = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                        else
                            return "err";
                    }
                }
            }
        }

        public Image GetImage(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"SELECT u.ProfilePicture
                                  FROM users u WHERE u.id = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            byte[] imageBytes = (byte[])reader["ProfilePicture"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                return Image.FromStream(ms);
                            }
                        }
                    }
                }
            }

            return null;
        }

        public Image SetImage(int id, Image img)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"UPDATE Users SET ProfilePicture = @Image WHERE Id = @UserId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    byte[] imgBytes;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        img.Save(ms, ImageFormat.Png);
                        imgBytes = ms.ToArray();
                    }

                    command.Parameters.AddWithValue("@UserId", id);
                    command.Parameters.AddWithValue("@Image", imgBytes);

                    command.ExecuteNonQuery();
                }
            }

            return img;
        }
    }
}