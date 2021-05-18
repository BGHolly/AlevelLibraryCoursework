using LibraryProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryProject.Forms
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }
        private static AdminHomeForm AdminHomeFormInstance = null;

        public static AdminHomeForm GetInstance()
        {
            if (AdminHomeForm.AdminHomeFormInstance == null)
            {
                AdminHomeForm.AdminHomeFormInstance = new AdminHomeForm();
                AdminHomeForm.AdminHomeFormInstance.FormClosed += new FormClosedEventHandler(AdminHomeFormInstance_FormClosed);
            }
            return AdminHomeForm.AdminHomeFormInstance;
        }

        static void AdminHomeFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminHomeForm.AdminHomeFormInstance = null;
        }
        private void AdminHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            if (tbxBarcode.Text != "" & tbxTitle.Text != "" & tbxAuthor.Text != "")
            {
                LibraryDataFunctions.AddBook(tbxTitle.Text, tbxBarcode.Text, tbxGenre.Text, tbxAuthor.Text, cbxFiction.Text, dest, cbxsafeguarding.Checked, tbxinfo.Text, tbxIsbn.Text, dtpPublicationDate.Text);

            }
        }


        private void reset()
        {
            tbxAuthor.Clear();
            tbxBarcode.Clear();
            tbxGenre.Clear();
            tbxTitle.Clear();
            cbxFiction.Text = "";
            tbxinfo.Clear();
            tbxFilename.Visible = false;
            tbxFilename.Clear();
            btnTakePhoto.Visible = true;
            btnUpload.Visible = true;
            cbxsafeguarding.Checked = false;
            tbxIsbn.Clear();
            dtpPublicationDate.Value = DateTimePicker.MinimumDateTime;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (tbxBarcode.Text != "")
            {
                LibraryDataFunctions.CloseLog(tbxBarcode.Text, ConfigurationManager.AppSettings["username"]);
                reset();
            }

        }

        private void tbxBarcode_Leave(object sender, EventArgs e)
        {
            if (tbxBarcode.Text != "")
            {
                if (LibraryDataFunctions.BookExists(tbxBarcode.Text))
                {
                    var book = LibraryDataFunctions.GetBook(tbxBarcode.Text);
                    tbxTitle.Text = book.Title;
                    tbxAuthor.Text = book.Author;
                    tbxGenre.Text = book.Genre;
                    cbxFiction.Text = book.Fiction;
                    tbxFilename.Text = book.Image;
                    cbxsafeguarding.Checked = book.Safeguarding;
                    tbxinfo.Text = book.Info;
                    tbxIsbn.Text = book.Isbn;
                    dtpPublicationDate.Text = book.PublicationDate;
                }
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (tbxBarcode.Text != "")
            {
                LibraryDataFunctions.AddLog(tbxBarcode.Text, ConfigurationManager.AppSettings["username"]);
                reset();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            logout();
            this.Close();
        }
        private void logout()
        {
            var configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            configuration.AppSettings.Settings["username"].Value = "";
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
            LoginForm f2 = LoginForm.GetInstance();
            f2.Show();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ReportsForm f2 = ReportsForm.GetInstance();
            f2.Show();
        }

        string dest;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string source = openFileDialog1.FileName;
                string name = Path.GetFileName(source);
                dest = Path.Combine("C:\\git\\libraryproject\\LibraryProject.Core\\images", name);
                try
                {
                    File.Copy(source, dest, false);
                    btnUpload.Visible = false;
                    btnTakePhoto.Visible = false;
                    tbxFilename.Visible = true;
                    tbxFilename.Text = name;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error occurred, please try again");
                }
            }
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            CameraForm f2 = new CameraForm();

            f2.AddressUpdated += new CameraForm.AddressUpdateHandler(CameraForm_ButtonClicked);

            f2.Show();
        }
        private void CameraForm_ButtonClicked(object sender, AddressUpdateEventArgs e)

        {
            dest = e.Address;
            btnUpload.Visible = false;
            btnTakePhoto.Visible = false;
            tbxFilename.Visible = true;
            tbxFilename.Text = e.Name;

        }

        private void AdminHomeForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            logout();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbxBarcode.Text != "")
            {
                LibraryDataFunctions.RemoveBook(tbxBarcode.Text);
                reset();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            LibraryDataFunctions.EditBook(tbxTitle.Text, tbxBarcode.Text, tbxGenre.Text, tbxAuthor.Text, cbxFiction.Text, tbxFilename.Text, cbxsafeguarding.Checked, tbxinfo.Text, tbxIsbn.Text, dtpPublicationDate.Text);
            reset();
        }

        private void btnRemoveuser_Click(object sender, EventArgs e)
        {
            RemoveUser f2 = new RemoveUser();
            f2.Show();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            EditUser f2 = EditUser.GetInstance();
            f2.Show();
        }

        private void btn_editusers_Click(object sender, EventArgs e)
        {
            EditOtherUsers f2 = new EditOtherUsers();
            f2.Show();
        }
    }
}
