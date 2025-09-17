namespace TechStorePOS
{
    partial class index
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonMerchant = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.buttonProduct.FlatAppearance.BorderSize = 0;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.buttonProduct.ForeColor = System.Drawing.Color.White;
            this.buttonProduct.Location = new System.Drawing.Point(50, 100);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(400, 500);
            this.buttonProduct.TabIndex = 0;
            this.buttonProduct.Text = "Product";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonMerchant
            // 
            this.buttonMerchant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.buttonMerchant.FlatAppearance.BorderSize = 0;
            this.buttonMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMerchant.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.buttonMerchant.ForeColor = System.Drawing.Color.White;
            this.buttonMerchant.Location = new System.Drawing.Point(480, 100);
            this.buttonMerchant.Name = "buttonMerchant";
            this.buttonMerchant.Size = new System.Drawing.Size(400, 500);
            this.buttonMerchant.TabIndex = 1;
            this.buttonMerchant.Text = "Merchant";
            this.buttonMerchant.UseVisualStyleBackColor = false;
            this.buttonMerchant.Click += new System.EventHandler(this.buttonMerchant_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(33)))), ((int)(((byte)(53)))));
            this.buttonSales.FlatAppearance.BorderSize = 0;
            this.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSales.ForeColor = System.Drawing.Color.White;
            this.buttonSales.Location = new System.Drawing.Point(910, 100);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(400, 500);
            this.buttonSales.TabIndex = 2;
            this.buttonSales.Text = "Sales";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1334, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(400, 500);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "CLOSE THE APP";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1736, 882);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonMerchant);
            this.Controls.Add(this.buttonProduct);
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TechStore POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonMerchant;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button btnExit;
    }
}
