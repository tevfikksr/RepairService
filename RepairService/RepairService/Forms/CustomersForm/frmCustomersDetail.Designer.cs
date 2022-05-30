namespace RepairService.Forms.CustomersForm
{
    partial class frmCustomersDetail
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusSurname = new System.Windows.Forms.TextBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtCusMail = new System.Windows.Forms.TextBox();
            this.txtCusAdress = new System.Windows.Forms.TextBox();
            this.txtCusPassword = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(12, 12);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(121, 251);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // txtCusId
            // 
            this.txtCusId.Location = new System.Drawing.Point(157, 13);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(100, 20);
            this.txtCusId.TabIndex = 1;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(157, 39);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(100, 20);
            this.txtCusName.TabIndex = 1;
            // 
            // txtCusSurname
            // 
            this.txtCusSurname.Location = new System.Drawing.Point(157, 65);
            this.txtCusSurname.Name = "txtCusSurname";
            this.txtCusSurname.Size = new System.Drawing.Size(100, 20);
            this.txtCusSurname.TabIndex = 1;
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(157, 91);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCusPhone.TabIndex = 1;
            // 
            // txtCusMail
            // 
            this.txtCusMail.Location = new System.Drawing.Point(157, 117);
            this.txtCusMail.Name = "txtCusMail";
            this.txtCusMail.Size = new System.Drawing.Size(100, 20);
            this.txtCusMail.TabIndex = 1;
            // 
            // txtCusAdress
            // 
            this.txtCusAdress.Location = new System.Drawing.Point(157, 143);
            this.txtCusAdress.Name = "txtCusAdress";
            this.txtCusAdress.Size = new System.Drawing.Size(100, 20);
            this.txtCusAdress.TabIndex = 1;
            // 
            // txtCusPassword
            // 
            this.txtCusPassword.Location = new System.Drawing.Point(157, 169);
            this.txtCusPassword.Name = "txtCusPassword";
            this.txtCusPassword.Size = new System.Drawing.Size(100, 20);
            this.txtCusPassword.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(157, 195);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(157, 221);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 1;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(296, 15);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 2;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(296, 37);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(121, 21);
            this.cmbDevices.TabIndex = 3;
            // 
            // frmCustomersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtCusPassword);
            this.Controls.Add(this.txtCusAdress);
            this.Controls.Add(this.txtCusMail);
            this.Controls.Add(this.txtCusPhone);
            this.Controls.Add(this.txtCusSurname);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.lstCustomers);
            this.Name = "frmCustomersDetail";
            this.Text = "frmCustomersDetail";
            this.Load += new System.EventHandler(this.frmCustomersDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusSurname;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.TextBox txtCusMail;
        private System.Windows.Forms.TextBox txtCusAdress;
        private System.Windows.Forms.TextBox txtCusPassword;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ComboBox cmbDevices;
    }
}