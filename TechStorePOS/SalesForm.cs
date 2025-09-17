using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class SalesForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";
        private List<CartItem> cartItems = new List<CartItem>();
        private string placeholder = "🔍 ابحث عن منتج...";

        public SalesForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            SetPlaceholder();
        }

        private void SetPlaceholder()
        {
            txtSearch.Text = placeholder;
            txtSearch.ForeColor = Color.Gray;
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName, ProductBarCode, Price, Quantity FROM Products";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;

                // Optional: Set headers or hide columns if needed
                dgvProducts.Columns["ProductID"].Visible = false;
                dgvProducts.Columns["ProductBarCode"].HeaderText = "Barcode";
                dgvProducts.Columns["ProductName"].HeaderText = "Product";
                dgvProducts.Columns["Price"].HeaderText = "Price";
                dgvProducts.Columns["Quantity"].HeaderText = "Available";
            }
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SetPlaceholder();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
            string productName = dgvProducts.CurrentRow.Cells["ProductName"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvProducts.CurrentRow.Cells["Price"].Value);
            int availableQty = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Quantity"].Value);
            int quantityToAdd = (int)numQuantity.Value;

            if (quantityToAdd <= 0)
            {
                MessageBox.Show("Please select a quantity greater than zero.");
                return;
            }

            if (quantityToAdd > availableQty)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

            CartItem existingItem = cartItems.Find(x => x.ProductID == productId);
            if (existingItem != null)
            {
                if (existingItem.Quantity + quantityToAdd > availableQty)
                {
                    MessageBox.Show("Not enough stock available for this quantity.");
                    return;
                }
                existingItem.Quantity += quantityToAdd;
            }
            else
            {
                cartItems.Add(new CartItem()
                {
                    ProductID = productId,
                    ProductName = productName,
                    Price = price,
                    Quantity = quantityToAdd
                });
            }

            RefreshCart();
        }

        private void RefreshCart()
        {
            lstCart.Items.Clear();
            decimal total = 0m;

            foreach (CartItem item in cartItems)
            {
                string line = item.ProductName + " - " + item.Quantity + " x " + item.Price.ToString("C") + " = " + (item.Price * item.Quantity).ToString("C");
                lstCart.Items.Add(line);
                total += item.Price * item.Quantity;
            }
            lblTotal.Text = "Total: " + total.ToString("C");
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex >= 0)
            {
                cartItems.RemoveAt(lstCart.SelectedIndex);
                RefreshCart();
            }
            else
            {
                MessageBox.Show("Please select an item in the cart to remove.");
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cartItems.Clear();
            RefreshCart();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvProducts.DataSource != null)
            {
                DataTable dt = dgvProducts.DataSource as DataTable;
                if (dt != null)
                {
                    string filter = txtSearch.Text.Replace("'", "''");

                    if (filter != placeholder)
                    {
                        dt.DefaultView.RowFilter = string.Format(
                            "ProductName LIKE '%{0}%' OR Convert(ProductBarCode, 'System.String') LIKE '%{0}%'",
                            filter);
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = "";
                    }
                }
            }
        }
        


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvProducts.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Visible)
                    {
                        row.Selected = true;
                        dgvProducts.CurrentCell = row.Cells[0];
                        break;
                    }
                }

                btnAddToCart.PerformClick();
                txtSearch.Clear();
                SetPlaceholder();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == placeholder)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                SetPlaceholder();
            }
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (CartItem item in cartItems)
                    {
                        string query = "UPDATE Products SET Quantity = Quantity - @qty WHERE ProductID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn, transaction);
                        cmd.Parameters.AddWithValue("@qty", item.Quantity);
                        cmd.Parameters.AddWithValue("@id", item.ProductID);
                        cmd.ExecuteNonQuery();

                        string insert = "INSERT INTO Sales (ProductID, ProductName, Quantity, TotalAmount, SaleDate) VALUES (@pid, @pname, @qty, @total, @date)";
                        SqlCommand insertCmd = new SqlCommand(insert, conn, transaction);
                        insertCmd.Parameters.AddWithValue("@pid", item.ProductID);
                        insertCmd.Parameters.AddWithValue("@pname", item.ProductName);
                        insertCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        insertCmd.Parameters.AddWithValue("@total", item.Price * item.Quantity);
                        insertCmd.Parameters.AddWithValue("@date", DateTime.Now);
                        insertCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    InvoiceHelper.PrintInvoice(cartItems);
                    MessageBox.Show("Sale completed successfully.");

                    cartItems.Clear();
                    RefreshCart();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error completing sale: " + ex.Message);
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class CartItem
    {
        public int ProductID;
        public string ProductName;
        public decimal Price;
        public int Quantity;
    }
}
