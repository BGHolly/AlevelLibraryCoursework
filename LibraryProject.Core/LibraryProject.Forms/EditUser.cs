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
using LibraryProject.Data;

namespace LibraryProject.Forms
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }
            private static EditUser EditUserInstance = null;

        public static EditUser GetInstance()
        {
            if (EditUser.EditUserInstance == null)
            {
                EditUser.EditUserInstance = new EditUser();
                EditUser.EditUserInstance.FormClosed += new FormClosedEventHandler(EditUserInstance_FormClosed);
            }
            return EditUser.EditUserInstance;
        }
        private User user;
        public static void EditUserInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditUser.EditUserInstance = null;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool DataValid = true;
            if (tbxEmail.Text != ConfigurationManager.AppSettings["username"])
            {
                MessageBox.Show("Email entered is not correct, please enter your own email address");
                DataValid = false;
            }
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
                    LibraryDataFunctions.EditUser(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, user.Status, tbxPassword.Text, gender);
                    UserHomeForm f1 = UserHomeForm.GetInstance();
                    f1.Show();
                    this.Close();

            }
        }
        private void EditUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm f2 = LoginForm.GetInstance();
            f2.Show();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            user = LibraryDataFunctions.GetUser(ConfigurationManager.AppSettings["username"]);
            tbxEmail.Text = user.Email;
            tbxFirstName.Text = user.FirstName;
            tbxLastName.Text = user.LastName;
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
