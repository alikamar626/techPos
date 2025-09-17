namespace TechStorePOS
{
    partial class AdminMerchant
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonAddInvoice;
        private System.Windows.Forms.Button buttonAddMerchant;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonAddInvoice = new System.Windows.Forms.Button();
            this.buttonAddMerchant = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Teal;
            this.buttonPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPayment.ForeColor = System.Drawing.Color.White;
            this.buttonPayment.Location = new System.Drawing.Point(50, 360);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(420, 270);
            this.buttonPayment.TabIndex = 0;
            this.buttonPayment.Text = "💵 إدارة المدفوعات";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAddInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddInvoice.ForeColor = System.Drawing.Color.White;
            this.buttonAddInvoice.Location = new System.Drawing.Point(500, 30);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(400, 300);
            this.buttonAddInvoice.TabIndex = 1;
            this.buttonAddInvoice.Text = "🧾 إضافة فاتورة";
            this.buttonAddInvoice.UseVisualStyleBackColor = false;
            this.buttonAddInvoice.Click += new System.EventHandler(this.buttonAddInvoice_Click);
            // 
            // buttonAddMerchant
            // 
            this.buttonAddMerchant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.buttonAddMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMerchant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddMerchant.ForeColor = System.Drawing.Color.White;
            this.buttonAddMerchant.Location = new System.Drawing.Point(50, 30);
            this.buttonAddMerchant.Name = "buttonAddMerchant";
            this.buttonAddMerchant.Size = new System.Drawing.Size(420, 300);
            this.buttonAddMerchant.TabIndex = 2;
            this.buttonAddMerchant.Text = "🏪 إضافة تاجر";
            this.buttonAddMerchant.UseVisualStyleBackColor = false;
            this.buttonAddMerchant.Click += new System.EventHandler(this.buttonAddMerchant_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(500, 360);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(400, 270);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "اغلاق الصفحة";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // AdminMerchant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonAddInvoice);
            this.Controls.Add(this.buttonAddMerchant);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMerchant";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة التجار";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnCloseForm;
    }
}
