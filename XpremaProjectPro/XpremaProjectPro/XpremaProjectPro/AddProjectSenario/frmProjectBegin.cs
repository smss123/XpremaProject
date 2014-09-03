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
    public partial class frmProjectBegin : DevExpress.XtraEditors.XtraForm
    {
        public frmProjectBegin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmProjectAddBasicInfo frm = new frmProjectAddBasicInfo();
            frm.Show();
            this.Close();
        }
    }
}