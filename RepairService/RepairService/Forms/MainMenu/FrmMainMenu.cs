using RepairService.Forms.Accounts;
using RepairService.Forms.CustomersForm;
using RepairService.Forms.DevicesMenu;
using RepairService.Forms.UserForms;
using RepairService.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairService.Forms.MainMenu
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }


        public FrmMainMenu(Users takenUser)
        {
            InitializeComponent();
            user = takenUser;
            lblUser.Text = user.UserName + " - " + user.Roles.Name;
            lblDate.Text = DateTime.Now.ToString("dd MM yy");
        }


        Users user;
        public LoginScreen login;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();

            this.Close();
            login.Show();
        }
        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUsers userForm = new frmUsers(user);
            userForm.Show();
            
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            frmDevices dvcform = new frmDevices(user);
            dvcform.Show();
            this.Close();
        }



        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            //if (user.RoleId != 1)
            //{
            //    btnUsers.Enabled = false;
            //}
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomersDetail detail = new frmCustomersDetail(user);
            detail.Show();
            this.Close();
        }
    }
}
