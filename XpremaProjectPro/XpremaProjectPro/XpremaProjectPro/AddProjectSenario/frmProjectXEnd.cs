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

namespace XpremaProjectPro.AddProjectSenario
{
    public partial class frmProjectXEnd : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectXEnd()
        {
            InitializeComponent();
        }

        private void frmProjectXEnd_Load(object sender, EventArgs e)
        {
            FinshedList.Items.Add("Basic Info", XProjectSenario.BasicInfo);
            FinshedList.Items.Add("Contract Info", XProjectSenario.ContractInfo);
            FinshedList.Items.Add("Financer Info", XProjectSenario.FinancerInfo);
            FinshedList.Items.Add("Project Activity Info", XProjectSenario.ProjectActivityInfo);
            FinshedList.Items.Add("Sub Activity Info", XProjectSenario.ProjectSubActivity);
        }

        private void FinshedList_SelectedValueChanged(object sender, EventArgs e)
        {
            string str = FinshedList.SelectedValue.ToString();
           
        }
    }
}