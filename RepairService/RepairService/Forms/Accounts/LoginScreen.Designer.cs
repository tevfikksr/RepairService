
namespace RepairService.Forms.Accounts
{
    partial class LoginScreen
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(305, 92);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(142, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Tevfik";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(305, 128);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(213, 203);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 71);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(305, 169);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(361, 203);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(142, 71);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer Login";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCustomer;
    }
}