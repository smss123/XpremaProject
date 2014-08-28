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
    public partial class frmGroup : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public frmGroup()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void SaveBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            if (groupNameTextBox.Text == "")
            {
                groupNameTextBox.BackColor = Color.OrangeRed;
                groupNameTextBox.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                groupNameTextBox.BackColor = Color.White;
            }
            if (groupDescriptionTextBox.Text == "")
            {
                groupDescriptionTextBox.BackColor = Color.OrangeRed;
                groupDescriptionTextBox.Text = OperationX.RequiredField;
                return;
            }
            else
            {
                groupDescriptionTextBox.BackColor = Color.White;
            }
             if (XtraMessageBox.Show(OperationX.SaveMessage,"Save",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
             { 
            XpremaProjectPro.XpConnected.UserGroup g = new UserGroup() { 
             GroupDescription= groupDescriptionTextBox.Text,
              GroupName=groupNameTextBox.Text,
               Id = int.Parse(idTextBox.Text)
            };
            proxy.GroupEdit(g);
        }
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            GroupAddFrm gadd = new GroupAddFrm();
            gadd.ShowDialog();
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
           
            userGroupBindingSource.DataSource = proxy.GroupGetAll();

        }

        private void DeltBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.DeleteMessage,"Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show(proxy.GroupDelete(int.Parse(idTextBox.Text)).ToString());
            }
           
        }

        private void RefreshBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            userGroupBindingSource.DataSource = proxy.GroupGetAll();
        }
    }
}