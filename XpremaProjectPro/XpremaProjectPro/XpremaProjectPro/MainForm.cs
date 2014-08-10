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
using DevExpress.XtraBars.Navigation;
using XpremaProjectPro.User_ManagmentForms;

namespace XpremaProjectPro
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public TileNavItemCollection Items { get; set; }
        private void navButton2_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            frmMain fr=new frmMain();
          //  UserstileNavCategory.ElementClick() = fr.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectFrm pro = new ProjectFrm();
            pro.ShowDialog();
        }

        private void gropManagmentBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGroup Frg = new frmGroup();
            Frg.ShowDialog();
        }

        private void AddGrpBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GroupAddFrm Gadd = new GroupAddFrm();
            Gadd.ShowDialog();
        }
    }
}