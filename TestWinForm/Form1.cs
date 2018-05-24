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
    public partial class Form1 : Form
    {
        private readonly IService<Address> _address;
        private readonly IService<Customer> _customer;
        public Form1(IService<Address> address
            , IService<Customer> customer)
        {
            InitializeComponent();
            _address = address;
            _customer = customer;
        }

        private void AccessAddress(object sender, EventArgs e)
        {
            AddressWindow address = new AddressWindow(_address);
            address.Show();
        }

        private void AccessCustomer(object sender, EventArgs e)
        {
            CustomerWindow customer = new CustomerWindow(_customer);
            customer.Show();
        }
    }
}
