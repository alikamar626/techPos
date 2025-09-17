using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace TechStorePOS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-30F6AU4\SQLEXPRESS;Initial Catalog=TechStoreDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                conn.Open();
                var role = cmd.ExecuteScalar();

                if (role != null)
                {
                    string userRole = role.ToString();
                    this.Hide();

                    if (userRole == "admin")
                    {
                        
                      index ind = new index();
                        ind.Show();
                    }
                    else if (userRole == "employee")
                    {
                        SalesForm salesForm = new SalesForm();
                        salesForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login!");
                }
            }
        }
    }
}

