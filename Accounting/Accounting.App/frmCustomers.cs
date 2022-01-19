using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;


namespace Accounting.App
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            Bindgrid();
        }


        void Bindgrid()
        {
            using (UnitOfWork db= new UnitOfWork())
            {
                digiCustomers.AutoGenerateColumns = false;
                digiCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            Bindgrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db= new UnitOfWork())
            {
                digiCustomers.DataSource = db.CustomerRepository.GetCustomersByFileter(txtFilter.Text);
            }
        }
    }
}
