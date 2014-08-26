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

namespace XpremaProjectPro.Employee_forms
{
   
    public partial class addEmployeefrm : DevExpress.XtraEditors.XtraForm
    {
        private XpremaConnectorSoapClient proxy = new XpremaConnectorSoapClient();
        public addEmployeefrm()
        {
            InitializeComponent();
            proxy = new XpremaConnectorSoapClient();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            XpremaProjectPro.XpConnected.Employee emp = new Employee()
            {
                EmployeeName=employeeNameTextBox.Text,
                EmployeeGender=employeeGenderComboBox.Text,
                EmployeejobNumber=employeejobNumberTextBox.Text,
                PhoneNumber=phoneNumberTextBox.Text,
                Mobilenumber=mobilenumberTextBox.Text,
                Email=emailTextBox.Text,
                EmployeeNationalNumber=employeeNationalNumberTextBox.Text,
               
               
            
            
            };
             proxy.EmployeeAdd(em: emp);

             XtraMessageBox.Show(OperationX.AddMessageDone, "Add");
        }
      

        private void addEmployeefrm_Load(object sender, EventArgs e)
        {

        }
    }
}