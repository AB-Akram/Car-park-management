namespace GestionParking
{
    partial class ParkingManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingManagement));
            this.listViewVehicles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.LogoParking = new System.Windows.Forms.PictureBox();
            this.listViewFirstFloor = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.listViewGroundFloor = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.listViewBasement = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.lblFirstFloor = new System.Windows.Forms.Label();
            this.lblGroundFloor = new System.Windows.Forms.Label();
            this.lblBasement = new System.Windows.Forms.Label();
            this.InputDE_FirstFloor = new System.Windows.Forms.TextBox();
            this.InputRD_FirstFloor = new System.Windows.Forms.TextBox();
            this.InputPrice_FirstFloor = new System.Windows.Forms.TextBox();
            this.InputDE_GroundFloor = new System.Windows.Forms.TextBox();
            this.InputRD_GroundFloor = new System.Windows.Forms.TextBox();
            this.InputPrice_GroundFloor = new System.Windows.Forms.TextBox();
            this.InputDE_Basement = new System.Windows.Forms.TextBox();
            this.InputRD_Basement = new System.Windows.Forms.TextBox();
            this.InputPrice_Basement = new System.Windows.Forms.TextBox();
            this.btnET_FirstFloor = new System.Windows.Forms.Button();
            this.btnEX_FirstFloor = new System.Windows.Forms.Button();
            this.btnET_GroundFloor = new System.Windows.Forms.Button();
            this.btnEX_GroundFloor = new System.Windows.Forms.Button();
            this.btnET_Basement = new System.Windows.Forms.Button();
            this.btnEX_Basement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoParking)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewVehicles
            // 
            this.listViewVehicles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader15});
            this.listViewVehicles.Location = new System.Drawing.Point(12, 183);
            this.listViewVehicles.Name = "listViewVehicles";
            this.listViewVehicles.Size = new System.Drawing.Size(306, 276);
            this.listViewVehicles.TabIndex = 0;
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
            this.columnHeader2.Text = "BadgeId";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "VehicleType";
            this.columnHeader15.Width = 100;
            // 
            // LogoParking
            // 
            this.LogoParking.Image = ((System.Drawing.Image)(resources.GetObject("LogoParking.Image")));
            this.LogoParking.Location = new System.Drawing.Point(925, 12);
            this.LogoParking.Name = "LogoParking";
            this.LogoParking.Size = new System.Drawing.Size(65, 63);
            this.LogoParking.TabIndex = 23;
            this.LogoParking.TabStop = false;
            this.LogoParking.Click += new System.EventHandler(this.LogoParking_Click);
            // 
            // listViewFirstFloor
            // 
            this.listViewFirstFloor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewFirstFloor.Location = new System.Drawing.Point(385, 13);
            this.listViewFirstFloor.Name = "listViewFirstFloor";
            this.listViewFirstFloor.Size = new System.Drawing.Size(412, 217);
            this.listViewFirstFloor.TabIndex = 24;
            this.listViewFirstFloor.UseCompatibleStateImageBehavior = false;
            this.listViewFirstFloor.View = System.Windows.Forms.View.Details;
            this.listViewFirstFloor.SelectedIndexChanged += new System.EventHandler(this.listViewFirstFloor_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "VehicleNumber";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DateEntry";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ReleaseDate";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Price";
            this.columnHeader10.Width = 100;
            // 
            // listViewGroundFloor
            // 
            this.listViewGroundFloor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewGroundFloor.Location = new System.Drawing.Point(385, 236);
            this.listViewGroundFloor.Name = "listViewGroundFloor";
            this.listViewGroundFloor.Size = new System.Drawing.Size(412, 212);
            this.listViewGroundFloor.TabIndex = 25;
            this.listViewGroundFloor.UseCompatibleStateImageBehavior = false;
            this.listViewGroundFloor.View = System.Windows.Forms.View.Details;
            this.listViewGroundFloor.SelectedIndexChanged += new System.EventHandler(this.listViewGroundFloor_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "VehicleNumber";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "DateEntry";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ReleaseDate";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Price";
            this.columnHeader8.Width = 100;
            // 
            // listViewBasement
            // 
            this.listViewBasement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewBasement.Location = new System.Drawing.Point(385, 454);
            this.listViewBasement.Name = "listViewBasement";
            this.listViewBasement.Size = new System.Drawing.Size(412, 222);
            this.listViewBasement.TabIndex = 26;
            this.listViewBasement.UseCompatibleStateImageBehavior = false;
            this.listViewBasement.View = System.Windows.Forms.View.Details;
            this.listViewBasement.SelectedIndexChanged += new System.EventHandler(this.listViewBasement_SelectedIndexChanged_1);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "VehicleNumber";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "DateEntry";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ReleaseDate";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Price";
            this.columnHeader14.Width = 100;
            // 
            // lblFirstFloor
            // 
            this.lblFirstFloor.AutoSize = true;
            this.lblFirstFloor.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstFloor.Location = new System.Drawing.Point(817, 19);
            this.lblFirstFloor.Name = "lblFirstFloor";
            this.lblFirstFloor.Size = new System.Drawing.Size(20, 20);
            this.lblFirstFloor.TabIndex = 27;
            this.lblFirstFloor.Text = "N";
            // 
            // lblGroundFloor
            // 
            this.lblGroundFloor.AutoSize = true;
            this.lblGroundFloor.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroundFloor.Location = new System.Drawing.Point(817, 236);
            this.lblGroundFloor.Name = "lblGroundFloor";
            this.lblGroundFloor.Size = new System.Drawing.Size(20, 20);
            this.lblGroundFloor.TabIndex = 30;
            this.lblGroundFloor.Text = "N";
            // 
            // lblBasement
            // 
            this.lblBasement.AutoSize = true;
            this.lblBasement.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBasement.Location = new System.Drawing.Point(817, 464);
            this.lblBasement.Name = "lblBasement";
            this.lblBasement.Size = new System.Drawing.Size(20, 20);
            this.lblBasement.TabIndex = 31;
            this.lblBasement.Text = "N";
            // 
            // InputDE_FirstFloor
            // 
            this.InputDE_FirstFloor.Enabled = false;
            this.InputDE_FirstFloor.Location = new System.Drawing.Point(817, 62);
            this.InputDE_FirstFloor.Name = "InputDE_FirstFloor";
            this.InputDE_FirstFloor.PlaceholderText = "DateEntry";
            this.InputDE_FirstFloor.Size = new System.Drawing.Size(91, 23);
            this.InputDE_FirstFloor.TabIndex = 32;
            // 
            // InputRD_FirstFloor
            // 
            this.InputRD_FirstFloor.Enabled = false;
            this.InputRD_FirstFloor.Location = new System.Drawing.Point(817, 91);
            this.InputRD_FirstFloor.Name = "InputRD_FirstFloor";
            this.InputRD_FirstFloor.PlaceholderText = "ReleaseDate";
            this.InputRD_FirstFloor.Size = new System.Drawing.Size(91, 23);
            this.InputRD_FirstFloor.TabIndex = 33;
            // 
            // InputPrice_FirstFloor
            // 
            this.InputPrice_FirstFloor.Enabled = false;
            this.InputPrice_FirstFloor.Location = new System.Drawing.Point(817, 120);
            this.InputPrice_FirstFloor.Name = "InputPrice_FirstFloor";
            this.InputPrice_FirstFloor.PlaceholderText = "Price";
            this.InputPrice_FirstFloor.Size = new System.Drawing.Size(91, 23);
            this.InputPrice_FirstFloor.TabIndex = 34;
            // 
            // InputDE_GroundFloor
            // 
            this.InputDE_GroundFloor.Enabled = false;
            this.InputDE_GroundFloor.Location = new System.Drawing.Point(817, 277);
            this.InputDE_GroundFloor.Name = "InputDE_GroundFloor";
            this.InputDE_GroundFloor.PlaceholderText = "DateEntry";
            this.InputDE_GroundFloor.Size = new System.Drawing.Size(91, 23);
            this.InputDE_GroundFloor.TabIndex = 35;
            // 
            // InputRD_GroundFloor
            // 
            this.InputRD_GroundFloor.Enabled = false;
            this.InputRD_GroundFloor.Location = new System.Drawing.Point(817, 306);
            this.InputRD_GroundFloor.Name = "InputRD_GroundFloor";
            this.InputRD_GroundFloor.PlaceholderText = "ReleaseDate";
            this.InputRD_GroundFloor.Size = new System.Drawing.Size(91, 23);
            this.InputRD_GroundFloor.TabIndex = 36;
            // 
            // InputPrice_GroundFloor
            // 
            this.InputPrice_GroundFloor.Enabled = false;
            this.InputPrice_GroundFloor.Location = new System.Drawing.Point(817, 335);
            this.InputPrice_GroundFloor.Name = "InputPrice_GroundFloor";
            this.InputPrice_GroundFloor.PlaceholderText = "Price";
            this.InputPrice_GroundFloor.Size = new System.Drawing.Size(91, 23);
            this.InputPrice_GroundFloor.TabIndex = 37;
            // 
            // InputDE_Basement
            // 
            this.InputDE_Basement.Enabled = false;
            this.InputDE_Basement.Location = new System.Drawing.Point(817, 500);
            this.InputDE_Basement.Name = "InputDE_Basement";
            this.InputDE_Basement.PlaceholderText = "DateEntry";
            this.InputDE_Basement.Size = new System.Drawing.Size(91, 23);
            this.InputDE_Basement.TabIndex = 38;
            // 
            // InputRD_Basement
            // 
            this.InputRD_Basement.Enabled = false;
            this.InputRD_Basement.Location = new System.Drawing.Point(817, 529);
            this.InputRD_Basement.Name = "InputRD_Basement";
            this.InputRD_Basement.PlaceholderText = "ReleaseDate";
            this.InputRD_Basement.Size = new System.Drawing.Size(91, 23);
            this.InputRD_Basement.TabIndex = 39;
            // 
            // InputPrice_Basement
            // 
            this.InputPrice_Basement.Enabled = false;
            this.InputPrice_Basement.Location = new System.Drawing.Point(817, 558);
            this.InputPrice_Basement.Name = "InputPrice_Basement";
            this.InputPrice_Basement.PlaceholderText = "Price";
            this.InputPrice_Basement.Size = new System.Drawing.Size(91, 23);
            this.InputPrice_Basement.TabIndex = 40;
            // 
            // btnET_FirstFloor
            // 
            this.btnET_FirstFloor.Enabled = false;
            this.btnET_FirstFloor.Location = new System.Drawing.Point(811, 152);
            this.btnET_FirstFloor.Name = "btnET_FirstFloor";
            this.btnET_FirstFloor.Size = new System.Drawing.Size(44, 23);
            this.btnET_FirstFloor.TabIndex = 41;
            this.btnET_FirstFloor.Text = "Entry";
            this.btnET_FirstFloor.UseVisualStyleBackColor = true;
            this.btnET_FirstFloor.Click += new System.EventHandler(this.btnET_FirstFloor_Click);
            // 
            // btnEX_FirstFloor
            // 
            this.btnEX_FirstFloor.Enabled = false;
            this.btnEX_FirstFloor.Location = new System.Drawing.Point(864, 152);
            this.btnEX_FirstFloor.Name = "btnEX_FirstFloor";
            this.btnEX_FirstFloor.Size = new System.Drawing.Size(44, 23);
            this.btnEX_FirstFloor.TabIndex = 42;
            this.btnEX_FirstFloor.Text = "Exit";
            this.btnEX_FirstFloor.UseVisualStyleBackColor = true;
            this.btnEX_FirstFloor.Click += new System.EventHandler(this.btnEX_FirstFloor_Click);
            // 
            // btnET_GroundFloor
            // 
            this.btnET_GroundFloor.Enabled = false;
            this.btnET_GroundFloor.Location = new System.Drawing.Point(811, 364);
            this.btnET_GroundFloor.Name = "btnET_GroundFloor";
            this.btnET_GroundFloor.Size = new System.Drawing.Size(44, 23);
            this.btnET_GroundFloor.TabIndex = 43;
            this.btnET_GroundFloor.Text = "Entry";
            this.btnET_GroundFloor.UseVisualStyleBackColor = true;
            this.btnET_GroundFloor.Click += new System.EventHandler(this.btnET_GroundFloor_Click);
            // 
            // btnEX_GroundFloor
            // 
            this.btnEX_GroundFloor.Enabled = false;
            this.btnEX_GroundFloor.Location = new System.Drawing.Point(864, 364);
            this.btnEX_GroundFloor.Name = "btnEX_GroundFloor";
            this.btnEX_GroundFloor.Size = new System.Drawing.Size(44, 23);
            this.btnEX_GroundFloor.TabIndex = 44;
            this.btnEX_GroundFloor.Text = "Exit";
            this.btnEX_GroundFloor.UseVisualStyleBackColor = true;
            this.btnEX_GroundFloor.Click += new System.EventHandler(this.btnEX_GroundFloor_Click);
            // 
            // btnET_Basement
            // 
            this.btnET_Basement.Enabled = false;
            this.btnET_Basement.Location = new System.Drawing.Point(811, 587);
            this.btnET_Basement.Name = "btnET_Basement";
            this.btnET_Basement.Size = new System.Drawing.Size(44, 23);
            this.btnET_Basement.TabIndex = 45;
            this.btnET_Basement.Text = "Entry";
            this.btnET_Basement.UseVisualStyleBackColor = true;
            this.btnET_Basement.Click += new System.EventHandler(this.btnET_Basement_Click);
            // 
            // btnEX_Basement
            // 
            this.btnEX_Basement.Enabled = false;
            this.btnEX_Basement.Location = new System.Drawing.Point(864, 587);
            this.btnEX_Basement.Name = "btnEX_Basement";
            this.btnEX_Basement.Size = new System.Drawing.Size(44, 23);
            this.btnEX_Basement.TabIndex = 46;
            this.btnEX_Basement.Text = "Exit";
            this.btnEX_Basement.UseVisualStyleBackColor = true;
            this.btnEX_Basement.Click += new System.EventHandler(this.btnEX_Basement_Click);
            // 
            // ParkingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 682);
            this.Controls.Add(this.btnEX_Basement);
            this.Controls.Add(this.btnET_Basement);
            this.Controls.Add(this.btnEX_GroundFloor);
            this.Controls.Add(this.btnET_GroundFloor);
            this.Controls.Add(this.btnEX_FirstFloor);
            this.Controls.Add(this.btnET_FirstFloor);
            this.Controls.Add(this.InputPrice_Basement);
            this.Controls.Add(this.InputRD_Basement);
            this.Controls.Add(this.InputDE_Basement);
            this.Controls.Add(this.InputPrice_GroundFloor);
            this.Controls.Add(this.InputRD_GroundFloor);
            this.Controls.Add(this.InputDE_GroundFloor);
            this.Controls.Add(this.InputPrice_FirstFloor);
            this.Controls.Add(this.InputRD_FirstFloor);
            this.Controls.Add(this.InputDE_FirstFloor);
            this.Controls.Add(this.lblBasement);
            this.Controls.Add(this.lblGroundFloor);
            this.Controls.Add(this.lblFirstFloor);
            this.Controls.Add(this.listViewBasement);
            this.Controls.Add(this.listViewGroundFloor);
            this.Controls.Add(this.listViewFirstFloor);
            this.Controls.Add(this.LogoParking);
            this.Controls.Add(this.listViewVehicles);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParkingManagement";
            this.Text = "ParkingManagement";
            this.Load += new System.EventHandler(this.ParkingManagement_Load);
            this.Click += new System.EventHandler(this.Panel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LogoParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewVehicles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private PictureBox LogoParking;
        private ListView listViewFirstFloor;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ListView listViewGroundFloor;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView listViewBasement;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label lblFirstFloor;
        private Label lblGroundFloor;
        private Label lblBasement;
        private TextBox InputDE_FirstFloor;
        private TextBox InputRD_FirstFloor;
        private TextBox InputPrice_FirstFloor;
        private TextBox InputDE_GroundFloor;
        private TextBox InputRD_GroundFloor;
        private TextBox InputPrice_GroundFloor;
        private TextBox InputDE_Basement;
        private TextBox InputRD_Basement;
        private TextBox InputPrice_Basement;
        private Button btnET_FirstFloor;
        private Button btnEX_FirstFloor;
        private Button btnET_GroundFloor;
        private Button btnEX_GroundFloor;
        private Button btnET_Basement;
        private Button btnEX_Basement;
        private ColumnHeader columnHeader15;
    }
}