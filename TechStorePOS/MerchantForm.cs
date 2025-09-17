using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class MerchantForm : Form
    {
        // Your database connection string here
        private readonly string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";

        public MerchantForm()
        {
            InitializeComponent();
        }

        private void btnAddMerchant_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter both Name and Phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simple phone validation (optional)
            if (!IsPhoneValid(phone))
            {
                MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO Merchant (Name, Phone) VALUES (@Name, @Phone)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Merchant added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtName.Clear();
                            txtPhone.Clear();
                            txtName.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add merchant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // More specific exception handling for SQL errors
                MessageBox.Show("Database error:\n{sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Simple phone number validation function
        private bool IsPhoneValid(string phone)
        {
            // Basic: only digits, length between 7 and 15 (adjust as needed)
            if (phone.Length < 7 || phone.Length > 15)
                return false;

            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }
    }
}
