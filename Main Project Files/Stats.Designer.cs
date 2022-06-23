
namespace The_Nursery_Management_System
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.lblSaleAmount = new System.Windows.Forms.Label();
            this.lblCustomerAmount = new System.Windows.Forms.Label();
            this.lblPlantAmount = new System.Windows.Forms.Label();
            this.lblEmployeeAmount = new System.Windows.Forms.Label();
            this.lblDeliveredOrderAmount = new System.Windows.Forms.Label();
            this.lblOrderAmount = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnPlants = new System.Windows.Forms.Button();
            this.btnAboutOxygen = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaleAmount
            // 
            this.lblSaleAmount.AutoSize = true;
            this.lblSaleAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblSaleAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleAmount.Location = new System.Drawing.Point(238, 214);
            this.lblSaleAmount.Name = "lblSaleAmount";
            this.lblSaleAmount.Size = new System.Drawing.Size(239, 70);
            this.lblSaleAmount.TabIndex = 1;
            this.lblSaleAmount.Text = "Amount";
            this.lblSaleAmount.Visible = false;
            // 
            // lblCustomerAmount
            // 
            this.lblCustomerAmount.AutoSize = true;
            this.lblCustomerAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAmount.Location = new System.Drawing.Point(918, 215);
            this.lblCustomerAmount.Name = "lblCustomerAmount";
            this.lblCustomerAmount.Size = new System.Drawing.Size(239, 70);
            this.lblCustomerAmount.TabIndex = 3;
            this.lblCustomerAmount.Text = "Amount";
            this.lblCustomerAmount.Visible = false;
            // 
            // lblPlantAmount
            // 
            this.lblPlantAmount.AutoSize = true;
            this.lblPlantAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlantAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantAmount.Location = new System.Drawing.Point(919, 331);
            this.lblPlantAmount.Name = "lblPlantAmount";
            this.lblPlantAmount.Size = new System.Drawing.Size(239, 70);
            this.lblPlantAmount.TabIndex = 7;
            this.lblPlantAmount.Text = "Amount";
            this.lblPlantAmount.Visible = false;
            this.lblPlantAmount.Click += new System.EventHandler(this.lblPlantAmount_Click);
            // 
            // lblEmployeeAmount
            // 
            this.lblEmployeeAmount.AutoSize = true;
            this.lblEmployeeAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeAmount.Location = new System.Drawing.Point(299, 333);
            this.lblEmployeeAmount.Name = "lblEmployeeAmount";
            this.lblEmployeeAmount.Size = new System.Drawing.Size(239, 70);
            this.lblEmployeeAmount.TabIndex = 5;
            this.lblEmployeeAmount.Text = "Amount";
            this.lblEmployeeAmount.Visible = false;
            this.lblEmployeeAmount.Click += new System.EventHandler(this.lblEmployeeAmount_Click);
            // 
            // lblDeliveredOrderAmount
            // 
            this.lblDeliveredOrderAmount.AutoSize = true;
            this.lblDeliveredOrderAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblDeliveredOrderAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveredOrderAmount.Location = new System.Drawing.Point(291, 591);
            this.lblDeliveredOrderAmount.Name = "lblDeliveredOrderAmount";
            this.lblDeliveredOrderAmount.Size = new System.Drawing.Size(239, 70);
            this.lblDeliveredOrderAmount.TabIndex = 11;
            this.lblDeliveredOrderAmount.Text = "Amount";
            this.lblDeliveredOrderAmount.Visible = false;
            this.lblDeliveredOrderAmount.Click += new System.EventHandler(this.lblDeliveredOrderAmount_Click);
            // 
            // lblOrderAmount
            // 
            this.lblOrderAmount.AutoSize = true;
            this.lblOrderAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAmount.Location = new System.Drawing.Point(257, 453);
            this.lblOrderAmount.Name = "lblOrderAmount";
            this.lblOrderAmount.Size = new System.Drawing.Size(239, 70);
            this.lblOrderAmount.TabIndex = 9;
            this.lblOrderAmount.Text = "Amount";
            this.lblOrderAmount.Visible = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnEmployee.Location = new System.Drawing.Point(353, 33);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(129, 47);
            this.btnEmployee.TabIndex = 46;
            this.btnEmployee.Text = "Employees";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCustomers.Location = new System.Drawing.Point(499, 33);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(129, 47);
            this.btnCustomers.TabIndex = 45;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnPlants
            // 
            this.btnPlants.BackColor = System.Drawing.Color.Transparent;
            this.btnPlants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlants.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlants.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPlants.Location = new System.Drawing.Point(249, 33);
            this.btnPlants.Name = "btnPlants";
            this.btnPlants.Size = new System.Drawing.Size(85, 47);
            this.btnPlants.TabIndex = 44;
            this.btnPlants.Text = "Plants";
            this.btnPlants.UseVisualStyleBackColor = false;
            this.btnPlants.Click += new System.EventHandler(this.btnPlants_Click);
            // 
            // btnAboutOxygen
            // 
            this.btnAboutOxygen.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutOxygen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutOxygen.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutOxygen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAboutOxygen.Location = new System.Drawing.Point(867, 35);
            this.btnAboutOxygen.Name = "btnAboutOxygen";
            this.btnAboutOxygen.Size = new System.Drawing.Size(153, 45);
            this.btnAboutOxygen.TabIndex = 43;
            this.btnAboutOxygen.Text = "About Oxygen";
            this.btnAboutOxygen.UseVisualStyleBackColor = false;
            this.btnAboutOxygen.Click += new System.EventHandler(this.btnAboutOxygen_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOrder.Location = new System.Drawing.Point(753, 35);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 45);
            this.btnOrder.TabIndex = 42;
            this.btnOrder.Text = "Orders";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.Transparent;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnStats.Location = new System.Drawing.Point(644, 33);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(95, 47);
            this.btnStats.TabIndex = 41;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1326, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnHome.Location = new System.Drawing.Point(1245, 33);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 44);
            this.btnHome.TabIndex = 56;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 786);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnPlants);
            this.Controls.Add(this.btnAboutOxygen);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lblDeliveredOrderAmount);
            this.Controls.Add(this.lblOrderAmount);
            this.Controls.Add(this.lblPlantAmount);
            this.Controls.Add(this.lblEmployeeAmount);
            this.Controls.Add(this.lblCustomerAmount);
            this.Controls.Add(this.lblSaleAmount);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stats";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSaleAmount;
        private System.Windows.Forms.Label lblCustomerAmount;
        private System.Windows.Forms.Label lblPlantAmount;
        private System.Windows.Forms.Label lblEmployeeAmount;
        private System.Windows.Forms.Label lblDeliveredOrderAmount;
        private System.Windows.Forms.Label lblOrderAmount;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPlants;
        private System.Windows.Forms.Button btnAboutOxygen;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
    }
}