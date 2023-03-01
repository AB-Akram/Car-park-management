namespace GestionParking
{
    partial class BadgesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BadgesManagement));
            this.LogoBadges = new System.Windows.Forms.PictureBox();
            this.listViewBadges = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.InputSearch = new System.Windows.Forms.TextBox();
            this.lblNIC_Search = new System.Windows.Forms.Label();
            this.InputSearchId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.btnSearchId = new MaterialSkin.Controls.MaterialButton();
            this.InputNIC_Customers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBadges)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBadges
            // 
            this.LogoBadges.Image = ((System.Drawing.Image)(resources.GetObject("LogoBadges.Image")));
            this.LogoBadges.Location = new System.Drawing.Point(427, 1);
            this.LogoBadges.Name = "LogoBadges";
            this.LogoBadges.Size = new System.Drawing.Size(65, 63);
            this.LogoBadges.TabIndex = 39;
            this.LogoBadges.TabStop = false;
            this.LogoBadges.Click += new System.EventHandler(this.LogoBadges_Click);
            // 
            // listViewBadges
            // 
            this.listViewBadges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewBadges.Location = new System.Drawing.Point(288, 70);
            this.listViewBadges.Name = "listViewBadges";
            this.listViewBadges.Size = new System.Drawing.Size(204, 145);
            this.listViewBadges.TabIndex = 38;
            this.listViewBadges.UseCompatibleStateImageBehavior = false;
            this.listViewBadges.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NIC_Customers";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Point";
            this.columnHeader2.Width = 100;
            // 
            // InputSearch
            // 
            this.InputSearch.Location = new System.Drawing.Point(43, 69);
            this.InputSearch.Name = "InputSearch";
            this.InputSearch.Size = new System.Drawing.Size(100, 23);
            this.InputSearch.TabIndex = 33;
            // 
            // lblNIC_Search
            // 
            this.lblNIC_Search.AutoSize = true;
            this.lblNIC_Search.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNIC_Search.Location = new System.Drawing.Point(3, 69);
            this.lblNIC_Search.Name = "lblNIC_Search";
            this.lblNIC_Search.Size = new System.Drawing.Size(39, 21);
            this.lblNIC_Search.TabIndex = 32;
            this.lblNIC_Search.Text = "NIC";
            // 
            // InputSearchId
            // 
            this.InputSearchId.Location = new System.Drawing.Point(43, 100);
            this.InputSearchId.Name = "InputSearchId";
            this.InputSearchId.Size = new System.Drawing.Size(100, 23);
            this.InputSearchId.TabIndex = 41;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(7, 102);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 42;
            this.lblId.Text = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(108, 188);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(71, 24);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 45;
            this.label1.Text = "NIC";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(158, 70);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(71, 24);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchId
            // 
            this.btnSearchId.AutoSize = false;
            this.btnSearchId.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchId.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearchId.Depth = 0;
            this.btnSearchId.HighEmphasis = true;
            this.btnSearchId.Icon = null;
            this.btnSearchId.Location = new System.Drawing.Point(158, 102);
            this.btnSearchId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchId.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearchId.Name = "btnSearchId";
            this.btnSearchId.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearchId.Size = new System.Drawing.Size(71, 24);
            this.btnSearchId.TabIndex = 47;
            this.btnSearchId.Text = "Search";
            this.btnSearchId.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearchId.UseAccentColor = false;
            this.btnSearchId.UseVisualStyleBackColor = true;
            this.btnSearchId.Click += new System.EventHandler(this.btnSearchId_Click);
            // 
            // InputNIC_Customers
            // 
            this.InputNIC_Customers.Location = new System.Drawing.Point(90, 148);
            this.InputNIC_Customers.Name = "InputNIC_Customers";
            this.InputNIC_Customers.Size = new System.Drawing.Size(100, 23);
            this.InputNIC_Customers.TabIndex = 48;
            // 
            // BadgesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(495, 240);
            this.Controls.Add(this.InputNIC_Customers);
            this.Controls.Add(this.btnSearchId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.InputSearchId);
            this.Controls.Add(this.LogoBadges);
            this.Controls.Add(this.listViewBadges);
            this.Controls.Add(this.InputSearch);
            this.Controls.Add(this.lblNIC_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BadgesManagement";
            this.Text = "BadgesManagement";
            this.Load += new System.EventHandler(this.BadgesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBadges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox LogoBadges;
        private ListView listViewBadges;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private TextBox InputSearch;
        private Label lblNIC_Search;
        private TextBox InputSearchId;
        private Label lblId;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnSearchId;
        private TextBox InputNIC_Customers;
    }
}