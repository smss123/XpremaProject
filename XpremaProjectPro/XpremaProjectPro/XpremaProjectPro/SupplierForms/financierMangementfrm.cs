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
    public partial class financierMangementfrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public financierMangementfrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();
        }

        private void FinanciergridControl_Click(object sender, EventArgs e)
        {

        }

        private void financierMangementfrm_Load(object sender, EventArgs e)
        {
            thefinancierBindingSource.DataSource = proxy.financierGetAll();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.SaveMessage, "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Thefinancier Fic = (Thefinancier)((GridView)FinanciergridControl.MainView).GetFocusedRow();
                proxy.financierEdit(Fic);
                XtraMessageBox.Show(OperationX.SaveMessagedone);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(OperationX.DeleteMessage, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                Thefinancier Fic = (Thefinancier)((GridView)FinanciergridControl.MainView).GetFocusedRow();
                proxy.SupplierDelete(Fic.ID);
                XtraMessageBox.Show(OperationX.DeletedMessage);

            }
        }

    }
}