namespace GestionParking
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTollCollector = new System.Windows.Forms.Button();
            this.btnParking = new System.Windows.Forms.Button();
            this.btnBadges = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 379);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.Location = new System.Drawing.Point(461, 22);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(124, 115);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTollCollector
            // 
            this.btnTollCollector.Image = ((System.Drawing.Image)(resources.GetObject("btnTollCollector.Image")));
            this.btnTollCollector.Location = new System.Drawing.Point(664, 22);
            this.btnTollCollector.Name = "btnTollCollector";
            this.btnTollCollector.Size = new System.Drawing.Size(124, 115);
            this.btnTollCollector.TabIndex = 2;
            this.btnTollCollector.UseVisualStyleBackColor = true;
            this.btnTollCollector.Click += new System.EventHandler(this.btnTollCollector_Click);
            // 
            // btnParking
            // 
            this.btnParking.Image = ((System.Drawing.Image)(resources.GetObject("btnParking.Image")));
            this.btnParking.Location = new System.Drawing.Point(568, 143);
            this.btnParking.Name = "btnParking";
            this.btnParking.Size = new System.Drawing.Size(124, 115);
            this.btnParking.TabIndex = 3;
            this.btnParking.UseVisualStyleBackColor = true;
            this.btnParking.Click += new System.EventHandler(this.btnParking_Click);
            // 
            // btnBadges
            // 
            this.btnBadges.Image = ((System.Drawing.Image)(resources.GetObject("btnBadges.Image")));
            this.btnBadges.Location = new System.Drawing.Point(445, 264);
            this.btnBadges.Name = "btnBadges";
            this.btnBadges.Size = new System.Drawing.Size(124, 115);
            this.btnBadges.TabIndex = 4;
            this.btnBadges.UseVisualStyleBackColor = true;
            this.btnBadges.Click += new System.EventHandler(this.btnBadges_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.Image = ((System.Drawing.Image)(resources.GetObject("btnVehicles.Image")));
            this.btnVehicles.Location = new System.Drawing.Point(673, 264);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(124, 115);
            this.btnVehicles.TabIndex = 5;
            this.btnVehicles.UseVisualStyleBackColor = true;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.btnVehicles);
            this.Controls.Add(this.btnBadges);
            this.Controls.Add(this.btnParking);
            this.Controls.Add(this.btnTollCollector);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCustomers;
        private Button btnTollCollector;
        private Button btnParking;
        private Button btnBadges;
        private Button btnVehicles;
    }
}