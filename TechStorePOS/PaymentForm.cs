using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class PaymentForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";

        public PaymentForm()
        {
            InitializeComponent();
            LoadMerchants();
        }

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
                MessageBox.Show("Error loading merchants:\n" + ex.Message);
            }
        }

        private void cmbMerchant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMerchant.SelectedIndex == -1)
            {
                lblOutstandingAmount.Text = "0.00";
                return;
            }

            int merchantId = Convert.ToInt32(cmbMerchant.SelectedValue);
            decimal outstanding = GetOutstandingAmount(merchantId);
            lblOutstandingAmount.Text = outstanding.ToString("F2");
        }

        private decimal GetOutstandingAmount(int merchantId)
        {
            decimal totalInvoices = 0m;
            decimal totalPayments = 0m;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string invoicesQuery = "SELECT ISNULL(SUM(Price), 0) FROM MerchantInvoice WHERE MerchantID = @MerchantID";
                    using (SqlCommand cmd = new SqlCommand(invoicesQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MerchantID", merchantId);
                        totalInvoices = (decimal)cmd.ExecuteScalar();
                    }

                    string paymentsQuery = "SELECT ISNULL(SUM(Amount), 0) FROM MerchantPayment WHERE MerchantID = @MerchantID";
                    using (SqlCommand cmd = new SqlCommand(paymentsQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@MerchantID", merchantId);
                        totalPayments = (decimal)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating outstanding amount:\n" + ex.Message);
            }

            decimal outstanding = totalInvoices - totalPayments;
            return outstanding < 0 ? 0 : outstanding;
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            if (cmbMerchant.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a merchant.");
                return;
            }

            decimal paymentAmount;
            if (!decimal.TryParse(txtPayment.Text.Trim(), out paymentAmount) || paymentAmount <= 0)
            {
                MessageBox.Show("Enter a valid positive payment amount.");
                return;
            }

            int merchantId = Convert.ToInt32(cmbMerchant.SelectedValue);

            decimal outstanding = GetOutstandingAmount(merchantId);

            if (paymentAmount > outstanding)
            {
                MessageBox.Show("Payment amount cannot exceed outstanding amount ({outstanding:F2}).");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO MerchantPayment (MerchantID, Amount, PaymentDate) VALUES (@MerchantID, @Amount, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MerchantID", merchantId);
                        cmd.Parameters.AddWithValue("@Amount", paymentAmount);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment saved successfully!");
                txtPayment.Clear();

                // Refresh outstanding label
                decimal newOutstanding = GetOutstandingAmount(merchantId);
                lblOutstandingAmount.Text = newOutstanding.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment:\n" + ex.Message);
            }
        }
    }
}
