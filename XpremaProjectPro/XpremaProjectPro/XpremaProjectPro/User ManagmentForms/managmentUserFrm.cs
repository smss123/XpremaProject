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
    public partial class managmentUserFrm : DevExpress.XtraEditors.XtraForm
    {
        public managmentUserFrm()
        {
            InitializeComponent();
        }

        private void AddBtn_ItemClick(object sender, TileItemEventArgs e)
        {
            AddUsersFrm adUser = new AddUsersFrm();
            adUser.ShowDialog();
        }
    }
}