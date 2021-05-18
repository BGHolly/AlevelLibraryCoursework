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
using LibraryProject.Data;

namespace LibraryProject.Forms
{
    public partial class UserHomeForm : Form
    {
        public UserHomeForm()
        {
            InitializeComponent();
        }

        private static UserHomeForm UserHomeFormInstance = null;

        public static UserHomeForm GetInstance()
        {
            if (UserHomeForm.UserHomeFormInstance == null)
            {
                UserHomeForm.UserHomeFormInstance = new UserHomeForm();
                UserHomeForm.UserHomeFormInstance.FormClosed += new FormClosedEventHandler(UserHomeFormInstance_FormClosed);
            }
            return UserHomeForm.UserHomeFormInstance;
        }

        static void UserHomeFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserHomeForm.UserHomeFormInstance = null;
        }

        private void UserHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            logout();
            this.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            if (tbxBarcode.Text != "")
            {
                LibraryDataFunctions.CloseLog(tbxBarcode.Text, ConfigurationManager.AppSettings["username"]);
                tbxAuthor.Clear();
                tbxBarcode.Clear();
                tbxGenre.Clear();
                tbxTitle.Clear();
            }
        }
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (tbxBarcode.Text != "") 
            {
                LibraryDataFunctions.AddLog(tbxBarcode.Text, ConfigurationManager.AppSettings["username"]);
                tbxAuthor.Clear();
                tbxBarcode.Clear();
                tbxGenre.Clear();
                tbxTitle.Clear();
            }
        }

        private void tbxBarcode_TextChanged(object sender, EventArgs e)
        {
            if (LibraryDataFunctions.BookExists(tbxBarcode.Text))
            {
                var book = LibraryDataFunctions.GetBook(tbxBarcode.Text);
                tbxTitle.Text = book.Title;
                tbxAuthor.Text = book.Author;
                tbxGenre.Text = book.Genre;
            }
            else
            {
                MessageBox.Show("invalid barcode, this book is not from the library");
                tbxBarcode.Clear();
            }
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

        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = null;
            ListViewItem item2 = null;
            ListViewItem item3 = null;
            ListViewItem item4 = null;
            ListViewItem item5 = null;
            imlReccomendations.ImageSize = new Size(150, 200);
            lvwReccomendations.View = View.Tile;
            lvwReccomendations.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            lvwReccomendations.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            lvwReccomendations.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            string[,] reccomendations = LibraryDataFunctions.GetReccomendations();
            int count = 0;
            if (reccomendations[0, 0] != null)
            {
                item1 = new ListViewItem(reccomendations[0, 0], 0);
                imlReccomendations.Images.Add(Bitmap.FromFile(reccomendations[0, 1]));
                item1.SubItems.Add(reccomendations[0, 2]);
                item1.SubItems.Add(reccomendations[0, 3]);
                count++;
            }
            if (reccomendations[1, 0] != null)
            {
                item2 = new ListViewItem(reccomendations[1, 0], 1);
                imlReccomendations.Images.Add(Bitmap.FromFile(reccomendations[1, 1]));
                item2.SubItems.Add(reccomendations[1, 2]);
                item2.SubItems.Add(reccomendations[1, 3]);
                count++;
            }
            if (reccomendations[2, 0] != null)
            {
                item3 = new ListViewItem(reccomendations[2, 0], 2);
                imlReccomendations.Images.Add(Bitmap.FromFile(reccomendations[2, 1]));
                item3.SubItems.Add(reccomendations[2, 2]);
                item3.SubItems.Add(reccomendations[2, 3]);
                count++;
            }
            if (reccomendations[3, 0] != null)
            {
                item4 = new ListViewItem(reccomendations[3, 0], 3);
                imlReccomendations.Images.Add(Bitmap.FromFile(reccomendations[3, 1]));
                item4.SubItems.Add(reccomendations[3, 2]);
                item4.SubItems.Add(reccomendations[3, 3]);
                count++;
            }
            if (reccomendations[4, 0] != null)
            {
                item5 = new ListViewItem(reccomendations[4, 0], 3);
                imlReccomendations.Images.Add(Bitmap.FromFile(reccomendations[4, 1]));
                item5.SubItems.Add(reccomendations[4, 2]);
                item5.SubItems.Add(reccomendations[4, 3]);
                count++;
            }
            if (count == 5)
            {
                lvwReccomendations.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4, item5});
            }
            if (count == 4)
            {
                lvwReccomendations.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4});
            }
            if (count == 3)
            {
                lvwReccomendations.Items.AddRange(new ListViewItem[] { item1, item2, item3});
            }
            if (count == 2)
            {
                lvwReccomendations.Items.AddRange(new ListViewItem[] { item1, item2});
            }
            if (count == 1)
            {
                lvwReccomendations.Items.AddRange(new ListViewItem[] { item1});
            }
            lvwReccomendations.LargeImageList = imlReccomendations;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser f2 = EditUser.GetInstance();
            f2.Show();
        }
    }
}

