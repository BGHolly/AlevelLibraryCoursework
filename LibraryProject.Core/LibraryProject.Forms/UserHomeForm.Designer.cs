namespace LibraryProject.Forms
{
    partial class UserHomeForm
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
            this.components = new System.ComponentModel.Container();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcodeNumber = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lvwReccomendations = new System.Windows.Forms.ListView();
            this.imlReccomendations = new System.Windows.Forms.ImageList(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(108, 446);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(262, 30);
            this.tbxGenre.TabIndex = 7;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(108, 396);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 25);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre";
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(108, 328);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(262, 30);
            this.tbxAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(103, 281);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(76, 25);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(103, 222);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(267, 30);
            this.tbxTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(98, 172);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // tbxBarcode
            // 
            this.tbxBarcode.Location = new System.Drawing.Point(98, 113);
            this.tbxBarcode.Name = "tbxBarcode";
            this.tbxBarcode.Size = new System.Drawing.Size(272, 30);
            this.tbxBarcode.TabIndex = 1;
            this.tbxBarcode.Leave += new System.EventHandler(this.tbxBarcode_TextChanged);
            // 
            // lblBarcodeNumber
            // 
            this.lblBarcodeNumber.AutoSize = true;
            this.lblBarcodeNumber.Location = new System.Drawing.Point(93, 64);
            this.lblBarcodeNumber.Name = "lblBarcodeNumber";
            this.lblBarcodeNumber.Size = new System.Drawing.Size(168, 25);
            this.lblBarcodeNumber.TabIndex = 0;
            this.lblBarcodeNumber.Text = "barcode number";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(332, 542);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(202, 45);
            this.btn_return.TabIndex = 9;
            this.btn_return.Text = "return";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(103, 542);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(202, 44);
            this.btn_checkout.TabIndex = 8;
            this.btn_checkout.Text = "check out";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1252, 701);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(202, 46);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lvwReccomendations
            // 
            this.lvwReccomendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwReccomendations.HideSelection = false;
            this.lvwReccomendations.LargeImageList = this.imlReccomendations;
            this.lvwReccomendations.Location = new System.Drawing.Point(1094, 64);
            this.lvwReccomendations.Name = "lvwReccomendations";
            this.lvwReccomendations.Size = new System.Drawing.Size(360, 605);
            this.lvwReccomendations.SmallImageList = this.imlReccomendations;
            this.lvwReccomendations.TabIndex = 24;
            this.lvwReccomendations.UseCompatibleStateImageBehavior = false;
            this.lvwReccomendations.View = System.Windows.Forms.View.Tile;
            // 
            // imlReccomendations
            // 
            this.imlReccomendations.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imlReccomendations.ImageSize = new System.Drawing.Size(150, 200);
            this.imlReccomendations.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(932, 701);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(202, 46);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit My Details";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UserHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 865);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lvwReccomendations);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.tbxAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxBarcode);
            this.Controls.Add(this.lblBarcodeNumber);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_checkout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserHomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserHomeForm_FormClosed);
            this.Load += new System.EventHandler(this.UserHomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.Label lblBarcodeNumber;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.ListView lvwReccomendations;
        private System.Windows.Forms.ImageList imlReccomendations;
        private System.Windows.Forms.Button btnEdit;
    }
}