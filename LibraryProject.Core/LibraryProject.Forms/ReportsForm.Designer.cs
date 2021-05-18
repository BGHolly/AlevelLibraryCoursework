namespace LibraryProject.Forms
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cbxReportType = new System.Windows.Forms.ComboBox();
            this.cbxReportScope = new System.Windows.Forms.ComboBox();
            this.lblReportScope = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbxDDValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(34, 152);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.Size = new System.Drawing.Size(1515, 525);
            this.dgvReport.TabIndex = 0;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Location = new System.Drawing.Point(34, 58);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(90, 25);
            this.lblReportType.TabIndex = 1;
            this.lblReportType.Text = "View All";
            // 
            // cbxReportType
            // 
            this.cbxReportType.FormattingEnabled = true;
            this.cbxReportType.Items.AddRange(new object[] {
            "Current Loans",
            "Past Loans",
            "Overdue Loans"});
            this.cbxReportType.Location = new System.Drawing.Point(153, 55);
            this.cbxReportType.Name = "cbxReportType";
            this.cbxReportType.Size = new System.Drawing.Size(193, 33);
            this.cbxReportType.TabIndex = 2;
            // 
            // cbxReportScope
            // 
            this.cbxReportScope.FormattingEnabled = true;
            this.cbxReportScope.Items.AddRange(new object[] {
            "All",
            "Girls",
            "Boys",
            "Year 9",
            "Year 10",
            "Year 11",
            "Year 12",
            "Year 13",
            "Fiction",
            "Non-Fiction",
            "Dewey Decimal Type:"});
            this.cbxReportScope.Location = new System.Drawing.Point(444, 55);
            this.cbxReportScope.Name = "cbxReportScope";
            this.cbxReportScope.Size = new System.Drawing.Size(194, 33);
            this.cbxReportScope.TabIndex = 4;
            this.cbxReportScope.SelectedIndexChanged += new System.EventHandler(this.cbxReportScope_SelectedIndexChanged);
            // 
            // lblReportScope
            // 
            this.lblReportScope.AutoSize = true;
            this.lblReportScope.Location = new System.Drawing.Point(352, 58);
            this.lblReportScope.Name = "lblReportScope";
            this.lblReportScope.Size = new System.Drawing.Size(73, 25);
            this.lblReportScope.TabIndex = 3;
            this.lblReportScope.Text = "Within";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(932, 55);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(124, 37);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbxDDValue
            // 
            this.tbxDDValue.Location = new System.Drawing.Point(694, 58);
            this.tbxDDValue.Name = "tbxDDValue";
            this.tbxDDValue.Size = new System.Drawing.Size(119, 30);
            this.tbxDDValue.TabIndex = 6;
            this.tbxDDValue.Visible = false;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 865);
            this.Controls.Add(this.tbxDDValue);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbxReportScope);
            this.Controls.Add(this.lblReportScope);
            this.Controls.Add(this.cbxReportType);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.dgvReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cbxReportType;
        private System.Windows.Forms.ComboBox cbxReportScope;
        private System.Windows.Forms.Label lblReportScope;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbxDDValue;
    }
}