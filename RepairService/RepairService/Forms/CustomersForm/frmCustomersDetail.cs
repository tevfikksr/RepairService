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
    public partial class frmCustomersDetail : Form
    {
        public frmCustomersDetail()
        {
            InitializeComponent();
        }

        public frmCustomersDetail(Users takenUser)
        {
            InitializeComponent();
            user = takenUser;
        }

        Users user;
        RepairContext2 db = new RepairContext2();

        private void frmCustomersDetail_Load(object sender, EventArgs e)
        {
            var custom = db.Customers.ToList();
            //lstCustomers.DataSource = custom;
            custom.ForEach(x => lstCustomers.Items.Add(x));
            lstCustomers.DisplayMember = "Name";

        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customers selected = lstCustomers.SelectedItem as Customers;

            txtCusName.Text = selected.CustomerDetails.Name;
            txtCusSurname.Text = selected.CustomerDetails.Surname;
            txtCusId.Text = selected.CustomerId.ToString();
            txtCusAdress.Text = selected.CustomerDetails.Adress;
            txtCusMail.Text = selected.Email;
            txtCusPhone.Text = selected.CustomerDetails.Phone;
            txtCusPassword.Text = selected.Password;
            chkIsActive.Checked = selected.IsActive;

            var device = db.Devices.Where(x => x.DeviceDetails.CustomerId == selected.CustomerId).ToList();

            cmbDevices.DataSource = device;
            cmbDevices.DisplayMember = "Model";

        }
    }
}
