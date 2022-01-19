using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using ValidationComponents;
using Accounting.DataLayer;

namespace Accounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        private UnitOfWork db = new UnitOfWork();

        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog()== DialogResult.OK)
            {
                
                pcCustomer.ImageLocation = openFile.FileName;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + ImageName);

                customers customers = new customers()
                {
                    Address = txtAdress.Text,
                    Email = txtEmail.Text,
                    FullName = txtName.Text,
                    Mobile = txtMobile.Text,
                    CustomerImage = ImageName
                };
                db.CustomerRepository.InsertCustomer(customers);
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
