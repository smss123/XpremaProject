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
using DevExpress.XtraGrid.Views.Grid;
using XpremaProjectPro.XpConnected;
namespace XpremaProjectPro.AddProjectSenario
{
    public partial class frmProjectFinanacer : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectFinanacer()
        {
            InitializeComponent();
        }
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public List<Fin> Ls { get; set; }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Ls.Add(new Fin() { Name = FinanacerlookUpEdit.Text, TotalCost = double.Parse(CosttextBox.Text), AccountID = int.Parse(FinanacerlookUpEdit.EditValue.ToString()) });
            bindingSource1.DataSource = Ls;  
        }

        private void frmProjectFinanacer_Load(object sender, EventArgs e)
        {
            thefinancierBindingSource.DataSource = proxy.financierGetAll();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in Ls)
            {
                XProjectSenario.ProjectFinceer.Clear();
                XProjectSenario.ProjectFinceer.AddRange(Ls);

            }
            frmProjectContract frm = new frmProjectContract();
            frm.Show();
        }
    }
}