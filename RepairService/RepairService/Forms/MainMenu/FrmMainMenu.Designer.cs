
namespace RepairService.Forms.MainMenu
{
    partial class FrmMainMenu
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnFault = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(29, 34);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 45);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(604, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(29, 160);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(99, 265);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(607, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // btnFault
            // 
            this.btnFault.Location = new System.Drawing.Point(155, 160);
            this.btnFault.Name = "btnFault";
            this.btnFault.Size = new System.Drawing.Size(99, 265);
            this.btnFault.TabIndex = 4;
            this.btnFault.Text = "Fault Record";
            this.btnFault.UseVisualStyleBackColor = true;
            this.btnFault.Click += new System.EventHandler(this.btnFault_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(281, 160);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(99, 265);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnFault);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnReturn);
            this.Name = "FrmMainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnFault;
        private System.Windows.Forms.Button btnCustomer;
    }
}