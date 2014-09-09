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

namespace XpremaProjectPro.AddProjectSenario.ProjectPlane
{
    public partial class frmProjectSubActivity : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectSubActivity()
        {
            InitializeComponent();
        }

        private List<SubActivityObj> ls = new List<SubActivityObj>();
        private void frmProjectSubActivity_Load(object sender, EventArgs e)
        {
            SubActivebindingSource.DataSource = ls;
            ActivtiybindingSource.DataSource = XProjectSenario.ProjectActivate;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SubActivebindingSource.Add(new SubActivityObj() { 
             ActivateID = int.Parse(lookUpEdit1.EditValue.ToString()),
             EndDate = DateTime.Parse(enddateDateEdit.EditValue.ToString()),
             StartDate = DateTime.Parse(startdateDateEdit.EditValue.ToString()),
             SubActiveName = subActivityNameTextBox.Text,
             TimeLine =  int.Parse(TimelinetextBox.Text),
             TotalCost = double.Parse(totalCostTextBox.Text)
            });
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            XProjectSenario.SubProjectActive.AddRange(ls);
            this.Hide();
            frmProjectEnd frm = new frmProjectEnd();
            frm.ShowDialog();
        }
    }
}