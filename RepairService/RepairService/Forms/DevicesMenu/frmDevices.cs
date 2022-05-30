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

namespace RepairService.Forms.DevicesMenu
{
    public partial class frmDevices : Form
    {
        public frmDevices()
        {
            InitializeComponent();
        }

        public frmDevices(Users takenUser)
        {
            InitializeComponent();
            user = takenUser;
        }

        Users user;
        RepairContext2 db = new RepairContext2();

        private void frmDevices_Load(object sender, EventArgs e)
        {
            lstFaults.DisplayMember = "FaultName";

            Fault();
            Repair();
            RepairMan();

            var deviceData = db.Devices.ToList();
            dgvDevices.DataSource = deviceData;

            dgvDevices.Columns.RemoveAt(3);
            dgvDevices.Columns.RemoveAt(2);

            dgvDevices.Columns.Add("Repair Statuses", "Situation");
            dgvDevices.Columns.Add("Users", "Repairman");
            dgvDevices.Columns.Add("Customer", "Customer");


            for (int i = 0; i < dgvDevices.RowCount; i++)
            {
                Devices device = dgvDevices.Rows[i].DataBoundItem as Devices;
                dgvDevices.Rows[i].Cells[3].Value = device.DeviceDetails.RepairStatuses.RepairStatus;
                dgvDevices.Rows[i].Cells[4].Value = device.DeviceDetails.Users.UserName;
                dgvDevices.Rows[i].Cells[5].Value = device.DeviceDetails.Customers.CustomerDetails.Name;

            }

            var Repair1 = db.RepairStatuses.ToList();
            cmbRepair.DataSource = Repair1;
            cmbRepair.DisplayMember = "RepairStatus";

            var custom = db.CustomerDetails.ToList();
            cmbCustomer.DataSource = custom;
            cmbCustomer.DisplayMember = "Name";

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var searchData = db.Devices.Where(d => d.Model.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
                dgvDevices.DataSource = searchData;
            }
            else
            {
                var deviceData = db.Devices.ToList();
                dgvDevices.DataSource = deviceData;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainMenu main = new FrmMainMenu(user);
            main.Show();
        }

        void Fault()
        {
            var faultType = db.FaultTypes.ToList();
            cmbFault.DataSource = faultType;
            cmbFault.DisplayMember = "FaultName";
        }

        void Repair()
        {
            var repairStat = db.RepairStatuses.ToList();
            cmbRepairStat.DataSource = repairStat;
            cmbRepairStat.DisplayMember = "RepairStatus";

        }

        void RepairMan()
        {
            var repairMan = db.Users.Where(w => w.IsActive == true && w.RoleId == 2).ToList();        //*************
            cmbRepairMan.DataSource = repairMan;
            cmbRepairMan.DisplayMember = "UserName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Devices newDevice = new Devices();

            newDevice.Model = txtModel.Text;
            newDevice.IsActive = true;

            DeviceDetails detail = new DeviceDetails();

            detail.Description = txtDescription.Text;
            detail.RegisterDate = DateTime.Now;
            detail.RepairStatuses = db.RepairStatuses.First();
            detail.Users = cmbRepairMan.SelectedItem as Users;

            foreach (var fault in lstFaults.Items)
            {
                newDevice.FaultTypes.Add(fault as FaultTypes);
            }

            if (chkNew.Checked)
            {
                CustomerDetails Cdetail = new CustomerDetails();

                Cdetail.Adress = txtCusAddress.Text;
                Cdetail.Name = txtCusName.Text;
                Cdetail.Surname = txtCusSurname.Text;
                Cdetail.Phone = txtCusPhone.Text;

                Customers customer = new Customers();

                customer.Email = txtCusEmail.Text;
                customer.Password = txtCusPassword.Text;


                customer.CustomerDetails = Cdetail;
                detail.Customers = customer;
                newDevice.DeviceDetails = detail;


                db.Devices.Add(newDevice);
                db.Customers.Add(customer);
                db.SaveChanges(); 
            }
            else
            {
                Customers addCustom = db.Customers.Find((cmbCustomer.SelectedItem as CustomerDetails).CustomerId);
                addCustom.DeviceDetails.Add(detail);
                db.Devices.Add(newDevice);
                db.SaveChanges();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbFault.SelectedIndex != -1 && !lstFaults.Items.Contains(cmbFault.SelectedItem))
            {
                lstFaults.Items.Add(cmbFault.SelectedItem);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstFaults.SelectedIndex != -1)
            {
                lstFaults.Items.RemoveAt(lstFaults.SelectedIndex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstFaults.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Devices selectedDevice = dgvDevices.SelectedRows[0].DataBoundItem as Devices;

            this.Close();
            frmDeviceDetails dvcdetail = new frmDeviceDetails(user, selectedDevice);
            dvcdetail.Show();
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            FaultTypes newFault = new FaultTypes();
            newFault.FaultName = txtFault.Text;

            db.FaultTypes.Add(newFault);
            db.SaveChanges();

        }

        private void btnEditRep_Click(object sender, EventArgs e)
        {
            RepairStatuses statuses = db.RepairStatuses.Find((cmbRepair.SelectedItem as RepairStatuses).RepairStatusId);
            statuses.RepairStatus = txtEdit.Text;

            db.SaveChanges();

        }

        private void cmbRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEdit.Text = cmbRepair.Text;
        }

        private void btnRepairAdd_Click(object sender, EventArgs e)
        {
            RepairStatuses newRep = new RepairStatuses();
            newRep.IsActive = true;
            newRep.RepairStatus = txtEdit.Text;

            db.RepairStatuses.Add(newRep);
            db.SaveChanges();
        }

        private void btnRemoveRep_Click(object sender, EventArgs e)
        {
            RepairStatuses delRep = db.RepairStatuses.Find((cmbRepair.SelectedItem as RepairStatuses).RepairStatusId);

            foreach (var item in db.DeviceDetails)
            {
                if (item.RepairStatusId == delRep.RepairStatusId)
                {
                    item.RepairStatusId = Convert.ToInt32(txtRepId.Text);
                }
            }

            db.RepairStatuses.Remove(delRep);

            db.SaveChanges();
        }

        private void chkNew_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNew.Checked)
            {
                cmbCustomer.SelectedIndex = -1;
                cmbCustomer.Enabled = false;
            }
            else
            {
                cmbCustomer.Enabled=true;
            }
        }
    }
}
