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
    public partial class frmProjectActivity : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectActivity()
        {
            InitializeComponent();
        }
        private List<ActivateObj> ls = new List<ActivateObj>();
        private void AddBtn_Click(object sender, EventArgs e)
        {
            ProActiviitybindingSource.Add(new ActivateObj()
            {
                ActivityName = activityNameTextBox.Text,
             Description= descriptionTextBox.Text,
             EndDate = DateTime.Parse(endDateDateEdit.EditValue.ToString()),
             StartDate = DateTime.Parse(startDateDateEdit.EditValue.ToString()),
             TotalCost =double.Parse(totalCostTextBox.Text)
             });

        }

        private void frmProjectActivity_Load(object sender, EventArgs e)
        {
            ProActiviitybindingSource.DataSource = ls;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            XProjectSenario.ProjectActivate.AddRange(ls);
            if (XtraMessageBox.Show("Add Sub Activety?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            {
                frmProjectSubActivity frm = new frmProjectSubActivity();
                XProjectSenario.ProjectActivityInfo = true;
                frm.ShowDialog();
            }
            else
            {
                this.Hide();
            }
        }
    }
}