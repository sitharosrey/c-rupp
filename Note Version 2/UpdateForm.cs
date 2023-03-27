using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Note_Version_2
{
    public partial class UpdateForm : Form
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            txt_desc.Text = Description;
            txt_title.Text = Title;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var updateStatement = $"UPDATE note_tb SET title = '{txt_title.Text}', description = '{txt_desc.Text}' WHERE id = {Id}";

            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            var command = new NpgsqlCommand(updateStatement, connection);
            var rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                MessageBox.Show("The note was updated successfully.");
                this.Hide();
                var display = new DisplayForm();
                display.Show();
            }
            else
            {
                MessageBox.Show("Update was not successful.");
            }

            connection.Close();

            // Close the update form
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new DisplayForm();
            display.Show();
        }
    }
}
