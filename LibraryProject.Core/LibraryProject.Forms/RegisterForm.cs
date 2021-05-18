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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private static RegisterForm RegisterFormInstance = null;

        public static RegisterForm GetInstance()
        {
            if (RegisterForm.RegisterFormInstance == null)
            {
                RegisterForm.RegisterFormInstance = new RegisterForm();
                RegisterForm.RegisterFormInstance.FormClosed += new FormClosedEventHandler(RegisterFormInstance_FormClosed);
            }
            return RegisterForm.RegisterFormInstance;
        }

        public static void RegisterFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegisterForm.RegisterFormInstance = null;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool DataValid = true;
            if (tbxFirstName.Text == "" | tbxLastName.Text == "" | tbxEmail.Text == "" | tbxPassword.Text == "" | tbxCPassword.Text == "" | cbxYear.SelectedItem == null | cbxGender.SelectedItem == null) 
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
                string status = "Unknown";
                if (cbxYear.Text == "Year 9" | cbxYear.Text == "Year 10" | cbxYear.Text == "Year 11")
                {
                    status = "Student";
                }
                else if (cbxYear.Text == "Year 12" | cbxYear.Text == "Year 13")
                {
                    status = "Sixth-Form";
                }
                else if (cbxYear.Text == "Staff")
                {
                    status = "Staff";
                }
                char gender = 'P';
                if (cbxGender.Text == "Female")
                {
                    gender = 'F';
                }
                if (cbxGender.Text == "Male")
                {
                    gender = 'M';
                }
                if (cbxGender.Text == "Non-Binary")
                {
                    gender = 'N';
                }
                if (LibraryDataFunctions.UserExists(tbxEmail.Text) == false)
                {
                    LibraryDataFunctions.AddUser(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, tbxPassword.Text, status,cbxYear.Text, gender);
                    LoginForm f1 = LoginForm.GetInstance();
                    f1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User already exists, please log in");
                    LoginForm f1 = LoginForm.GetInstance();
                    f1.Show();
                    this.Close();
                }
                
            }
        }
        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm f2 = LoginForm.GetInstance();
            f2.Show();
        }
    }
}
