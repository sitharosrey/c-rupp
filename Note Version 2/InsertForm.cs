using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Note_Version_2
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new DisplayForm();
            display.Show();
        }

        private void btn_new_note_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            String title = txt_title.Text;
            String description = txt_desc.Text;

            if(!String.IsNullOrEmpty(title) && !String.IsNullOrEmpty(description))
            {
                var sql = "INSERT INTO note_tb (title, description) VALUES (@title, @description)";

                // Create a command object with the SQL statement and connection
                var command = new NpgsqlCommand(sql, connection);

                // Add parameters for the title and description values
                command.Parameters.AddWithValue("title", title);
                command.Parameters.AddWithValue("description", description);

                // Execute the SQL statement
                command.ExecuteNonQuery();

                this.Hide();
                var display = new DisplayForm();
                display.Show();
            }
            else
            {
                MessageBox.Show("Title or Descriptio is empty or null !!");
            }

            connection.Close();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var display = new DisplayForm();
            display.Show();
        }
    }
}
