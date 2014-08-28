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
    public partial class financierAddfrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public financierAddfrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (financiernameTextBox.Text == "")
            {
                financiernameTextBox.BackColor = Color.OrangeRed;
                financiernameTextBox.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                financiernameTextBox.BackColor = Color.White;
            }


            XpremaProjectPro.XpConnected.Thefinancier fc = new Thefinancier()
            {
                financiername = financiernameTextBox.Text,
                agentName = agentNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Fax = faxTextBox.Text,
                Email = emailTextBox.Text,
                Adderss = adderssTextBox.Text,

            };
            proxy.financierAdd(fc: fc);
            XtraMessageBox.Show(OperationX.AddMessageDone, "Done");
        }
    }
}