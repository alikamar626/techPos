using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStorePOS
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            AdminForm f1 = new AdminForm();
            f1.Show();
        }

        private void buttonMerchant_Click(object sender, EventArgs e)
        {
            AdminMerchant f1 = new AdminMerchant();
            f1.Show();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            adminSales f1 = new adminSales();
            f1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
