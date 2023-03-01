namespace GestionParking
{
    partial class CustomerManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.InputPhoneNumber = new System.Windows.Forms.TextBox();
            this.InputNIC = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNIC_Search = new System.Windows.Forms.Label();
            this.InputSearch = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.listViewCustomers = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.LogoCustomers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(579, 113);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(163, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(83, 85);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(93, 23);
            this.InputLastName.TabIndex = 3;
            // 
            // InputFirstName
            // 
            this.InputFirstName.Location = new System.Drawing.Point(83, 116);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(93, 23);
            this.InputFirstName.TabIndex = 4;
            // 
            // InputAddress
            // 
            this.InputAddress.Location = new System.Drawing.Point(292, 85);
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(93, 23);
            this.InputAddress.TabIndex = 5;
            // 
            // InputPhoneNumber
            // 
            this.InputPhoneNumber.Location = new System.Drawing.Point(292, 116);
            this.InputPhoneNumber.Name = "InputPhoneNumber";
            this.InputPhoneNumber.Size = new System.Drawing.Size(93, 23);
            this.InputPhoneNumber.TabIndex = 6;
            // 
            // InputNIC
            // 
            this.InputNIC.Location = new System.Drawing.Point(426, 99);
            this.InputNIC.Name = "InputNIC";
            this.InputNIC.Size = new System.Drawing.Size(93, 23);
            this.InputNIC.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(11, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "LastName";
            // 
            // lblNIC_Search
            // 
            this.lblNIC_Search.AutoSize = true;
            this.lblNIC_Search.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC_Search.Location = new System.Drawing.Point(12, 22);
            this.lblNIC_Search.Name = "lblNIC_Search";
            this.lblNIC_Search.Size = new System.Drawing.Size(39, 21);
            this.lblNIC_Search.TabIndex = 15;
            this.lblNIC_Search.Text = "NIC";
            // 
            // InputSearch
            // 
            this.InputSearch.Location = new System.Drawing.Point(52, 22);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(100, 23);
            this.InputSearch.TabIndex = 16;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(11, 119);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 15);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "FirstName";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(209, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(192, 119);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(94, 15);
            this.lblPhoneNumber.TabIndex = 19;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC.Location = new System.Drawing.Point(391, 102);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(29, 15);
            this.lblNIC.TabIndex = 20;
            this.lblNIC.Text = "NIC";
            // 
            // listViewCustomers
            // 
            this.listViewCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewCustomers.Location = new System.Drawing.Point(26, 167);
            this.listViewCustomers.Name = "listViewCustomers";
            this.listViewCustomers.Size = new System.Drawing.Size(506, 145);
            this.listViewCustomers.TabIndex = 21;
            this.listViewCustomers.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers.View = System.Windows.Forms.View.Details;
            this.listViewCustomers.SelectedIndexChanged += new System.EventHandler(this.listViewCustomers_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "LastName";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NIC";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Address";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "PhoneNumber";
            this.columnHeader5.Width = 100;
            // 
            // LogoCustomers
            // 
            this.LogoCustomers.Image = ((System.Drawing.Image)(resources.GetObject("LogoCustomers.Image")));
            this.LogoCustomers.Location = new System.Drawing.Point(604, 2);
            this.LogoCustomers.Name = "LogoCustomers";
            this.LogoCustomers.Size = new System.Drawing.Size(65, 63);
            this.LogoCustomers.TabIndex = 22;
            this.LogoCustomers.TabStop = false;
            this.LogoCustomers.Click += new System.EventHandler(this.LogoCustomers_Click);
            this.LogoCustomers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoIParking_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(671, 341);
            this.Controls.Add(this.LogoCustomers);
            this.Controls.Add(this.listViewCustomers);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.InputSearch);
            this.Controls.Add(this.lblNIC_Search);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.InputNIC);
            this.Controls.Add(this.InputPhoneNumber);
            this.Controls.Add(this.InputAddress);
            this.Controls.Add(this.InputFirstName);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.Click += new System.EventHandler(this.Panel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LogoCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Button btnModify;
        private Button btnSearch;
        private TextBox InputLastName;
        private TextBox InputFirstName;
        private TextBox InputAddress;
        private TextBox InputPhoneNumber;
        private TextBox InputNIC;
        private Label lblLastName;
        private Label lblNIC_Search;
        private TextBox InputSearch;
        private Label lblFirstName;
        private Label lblAddress;
        private Label lblPhoneNumber;
        private Label lblNIC;
        private ListView listViewCustomers;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private PictureBox LogoCustomers;
    }
}