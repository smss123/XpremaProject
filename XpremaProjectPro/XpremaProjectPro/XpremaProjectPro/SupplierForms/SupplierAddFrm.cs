using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XpremaProjectPro.XpConnected;
namespace XpremaProjectPro.SupplierForms
{
    public partial class SupplierAddFrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public SupplierAddFrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.BackColor = Color.OrangeRed;
                nameTextBox.Focus();
                return;
            }
            else
            {
                nameTextBox.BackColor = Color.White;
            }


             XpremaProjectPro.XpConnected.Supplier sup= new Supplier()

              {
                  
                  Adderss = adderssTextBox.Text,
                  Email = emailTextBox.Text,
                  Fax = faxTextBox.Text,
                  name = nameTextBox.Text,
                  PhoneNumber = phoneNumberTextBox.Text,
                  SuppliersNatural = suppliersNaturalTextBox.Text
              };
             proxy.SupplierAdd(sp: sup);
             XtraMessageBox.Show(OperationX.AddMessageDone, "Add");



        }
    }
}