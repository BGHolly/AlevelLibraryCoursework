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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private static ReportsForm ReportsFormInstance = null;

        public static ReportsForm GetInstance()
        {
            if (ReportsForm.ReportsFormInstance == null)
            {
                ReportsForm.ReportsFormInstance = new ReportsForm();
                ReportsForm.ReportsFormInstance.FormClosed += new FormClosedEventHandler(ReportsFormInstance_FormClosed);
            }
            return ReportsForm.ReportsFormInstance;
        }

        static void ReportsFormInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReportsForm.ReportsFormInstance = null;
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminHomeForm f2 = AdminHomeForm.GetInstance();
            f2.Show();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cbxReportScope.Text == "Dewey Decimal Type:") 
            {
                dgvReport.DataSource = LibraryDataFunctions.GetReport(cbxReportType.Text, cbxReportScope.Text + tbxDDValue.Text);
            }
            dgvReport.DataSource = LibraryDataFunctions.GetReport(cbxReportType.Text, cbxReportScope.Text);

        }

        private void cbxReportScope_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxReportScope.Text == "Dewey Decimal Type:")
            {
                tbxDDValue.Visible = true;
            }
        }
    }
}
