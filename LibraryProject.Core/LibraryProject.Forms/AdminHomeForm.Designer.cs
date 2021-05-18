namespace LibraryProject.Forms
{
    partial class AdminHomeForm
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
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcodeNumber = new System.Windows.Forms.Label();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lblFiction = new System.Windows.Forms.Label();
            this.cbxFiction = new System.Windows.Forms.ComboBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFile = new System.Windows.Forms.Label();
            this.tbxFilename = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbxinfo = new System.Windows.Forms.TextBox();
            this.cbxsafeguarding = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtpPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.btnRemoveusers = new System.Windows.Forms.Button();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.btn_editusers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(94, 744);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(202, 44);
            this.btn_checkout.TabIndex = 20;
            this.btn_checkout.Text = "check out book";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(327, 744);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(202, 45);
            this.btn_return.TabIndex = 21;
            this.btn_return.Text = "return book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Location = new System.Drawing.Point(1283, 742);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(202, 46);
            this.btn_reports.TabIndex = 25;
            this.btn_reports.Text = "get reports";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(93, 334);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(262, 30);
            this.tbxAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(88, 287);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(76, 25);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(88, 228);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(267, 30);
            this.tbxTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(83, 178);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(83, 119);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(272, 30);
            this.tbxBarcode.TabIndex = 1;
            // 
            // lblBarcodeNumber
            // 
            this.lblBarcodeNumber.AutoSize = true;
            this.lblBarcodeNumber.Location = new System.Drawing.Point(78, 70);
            this.lblBarcodeNumber.Name = "lblBarcodeNumber";
            this.lblBarcodeNumber.Size = new System.Drawing.Size(168, 25);
            this.lblBarcodeNumber.TabIndex = 0;
            this.lblBarcodeNumber.Text = "barcode number";
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Location = new System.Drawing.Point(557, 743);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(202, 46);
            this.btnAddBooks.TabIndex = 22;
            this.btnAddBooks.Text = "add book";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(93, 402);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 25);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(93, 452);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(262, 30);
            this.tbxGenre.TabIndex = 7;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1283, 605);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(202, 46);
            this.btn_logout.TabIndex = 29;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lblFiction
            // 
            this.lblFiction.AutoSize = true;
            this.lblFiction.Location = new System.Drawing.Point(93, 518);
            this.lblFiction.Name = "lblFiction";
            this.lblFiction.Size = new System.Drawing.Size(206, 25);
            this.lblFiction.TabIndex = 8;
            this.lblFiction.Text = "Fiction / Non-Fiction";
            // 
            // cbxFiction
            // 
            this.cbxFiction.FormattingEnabled = true;
            this.cbxFiction.Items.AddRange(new object[] {
            "Fiction",
            "Non-Fiction"});
            this.cbxFiction.Location = new System.Drawing.Point(93, 561);
            this.cbxFiction.Name = "cbxFiction";
            this.cbxFiction.Size = new System.Drawing.Size(262, 33);
            this.cbxFiction.TabIndex = 9;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(93, 616);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(71, 25);
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "Image";
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Location = new System.Drawing.Point(93, 658);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(144, 47);
            this.btnTakePhoto.TabIndex = 11;
            this.btnTakePhoto.Text = "Take Photo";
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(266, 658);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(155, 47);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(94, 669);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 25);
            this.lblFile.TabIndex = 18;
            // 
            // tbxFilename
            // 
            this.tbxFilename.Location = new System.Drawing.Point(94, 658);
            this.tbxFilename.Name = "tbxFilename";
            this.tbxFilename.Size = new System.Drawing.Size(261, 30);
            this.tbxFilename.TabIndex = 13;
            this.tbxFilename.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(441, 179);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(48, 25);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "Info";
            // 
            // tbxinfo
            // 
            this.tbxinfo.Location = new System.Drawing.Point(446, 228);
            this.tbxinfo.Multiline = true;
            this.tbxinfo.Name = "tbxinfo";
            this.tbxinfo.Size = new System.Drawing.Size(373, 193);
            this.tbxinfo.TabIndex = 17;
            // 
            // cbxsafeguarding
            // 
            this.cbxsafeguarding.AutoSize = true;
            this.cbxsafeguarding.Location = new System.Drawing.Point(446, 445);
            this.cbxsafeguarding.Name = "cbxsafeguarding";
            this.cbxsafeguarding.Size = new System.Drawing.Size(196, 29);
            this.cbxsafeguarding.TabIndex = 18;
            this.cbxsafeguarding.Text = "safeguarding risk";
            this.cbxsafeguarding.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(800, 742);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(202, 46);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "remove book";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1038, 742);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(202, 46);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit book";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpPublicationDate
            // 
            this.dtpPublicationDate.Location = new System.Drawing.Point(446, 515);
            this.dtpPublicationDate.Name = "dtpPublicationDate";
            this.dtpPublicationDate.Size = new System.Drawing.Size(200, 30);
            this.dtpPublicationDate.TabIndex = 19;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(446, 119);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(272, 30);
            this.tbxIsbn.TabIndex = 15;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(441, 70);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(62, 25);
            this.lblIsbn.TabIndex = 14;
            this.lblIsbn.Text = "ISBN";
            // 
            // btnRemoveusers
            // 
            this.btnRemoveusers.Location = new System.Drawing.Point(1312, 195);
            this.btnRemoveusers.Name = "btnRemoveusers";
            this.btnRemoveusers.Size = new System.Drawing.Size(202, 46);
            this.btnRemoveusers.TabIndex = 27;
            this.btnRemoveusers.Text = "remove users";
            this.btnRemoveusers.UseVisualStyleBackColor = true;
            this.btnRemoveusers.Click += new System.EventHandler(this.btnRemoveuser_Click);
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(1312, 111);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(202, 46);
            this.btnEditDetails.TabIndex = 26;
            this.btnEditDetails.Text = "Edit My Details";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // btn_editusers
            // 
            this.btn_editusers.Location = new System.Drawing.Point(1312, 276);
            this.btn_editusers.Name = "btn_editusers";
            this.btn_editusers.Size = new System.Drawing.Size(202, 46);
            this.btn_editusers.TabIndex = 28;
            this.btn_editusers.Text = "edit users";
            this.btn_editusers.UseVisualStyleBackColor = true;
            this.btn_editusers.Click += new System.EventHandler(this.btn_editusers_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 865);
            this.Controls.Add(this.btn_editusers);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.btnRemoveusers);
            this.Controls.Add(this.tbxIsbn);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.dtpPublicationDate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cbxsafeguarding);
            this.Controls.Add(this.tbxinfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tbxFilename);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.cbxFiction);
            this.Controls.Add(this.lblFiction);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.btnAddBooks);
            this.Controls.Add(this.tbxAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxBarcode);
            this.Controls.Add(this.lblBarcodeNumber);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_checkout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AdminHomeForm";
            this.Text = "Admin Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminHomeForm_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.Label lblBarcodeNumber;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lblFiction;
        private System.Windows.Forms.ComboBox cbxFiction;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox tbxFilename;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tbxinfo;
        private System.Windows.Forms.CheckBox cbxsafeguarding;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dtpPublicationDate;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Button btnRemoveusers;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Button btn_editusers;
    }
}