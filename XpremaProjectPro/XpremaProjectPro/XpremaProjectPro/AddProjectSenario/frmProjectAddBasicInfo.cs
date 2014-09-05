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
    public partial class frmProjectAddBasicInfo : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectAddBasicInfo()
        {
            InitializeComponent();
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            XProjectSenario.ini();
            XProjectSenario.ProjectSenarioSetting.ProjectName = projectNameTextBox.Text;
            XProjectSenario.ProjectSenarioSetting.ProjectDescription = projectDescriptionTextBox.Text;
            XProjectSenario.ProjectSenarioSetting.StartDate = DateTime.Parse(startDateDateEdit.EditValue.ToString());
            XProjectSenario.ProjectSenarioSetting.EndDate = DateTime.Parse(endDateDateEdit.EditValue.ToString());
            XProjectSenario.ProjectSenarioSetting.TotalCost = double.Parse(totalCostTextBox.Text);
            XProjectSenario.BasicInfo = true;
            frmProjectFinanacer frm = new frmProjectFinanacer();
            frm.Show();
            this.Hide();
        }

        private void ChangeEndDate()
        {
            try
            {
                endDateDateEdit.DateTime = startDateDateEdit.DateTime.AddMonths(int.Parse(TimeLinetextBox.Text));
    
            }
            catch (System.FormatException ex)
            {
                
                return;
            }
       }

        private void Summary()
        {
            string projectName= projectNameTextBox.Text;
            string startDate= startDateDateEdit.DateTime.ToShortDateString();
            string EndDate = endDateDateEdit.DateTime.ToShortDateString();
            string TotalCost=totalCostTextBox.Text;

            string str = string.Format("You are about to create a project {0} starts at {1} and you will end up in {2} and the estimated cost is {3}",projectName,
                                        startDate ,EndDate, TotalCost);
            lblSummry.Text = str;
            // To Flushing Memory
            projectName = null;
            startDate = null;
            EndDate = null;
            GC.Collect();
            TotalCost = null;
            str = null;
        }

        private void TimeLinetextBox_TextChanged(object sender, EventArgs e)
        {
            ChangeEndDate();
            Summary();
        }

        private void projectNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Summary();
        }

        private void projectDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Summary();
        }

        private void startDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            Summary();
        }

        private void endDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            Summary();
        }

        private void totalCostTextBox_TextChanged(object sender, EventArgs e)
        {
            Summary();
        }
    }
}