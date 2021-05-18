using LibraryProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Forms
{
    public partial class EditOtherUsers : Form
    {
        public EditOtherUsers()
        {
            InitializeComponent();
        }
        private static EditOtherUsers EditOtherUsersInstance = null;

        public static EditOtherUsers GetInstance()
        {
            if (EditOtherUsers.EditOtherUsersInstance == null)
            {
                EditOtherUsers.EditOtherUsersInstance = new EditOtherUsers();
                EditOtherUsers.EditOtherUsersInstance.FormClosed += new FormClosedEventHandler(EditOtherUsersInstance_FormClosed);
            }
            return EditOtherUsers.EditOtherUsersInstance;
        }

        public static void EditOtherUsersInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditOtherUsers.EditOtherUsersInstance = null;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool DataValid = true;
            if (tbxFirstName.Text == "" | tbxLastName.Text == "" | tbxEmail.Text == "" | tbxPassword.Text == "" | tbxCPassword.Text == "" | cbxGender.SelectedItem == null)
            {
                MessageBox.Show("Information missing: Please enter your details");
                DataValid = false;
            }
            if (tbxPassword.Text != tbxCPassword.Text)
            {
                MessageBox.Show("Password do not match: Please re-enter password");
                DataValid = false;
                tbxPassword.Clear();
                tbxCPassword.Clear();
            }
            if (DataValid == true)
            {
                char gender = 'P';
                if (cbxGender.Text == "Female")
                {
                    gender = 'F';
                }
                else if (cbxGender.Text == "Male")
                {
                    gender = 'M';
                }
                else if (cbxGender.Text == "Non-Binary")
                {
                    gender = 'N';
                }
                LibraryDataFunctions.EditUser(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, cbxStatus.Text, tbxPassword.Text, gender);
                UserHomeForm f1 = UserHomeForm.GetInstance();
                f1.Show();
                this.Close();
            }
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            var user = LibraryDataFunctions.GetUser(tbxEmail.Text);
            tbxEmail.Text = user.Email;
            tbxFirstName.Text = user.FirstName;
            tbxLastName.Text = user.LastName;
            cbxStatus.Text = user.Status;
            if (user.Gender == 'F')
            {
                cbxGender.Text = "Female";
            }
            else if (user.Gender == 'M')
            {
                cbxGender.Text = "Male";
            }
            else if (user.Gender == 'N')
            {
                cbxGender.Text = "Non-Binary";
            }
            else
            {
                cbxGender.Text = "Prefer not to say";
            }
        }
    }
}
