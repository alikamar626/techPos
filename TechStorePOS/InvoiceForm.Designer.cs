namespace TechStorePOS
{
    partial class InvoiceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbMerchant;
        private System.Windows.Forms.Label lblMerchant;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSaveInvoice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbMerchant = new System.Windows.Forms.ComboBox();
            this.lblMerchant = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMerchant
            // 
            this.cmbMerchant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMerchant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMerchant.ForeColor = System.Drawing.Color.White;
            this.cmbMerchant.BackColor = System.Drawing.Color.FromArgb(30, 33, 45);
            this.cmbMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMerchant.Location = new System.Drawing.Point(140, 30);
            this.cmbMerchant.Name = "cmbMerchant";
            this.cmbMerchant.Size = new System.Drawing.Size(200, 31);
            this.cmbMerchant.TabIndex = 0;
            // 
            // lblMerchant
            // 
            this.lblMerchant.AutoSize = true;
            this.lblMerchant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMerchant.ForeColor = System.Drawing.Color.White;
            this.lblMerchant.Location = new System.Drawing.Point(30, 33);
            this.lblMerchant.Name = "lblMerchant";
            this.lblMerchant.Size = new System.Drawing.Size(97, 23);
            this.lblMerchant.TabIndex = 1;
            this.lblMerchant.Text = "اسم التاجر:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(30, 33, 45);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(140, 75);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 30);
            this.txtPrice.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(30, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(94, 23);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "سعر الفاتورة:";
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.Location = new System.Drawing.Point(140, 130);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(200, 40);
            this.btnSaveInvoice.TabIndex = 4;
            this.btnSaveInvoice.Text = "💾 حفظ الفاتورة";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click_1);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(20, 22, 34);
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnSaveInvoice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblMerchant);
            this.Controls.Add(this.cmbMerchant);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InvoiceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة فاتورة جديدة";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
