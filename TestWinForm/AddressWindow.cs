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
    public partial class AddressWindow : Form
    {
        private readonly IService<Address> _service;

        public AddressWindow(IService<Address> service)
        {
            
            InitializeComponent();
            _service = service;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {

            addressBindingSource.DataSource = _service.Get("Address","GetAddresses");
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count != 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtAddressID.Text = (row.Cells[0].Value ?? string.Empty).ToString();
                txtAddressLine1.Text = (row.Cells[1].Value ?? string.Empty).ToString();
                txtAddressLine2.Text = (row.Cells[2].Value ?? string.Empty).ToString();
                txtCity.Text = (row.Cells[3].Value ?? string.Empty).ToString();
                txtStateProvince.Text = (row.Cells[4].Value ?? string.Empty).ToString();
                txtCountryRegion.Text = (row.Cells[5].Value ?? string.Empty).ToString();
                txtPostalCode.Text = (row.Cells[6].Value ?? string.Empty).ToString();
                dtpModifiedDate.Value = row.Cells[8].Value != null ? DateTime.Parse(row.Cells[8].Value.ToString()) : DateTime.Now;
            }

        }
    }
}
