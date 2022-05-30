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

namespace RepairService.Forms.CustomersForm
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        public frmCustomers(Customers takenCustomers)
        {
            InitializeComponent();
            customer = takenCustomers;
        }

        Customers customer;
        RepairContext2 db = new RepairContext2();

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            LblCustomer.Text = customer.CustomerDetails.Name + " " + customer.CustomerDetails.Surname;

            var deviceData = db.Devices.Where(d => d.DeviceDetails.CustomerId == customer.CustomerId).ToList();
            dgvDeviceData.DataSource = deviceData;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen login = new LoginScreen();
            login.Show();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Devices selected = dgvDeviceData.SelectedRows[0].DataBoundItem as Devices;

            txtDescription.Text = selected.DeviceDetails.Description;
            txtRepair.Text = selected.DeviceDetails.RepairStatuses.RepairStatus;
            txtUser.Text = selected.DeviceDetails.Users.UserName;
            txtDate.Text = selected.DeviceDetails.RegisterDate.ToShortDateString();
        }
    }
}
