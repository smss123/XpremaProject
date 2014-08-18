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
using Xprema.Base;
namespace XpremaProjectPro.SupplierForms
{
    public partial class SupplierAddFrm : DevExpress.XtraEditors.XtraForm
    {
        public SupplierAddFrm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (this.Validation())
                {
                    Xprema_PrjectEntities db = new Xprema_PrjectEntities();
                    Supplier sup = new Supplier()
                    {
                        Adderss = adderssTextBox.Text,
                        Email = emailTextBox.Text,
                        Fax = faxTextBox.Text,
                        name = nameTextBox.Text,
                        PhoneNumber = phoneNumberTextBox.Text,
                        SuppliersNatural = suppliersNaturalTextBox.Text
                    };
                    db.Suppliers.Add(sup);
                    db.SaveChangesAsync();
                    MessageBox.Show("Ok");
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private bool Validation()
        {
            bool state = true;
            //Supplier sup = new Supplier()
            //{
            //    Adderss = adderssTextBox.Text,
            //    Email = emailTextBox.Text,
            //    Fax = faxTextBox.Text,
            //    name = nameTextBox.Text,
            //    PhoneNumber = phoneNumberTextBox.Text,
            //    SuppliersNatural = suppliersNaturalTextBox.Text
            //};
            state = ChangeToError(adderssTextBox);
            state = ChangeToError(emailTextBox);
            state = ChangeToError(faxTextBox);
            state = ChangeToError(nameTextBox);
            state = ChangeToError(phoneNumberTextBox);
            state = ChangeToError(suppliersNaturalTextBox);


            return state;
        }

        private bool ChangeToError(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Text = "";
                txt.BackColor = Color.Red; //Color.FromArgb(255, 255, 192);
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
            
        }

        private bool ChangeToError(TextEdit txt)
        {
            if (txt.Text == "")
            {
                txt.Text = "";
                txt.BackColor = Color.Red; //Color.FromArgb(255, 255, 192);
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
    }
}