namespace RepairService.Forms.DevicesMenu
{
    partial class frmDevices
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
            this.dgvDevices = new System.Windows.Forms.DataGridView();
            this.lstFaults = new System.Windows.Forms.ListBox();
            this.cmbRepairStat = new System.Windows.Forms.ComboBox();
            this.cmbFault = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbRepairMan = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusSurname = new System.Windows.Forms.TextBox();
            this.txtCusPassword = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFault = new System.Windows.Forms.TextBox();
            this.btnFault = new System.Windows.Forms.Button();
            this.txtFaultId = new System.Windows.Forms.TextBox();
            this.cmbRepair = new System.Windows.Forms.ComboBox();
            this.btnEditRep = new System.Windows.Forms.Button();
            this.btnRepairAdd = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.txtRepId = new System.Windows.Forms.TextBox();
            this.btnRemoveRep = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.chkNew = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDevices
            // 
            this.dgvDevices.AllowUserToAddRows = false;
            this.dgvDevices.AllowUserToDeleteRows = false;
            this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevices.Location = new System.Drawing.Point(12, 345);
            this.dgvDevices.Name = "dgvDevices";
            this.dgvDevices.ReadOnly = true;
            this.dgvDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevices.Size = new System.Drawing.Size(644, 144);
            this.dgvDevices.TabIndex = 0;
            // 
            // lstFaults
            // 
            this.lstFaults.FormattingEnabled = true;
            this.lstFaults.Location = new System.Drawing.Point(12, 87);
            this.lstFaults.Name = "lstFaults";
            this.lstFaults.Size = new System.Drawing.Size(169, 147);
            this.lstFaults.TabIndex = 1;
            // 
            // cmbRepairStat
            // 
            this.cmbRepairStat.FormattingEnabled = true;
            this.cmbRepairStat.Location = new System.Drawing.Point(188, 123);
            this.cmbRepairStat.Name = "cmbRepairStat";
            this.cmbRepairStat.Size = new System.Drawing.Size(121, 21);
            this.cmbRepairStat.TabIndex = 2;
            // 
            // cmbFault
            // 
            this.cmbFault.FormattingEnabled = true;
            this.cmbFault.Location = new System.Drawing.Point(188, 87);
            this.cmbFault.Name = "cmbFault";
            this.cmbFault.Size = new System.Drawing.Size(121, 21);
            this.cmbFault.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(462, 319);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(662, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 88);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cihazın ayrıntıları formu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 10);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(143, 71);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbRepairMan
            // 
            this.cmbRepairMan.FormattingEnabled = true;
            this.cmbRepairMan.Location = new System.Drawing.Point(188, 163);
            this.cmbRepairMan.Name = "cmbRepairMan";
            this.cmbRepairMan.Size = new System.Drawing.Size(121, 21);
            this.cmbRepairMan.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(188, 61);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 7;
            this.txtModel.Text = "Model";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(329, 163);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 241);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 87);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "Description";
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(485, 90);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(145, 20);
            this.txtCusEmail.TabIndex = 64;
            this.txtCusEmail.Text = "Email";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(485, 142);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(145, 20);
            this.txtCusPhone.TabIndex = 66;
            this.txtCusPhone.Text = "Phone";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(485, 38);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(145, 20);
            this.txtCusName.TabIndex = 61;
            this.txtCusName.Text = "Name";
            // 
            // txtCusSurname
            // 
            this.txtCusSurname.Location = new System.Drawing.Point(485, 64);
            this.txtCusSurname.Name = "txtCusSurname";
            this.txtCusSurname.Size = new System.Drawing.Size(145, 20);
            this.txtCusSurname.TabIndex = 63;
            this.txtCusSurname.Text = "Surname";
            // 
            // txtCusPassword
            // 
            this.txtCusPassword.Location = new System.Drawing.Point(485, 116);
            this.txtCusPassword.Name = "txtCusPassword";
            this.txtCusPassword.Size = new System.Drawing.Size(145, 20);
            this.txtCusPassword.TabIndex = 65;
            this.txtCusPassword.Text = "Password";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(485, 168);
            this.txtCusAddress.Multiline = true;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(145, 119);
            this.txtCusAddress.TabIndex = 67;
            this.txtCusAddress.Text = "Address";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1017, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 75);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFault
            // 
            this.txtFault.Location = new System.Drawing.Point(983, 319);
            this.txtFault.Name = "txtFault";
            this.txtFault.Size = new System.Drawing.Size(100, 20);
            this.txtFault.TabIndex = 68;
            this.txtFault.Text = "AddFault";
            // 
            // btnFault
            // 
            this.btnFault.Location = new System.Drawing.Point(983, 341);
            this.btnFault.Name = "btnFault";
            this.btnFault.Size = new System.Drawing.Size(100, 23);
            this.btnFault.TabIndex = 69;
            this.btnFault.Text = "Add Fault";
            this.btnFault.UseVisualStyleBackColor = true;
            this.btnFault.Click += new System.EventHandler(this.btnFault_Click);
            // 
            // txtFaultId
            // 
            this.txtFaultId.Location = new System.Drawing.Point(1089, 319);
            this.txtFaultId.Name = "txtFaultId";
            this.txtFaultId.Size = new System.Drawing.Size(100, 20);
            this.txtFaultId.TabIndex = 68;
            this.txtFaultId.Text = "FaultId";
            // 
            // cmbRepair
            // 
            this.cmbRepair.FormattingEnabled = true;
            this.cmbRepair.Location = new System.Drawing.Point(983, 383);
            this.cmbRepair.Name = "cmbRepair";
            this.cmbRepair.Size = new System.Drawing.Size(100, 21);
            this.cmbRepair.TabIndex = 70;
            this.cmbRepair.SelectedIndexChanged += new System.EventHandler(this.cmbRepair_SelectedIndexChanged);
            // 
            // btnEditRep
            // 
            this.btnEditRep.Location = new System.Drawing.Point(983, 433);
            this.btnEditRep.Name = "btnEditRep";
            this.btnEditRep.Size = new System.Drawing.Size(100, 23);
            this.btnEditRep.TabIndex = 71;
            this.btnEditRep.Text = "Repair Edit";
            this.btnEditRep.UseVisualStyleBackColor = true;
            this.btnEditRep.Click += new System.EventHandler(this.btnEditRep_Click);
            // 
            // btnRepairAdd
            // 
            this.btnRepairAdd.Location = new System.Drawing.Point(1089, 433);
            this.btnRepairAdd.Name = "btnRepairAdd";
            this.btnRepairAdd.Size = new System.Drawing.Size(100, 23);
            this.btnRepairAdd.TabIndex = 71;
            this.btnRepairAdd.Text = "Repair Add ";
            this.btnRepairAdd.UseVisualStyleBackColor = true;
            this.btnRepairAdd.Click += new System.EventHandler(this.btnRepairAdd_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(983, 407);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEdit.TabIndex = 72;
            this.txtEdit.Text = "edit";
            // 
            // txtRepId
            // 
            this.txtRepId.Location = new System.Drawing.Point(1089, 408);
            this.txtRepId.Name = "txtRepId";
            this.txtRepId.Size = new System.Drawing.Size(100, 20);
            this.txtRepId.TabIndex = 68;
            this.txtRepId.Text = "RepairId";
            // 
            // btnRemoveRep
            // 
            this.btnRemoveRep.Location = new System.Drawing.Point(983, 463);
            this.btnRemoveRep.Name = "btnRemoveRep";
            this.btnRemoveRep.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveRep.TabIndex = 73;
            this.btnRemoveRep.Text = "Repair Delete";
            this.btnRemoveRep.UseVisualStyleBackColor = true;
            this.btnRemoveRep.Click += new System.EventHandler(this.btnRemoveRep_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(485, 11);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomer.TabIndex = 74;
            // 
            // chkNew
            // 
            this.chkNew.AutoSize = true;
            this.chkNew.Location = new System.Drawing.Point(625, 10);
            this.chkNew.Name = "chkNew";
            this.chkNew.Size = new System.Drawing.Size(95, 17);
            this.chkNew.TabIndex = 75;
            this.chkNew.Text = "New Customer";
            this.chkNew.UseVisualStyleBackColor = true;
            this.chkNew.CheckedChanged += new System.EventHandler(this.chkNew_CheckedChanged);
            // 
            // frmDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 501);
            this.Controls.Add(this.chkNew);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnRemoveRep);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnRepairAdd);
            this.Controls.Add(this.btnEditRep);
            this.Controls.Add(this.cmbRepair);
            this.Controls.Add(this.btnFault);
            this.Controls.Add(this.txtRepId);
            this.Controls.Add(this.txtFaultId);
            this.Controls.Add(this.txtFault);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCusAddress);
            this.Controls.Add(this.txtCusPassword);
            this.Controls.Add(this.txtCusSurname);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.txtCusEmail);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cmbRepairMan);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbFault);
            this.Controls.Add(this.cmbRepairStat);
            this.Controls.Add(this.lstFaults);
            this.Controls.Add(this.dgvDevices);
            this.Name = "frmDevices";
            this.Text = "frmDevices";
            this.Load += new System.EventHandler(this.frmDevices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDevices;
        private System.Windows.Forms.ListBox lstFaults;
        private System.Windows.Forms.ComboBox cmbRepairStat;
        private System.Windows.Forms.ComboBox cmbFault;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbRepairMan;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusSurname;
        private System.Windows.Forms.TextBox txtCusPassword;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFault;
        private System.Windows.Forms.Button btnFault;
        private System.Windows.Forms.TextBox txtFaultId;
        private System.Windows.Forms.ComboBox cmbRepair;
        private System.Windows.Forms.Button btnEditRep;
        private System.Windows.Forms.Button btnRepairAdd;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.TextBox txtRepId;
        private System.Windows.Forms.Button btnRemoveRep;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.CheckBox chkNew;
    }
}