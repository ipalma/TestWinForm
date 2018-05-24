using Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForm
{
    public partial class CustomerWindow : Form
    {
        private readonly IService<Customer> _customerService;
        private CustomerAddressWindow customerAddressWindow;
        public CustomerWindow(IService<Customer> customerService)
        {
            InitializeComponent();
            _customerService = customerService;
            LoadDataGridView();
            customerAddressWindow = new CustomerAddressWindow();
        }
        private void LoadDataGridView()
        {

            dgwCustomer.DataSource = _customerService.Get("Customer", "GetCustomers");
        }

        private void dgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCustomer.CurrentRow;

            txtCustomerID.Text = (row.Cells["CustomerID"].Value ?? string.Empty).ToString();
            chkNameStyle.Checked = (bool)row.Cells["NameStyle"].Value;
            txtTitle.Text = (row.Cells["Title"].Value ?? string.Empty).ToString();
            txtFirstName.Text = (row.Cells["FirstName"].Value ?? string.Empty).ToString();
            txtMiddleName.Text = (row.Cells["MiddleName"].Value ?? string.Empty).ToString();
            txtLastName.Text = (row.Cells["LastName"].Value ?? string.Empty).ToString();
            txtSuffix.Text = (row.Cells["Suffix"].Value ?? string.Empty).ToString();
            txtCompanyName.Text = (row.Cells["CompanyName"].Value ?? string.Empty).ToString();
            txtSalesPerson.Text = (row.Cells["SalesPerson"].Value ?? string.Empty).ToString();
            txtEmailAddress.Text = (row.Cells["EmailAddress"].Value ?? string.Empty).ToString();
            txtPhone.Text = (row.Cells["Phone"].Value ?? string.Empty).ToString();
            txtPasswordHash.Text = (row.Cells["PasswordHash"].Value ?? string.Empty).ToString();
            txtPasswordSalt.Text = (row.Cells["PasswordSalt"].Value ?? string.Empty).ToString();
            txtRowguid.Text = (row.Cells["rowguid"].Value ?? string.Empty).ToString();
            dtpModifiedDate.Value = row.Cells["ModifiedDate"].Value != null ? DateTime.Parse(row.Cells["ModifiedDate"].Value.ToString()) : DateTime.Now;
        }

        private void btnCustomerAddress_Click(object sender, EventArgs e)
        {
            var selectedCustomer = _customerService.Get("Customer", "GetCustomer", Convert.ToInt32(txtCustomerID.Text));
            customerAddressWindow.SetCustomerAddress(selectedCustomer.CustomerAddress);
            customerAddressWindow.Show();
        }
    }
}
