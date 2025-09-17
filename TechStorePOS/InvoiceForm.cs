using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class InvoiceForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";

        public InvoiceForm()
        {
            InitializeComponent();
            LoadMerchants();
        }

        // Load merchants into combobox
        private void LoadMerchants()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT MerchantID, Name FROM Merchant";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            cmbMerchant.DisplayMember = "Name";
                            cmbMerchant.ValueMember = "MerchantID";
                            cmbMerchant.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading merchants:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save invoice to database
        


        private void ClearForm()
        {
            cmbMerchant.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveInvoice_Click_1(object sender, EventArgs e)
        {
            if (cmbMerchant.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a merchant.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text.Trim(), out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid positive Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int merchantId = Convert.ToInt32(cmbMerchant.SelectedValue);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO MerchantInvoice (MerchantID, Price, InvoiceDate)
                             VALUES (@MerchantID, @Price, @InvoiceDate)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MerchantID", merchantId);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@InvoiceDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Invoice saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving invoice:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
