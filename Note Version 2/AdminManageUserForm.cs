using System;
using System.Data;
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

        private void btn_banned_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            String selectedId = guna2DataGridView1.CurrentRow.Cells["id"].Value.ToString();
            var deleteStatement = $"UPDATE user_tb SET is_ban = @isBan WHERE id = {selectedId}";

            // execute the DELETE statement
            var command = new NpgsqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("isBan", true);
            var rowEffect = command.ExecuteNonQuery();

            if (rowEffect == 1)
            {
                var messageBoxText = "The selected row was banned successfully.";
                var caption = "Banned is Successful";
                var buttons = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Information;
                MessageBox.Show(messageBoxText, caption, buttons, icon);
                // clear the existing data in the datagrid
                guna2DataGridView1.DataSource = null;

                // rebind the datagrid to the updated data
                var selectStatement = "SELECT * FROM user_tb";
                var adapter = new NpgsqlDataAdapter(selectStatement, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;

            }

            connection.Close();
        }

        private void btn_unban_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            String selectedId = guna2DataGridView1.CurrentRow.Cells["id"].Value.ToString();
            var deleteStatement = $"UPDATE user_tb SET is_ban = @isBan WHERE id = {selectedId}";

            // execute the DELETE statement
            var command = new NpgsqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("isBan", false);
            var rowEffect = command.ExecuteNonQuery();

            if (rowEffect == 1)
            {
                var messageBoxText = "The selected row was unbanned successfully.";
                var caption = "Unbanned is Successful";
                var buttons = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Information;
                MessageBox.Show(messageBoxText, caption, buttons, icon);
                // clear the existing data in the datagrid
                guna2DataGridView1.DataSource = null;

                // rebind the datagrid to the updated data
                var selectStatement = "SELECT * FROM user_tb";
                var adapter = new NpgsqlDataAdapter(selectStatement, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;

            }

            connection.Close();
        }
    }
}
