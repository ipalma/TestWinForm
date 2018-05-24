namespace TestWinForm
{
    partial class CustomerWindow
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
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblSalesPerson = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPasswordHash = new System.Windows.Forms.Label();
            this.lblPasswordSalt = new System.Windows.Forms.Label();
            this.lblRowguid = new System.Windows.Forms.Label();
            this.lblModifiedDate = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtSalesPerson = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPasswordHash = new System.Windows.Forms.TextBox();
            this.txtPasswordSalt = new System.Windows.Forms.TextBox();
            this.txtRowguid = new System.Windows.Forms.TextBox();
            this.dtpModifiedDate = new System.Windows.Forms.DateTimePicker();
            this.chkNameStyle = new System.Windows.Forms.CheckBox();
            this.btnCustomerAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(12, 320);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.RowTemplate.Height = 24;
            this.dgwCustomer.Size = new System.Drawing.Size(1198, 378);
            this.dgwCustomer.TabIndex = 0;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellClick);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(54, 40);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(85, 17);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "CustomerID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(54, 117);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(54, 151);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "FirstName:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(54, 189);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(90, 17);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = "MiddleName:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(54, 230);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "LastName:";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.Location = new System.Drawing.Point(54, 275);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(46, 17);
            this.lblSuffix.TabIndex = 7;
            this.lblSuffix.Text = "Suffix:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(459, 40);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(108, 17);
            this.lblCompanyName.TabIndex = 8;
            this.lblCompanyName.Text = "CompanyName:";
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.AutoSize = true;
            this.lblSalesPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPerson.Location = new System.Drawing.Point(459, 78);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(92, 17);
            this.lblSalesPerson.TabIndex = 9;
            this.lblSalesPerson.Text = "SalesPerson:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(459, 117);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(98, 17);
            this.lblEmailAddress.TabIndex = 10;
            this.lblEmailAddress.Text = "EmailAddress:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(459, 151);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 17);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone:";
            // 
            // lblPasswordHash
            // 
            this.lblPasswordHash.AutoSize = true;
            this.lblPasswordHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordHash.Location = new System.Drawing.Point(459, 189);
            this.lblPasswordHash.Name = "lblPasswordHash";
            this.lblPasswordHash.Size = new System.Drawing.Size(106, 17);
            this.lblPasswordHash.TabIndex = 12;
            this.lblPasswordHash.Text = "PasswordHash:";
            // 
            // lblPasswordSalt
            // 
            this.lblPasswordSalt.AutoSize = true;
            this.lblPasswordSalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSalt.Location = new System.Drawing.Point(459, 230);
            this.lblPasswordSalt.Name = "lblPasswordSalt";
            this.lblPasswordSalt.Size = new System.Drawing.Size(97, 17);
            this.lblPasswordSalt.TabIndex = 13;
            this.lblPasswordSalt.Text = "PasswordSalt:";
            // 
            // lblRowguid
            // 
            this.lblRowguid.AutoSize = true;
            this.lblRowguid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowguid.Location = new System.Drawing.Point(378, 275);
            this.lblRowguid.Name = "lblRowguid";
            this.lblRowguid.Size = new System.Drawing.Size(69, 17);
            this.lblRowguid.TabIndex = 14;
            this.lblRowguid.Text = "RowGuid:";
            // 
            // lblModifiedDate
            // 
            this.lblModifiedDate.AutoSize = true;
            this.lblModifiedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifiedDate.Location = new System.Drawing.Point(765, 275);
            this.lblModifiedDate.Name = "lblModifiedDate";
            this.lblModifiedDate.Size = new System.Drawing.Size(95, 17);
            this.lblModifiedDate.TabIndex = 15;
            this.lblModifiedDate.Text = "ModifiedDate:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(157, 37);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 22);
            this.txtCustomerID.TabIndex = 16;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(157, 114);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 148);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 19;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(157, 186);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(200, 22);
            this.txtMiddleName.TabIndex = 20;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 227);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 21;
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(157, 272);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(200, 22);
            this.txtSuffix.TabIndex = 22;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(596, 37);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(419, 22);
            this.txtCompanyName.TabIndex = 23;
            // 
            // txtSalesPerson
            // 
            this.txtSalesPerson.Location = new System.Drawing.Point(596, 75);
            this.txtSalesPerson.Name = "txtSalesPerson";
            this.txtSalesPerson.Size = new System.Drawing.Size(419, 22);
            this.txtSalesPerson.TabIndex = 24;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(596, 114);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(419, 22);
            this.txtEmailAddress.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(596, 148);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(234, 22);
            this.txtPhone.TabIndex = 26;
            // 
            // txtPasswordHash
            // 
            this.txtPasswordHash.Location = new System.Drawing.Point(596, 186);
            this.txtPasswordHash.Name = "txtPasswordHash";
            this.txtPasswordHash.Size = new System.Drawing.Size(419, 22);
            this.txtPasswordHash.TabIndex = 27;
            // 
            // txtPasswordSalt
            // 
            this.txtPasswordSalt.Location = new System.Drawing.Point(596, 227);
            this.txtPasswordSalt.Name = "txtPasswordSalt";
            this.txtPasswordSalt.Size = new System.Drawing.Size(419, 22);
            this.txtPasswordSalt.TabIndex = 28;
            // 
            // txtRowguid
            // 
            this.txtRowguid.Location = new System.Drawing.Point(453, 272);
            this.txtRowguid.Name = "txtRowguid";
            this.txtRowguid.Size = new System.Drawing.Size(256, 22);
            this.txtRowguid.TabIndex = 29;
            // 
            // dtpModifiedDate
            // 
            this.dtpModifiedDate.Location = new System.Drawing.Point(889, 272);
            this.dtpModifiedDate.Name = "dtpModifiedDate";
            this.dtpModifiedDate.Size = new System.Drawing.Size(268, 22);
            this.dtpModifiedDate.TabIndex = 30;
            // 
            // chkNameStyle
            // 
            this.chkNameStyle.AutoSize = true;
            this.chkNameStyle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkNameStyle.Location = new System.Drawing.Point(57, 77);
            this.chkNameStyle.Name = "chkNameStyle";
            this.chkNameStyle.Size = new System.Drawing.Size(102, 21);
            this.chkNameStyle.TabIndex = 31;
            this.chkNameStyle.Text = "NameStyle:";
            this.chkNameStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkNameStyle.UseVisualStyleBackColor = true;
            // 
            // btnCustomerAddress
            // 
            this.btnCustomerAddress.Location = new System.Drawing.Point(1082, 40);
            this.btnCustomerAddress.Name = "btnCustomerAddress";
            this.btnCustomerAddress.Size = new System.Drawing.Size(102, 34);
            this.btnCustomerAddress.TabIndex = 32;
            this.btnCustomerAddress.Text = "CustomerAddresses";
            this.btnCustomerAddress.UseVisualStyleBackColor = true;
            this.btnCustomerAddress.Click += new System.EventHandler(this.btnCustomerAddress_Click);
            // 
            // CustomerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 710);
            this.Controls.Add(this.btnCustomerAddress);
            this.Controls.Add(this.chkNameStyle);
            this.Controls.Add(this.dtpModifiedDate);
            this.Controls.Add(this.txtRowguid);
            this.Controls.Add(this.txtPasswordSalt);
            this.Controls.Add(this.txtPasswordHash);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtSalesPerson);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtSuffix);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblModifiedDate);
            this.Controls.Add(this.lblRowguid);
            this.Controls.Add(this.lblPasswordSalt);
            this.Controls.Add(this.lblPasswordHash);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblSalesPerson);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.dgwCustomer);
            this.Name = "CustomerWindow";
            this.Text = "CustomerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblSalesPerson;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPasswordHash;
        private System.Windows.Forms.Label lblPasswordSalt;
        private System.Windows.Forms.Label lblRowguid;
        private System.Windows.Forms.Label lblModifiedDate;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtSalesPerson;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPasswordHash;
        private System.Windows.Forms.TextBox txtPasswordSalt;
        private System.Windows.Forms.TextBox txtRowguid;
        private System.Windows.Forms.DateTimePicker dtpModifiedDate;
        private System.Windows.Forms.CheckBox chkNameStyle;
        private System.Windows.Forms.Button btnCustomerAddress;
    }
}