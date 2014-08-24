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
namespace XpremaProjectPro.User_ManagmentForms
{
    public partial class AddUsersFrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public AddUsersFrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void UserAddgroupControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddUsersFrm_Load(object sender, EventArgs e)
        {
            GroupNamelookUpEdit.Properties.DataSource = proxy.GroupGetAll();
            GroupNamelookUpEdit.Properties.DisplayMember = "GroupName";
            GroupNamelookUpEdit.Properties.ValueMember = "id";
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
                        MessageBox.Show(GroupNamelookUpEdit.Properties.GetDataSourceValue("id", GroupNamelookUpEdit.ItemIndex).ToString());
        }
    }
}