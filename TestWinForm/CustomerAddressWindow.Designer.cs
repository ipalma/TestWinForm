namespace TestWinForm
{
    partial class CustomerAddressWindow
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
            this.dgwCustomerAddress = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCustomerAddress
            // 
            this.dgwCustomerAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomerAddress.Location = new System.Drawing.Point(12, 427);
            this.dgwCustomerAddress.Name = "dgwCustomerAddress";
            this.dgwCustomerAddress.RowTemplate.Height = 24;
            this.dgwCustomerAddress.Size = new System.Drawing.Size(1162, 233);
            this.dgwCustomerAddress.TabIndex = 0;
            // 
            // CustomerAddressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 672);
            this.Controls.Add(this.dgwCustomerAddress);
            this.Name = "CustomerAddressWindow";
            this.Text = "CustomerAddressWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomerAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomerAddress;
    }
}