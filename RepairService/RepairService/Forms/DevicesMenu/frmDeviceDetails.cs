using RepairService.Models.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairService.Forms.DevicesMenu
{
    public partial class frmDeviceDetails : Form
    {
        public frmDeviceDetails()
        {
            InitializeComponent();
        }

        public frmDeviceDetails(Users takenUser1)
        {
            InitializeComponent();
            user = takenUser1;
        }

        public frmDeviceDetails(Users takenUser, Devices takenDevice)
        {
            InitializeComponent();
            user = takenUser;
            device = db.Devices.Find(takenDevice.DeviceId); // find metodunu primary key ile yapıyoruz!!
        }

        RepairContext2 db = new RepairContext2();
        Users user;
        Devices device;

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDevices frmdvc = new frmDevices(user);
            frmdvc.Show();
        }

        private void frmDeviceDetails_Load(object sender, EventArgs e)
        {
            var us = db.Users.ToList();
            cmbUser.DataSource = us;
            cmbUser.DisplayMember = "UserName";

            var repSta = db.RepairStatuses.ToList();
            cmbRepStat.DataSource = repSta;
            cmbRepStat.DisplayMember = "RepairStatus";

            int x = device.DeviceDetails.Users.UserId;                          //find metodunu primary key ile çalıştırdık :)
            Users finUser = db.Users.Find(x);
            cmbUser.SelectedItem = finUser;

            int y = device.DeviceDetails.RepairStatusId;
            RepairStatuses findRep = db.RepairStatuses.Find(y);
            cmbRepStat.SelectedItem = findRep;


            txtId.Text = device.DeviceId.ToString();
            txtCusId.Text = device.DeviceDetails.Customers.CustomerDetails.Name;
            txtCusSurname.Text = device.DeviceDetails.Customers.CustomerDetails.Surname;
            txtDevDesc.Text = device.DeviceDetails.Description;
            txtDevModel.Text = device.Model;
            txtUser.Text = device.DeviceDetails.Users.UserName;
            txtDevRepSta.Text = device.DeviceDetails.RepairStatuses.RepairStatus;
            txtRegDate.Text = device.DeviceDetails.RegisterDate.ToShortDateString();
            chkIsActive.Checked = device.IsActive;

            foreach (var fault in db.FaultTypes)
            {
                cmbFaults.Items.Add(fault);
            }
            cmbFaults.DisplayMember = "FaultName";
            lstFault.DisplayMember = "FaultName";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            device.DeviceDetails.Customers.CustomerDetails.Name = txtCusId.Text;
            device.DeviceDetails.Customers.CustomerDetails.Surname = txtCusSurname.Text;
            device.DeviceDetails.Description = txtDevDesc.Text;
            device.Model = txtDevModel.Text;
            device.IsActive = chkIsActive.Checked;

            var x = cmbUser.SelectedItem as Users;
            device.DeviceDetails.Users = x as Users;

            var y = cmbRepStat.SelectedItem as RepairStatuses;
            device.DeviceDetails.RepairStatuses = y as RepairStatuses;

            device.FaultTypes.Clear();
            foreach (var fault in lstFault.Items)
            {
                device.FaultTypes.Add(fault as FaultTypes);
            }

            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Question = MessageBox.Show("are you sure ?","WARNING",MessageBoxButtons.YesNo);

            device.FaultTypes.Clear();
            db.Devices.Remove(device);
            db.SaveChanges();
 
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            if (cmbFaults.SelectedIndex != -1 && !lstFault.Items.Contains(cmbFaults.SelectedItem))
            {
                lstFault.Items.Add(cmbFaults.SelectedItem);
            }
            else
            {
                MessageBox.Show("Hatalı işlem!");
            }
        }
    }
}
