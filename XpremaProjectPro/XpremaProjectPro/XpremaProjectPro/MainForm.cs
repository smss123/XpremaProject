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
using XpremaProjectPro.Employee_forms;
using XpremaProjectPro.SupplierForms;

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

        private void AddUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUsersFrm addUserfrm = new AddUsersFrm();
            addUserfrm.ShowDialog();
        }

        private void managmentUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            managmentUserFrm MngUserfrm = new managmentUserFrm();
            MngUserfrm.ShowDialog();
        }

        private void newEmployeeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addEmployeefrm AddEmpfrm = new addEmployeefrm();
            AddEmpfrm.ShowDialog();
        }

        private void ManagmentEmployeeBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Managementemployeefrm empmang = new Managementemployeefrm();
            empmang.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SupplierAddFrm Supadd = new SupplierAddFrm();
            Supadd.ShowDialog();
        }

        private void AddFinanciersbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            financierAddfrm fricadd = new financierAddfrm();
            fricadd.ShowDialog();
        }

        private void managmentfinanciersBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            financierMangementfrm frcmng = new financierMangementfrm();
            frcmng.ShowDialog();
        }
    }
}