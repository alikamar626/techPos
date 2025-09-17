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
    public partial class AdminMerchant : Form
    {
        public AdminMerchant()
        {
            InitializeComponent();
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

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
