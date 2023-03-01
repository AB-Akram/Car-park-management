namespace GestionParking
{
    partial class TollCollectorManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TollCollectorManagement));
            this.LogoTollCollector = new System.Windows.Forms.PictureBox();
            this.listViewTollCollecTors = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.InputSearch = new System.Windows.Forms.TextBox();
            this.lblNIC_Search = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.InputNIC = new System.Windows.Forms.TextBox();
            this.InputPhoneNumber = new System.Windows.Forms.TextBox();
            this.InputAddress = new System.Windows.Forms.TextBox();
            this.InputFirstName = new System.Windows.Forms.TextBox();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoTollCollector)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoTollCollector
            // 
            this.LogoTollCollector.BackColor = System.Drawing.Color.Transparent;
            this.LogoTollCollector.Image = ((System.Drawing.Image)(resources.GetObject("LogoTollCollector.Image")));
            this.LogoTollCollector.Location = new System.Drawing.Point(611, 4);
            this.LogoTollCollector.Name = "LogoTollCollector";
            this.LogoTollCollector.Size = new System.Drawing.Size(65, 63);
            this.LogoTollCollector.TabIndex = 39;
            this.LogoTollCollector.TabStop = false;
            this.LogoTollCollector.Click += new System.EventHandler(this.LogoTollCollector_Click);
            // 
            // listViewTollCollecTors
            // 
            this.listViewTollCollecTors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewTollCollecTors.Location = new System.Drawing.Point(26, 155);
            this.listViewTollCollecTors.Name = "listViewTollCollecTors";
            this.listViewTollCollecTors.Size = new System.Drawing.Size(604, 145);
            this.listViewTollCollecTors.TabIndex = 38;
            this.listViewTollCollecTors.UseCompatibleStateImageBehavior = false;
            this.listViewTollCollecTors.View = System.Windows.Forms.View.Details;
            this.listViewTollCollecTors.SelectedIndexChanged += new System.EventHandler(this.listViewTollCollecTors_SelectedIndexChanged);
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
            // columnHeader6
            // 
            this.columnHeader6.Text = "isActive";
            this.columnHeader6.Width = 100;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC.Location = new System.Drawing.Point(391, 91);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(29, 15);
            this.lblNIC.TabIndex = 37;
            this.lblNIC.Text = "NIC";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.Location = new System.Drawing.Point(192, 108);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(94, 15);
            this.lblPhoneNumber.TabIndex = 36;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(209, 77);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 15);
            this.lblAddress.TabIndex = 35;
            this.lblAddress.Text = "Address";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(11, 108);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 15);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "FirstName";
            // 
            // InputSearch
            // 
            this.InputSearch.Location = new System.Drawing.Point(52, 11);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(100, 23);
            this.InputSearch.TabIndex = 33;
            // 
            // lblNIC_Search
            // 
            this.lblNIC_Search.AutoSize = true;
            this.lblNIC_Search.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC_Search.Location = new System.Drawing.Point(12, 11);
            this.lblNIC_Search.Name = "lblNIC_Search";
            this.lblNIC_Search.Size = new System.Drawing.Size(39, 21);
            this.lblNIC_Search.TabIndex = 32;
            this.lblNIC_Search.Text = "NIC";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(11, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "LastName";
            // 
            // InputNIC
            // 
            this.InputNIC.Location = new System.Drawing.Point(426, 88);
            this.InputNIC.Name = "InputNIC";
            this.InputNIC.Size = new System.Drawing.Size(93, 23);
            this.InputNIC.TabIndex = 30;
            // 
            // InputPhoneNumber
            // 
            this.InputPhoneNumber.Location = new System.Drawing.Point(292, 105);
            this.InputPhoneNumber.Name = "InputPhoneNumber";
            this.InputPhoneNumber.Size = new System.Drawing.Size(93, 23);
            this.InputPhoneNumber.TabIndex = 29;
            // 
            // InputAddress
            // 
            this.InputAddress.Location = new System.Drawing.Point(292, 74);
            this.InputAddress.Name = "InputAddress";
            this.InputAddress.Size = new System.Drawing.Size(93, 23);
            this.InputAddress.TabIndex = 28;
            // 
            // InputFirstName
            // 
            this.InputFirstName.Location = new System.Drawing.Point(83, 105);
            this.InputFirstName.Name = "InputFirstName";
            this.InputFirstName.Size = new System.Drawing.Size(93, 23);
            this.InputFirstName.TabIndex = 27;
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(83, 74);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(93, 23);
            this.InputLastName.TabIndex = 26;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(163, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(555, 104);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 24;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TollCollectorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(679, 312);
            this.Controls.Add(this.LogoTollCollector);
            this.Controls.Add(this.listViewTollCollecTors);
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
            this.Name = "TollCollectorManagement";
            this.Text = "TollCollectorManagement";
            this.Load += new System.EventHandler(this.TollCollectorManagement_Load);
            this.Click += new System.EventHandler(this.Panel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LogoTollCollector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoTollCollector;
        private ListView listViewTollCollecTors;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label lblNIC;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Label lblFirstName;
        private TextBox InputSearch;
        private Label lblNIC_Search;
        private Label lblLastName;
        private TextBox InputNIC;
        private TextBox InputPhoneNumber;
        private TextBox InputAddress;
        private TextBox InputFirstName;
        private TextBox InputLastName;
        private Button btnSearch;
        private Button btnModify;
        private Button btnAdd;
        private ColumnHeader columnHeader6;
    }
}