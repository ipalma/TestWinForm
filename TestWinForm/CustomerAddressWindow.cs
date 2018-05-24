using Models;
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
    public partial class CustomerAddressWindow : Form
    {
        private List<CustomerAddress> customerAddressList;
        public CustomerAddressWindow()
        {
            InitializeComponent();
            
        }

        private void LoadDataGridView()
        {
            List<Address> addresses = new List<Address>();

            addresses.AddRange(customerAddressList.Select(x => x.Address));

            dgwCustomerAddress.DataSource = addresses;
        }

        public void SetCustomerAddress(ICollection<CustomerAddress> cAddresses)
        {
            customerAddressList = new List<CustomerAddress>();
            if (cAddresses.Any())
                customerAddressList.AddRange(cAddresses);
            LoadDataGridView();
        }
    }
}
