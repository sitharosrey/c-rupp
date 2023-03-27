using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Version_2
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new LogIn();
            display.Show();
        }

        private void btn_manage_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new AdminManageUserForm();
            display.Show();
        }
    }
}
