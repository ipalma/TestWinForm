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
        public Form1(IService<Address> address)
        {
            InitializeComponent();
            _address = address;
        }

        private void AccessAddress(object sender, EventArgs e)
        {
            AddressWindow address = new AddressWindow(_address);
            address.Show();
        }
    }
}
