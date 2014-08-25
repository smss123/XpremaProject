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
            UserSystem se = (UserSystem)((GridView)UsersgridControl.MainView).GetFocusedRow();
            proxy.UserDelete(se.Id);
            MessageBox.Show(OperationX.DeleteMessage);
        }

        private void managmentUserFrm_Load(object sender, EventArgs e)
        {
            userGroupBindingSource.DataSource = proxy.GroupGetAll();
            //GroupCombo.DataSource = proxy.GroupGetAll();
         
          
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UserSystem se = (UserSystem)((GridView)UsersgridControl.MainView).GetFocusedRow();
            proxy.UserEdit(se);
            MessageBox.Show(OperationX.DeleteMessage);
        }
    }
}