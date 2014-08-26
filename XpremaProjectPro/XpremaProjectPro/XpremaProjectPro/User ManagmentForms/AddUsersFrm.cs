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
            userGroupBindingSource.DataSource = proxy.GroupGetAll();
            //GroupNamelookUpEdit.Properties.DisplayMember = "GroupName";
            //GroupNamelookUpEdit.Properties.ValueMember = "id";
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                userNameTextBox.BackColor = Color.OrangeRed;
                userNameTextBox.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                userNameTextBox.BackColor = Color.White;
            }
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.BackColor = Color.OrangeRed;
                passwordTextBox.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                passwordTextBox.BackColor = Color.White;
            }
            if (GroupNamelookUpEdit.EditValue==null)
            {
                GroupNamelookUpEdit.BackColor = Color.OrangeRed;
                GroupNamelookUpEdit.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                GroupNamelookUpEdit.BackColor = Color.White;
            }

             XpremaProjectPro.XpConnected.UserSystem user = new UserSystem()
            {
                UserName =userNameTextBox.Text,
                Password =passwordTextBox.Text,
                UserGroup_Id= int.Parse(this.GroupNamelookUpEdit.EditValue.ToString()),
            
            };
             proxy.UserAdd(u: user);

             XtraMessageBox.Show(OperationX.AddMessageDone, "Add");
        }

        private void GroupNamelookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}