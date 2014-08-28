﻿namespace XpremaProjectPro.Employee_forms
{
    partial class Managementemployeefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Managementemployeefrm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.employeegridControl = new DevExpress.XtraGrid.GridControl();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeejobNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeNationalNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobilenumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaveBtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EditBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.deleteBtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delbtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.RefreshBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.employeegridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 2;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(787, 125);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // employeegridControl
            // 
            this.employeegridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.employeegridControl.DataSource = this.employeeBindingSource;
            this.employeegridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeegridControl.Location = new System.Drawing.Point(0, 125);
            this.employeegridControl.MainView = this.gridView1;
            this.employeegridControl.Name = "employeegridControl";
            this.employeegridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EditBtn,
            this.delbtn});
            this.employeegridControl.Size = new System.Drawing.Size(787, 303);
            this.employeegridControl.TabIndex = 1;
            this.employeegridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Xprema.Base.Employee);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colEmployeeName,
            this.colEmployeejobNumber,
            this.colEmployeeGender,
            this.colEmployeeNationalNumber,
            this.colPhoneNumber,
            this.colMobilenumber,
            this.colEmail,
            this.SaveBtn,
            this.deleteBtn});
            this.gridView1.GridControl = this.employeegridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 1;
            // 
            // colEmployeejobNumber
            // 
            this.colEmployeejobNumber.FieldName = "EmployeejobNumber";
            this.colEmployeejobNumber.Name = "colEmployeejobNumber";
            this.colEmployeejobNumber.Visible = true;
            this.colEmployeejobNumber.VisibleIndex = 2;
            // 
            // colEmployeeGender
            // 
            this.colEmployeeGender.FieldName = "EmployeeGender";
            this.colEmployeeGender.Name = "colEmployeeGender";
            this.colEmployeeGender.Visible = true;
            this.colEmployeeGender.VisibleIndex = 3;
            // 
            // colEmployeeNationalNumber
            // 
            this.colEmployeeNationalNumber.FieldName = "EmployeeNationalNumber";
            this.colEmployeeNationalNumber.Name = "colEmployeeNationalNumber";
            this.colEmployeeNationalNumber.Visible = true;
            this.colEmployeeNationalNumber.VisibleIndex = 4;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 5;
            // 
            // colMobilenumber
            // 
            this.colMobilenumber.FieldName = "Mobilenumber";
            this.colMobilenumber.Name = "colMobilenumber";
            this.colMobilenumber.Visible = true;
            this.colMobilenumber.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "Save Changes";
            this.SaveBtn.ColumnEdit = this.EditBtn;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Visible = true;
            this.SaveBtn.VisibleIndex = 8;
            // 
            // EditBtn
            // 
            this.EditBtn.AutoHeight = false;
            this.EditBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("EditBtn.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.EditBtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.EditBtn_ButtonClick);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Caption = "Delete Records";
            this.deleteBtn.ColumnEdit = this.delbtn;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Visible = true;
            this.deleteBtn.VisibleIndex = 9;
            // 
            // delbtn
            // 
            this.delbtn.AutoHeight = false;
            this.delbtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("delbtn.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.delbtn.Name = "delbtn";
            this.delbtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.delbtn.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.delbtn_ButtonClick);
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.RefreshBtn);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.RefreshBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = global::XpremaProjectPro.Properties.Resources.refbtn;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement1.Text = "Refresh";
            this.RefreshBtn.Elements.Add(tileItemElement1);
            this.RefreshBtn.Id = 1;
            this.RefreshBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.RefreshBtn_ItemClick);
            // 
            // Managementemployeefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 428);
            this.Controls.Add(this.employeegridControl);
            this.Controls.Add(this.tileBar1);
            this.Name = "Managementemployeefrm";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.Managementemployeefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeegridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraGrid.GridControl employeegridControl;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeejobNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeGender;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeNationalNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMobilenumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn SaveBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit EditBtn;
        private DevExpress.XtraGrid.Columns.GridColumn deleteBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit delbtn;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem RefreshBtn;
    }
}