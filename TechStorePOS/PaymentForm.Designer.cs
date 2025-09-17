namespace TechStorePOS
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbMerchant;
        private System.Windows.Forms.Label lblOutstandingText;
        private System.Windows.Forms.Label lblOutstandingAmount;
        private System.Windows.Forms.Label lblPaymentText;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button btnSavePayment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbMerchant = new System.Windows.Forms.ComboBox();
            this.lblOutstandingText = new System.Windows.Forms.Label();
            this.lblOutstandingAmount = new System.Windows.Forms.Label();
            this.lblPaymentText = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbMerchant
            // 
            this.cmbMerchant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.cmbMerchant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMerchant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMerchant.ForeColor = System.Drawing.Color.White;
            this.cmbMerchant.Location = new System.Drawing.Point(203, 28);
            this.cmbMerchant.Name = "cmbMerchant";
            this.cmbMerchant.Size = new System.Drawing.Size(200, 31);
            this.cmbMerchant.TabIndex = 0;
            this.cmbMerchant.SelectedIndexChanged += new System.EventHandler(this.cmbMerchant_SelectedIndexChanged);
            // 
            // lblOutstandingText
            // 
            this.lblOutstandingText.AutoSize = true;
            this.lblOutstandingText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOutstandingText.ForeColor = System.Drawing.Color.White;
            this.lblOutstandingText.Location = new System.Drawing.Point(30, 31);
            this.lblOutstandingText.Name = "lblOutstandingText";
            this.lblOutstandingText.Size = new System.Drawing.Size(153, 23);
            this.lblOutstandingText.TabIndex = 1;
            this.lblOutstandingText.Text = "المبلغ المتبقي عليه:";
            // 
            // lblOutstandingAmount
            // 
            this.lblOutstandingAmount.AutoSize = true;
            this.lblOutstandingAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOutstandingAmount.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblOutstandingAmount.Location = new System.Drawing.Point(253, 73);
            this.lblOutstandingAmount.Name = "lblOutstandingAmount";
            this.lblOutstandingAmount.Size = new System.Drawing.Size(45, 23);
            this.lblOutstandingAmount.TabIndex = 2;
            this.lblOutstandingAmount.Text = "0.00";
            // 
            // lblPaymentText
            // 
            this.lblPaymentText.AutoSize = true;
            this.lblPaymentText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentText.ForeColor = System.Drawing.Color.White;
            this.lblPaymentText.Location = new System.Drawing.Point(30, 110);
            this.lblPaymentText.Name = "lblPaymentText";
            this.lblPaymentText.Size = new System.Drawing.Size(119, 23);
            this.lblPaymentText.TabIndex = 3;
            this.lblPaymentText.Text = "المبلغ المدفوع:";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.txtPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPayment.ForeColor = System.Drawing.Color.White;
            this.txtPayment.Location = new System.Drawing.Point(203, 111);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(200, 30);
            this.txtPayment.TabIndex = 4;
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSavePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSavePayment.ForeColor = System.Drawing.Color.White;
            this.btnSavePayment.Location = new System.Drawing.Point(158, 176);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(140, 40);
            this.btnSavePayment.TabIndex = 5;
            this.btnSavePayment.Text = "💰 حفظ الدفع";
            this.btnSavePayment.UseVisualStyleBackColor = false;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(508, 249);
            this.Controls.Add(this.cmbMerchant);
            this.Controls.Add(this.lblOutstandingText);
            this.Controls.Add(this.lblOutstandingAmount);
            this.Controls.Add(this.lblPaymentText);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.btnSavePayment);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaymentForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة دفعة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
