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
using DevExpress.XtraGrid.Views.Grid;

namespace XpremaProjectPro.Employee_forms
{
    public partial class Managementemployeefrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public Managementemployeefrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void Managementemployeefrm_Load(object sender, EventArgs e)
        {
           employeeBindingSource.DataSource = proxy.EmployeeGetAll();
        }

        private void EditBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.SaveMessage, "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Employee emp = (Employee)((GridView)employeegridControl.MainView).GetFocusedRow();
                proxy.EmployeeEdit(emp);
                XtraMessageBox.Show(OperationX.SaveMessagedone);
              //  employeeBindingSource.DataSource = proxy.EmployeeGetAll();
            }
        }

        private void delbtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Employee se = (Employee)((GridView)employeegridControl.MainView).GetFocusedRow();
                proxy.EmployeeDelete(se.ID);
                XtraMessageBox.Show(OperationX.DeletedMessage);
               
            }

        }

        private void RefreshBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            employeeBindingSource.DataSource = null;
            employeeBindingSource.DataSource = proxy.EmployeeGetAll();
        }
    }
}