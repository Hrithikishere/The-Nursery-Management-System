
namespace The_Nursery_Management_System
{
    partial class OrderEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderEmployee));
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataViewOrder = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnTotalPrice = new System.Windows.Forms.Label();
            this.txtPlantAmount = new System.Windows.Forms.TextBox();
            this.lblPlantAmount = new System.Windows.Forms.Label();
            this.txtPlantID = new System.Windows.Forms.TextBox();
            this.lblPlantID = new System.Windows.Forms.Label();
            this.rbtnDelivered = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rbtnInProcess = new System.Windows.Forms.RadioButton();
            this.rbtnPending = new System.Windows.Forms.RadioButton();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.btnAboutme = new System.Windows.Forms.Button();
            this.btnAboutOxygen = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnPlants = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1326, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 87;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1086, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 44);
            this.btnSearch.TabIndex = 86;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(769, 162);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 50);
            this.txtSearch.TabIndex = 85;
            // 
            // dataViewOrder
            // 
            this.dataViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewOrder.Location = new System.Drawing.Point(679, 243);
            this.dataViewOrder.Name = "dataViewOrder";
            this.dataViewOrder.Size = new System.Drawing.Size(618, 462);
            this.dataViewOrder.TabIndex = 84;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(499, 664);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 46);
            this.btnUpdate.TabIndex = 83;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(365, 665);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 46);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnShow.Location = new System.Drawing.Point(230, 664);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(128, 46);
            this.btnShow.TabIndex = 81;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(202, 561);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(425, 50);
            this.txtTotalPrice.TabIndex = 80;
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.AutoSize = true;
            this.btnTotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPrice.Location = new System.Drawing.Point(78, 574);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(111, 27);
            this.btnTotalPrice.TabIndex = 79;
            this.btnTotalPrice.Text = "Total Price";
            // 
            // txtPlantAmount
            // 
            this.txtPlantAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlantAmount.Location = new System.Drawing.Point(202, 498);
            this.txtPlantAmount.Name = "txtPlantAmount";
            this.txtPlantAmount.Size = new System.Drawing.Size(425, 50);
            this.txtPlantAmount.TabIndex = 78;
            // 
            // lblPlantAmount
            // 
            this.lblPlantAmount.AutoSize = true;
            this.lblPlantAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlantAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantAmount.Location = new System.Drawing.Point(45, 509);
            this.lblPlantAmount.Name = "lblPlantAmount";
            this.lblPlantAmount.Size = new System.Drawing.Size(142, 27);
            this.lblPlantAmount.TabIndex = 77;
            this.lblPlantAmount.Text = "Plant Amount";
            // 
            // txtPlantID
            // 
            this.txtPlantID.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlantID.Location = new System.Drawing.Point(202, 433);
            this.txtPlantID.Name = "txtPlantID";
            this.txtPlantID.Size = new System.Drawing.Size(425, 50);
            this.txtPlantID.TabIndex = 76;
            // 
            // lblPlantID
            // 
            this.lblPlantID.AutoSize = true;
            this.lblPlantID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlantID.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantID.Location = new System.Drawing.Point(101, 446);
            this.lblPlantID.Name = "lblPlantID";
            this.lblPlantID.Size = new System.Drawing.Size(86, 27);
            this.lblPlantID.TabIndex = 75;
            this.lblPlantID.Text = "Plant ID";
            // 
            // rbtnDelivered
            // 
            this.rbtnDelivered.AutoSize = true;
            this.rbtnDelivered.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnDelivered.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDelivered.Location = new System.Drawing.Point(494, 315);
            this.rbtnDelivered.Name = "rbtnDelivered";
            this.rbtnDelivered.Size = new System.Drawing.Size(120, 31);
            this.rbtnDelivered.TabIndex = 74;
            this.rbtnDelivered.TabStop = true;
            this.rbtnDelivered.Text = "Delivered";
            this.rbtnDelivered.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsert.Location = new System.Drawing.Point(93, 664);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 46);
            this.btnInsert.TabIndex = 73;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rbtnInProcess
            // 
            this.rbtnInProcess.AutoSize = true;
            this.rbtnInProcess.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnInProcess.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInProcess.Location = new System.Drawing.Point(348, 316);
            this.rbtnInProcess.Name = "rbtnInProcess";
            this.rbtnInProcess.Size = new System.Drawing.Size(126, 31);
            this.rbtnInProcess.TabIndex = 72;
            this.rbtnInProcess.TabStop = true;
            this.rbtnInProcess.Text = "In Process";
            this.rbtnInProcess.UseVisualStyleBackColor = false;
            // 
            // rbtnPending
            // 
            this.rbtnPending.AutoSize = true;
            this.rbtnPending.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnPending.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPending.Location = new System.Drawing.Point(223, 316);
            this.rbtnPending.Name = "rbtnPending";
            this.rbtnPending.Size = new System.Drawing.Size(108, 31);
            this.rbtnPending.TabIndex = 71;
            this.rbtnPending.TabStop = true;
            this.rbtnPending.Text = "Pending";
            this.rbtnPending.UseVisualStyleBackColor = false;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(202, 367);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(425, 50);
            this.txtCustomerID.TabIndex = 70;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(56, 317);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(132, 27);
            this.lblOrderStatus.TabIndex = 69;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(56, 381);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(131, 27);
            this.lblCustomerID.TabIndex = 68;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(202, 242);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(425, 50);
            this.txtOrderID.TabIndex = 67;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(92, 254);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(95, 27);
            this.lblOrderID.TabIndex = 66;
            this.lblOrderID.Text = "Order ID";
            // 
            // btnAboutme
            // 
            this.btnAboutme.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutme.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutme.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAboutme.Location = new System.Drawing.Point(1126, 37);
            this.btnAboutme.Name = "btnAboutme";
            this.btnAboutme.Size = new System.Drawing.Size(113, 45);
            this.btnAboutme.TabIndex = 92;
            this.btnAboutme.Text = "About me";
            this.btnAboutme.UseVisualStyleBackColor = false;
            this.btnAboutme.Click += new System.EventHandler(this.btnAboutme_Click);
            // 
            // btnAboutOxygen
            // 
            this.btnAboutOxygen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAboutOxygen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutOxygen.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutOxygen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAboutOxygen.Location = new System.Drawing.Point(618, 35);
            this.btnAboutOxygen.Name = "btnAboutOxygen";
            this.btnAboutOxygen.Size = new System.Drawing.Size(153, 45);
            this.btnAboutOxygen.TabIndex = 91;
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
            this.btnOrder.Location = new System.Drawing.Point(498, 35);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 45);
            this.btnOrder.TabIndex = 90;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCustomers.Location = new System.Drawing.Point(355, 35);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(125, 47);
            this.btnCustomers.TabIndex = 89;
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
            this.btnPlants.Location = new System.Drawing.Point(249, 35);
            this.btnPlants.Name = "btnPlants";
            this.btnPlants.Size = new System.Drawing.Size(85, 47);
            this.btnPlants.TabIndex = 88;
            this.btnPlants.Text = "Plants";
            this.btnPlants.UseVisualStyleBackColor = false;
            this.btnPlants.Click += new System.EventHandler(this.btnPlants_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnHome.Location = new System.Drawing.Point(1248, 38);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 44);
            this.btnHome.TabIndex = 93;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // OrderEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 786);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAboutme);
            this.Controls.Add(this.btnAboutOxygen);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnPlants);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataViewOrder);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.txtPlantAmount);
            this.Controls.Add(this.lblPlantAmount);
            this.Controls.Add(this.txtPlantID);
            this.Controls.Add(this.lblPlantID);
            this.Controls.Add(this.rbtnDelivered);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbtnInProcess);
            this.Controls.Add(this.rbtnPending);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderEmployee";
            this.Text = "OrderEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dataViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataViewOrder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label btnTotalPrice;
        private System.Windows.Forms.TextBox txtPlantAmount;
        private System.Windows.Forms.Label lblPlantAmount;
        private System.Windows.Forms.TextBox txtPlantID;
        private System.Windows.Forms.Label lblPlantID;
        private System.Windows.Forms.RadioButton rbtnDelivered;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton rbtnInProcess;
        private System.Windows.Forms.RadioButton rbtnPending;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnAboutme;
        private System.Windows.Forms.Button btnAboutOxygen;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPlants;
        private System.Windows.Forms.Button btnHome;
    }
}