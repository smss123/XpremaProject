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

namespace XpremaProjectPro.AddProjectSenario
{
    public partial class frmProjectContract : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectContract()
        {
            InitializeComponent();
        }

        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        private List<ProContract> ls = new List<ProContract>();
        private void frmProjectContract_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = proxy.EmployeeGetAll();
            proContractBindingSource.DataSource = ls;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            proContractBindingSource.Add(new ProContract()
            {
                EmpID = int.Parse(EmployeelookUpEdit.EditValue.ToString()),
                StartDate = DateTime.Parse(startDateDateEdit.EditValue.ToString()),
                  Name = EmployeelookUpEdit.Text,
                   SelaryAmount = double.Parse(selaryAmountTextBox.Text),
                EndDate = DateTime.Parse(endDateDateEdit.EditValue.ToString()),
                 TimeLine= int.Parse(TimelinetextBox.Text)
            });
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            XProjectSenario.Contracts = ls;
            
        }
    }
}