using System;
using System.Windows.Forms;
using Npgsql;

namespace Note_Version_2
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sign_up_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            var insertStatement = $"INSERT INTO user_tb (username, password) VALUES ('{txt_username.Text}', '{txt_password.Text}')";
            var command = new NpgsqlCommand(insertStatement, connection);
            var rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 1)
            {
                // Show a success message box
                MessageBox.Show("User register successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var display = new LogIn();
                display.Show();
            }
            else
            {
                // Show an error message box
                MessageBox.Show("An error occurred while register the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close the connection
            connection.Close();

        }

        private void log_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new LogIn();
            display.Show();
        }
    }
}
