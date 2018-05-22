namespace TestWinForm
{
    partial class AddressWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderHeaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderHeader1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAddressID = new System.Windows.Forms.Label();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStateProvince = new System.Windows.Forms.Label();
            this.lblCountryRegion = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.txtAddressID = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStateProvince = new System.Windows.Forms.TextBox();
            this.txtCountryRegion = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.dtpModifiedDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressIDDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateProvinceDataGridViewTextBoxColumn,
            this.countryRegionDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.salesOrderHeaderDataGridViewTextBoxColumn,
            this.salesOrderHeader1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 595);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // addressIDDataGridViewTextBoxColumn
            // 
            this.addressIDDataGridViewTextBoxColumn.DataPropertyName = "AddressID";
            this.addressIDDataGridViewTextBoxColumn.HeaderText = "AddressID";
            this.addressIDDataGridViewTextBoxColumn.Name = "addressIDDataGridViewTextBoxColumn";
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateProvinceDataGridViewTextBoxColumn
            // 
            this.stateProvinceDataGridViewTextBoxColumn.DataPropertyName = "StateProvince";
            this.stateProvinceDataGridViewTextBoxColumn.HeaderText = "StateProvince";
            this.stateProvinceDataGridViewTextBoxColumn.Name = "stateProvinceDataGridViewTextBoxColumn";
            // 
            // countryRegionDataGridViewTextBoxColumn
            // 
            this.countryRegionDataGridViewTextBoxColumn.DataPropertyName = "CountryRegion";
            this.countryRegionDataGridViewTextBoxColumn.HeaderText = "CountryRegion";
            this.countryRegionDataGridViewTextBoxColumn.Name = "countryRegionDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            // 
            // salesOrderHeaderDataGridViewTextBoxColumn
            // 
            this.salesOrderHeaderDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderHeader";
            this.salesOrderHeaderDataGridViewTextBoxColumn.HeaderText = "SalesOrderHeader";
            this.salesOrderHeaderDataGridViewTextBoxColumn.Name = "salesOrderHeaderDataGridViewTextBoxColumn";
            // 
            // salesOrderHeader1DataGridViewTextBoxColumn
            // 
            this.salesOrderHeader1DataGridViewTextBoxColumn.DataPropertyName = "SalesOrderHeader1";
            this.salesOrderHeader1DataGridViewTextBoxColumn.HeaderText = "SalesOrderHeader1";
            this.salesOrderHeader1DataGridViewTextBoxColumn.Name = "salesOrderHeader1DataGridViewTextBoxColumn";
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(Models.Address);
            // 
            // lblAddressID
            // 
            this.lblAddressID.AutoSize = true;
            this.lblAddressID.Location = new System.Drawing.Point(51, 38);
            this.lblAddressID.Name = "lblAddressID";
            this.lblAddressID.Size = new System.Drawing.Size(77, 17);
            this.lblAddressID.TabIndex = 1;
            this.lblAddressID.Text = "AddressID:";
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Location = new System.Drawing.Point(51, 66);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(99, 17);
            this.lblAddressLine1.TabIndex = 2;
            this.lblAddressLine1.Text = "AddressLine1:";
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Location = new System.Drawing.Point(51, 94);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(99, 17);
            this.lblAddressLine2.TabIndex = 3;
            this.lblAddressLine2.Text = "AddressLine2:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(51, 122);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblStateProvince
            // 
            this.lblStateProvince.AutoSize = true;
            this.lblStateProvince.Location = new System.Drawing.Point(639, 40);
            this.lblStateProvince.Name = "lblStateProvince";
            this.lblStateProvince.Size = new System.Drawing.Size(100, 17);
            this.lblStateProvince.TabIndex = 5;
            this.lblStateProvince.Text = "StateProvince:";
            // 
            // lblCountryRegion
            // 
            this.lblCountryRegion.AutoSize = true;
            this.lblCountryRegion.Location = new System.Drawing.Point(639, 66);
            this.lblCountryRegion.Name = "lblCountryRegion";
            this.lblCountryRegion.Size = new System.Drawing.Size(106, 17);
            this.lblCountryRegion.TabIndex = 6;
            this.lblCountryRegion.Text = "CountryRegion:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(639, 94);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(84, 17);
            this.lblPostalCode.TabIndex = 7;
            this.lblPostalCode.Text = "PostalCode:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Location = new System.Drawing.Point(639, 136);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(91, 17);
            this.lblModifiedDate.TabIndex = 8;
            this.lblModifiedDate.Text = "ModifiedDate";
            // 
            // txtAddressID
            // 
            this.txtAddressID.Location = new System.Drawing.Point(179, 35);
            this.txtAddressID.Name = "txtAddressID";
            this.txtAddressID.Size = new System.Drawing.Size(395, 22);
            this.txtAddressID.TabIndex = 9;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(179, 63);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(395, 22);
            this.txtAddressLine1.TabIndex = 10;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(179, 91);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(395, 22);
            this.txtAddressLine2.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(179, 119);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(395, 22);
            this.txtCity.TabIndex = 12;
            // 
            // txtStateProvince
            // 
            this.txtStateProvince.Location = new System.Drawing.Point(790, 37);
            this.txtStateProvince.Name = "txtStateProvince";
            this.txtStateProvince.Size = new System.Drawing.Size(408, 22);
            this.txtStateProvince.TabIndex = 13;
            // 
            // txtCountryRegion
            // 
            this.txtCountryRegion.Location = new System.Drawing.Point(790, 63);
            this.txtCountryRegion.Name = "txtCountryRegion";
            this.txtCountryRegion.Size = new System.Drawing.Size(408, 22);
            this.txtCountryRegion.TabIndex = 14;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(790, 91);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(408, 22);
            this.txtPostalCode.TabIndex = 15;
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Location = new System.Drawing.Point(790, 131);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(408, 22);
            this.dtpModifiedDate.TabIndex = 16;
            // 
            // AddressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 850);
            this.Controls.Add(this.dtpModifiedDate);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtCountryRegion);
            this.Controls.Add(this.txtStateProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.txtAddressID);
            this.Controls.Add(this.lblModifiedDate);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblCountryRegion);
            this.Controls.Add(this.lblStateProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddressLine2);
            this.Controls.Add(this.lblAddressLine1);
            this.Controls.Add(this.lblAddressID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddressWindow";
            this.Text = "AddressWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderHeaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderHeader1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.Label lblAddressID;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStateProvince;
        private System.Windows.Forms.Label lblCountryRegion;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.TextBox txtAddressID;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStateProvince;
        private System.Windows.Forms.TextBox txtCountryRegion;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.DateTimePicker dtpModifiedDate;
    }
}