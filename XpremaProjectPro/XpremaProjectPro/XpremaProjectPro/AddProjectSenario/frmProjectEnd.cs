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
    public partial class frmProjectEnd : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectEnd()
        {
            InitializeComponent();
        }

        private void frmProjectEnd_Load(object sender, EventArgs e)
        {
            string Activ ="";
            foreach (var item in XProjectSenario.ProjectActivate)
	         {
		        Activ +=item.ActivityName+",\n";
            }
            string subAct = "";
            foreach (var item in XProjectSenario.SubProjectActive)
	{
		 subAct+=item.SubActiveName+",\n";
	}
            string  forx = "Hello,\n you are Create Project {0} With Activety :- \n {1} Thay are sub Activity :-{2} \n This Project Planed End in {3}";
            string str = string.Format(forx, XProjectSenario.ProjectSenarioSetting.ProjectName, Activ, subAct, XProjectSenario.ProjectSenarioSetting.EndDate.ToShortDateString());
            richTextBox1.Text = str;
        }
    }
}