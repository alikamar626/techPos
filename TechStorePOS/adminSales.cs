using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class adminSales : Form
    {
        string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";

        public adminSales()
        {
            InitializeComponent();
        }

        private void adminSales_Load(object sender, EventArgs e)
        {
            LoadAllSales();
        }

        private void LoadAllSales()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT SaleID, ProductID, ProductName, Quantity, TotalAmount, SaleDate FROM Sales ORDER BY SaleDate DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSales.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء تحميل المبيعات: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterSalesByDate(dtpStartDate.Value.Date, dtpEndDate.Value.Date);
        }

        private void FilterSalesByDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT SaleID, ProductID, ProductName, Quantity, TotalAmount, SaleDate 
                                     FROM Sales 
                                     WHERE SaleDate BETWEEN @StartDate AND @EndDate
                                     ORDER BY SaleDate DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSales.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء التصفية: " + ex.Message);
            }
        }
    }
}
