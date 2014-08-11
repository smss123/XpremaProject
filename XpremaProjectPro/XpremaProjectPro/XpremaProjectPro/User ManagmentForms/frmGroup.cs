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

namespace XpremaProjectPro.User_ManagmentForms
{
    public partial class frmGroup : DevExpress.XtraEditors.XtraForm
    {
        public frmGroup()
        {
            InitializeComponent();
        }

        private void SaveBtn_ItemClick(object sender, TileItemEventArgs e)
        {
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            GroupAddFrm gadd = new GroupAddFrm();
            gadd.ShowDialog();
        }
    }
}