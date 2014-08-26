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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace XpremaProjectPro.User_ManagmentForms
{
    public partial class managmentUserFrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public managmentUserFrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void AddBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            AddUsersFrm adUser = new AddUsersFrm();
            adUser.ShowDialog();
        }

        private void RefreshBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            userSystemBindingSource.DataSource = null;
            userSystemBindingSource.DataSource = proxy.UserGetAll();
            
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             if (XtraMessageBox.Show(OperationX.DeleteMessage,"Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes){

            UserSystem se = (UserSystem)((GridView)UsersgridControl.MainView).GetFocusedRow();
            proxy.UserDelete(se.Id);
            XtraMessageBox.Show(OperationX.DeletedMessage);
        }
        }

        private void managmentUserFrm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            
            userSystemBindingSource.DataSource = proxy.UserGetAll();

            userGroupBindingSource.DataSource = proxy.GroupGetAll();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.SaveMessage, "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                UserSystem se = (UserSystem)((GridView)UsersgridControl.MainView).GetFocusedRow();
                proxy.UserEdit(se);
                XtraMessageBox.Show(OperationX.SaveMessagedone);
            }
        }
        private void UsersgridControl_Click(object sender, EventArgs e)
        {

        }

        private void UsersgridControl_DoubleClick(object sender, EventArgs e)
        {
            
            //gridView1.RowClick
            //gridView1.OptionsBehavior.ReadOnly = false;
        }
    }
}