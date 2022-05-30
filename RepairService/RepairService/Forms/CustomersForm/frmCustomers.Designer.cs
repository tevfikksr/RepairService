namespace RepairService.Forms.CustomersForm
{
    partial class frmCustomers
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
            this.dgvDeviceData = new System.Windows.Forms.DataGridView();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRepair = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeviceData
            // 
            this.dgvDeviceData.AllowUserToAddRows = false;
            this.dgvDeviceData.AllowUserToDeleteRows = false;
            this.dgvDeviceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceData.Location = new System.Drawing.Point(12, 85);
            this.dgvDeviceData.Name = "dgvDeviceData";
            this.dgvDeviceData.ReadOnly = true;
            this.dgvDeviceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeviceData.Size = new System.Drawing.Size(563, 182);
            this.dgvDeviceData.TabIndex = 0;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Location = new System.Drawing.Point(648, 9);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(35, 13);
            this.LblCustomer.TabIndex = 1;
            this.LblCustomer.Text = "label1";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(107, 67);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(606, 85);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(105, 61);
            this.btnDetail.TabIndex = 3;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 273);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // txtRepair
            // 
            this.txtRepair.Location = new System.Drawing.Point(12, 299);
            this.txtRepair.Name = "txtRepair";
            this.txtRepair.Size = new System.Drawing.Size(100, 20);
            this.txtRepair.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 325);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(12, 352);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 5;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtRepair);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.dgvDeviceData);
            this.Name = "frmCustomers";
            this.Text = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeviceData;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRepair;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDate;
    }
}