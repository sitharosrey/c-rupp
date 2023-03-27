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
    public partial class AdminManageUserForm : Form
    {
        public AdminManageUserForm()
        {
            InitializeComponent();
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            using (var command = new NpgsqlCommand("SELECT id, username, password, is_ban FROM user_tb", connection))
            {
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // set the DataSource of the DataGridView to the DataTable
                    guna2DataGridView1.DataSource = dataTable;
                }
            }


            connection.Close();
        }

        private void btn_manage_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new AdminForm();
            display.Show();
        }

        private void AdminManageUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
