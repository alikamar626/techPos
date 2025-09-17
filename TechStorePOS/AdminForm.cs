using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class AdminForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            
            
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // تم تعديل الاستعلام ليشمل BarCode و WholesalePrice
                    string query = "SELECT ProductID, ProductName, ProductBarCode, Price, WholesalePrice, Quantity FROM Products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvProducts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

       


      

        

        

       

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddEditProductForm addForm = new AddEditProductForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);
            AddEditProductForm editForm = new AddEditProductForm(productId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
                
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["ProductID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteProduct(productId);
                LoadProducts();
                
            }
        }

        private void DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @ProductID", conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: actions on sales grid click
        }

        private void buttonAddMerchant_Click(object sender, EventArgs e)
        {
            MerchantForm f1 = new MerchantForm();
            f1.Show();
        }

        private void buttonAddInvoice_Click(object sender, EventArgs e)
        {
            InvoiceForm f1 = new InvoiceForm();
            f1.Show();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            PaymentForm f1 = new PaymentForm();
            f1.Show();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
