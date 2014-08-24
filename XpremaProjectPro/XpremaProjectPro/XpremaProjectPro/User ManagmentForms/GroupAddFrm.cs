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
    public partial class GroupAddFrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
      
        public GroupAddFrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
            proxy.Open();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (groupNameTextBox.Text=="")
            {
                groupNameTextBox.BackColor = Color.OrangeRed;
                groupNameTextBox.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                groupNameTextBox.BackColor = Color.White;
            }
            if (groupDescriptionRichTextBox.Text == "")
            {
                groupDescriptionRichTextBox.BackColor = Color.OrangeRed;
                groupDescriptionRichTextBox.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                groupDescriptionRichTextBox.BackColor = Color.White;
            }

            XpremaProjectPro.XpConnected.UserGroup g = new UserGroup()
            {
                GroupName = groupNameTextBox.Text,
                GroupDescription = groupDescriptionRichTextBox.Text
            };
            proxy.GroupAdd(g: g);
        }

    }
}