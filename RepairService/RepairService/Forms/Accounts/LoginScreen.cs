using RepairService.Models.Entities;
using RepairService.Forms.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairService.Forms.CustomersForm;

namespace RepairService.Forms.Accounts
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            lblLogin.ForeColor = Color.Black;
        }

            RepairContext2 database = new RepairContext2();

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string username = txtUserName.Text;
            string password = txtPassword.Text;

            Users user = database.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (user == null)
            {
                lblLogin.ForeColor = Color.Red;
                lblLogin.Text = "User Not Found";
            }
            else
            {
                if (user.IsActive)
                {
                    if (LoginCheck.isFirst)
                    {
                        FrmMainMenu mainMenu = new FrmMainMenu(user);
                        this.Hide();
                        mainMenu.Show();
                        LoginCheck.isFirst = false;


                    }
                    else
                    {
                        FrmMainMenu mainMenu = new FrmMainMenu(user);
                        this.Close();
                        mainMenu.Show();
                    }

                }
                else
                {
                    lblLogin.ForeColor = Color.Red;
                    lblLogin.Text = "User is blocked from login";
                }
            }

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUserName.Text != "")
            {
                Customers loginCustomer = database.Customers.FirstOrDefault(c => c.CustomerDetails.Name == txtUserName.Text && c.Password == txtPassword.Text);
                if (loginCustomer != null)
                {
                    if (loginCustomer.IsActive != false)
                    {
                        frmCustomers menu = new frmCustomers(loginCustomer);
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hesabınız kullanıma açık değildir");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı");
                }
            }
        }
    }
}
