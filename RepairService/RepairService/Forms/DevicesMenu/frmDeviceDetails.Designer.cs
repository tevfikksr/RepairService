namespace RepairService.Forms.DevicesMenu
{
    partial class frmDeviceDetails
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.txtDevRepSta = new System.Windows.Forms.TextBox();
            this.txtDevDesc = new System.Windows.Forms.TextBox();
            this.txtRegDate = new System.Windows.Forms.TextBox();
            this.txtDevModel = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lstFault = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCusSurname = new System.Windows.Forms.TextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbRepStat = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbFaults = new System.Windows.Forms.ComboBox();
            this.btnFault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 53);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 84);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "Id";
            // 
            // txtCusId
            // 
            this.txtCusId.Location = new System.Drawing.Point(12, 110);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(120, 20);
            this.txtCusId.TabIndex = 1;
            this.txtCusId.Text = "Customer";
            // 
            // txtDevRepSta
            // 
            this.txtDevRepSta.Location = new System.Drawing.Point(139, 135);
            this.txtDevRepSta.Name = "txtDevRepSta";
            this.txtDevRepSta.Size = new System.Drawing.Size(120, 20);
            this.txtDevRepSta.TabIndex = 1;
            this.txtDevRepSta.Text = "Repair Status";
            // 
            // txtDevDesc
            // 
            this.txtDevDesc.Location = new System.Drawing.Point(13, 162);
            this.txtDevDesc.Name = "txtDevDesc";
            this.txtDevDesc.Size = new System.Drawing.Size(120, 20);
            this.txtDevDesc.TabIndex = 1;
            this.txtDevDesc.Text = "Description";
            // 
            // txtRegDate
            // 
            this.txtRegDate.Location = new System.Drawing.Point(12, 188);
            this.txtRegDate.Name = "txtRegDate";
            this.txtRegDate.Size = new System.Drawing.Size(120, 20);
            this.txtRegDate.TabIndex = 1;
            this.txtRegDate.Text = "Register Date";
            // 
            // txtDevModel
            // 
            this.txtDevModel.Location = new System.Drawing.Point(13, 214);
            this.txtDevModel.Name = "txtDevModel";
            this.txtDevModel.Size = new System.Drawing.Size(120, 20);
            this.txtDevModel.TabIndex = 1;
            this.txtDevModel.Text = "Model";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(140, 242);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(120, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "User";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(138, 188);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 2;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lstFault
            // 
            this.lstFault.FormattingEnabled = true;
            this.lstFault.Location = new System.Drawing.Point(14, 268);
            this.lstFault.Name = "lstFault";
            this.lstFault.Size = new System.Drawing.Size(120, 56);
            this.lstFault.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 54);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Edit and Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCusSurname
            // 
            this.txtCusSurname.Location = new System.Drawing.Point(139, 109);
            this.txtCusSurname.Name = "txtCusSurname";
            this.txtCusSurname.Size = new System.Drawing.Size(120, 20);
            this.txtCusSurname.TabIndex = 5;
            this.txtCusSurname.Text = "Surname";
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(13, 241);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 6;
            // 
            // cmbRepStat
            // 
            this.cmbRepStat.FormattingEnabled = true;
            this.cmbRepStat.Location = new System.Drawing.Point(12, 137);
            this.cmbRepStat.Name = "cmbRepStat";
            this.cmbRepStat.Size = new System.Drawing.Size(121, 21);
            this.cmbRepStat.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 54);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Device";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbFaults
            // 
            this.cmbFaults.FormattingEnabled = true;
            this.cmbFaults.Location = new System.Drawing.Point(14, 331);
            this.cmbFaults.Name = "cmbFaults";
            this.cmbFaults.Size = new System.Drawing.Size(121, 21);
            this.cmbFaults.TabIndex = 9;
            // 
            // btnFault
            // 
            this.btnFault.Location = new System.Drawing.Point(142, 331);
            this.btnFault.Name = "btnFault";
            this.btnFault.Size = new System.Drawing.Size(118, 23);
            this.btnFault.TabIndex = 10;
            this.btnFault.Text = "Add Fault";
            this.btnFault.UseVisualStyleBackColor = true;
            this.btnFault.Click += new System.EventHandler(this.btnFault_Click);
            // 
            // frmDeviceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFault);
            this.Controls.Add(this.cmbFaults);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbRepStat);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.txtCusSurname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstFault);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDevModel);
            this.Controls.Add(this.txtRegDate);
            this.Controls.Add(this.txtDevDesc);
            this.Controls.Add(this.txtDevRepSta);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmDeviceDetails";
            this.Text = "frmDeviceDetails";
            this.Load += new System.EventHandler(this.frmDeviceDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.TextBox txtDevRepSta;
        private System.Windows.Forms.TextBox txtDevDesc;
        private System.Windows.Forms.TextBox txtRegDate;
        private System.Windows.Forms.TextBox txtDevModel;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ListBox lstFault;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCusSurname;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbRepStat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbFaults;
        private System.Windows.Forms.Button btnFault;
    }
}