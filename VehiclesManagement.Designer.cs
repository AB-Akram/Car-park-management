namespace GestionParking
{
    partial class VehiclesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesManagement));
            this.LogoVehicles = new System.Windows.Forms.PictureBox();
            this.listViewVehicles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.InputSearch = new System.Windows.Forms.TextBox();
            this.lblVehicleNumber = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.InputType = new System.Windows.Forms.TextBox();
            this.InputModel = new System.Windows.Forms.TextBox();
            this.InputBrand = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.InputBadgeId = new System.Windows.Forms.TextBox();
            this.lblBadgeId = new System.Windows.Forms.Label();
            this.InputNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.InputVehicleType = new System.Windows.Forms.TextBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoVehicles
            // 
            this.LogoVehicles.BackColor = System.Drawing.Color.Transparent;
            this.LogoVehicles.Image = ((System.Drawing.Image)(resources.GetObject("LogoVehicles.Image")));
            this.LogoVehicles.Location = new System.Drawing.Point(617, 0);
            this.LogoVehicles.Name = "LogoVehicles";
            this.LogoVehicles.Size = new System.Drawing.Size(65, 63);
            this.LogoVehicles.TabIndex = 56;
            this.LogoVehicles.TabStop = false;
            this.LogoVehicles.Click += new System.EventHandler(this.LogoVehicles_Click);
            // 
            // listViewVehicles
            // 
            this.listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewVehicles.Location = new System.Drawing.Point(26, 155);
            this.listViewVehicles.Name = "listViewVehicles";
            this.listViewVehicles.Size = new System.Drawing.Size(604, 145);
            this.listViewVehicles.TabIndex = 55;
            this.listViewVehicles.UseCompatibleStateImageBehavior = false;
            this.listViewVehicles.View = System.Windows.Forms.View.Details;
            this.listViewVehicles.SelectedIndexChanged += new System.EventHandler(this.listViewVehicles_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Brand";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BadgeId";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "VehicleType";
            this.columnHeader6.Width = 100;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(196, 121);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 15);
            this.lblType.TabIndex = 52;
            this.lblType.Text = "Type";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(193, 77);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 15);
            this.lblModel.TabIndex = 51;
            this.lblModel.Text = "Model";
            // 
            // InputSearch
            // 
            this.InputSearch.Location = new System.Drawing.Point(143, 11);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(100, 23);
            this.InputSearch.TabIndex = 50;
            // 
            // lblVehicleNumber
            // 
            this.lblVehicleNumber.AutoSize = true;
            this.lblVehicleNumber.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehicleNumber.Location = new System.Drawing.Point(12, 11);
            this.lblVehicleNumber.Name = "lblVehicleNumber";
            this.lblVehicleNumber.Size = new System.Drawing.Size(131, 21);
            this.lblVehicleNumber.TabIndex = 49;
            this.lblVehicleNumber.Text = "VehicleNumber";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrand.Location = new System.Drawing.Point(34, 121);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(43, 15);
            this.lblBrand.TabIndex = 48;
            this.lblBrand.Text = "Brand";
            // 
            // InputType
            // 
            this.InputType.Location = new System.Drawing.Point(245, 115);
            this.InputType.Name = "InputType";
            this.InputType.Size = new System.Drawing.Size(93, 23);
            this.InputType.TabIndex = 45;
            // 
            // InputModel
            // 
            this.InputModel.Location = new System.Drawing.Point(245, 74);
            this.InputModel.Name = "InputModel";
            this.InputModel.Size = new System.Drawing.Size(93, 23);
            this.InputModel.TabIndex = 44;
            // 
            // InputBrand
            // 
            this.InputBrand.Location = new System.Drawing.Point(94, 115);
            this.InputBrand.Name = "InputBrand";
            this.InputBrand.Size = new System.Drawing.Size(93, 23);
            this.InputBrand.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(254, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(555, 108);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 41;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // InputBadgeId
            // 
            this.InputBadgeId.Location = new System.Drawing.Point(425, 74);
            this.InputBadgeId.Name = "InputBadgeId";
            this.InputBadgeId.Size = new System.Drawing.Size(93, 23);
            this.InputBadgeId.TabIndex = 57;
            // 
            // lblBadgeId
            // 
            this.lblBadgeId.AutoSize = true;
            this.lblBadgeId.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBadgeId.Location = new System.Drawing.Point(362, 79);
            this.lblBadgeId.Name = "lblBadgeId";
            this.lblBadgeId.Size = new System.Drawing.Size(57, 15);
            this.lblBadgeId.TabIndex = 58;
            this.lblBadgeId.Text = "BadgeId";
            // 
            // InputNumber
            // 
            this.InputNumber.Location = new System.Drawing.Point(94, 75);
            this.InputNumber.Name = "InputNumber";
            this.InputNumber.Size = new System.Drawing.Size(93, 23);
            this.InputNumber.TabIndex = 59;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.Location = new System.Drawing.Point(26, 78);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(56, 15);
            this.lblNumber.TabIndex = 60;
            this.lblNumber.Text = "Number";
            // 
            // InputVehicleType
            // 
            this.InputVehicleType.Location = new System.Drawing.Point(425, 115);
            this.InputVehicleType.Name = "InputVehicleType";
            this.InputVehicleType.Size = new System.Drawing.Size(93, 23);
            this.InputVehicleType.TabIndex = 61;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehicleType.Location = new System.Drawing.Point(344, 121);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(80, 15);
            this.lblVehicleType.TabIndex = 62;
            this.lblVehicleType.Text = "VehicleType";
            // 
            // VehiclesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(690, 324);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.InputVehicleType);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.InputNumber);
            this.Controls.Add(this.lblBadgeId);
            this.Controls.Add(this.InputBadgeId);
            this.Controls.Add(this.LogoVehicles);
            this.Controls.Add(this.listViewVehicles);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.InputSearch);
            this.Controls.Add(this.lblVehicleNumber);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.InputType);
            this.Controls.Add(this.InputModel);
            this.Controls.Add(this.InputBrand);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehiclesManagement";
            this.Text = "VehiclesManagement";
            this.Load += new System.EventHandler(this.VehiclesManagement_Load);
            this.Click += new System.EventHandler(this.Panel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LogoVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoVehicles;
        private ListView listViewVehicles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label lblType;
        private Label lblModel;
        private TextBox InputSearch;
        private Label lblVehicleNumber;
        private Label lblBrand;
        private TextBox InputType;
        private TextBox InputModel;
        private TextBox InputBrand;
        private Button btnSearch;
        private Button btnModify;
        private Button btnAdd;
        private TextBox InputBadgeId;
        private Label lblBadgeId;
        private TextBox InputNumber;
        private Label lblNumber;
        private TextBox InputVehicleType;
        private Label lblVehicleType;
    }
}