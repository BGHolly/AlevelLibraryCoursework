using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.Data;

namespace LibraryProject.Forms
{
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = LibraryDataFunctions.GetYearGroup(cbxYearGroup.Text);
            cbxYearGroup.Text = "";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var todelete = dgvReport.SelectedRows;
            foreach (DataGridViewRow user in todelete) 
            {
                    string email = user.Cells[3].Value.ToString();
                    LibraryDataFunctions.RemoveUser(email);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<User> user = new List<User>();
            user.Add(LibraryDataFunctions.GetUser(tbxEmail.Text));
            tbxEmail.Clear();
            if (user == null)
            {
                MessageBox.Show("user does not exist in database, please check spelling and try again");
            }
            else
            {
                dgvReport.DataSource = user;
                
            }
        }
    }
}
