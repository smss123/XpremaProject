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

namespace XpremaProjectPro.SupplierForms
{
    public partial class SupplierMangmentFrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public SupplierMangmentFrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void SupplierMangmentFrm_Load(object sender, EventArgs e)
        {
            supplierBindingSource.DataSource = proxy.SupplierGetAll();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.SaveMessage, "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Supplier sup = (Supplier)((GridView)SuppliergridControl.MainView).GetFocusedRow();
                proxy.SupplierEdit(sup);
                XtraMessageBox.Show(OperationX.SaveMessagedone);

            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Supplier sp = (Supplier)((GridView)SuppliergridControl.MainView).GetFocusedRow();
                proxy.SupplierDelete(sp.ID);
                XtraMessageBox.Show(OperationX.DeletedMessage);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void AddBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            SupplierAddFrm Addfrm = new SupplierAddFrm();
            Addfrm.ShowDialog();

        }
    }
}