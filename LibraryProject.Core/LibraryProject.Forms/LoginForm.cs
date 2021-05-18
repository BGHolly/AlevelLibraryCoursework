using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Data;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Reflection;

namespace LibraryProject.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private static LoginForm LoginFormInstance = null;

        public static LoginForm GetInstance()
        {
            if (LoginForm.LoginFormInstance == null)
            {
                LoginForm.LoginFormInstance = new LoginForm();
                LoginForm.LoginFormInstance.FormClosed += new FormClosedEventHandler(LoginFormInstance_FormClosed);
            }
            return LoginForm.LoginFormInstance;
        }

        static void LoginFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.LoginFormInstance = null;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm f2 = RegisterForm.GetInstance();
            f2.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginValid = LibraryDataFunctions.LoginValid(tbxEmail.Text, tbxPassword.Text);
            if (loginValid == "Student" || loginValid == "Sixth-Form") {
                var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                configuration.AppSettings.Settings["username"].Value = tbxEmail.Text;
                configuration.Save();
                ConfigurationManager.RefreshSection("appSettings");
                tbxEmail.Clear();
                tbxPassword.Clear();
                UserHomeForm f2 = UserHomeForm.GetInstance();
                f2.Show();
                this.Hide();
            }
            else if (loginValid == "Staff" || loginValid == "VIP")
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                configuration.AppSettings.Settings["username"].Value = tbxEmail.Text;
                configuration.Save();
                ConfigurationManager.RefreshSection("appSettings");
                tbxEmail.Clear();
                tbxPassword.Clear();
                AdminHomeForm f2 = AdminHomeForm.GetInstance();
                f2.Show();
                this.Hide();
            }
            else if (loginValid == "false")
            {
                MessageBox.Show("Username and password do not match, please re-enter your details or register");
                tbxEmail.Clear();
                tbxPassword.Clear();
            }
        }
    }
}
