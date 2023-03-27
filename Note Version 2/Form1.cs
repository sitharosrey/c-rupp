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
            if (txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                this.Hide();
                var display = new AdminForm();
                display.Show();
            }
            else
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

                NpgsqlConnection connectionOne = DatabaseConnection.Instance.GetConnection();
                var selectStatement = "SELECT * FROM user_tb WHERE username = @username AND password = @password";
                // Execute the select statement
                var commandOne = new NpgsqlCommand(selectStatement, connectionOne);
                commandOne.Parameters.AddWithValue("@username", username);
                commandOne.Parameters.AddWithValue("@password", password);
                var readerOne = commandOne.ExecuteReader();
                var usernameOne = "";
                var passwordOne = "";
                var isBan = false;
                while (readerOne.Read())
                {
                    var id = readerOne.GetInt64(0);
                    usernameOne = readerOne.GetString(1);
                    passwordOne = readerOne.GetString(2);
                    isBan = readerOne.GetBoolean(3);
                }

                connectionOne.Close();

                if (isBan)
                {
                    MessageBox.Show("Your account was banned !", "Banned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    var display = new LogIn();
                    display.Show();
                }
                else
                {
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

        private void sign_up_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signUp = new SignUpForm();
            signUp.Show();
        }
    }
}
