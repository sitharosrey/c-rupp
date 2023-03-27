using System;
using System.Windows.Forms;
using Npgsql;

namespace Note_Version_2
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            String username = txt_username.Text;
            String password = txt_password.Text;

                var command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(*) FROM user_tb WHERE username = @username AND password = @password";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                var reader = command.ExecuteReader();
            var val = 0;
            while (reader.Read())
            {
                val = Int32.Parse(reader[0].ToString());
            }

            connection.Close();

            if (val > 0)
            {
                this.Hide();
                var display = new DisplayForm();
                display.Show();
            }
            else
            {
                MessageBox.Show("Log in is not successful !", "Invalid Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
