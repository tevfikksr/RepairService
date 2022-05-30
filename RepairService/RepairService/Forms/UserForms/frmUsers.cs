using RepairService.Forms.MainMenu;
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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        public frmUsers(Users takenUser)
        {
            InitializeComponent();
            user = takenUser;

        }
        Users user;
        RepairContext2 db = new RepairContext2();
        private void frmUsers_Load(object sender, EventArgs e)
        {
            var usersData = db.Users.ToList();
            dgvUsers.DataSource = usersData;

            dgvUsers.Columns[7].Visible = false;
            dgvUsers.Columns[6].Visible = false;
            dgvUsers.Columns[5].Visible = false;

            dgvUsers.Columns[0].HeaderText = "NO";
            dgvUsers.Columns[1].HeaderText = "Role ID";
            dgvUsers.Columns[2].HeaderText = "Kullanıcı Adı";
            dgvUsers.Columns[3].HeaderText = "Şifre";
            dgvUsers.Columns[4].HeaderText = "Aktiflik";

            //if (user.RoleId != 1)
            //{
            //    btnDetails.Enabled = false;
            //    dgvUsers.Columns[3].Visible = false;
            //}


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainMenu main = new FrmMainMenu(user);
            main.Show();

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Users wantedUser = dgvUsers.SelectedRows[0].DataBoundItem as Users;
            int id = wantedUser.UserId;

            this.Close();
            frmUserDetails details = new frmUserDetails(user, id);
            details.Show();

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();

            newUser.IsActive = true;
            newUser.UserName = "default";
            newUser.Password = "default";
            newUser.RoleId = 2;

            UserDetails newDetails = new UserDetails();

            newDetails.Name = "default";
            newDetails.Surname = "default";
            newDetails.Salary = 0;

            newUser.UserDetails = newDetails;
            db.Users.Add(newUser);
            db.SaveChanges();

            int newId = newUser.UserId;

            this.Close();
            frmUserDetails userDetails = new frmUserDetails(user, newId);
            userDetails.Show();
        }
    }
}
