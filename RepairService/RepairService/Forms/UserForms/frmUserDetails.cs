using RepairService.Forms.Accounts;
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

namespace RepairService.Forms.UserForms
{
    public partial class frmUserDetails : Form
    {
        public frmUserDetails()
        {
            InitializeComponent();
        }
        public frmUserDetails(Users takenUser)
        {
            InitializeComponent();
            user = takenUser;

        }
        public frmUserDetails(Users takenUser, int userId)
        {
            InitializeComponent();
            user = takenUser;
            detailUser = db.Users.Find(userId);
        }

        Users user;
        Users detailUser;
        RepairContext2 db = new RepairContext2();

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmUsers usersForm = new frmUsers(user);
            this.Close();
            usersForm.Show();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            if (user.UserId != 1)
            {
                btnDelete.Enabled = false;
                btnSave.Enabled = false;
                chkActive.Enabled = false;
            }

            if (detailUser.UserId == 1)
            {
                chkActive.Enabled = false;
            }



            txtUserId.Text = detailUser.UserId.ToString();
            txtUserName.Text = detailUser.UserName;
            txtPassword.Text = detailUser.Password;

            // var rolesData = db.Roles.Where(r=> r.IsActive==true).ToList();                //sadece aktif roller gelir
            var rolesData = db.Roles.ToList();
            cmbRoles.DataSource = rolesData;
            cmbRoles.DisplayMember = "Name";
            cmbRoles.SelectedItem = detailUser.Roles;

            //string role = db.Roles.FirstOrDefault(r=>r.RoleId == detailUser.RoleId).Name;
            //txtRole.Text = role;

            chkActive.Checked = detailUser.IsActive;

            txtName.Text = detailUser.UserDetails.Name;
            txtSurname.Text = detailUser.UserDetails.Surname;
            txtSalary.Text = detailUser.UserDetails.Salary.ToString();

            /* 


             cmbRoles.DisplayMember = "Name";

             foreach (var item in db.Roles)
             {
                 cmbRoles.Items.Add(item);
             }

             cmbRoles.SelectedItem = detailUser.Roles;

            */
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtSurname.Text != "" && txtSalary.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                detailUser.UserName = txtUserName.Text;
                detailUser.Password = txtPassword.Text;
                detailUser.IsActive = chkActive.Checked;

                Roles newRole = cmbRoles.SelectedItem as Roles;
                detailUser.RoleId = newRole.RoleId;
                detailUser.UserDetails.Name = txtName.Text;
                detailUser.UserDetails.Surname = txtSurname.Text;
                detailUser.UserDetails.Salary = Convert.ToDecimal(txtSalary.Text);


                db.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (var item in db.DeviceDetails)
            {
                if (item.UserId == detailUser.UserId)
                {
                    item.UserId = 5;
                }
            }

            db.Users.Remove(detailUser);
            db.SaveChanges();

            frmUsers usersForm = new frmUsers(user);
            this.Close();
            usersForm.Show();
        }
    }
}
