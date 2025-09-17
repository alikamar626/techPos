using System.Drawing;
namespace TechStorePOS
{
    partial class SalesForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.GroupBox groupProducts;
        private System.Windows.Forms.GroupBox groupCart;
        private System.Windows.Forms.TextBox txtSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.groupProducts = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupCart = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.groupProducts.SuspendLayout();
            this.groupCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.DimGray;
            this.dgvProducts.Location = new System.Drawing.Point(20, 70);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1060, 150);
            this.dgvProducts.TabIndex = 1;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(20, 230);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(100, 32);
            this.numQuantity.TabIndex = 2;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.lstCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstCart.ForeColor = System.Drawing.Color.White;
            this.lstCart.ItemHeight = 23;
            this.lstCart.Location = new System.Drawing.Point(20, 30);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(1060, 94);
            this.lstCart.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(500, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 28);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "المجموع: 0";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(130, 228);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(250, 35);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "🛒 إضافة إلى السلة";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(20, 150);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(200, 35);
            this.btnRemoveFromCart.TabIndex = 1;
            this.btnRemoveFromCart.Text = "🗑️ حذف من السلة";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteSale.ForeColor = System.Drawing.Color.White;
            this.btnCompleteSale.Location = new System.Drawing.Point(880, 150);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(200, 40);
            this.btnCompleteSale.TabIndex = 4;
            this.btnCompleteSale.Text = "💰 إتمام البيع";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.Gray;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(230, 150);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(200, 35);
            this.btnClearCart.TabIndex = 2;
            this.btnClearCart.Text = "🪑 تفريغ السلة";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // groupProducts
            // 
            this.groupProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.groupProducts.Controls.Add(this.txtSearch);
            this.groupProducts.Controls.Add(this.dgvProducts);
            this.groupProducts.Controls.Add(this.numQuantity);
            this.groupProducts.Controls.Add(this.btnAddToCart);
            this.groupProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupProducts.ForeColor = System.Drawing.Color.White;
            this.groupProducts.Location = new System.Drawing.Point(50, 30);
            this.groupProducts.Name = "groupProducts";
            this.groupProducts.Size = new System.Drawing.Size(1100, 300);
            this.groupProducts.TabIndex = 0;
            this.groupProducts.TabStop = false;
            this.groupProducts.Text = "المنتجات المتوفرة";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.Location = new System.Drawing.Point(20, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1060, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "🔍 ابحث عن منتج...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_GotFocus);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_LostFocus);
            // 
            // groupCart
            // 
            this.groupCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.groupCart.Controls.Add(this.btnExit);
            this.groupCart.Controls.Add(this.lstCart);
            this.groupCart.Controls.Add(this.btnRemoveFromCart);
            this.groupCart.Controls.Add(this.btnClearCart);
            this.groupCart.Controls.Add(this.lblTotal);
            this.groupCart.Controls.Add(this.btnCompleteSale);
            this.groupCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupCart.ForeColor = System.Drawing.Color.White;
            this.groupCart.Location = new System.Drawing.Point(50, 350);
            this.groupCart.Name = "groupCart";
            this.groupCart.Size = new System.Drawing.Size(1100, 300);
            this.groupCart.TabIndex = 1;
            this.groupCart.TabStop = false;
            this.groupCart.Text = "عربة المبيعات";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(130, 219);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "CLOSE THE APP";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1355, 700);
            this.Controls.Add(this.groupProducts);
            this.Controls.Add(this.groupCart);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام نقاط بيع - TechStore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.groupProducts.ResumeLayout(false);
            this.groupProducts.PerformLayout();
            this.groupCart.ResumeLayout(false);
            this.groupCart.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnExit;
    }
}
