﻿namespace XpremaProjectPro.SupplierForms
{
    partial class SupplierAddFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.suppliersNaturalTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.adderssTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnAdd);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(358, 266);
            this.groupControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.adderssTextBox);
            this.layoutControl1.Controls.Add(this.emailTextBox);
            this.layoutControl1.Controls.Add(this.faxTextBox);
            this.layoutControl1.Controls.Add(this.phoneNumberTextBox);
            this.layoutControl1.Controls.Add(this.suppliersNaturalTextBox);
            this.layoutControl1.Controls.Add(this.nameTextBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(354, 177);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(354, 177);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(Xprema.Base.Supplier);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(101, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(241, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.nameTextBox;
            this.layoutControlItem2.CustomizationFormText = "name:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(334, 24);
            this.layoutControlItem2.Text = "name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // suppliersNaturalTextBox
            // 
            this.suppliersNaturalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SuppliersNatural", true));
            this.suppliersNaturalTextBox.Location = new System.Drawing.Point(101, 36);
            this.suppliersNaturalTextBox.Name = "suppliersNaturalTextBox";
            this.suppliersNaturalTextBox.Size = new System.Drawing.Size(241, 20);
            this.suppliersNaturalTextBox.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.suppliersNaturalTextBox;
            this.layoutControlItem3.CustomizationFormText = "Suppliers Natural:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(334, 24);
            this.layoutControlItem3.Text = "Suppliers Natural:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 13);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(101, 60);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(241, 20);
            this.phoneNumberTextBox.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.phoneNumberTextBox;
            this.layoutControlItem4.CustomizationFormText = "Phone Number:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(334, 24);
            this.layoutControlItem4.Text = "Phone Number:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(85, 13);
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(101, 84);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(241, 20);
            this.faxTextBox.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.faxTextBox;
            this.layoutControlItem5.CustomizationFormText = "Fax:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(334, 24);
            this.layoutControlItem5.Text = "Fax:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(85, 13);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(101, 108);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(241, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.emailTextBox;
            this.layoutControlItem6.CustomizationFormText = "Email:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(334, 24);
            this.layoutControlItem6.Text = "Email:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(85, 13);
            // 
            // adderssTextBox
            // 
            this.adderssTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Adderss", true));
            this.adderssTextBox.Location = new System.Drawing.Point(101, 132);
            this.adderssTextBox.Name = "adderssTextBox";
            this.adderssTextBox.Size = new System.Drawing.Size(241, 20);
            this.adderssTextBox.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.adderssTextBox;
            this.layoutControlItem7.CustomizationFormText = "Adderss:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(334, 37);
            this.layoutControlItem7.Text = "Adderss:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(85, 13);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 204);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(159, 42);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            // 
            // SupplierAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 266);
            this.Controls.Add(this.groupControl1);
            this.Name = "SupplierAddFrm";
            this.Text = "SupplierAddFrm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private System.Windows.Forms.TextBox adderssTextBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox suppliersNaturalTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}