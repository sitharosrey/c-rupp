using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using Npgsql;

namespace Note_Version_2
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            /*using (var command = new NpgsqlCommand("SELECT id AS note_id, title, description FROM note_tb", connection))
            {
                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // create the columns for the DataGridView
                    DataGridViewColumn idColumn = new DataGridViewTextBoxColumn();
                    idColumn.DataPropertyName = "note_id"; // set the DataPropertyName property to "note_id"
                    idColumn.HeaderText = "ID";
                    dataGridView1.Columns.Add(idColumn);

                    DataGridViewColumn titleColumn = new DataGridViewTextBoxColumn();
                    titleColumn.DataPropertyName = "title";
                    titleColumn.HeaderText = "Title";
                    dataGridView1.Columns.Add(titleColumn);

                    DataGridViewColumn descriptionColumn = new DataGridViewTextBoxColumn();
                    descriptionColumn.DataPropertyName = "description";
                    descriptionColumn.HeaderText = "Description";
                    dataGridView1.Columns.Add(descriptionColumn);

                    // set the DataSource of the DataGridView to the DataTable
                    dataGridView1.DataSource = dataTable; 
                }
            }*/
                using (var command = new NpgsqlCommand("SELECT id, title, description FROM note_tb", connection))
                {
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // set the DataSource of the DataGridView to the DataTable
                        dataGridView1.DataSource = dataTable;
                    }
                }


            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_note_Click(object sender, EventArgs e)
        {
            this.Hide();
            var insert = new InsertForm();
            insert.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection = DatabaseConnection.Instance.GetConnection();

            String selectedId = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            var deleteStatement = $"DELETE FROM note_tb WHERE id = {selectedId}";

            // execute the DELETE statement
            var command = new NpgsqlCommand(deleteStatement, connection);
            var rowEffect = command.ExecuteNonQuery();

            if(rowEffect == 1)
            {
                var messageBoxText = "The selected row was deleted successfully.";
                var caption = "Deletion Successful";
                var buttons = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Information;
                MessageBox.Show(messageBoxText, caption, buttons, icon);
                // clear the existing data in the datagrid
                dataGridView1.DataSource = null;

                // rebind the datagrid to the updated data
                var selectStatement = "SELECT * FROM note_tb";
                var adapter = new NpgsqlDataAdapter(selectStatement, connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Delete this note is not successfully !");
            }

            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure a row is actually selected
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value); // get the value of the note_id column as an integer
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // get the selected row from the datagrid
            var selectedRow = dataGridView1.SelectedRows[0];

            // create a new instance of the update form
            var updateForm = new UpdateForm();

            // set the properties of the update form to the values of the selected row
            updateForm.Id = (int)selectedRow.Cells["id"].Value;
            updateForm.Title = (string)selectedRow.Cells["title"].Value;
            updateForm.Description = (string)selectedRow.Cells["description"].Value;

            this.Hide();
            updateForm.Show();

        }
    }
}
