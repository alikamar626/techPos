namespace TechStorePOS
{
    partial class AddEditProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numWholesale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numWholesale = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWholesale)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.ForeColor = System.Drawing.Color.White;
            this.txtProductName.Location = new System.Drawing.Point(160, 20);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 30);
            this.txtProductName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product Code";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.ForeColor = System.Drawing.Color.White;
            this.txtBarCode.Location = new System.Drawing.Point(160, 60);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(200, 30);
            this.txtBarCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.ForeColor = System.Drawing.Color.White;
            this.numPrice.Location = new System.Drawing.Point(160, 140);
            this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 30);
            this.numPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.numQuantity.ForeColor = System.Drawing.Color.White;
            this.numQuantity.Location = new System.Drawing.Point(160, 180);
            this.numQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 30);
            this.numQuantity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wholesale Price";
            // 
            // numWholesale
            // 
            this.numWholesale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.numWholesale.DecimalPlaces = 2;
            this.numWholesale.ForeColor = System.Drawing.Color.White;
            this.numWholesale.Location = new System.Drawing.Point(160, 100);
            this.numWholesale.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWholesale.Name = "numWholesale";
            this.numWholesale.Size = new System.Drawing.Size(120, 30);
            this.numWholesale.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(80, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(200, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.AutoSize = true;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.txtProductName);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.txtBarCode);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.numWholesale);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.numPrice);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.numQuantity);
            this.panelContainer.Controls.Add(this.btnSave);
            this.panelContainer.Controls.Add(this.btnCancel);
            this.panelContainer.Location = new System.Drawing.Point(42, 138);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(400, 400);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // AddEditProductForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(459, 830);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddEditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWholesale)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}