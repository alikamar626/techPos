namespace TechStorePOS
{
    partial class MerchantForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAddMerchant;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAddMerchant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(40, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "اسم التاجر:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(30, 33, 45);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(180, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 30);
            this.txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(40, 95);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 23);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "رقم الهاتف:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(30, 33, 45);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(180, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(270, 30);
            this.txtPhone.TabIndex = 3;
            // 
            // btnAddMerchant
            // 
            this.btnAddMerchant.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMerchant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMerchant.ForeColor = System.Drawing.Color.White;
            this.btnAddMerchant.Location = new System.Drawing.Point(180, 150);
            this.btnAddMerchant.Name = "btnAddMerchant";
            this.btnAddMerchant.Size = new System.Drawing.Size(160, 40);
            this.btnAddMerchant.TabIndex = 4;
            this.btnAddMerchant.Text = "➕ إضافة التاجر";
            this.btnAddMerchant.UseVisualStyleBackColor = false;
            this.btnAddMerchant.Click += new System.EventHandler(this.btnAddMerchant_Click);
            // 
            // MerchantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(20, 22, 34);
            this.ClientSize = new System.Drawing.Size(500, 230);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnAddMerchant);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MerchantForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة تاجر جديد";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
