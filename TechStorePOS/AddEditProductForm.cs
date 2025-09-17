using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class AddEditProductForm : Form
    {
        private int productId = 0;
        string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";

        public AddEditProductForm()
        {
            InitializeComponent();
            this.Text = "Add New Product";
        }

        public AddEditProductForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            this.Text = "Edit Product";
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductName, Price, WholesalePrice, Quantity, ProductBarCode FROM Products WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtProductName.Text = reader["ProductName"].ToString();
                        numPrice.Value = Convert.ToDecimal(reader["Price"]);
                        numWholesale.Value = Convert.ToDecimal(reader["WholesalePrice"]);
                        numQuantity.Value = Convert.ToInt32(reader["Quantity"]);
                        txtBarCode.Text = reader["ProductBarCode"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter product name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBarCode.Text))
            {
                MessageBox.Show("Please enter product barcode.");
                return;
            }

            if (productId == 0)
                AddProduct();
            else
                UpdateProduct();
        }

        private void AddProduct()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Products (ProductName, Price, WholesalePrice, Quantity, ProductBarCode) VALUES (@Name, @Price, @Wholesale, @Quantity, @BarCode)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Price", numPrice.Value);
                    cmd.Parameters.AddWithValue("@Wholesale", numWholesale.Value);
                    cmd.Parameters.AddWithValue("@Quantity", (int)numQuantity.Value);
                    cmd.Parameters.AddWithValue("@BarCode", txtBarCode.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product added successfully.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void UpdateProduct()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Products SET ProductName = @Name, Price = @Price, WholesalePrice = @Wholesale, Quantity = @Quantity, ProductBarCode = @BarCode WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Price", numPrice.Value);
                    cmd.Parameters.AddWithValue("@Wholesale", numWholesale.Value);
                    cmd.Parameters.AddWithValue("@Quantity", (int)numQuantity.Value);
                    cmd.Parameters.AddWithValue("@BarCode", txtBarCode.Text);
                    cmd.Parameters.AddWithValue("@ProductID", productId);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product updated successfully.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditProductForm_Load(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
