namespace XpremaProjectPro.AddProjectSenario
{
    partial class frmProjectContract
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
            this.ContractgroupControl = new DevExpress.XtraEditors.GroupControl();
            this.NextBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ContractgridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.TimelinetextBox = new System.Windows.Forms.TextBox();
            this.selaryAmountTextBox = new System.Windows.Forms.TextBox();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.EmployeelookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.ContractgroupControl)).BeginInit();
            this.ContractgroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContractgroupControl
            // 
            this.ContractgroupControl.Controls.Add(this.NextBtn);
            this.ContractgroupControl.Controls.Add(this.ContractgridControl);
            this.ContractgroupControl.Controls.Add(this.layoutControl1);
            this.ContractgroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractgroupControl.Location = new System.Drawing.Point(0, 0);
            this.ContractgroupControl.Name = "ContractgroupControl";
            this.ContractgroupControl.Size = new System.Drawing.Size(597, 478);
            this.ContractgroupControl.TabIndex = 0;
            this.ContractgroupControl.Text = "Add Contract";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(473, 429);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(113, 41);
            this.NextBtn.TabIndex = 3;
            this.NextBtn.Text = "Next";
            // 
            // ContractgridControl
            // 
            this.ContractgridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ContractgridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContractgridControl.Location = new System.Drawing.Point(2, 215);
            this.ContractgridControl.MainView = this.gridView1;
            this.ContractgridControl.Name = "ContractgridControl";
            this.ContractgridControl.Size = new System.Drawing.Size(593, 208);
            this.ContractgridControl.TabIndex = 1;
            this.ContractgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ContractgridControl;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddBtn);
            this.layoutControl1.Controls.Add(this.TimelinetextBox);
            this.layoutControl1.Controls.Add(this.selaryAmountTextBox);
            this.layoutControl1.Controls.Add(this.endDateDateEdit);
            this.layoutControl1.Controls.Add(this.startDateDateEdit);
            this.layoutControl1.Controls.Add(this.EmployeelookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1102, 69, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(593, 194);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = global::XpremaProjectPro.Properties.Resources.add_32x32;
            this.AddBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.AddBtn.Location = new System.Drawing.Point(12, 138);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(160, 44);
            this.AddBtn.StyleController = this.layoutControl1;
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            // 
            // TimelinetextBox
            // 
            this.TimelinetextBox.Location = new System.Drawing.Point(120, 64);
            this.TimelinetextBox.Name = "TimelinetextBox";
            this.TimelinetextBox.Size = new System.Drawing.Size(461, 20);
            this.TimelinetextBox.TabIndex = 9;
            // 
            // selaryAmountTextBox
            // 
            this.selaryAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "SelaryAmount", true));
            this.selaryAmountTextBox.Location = new System.Drawing.Point(120, 114);
            this.selaryAmountTextBox.Name = "selaryAmountTextBox";
            this.selaryAmountTextBox.Size = new System.Drawing.Size(461, 20);
            this.selaryAmountTextBox.TabIndex = 8;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(Xprema.Base.Contract);
            // 
            // endDateDateEdit
            // 
            this.endDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "EndDate", true));
            this.endDateDateEdit.EditValue = null;
            this.endDateDateEdit.Location = new System.Drawing.Point(120, 88);
            this.endDateDateEdit.Name = "endDateDateEdit";
            this.endDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.endDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Size = new System.Drawing.Size(461, 22);
            this.endDateDateEdit.StyleController = this.layoutControl1;
            this.endDateDateEdit.TabIndex = 7;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contractBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(120, 38);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Size = new System.Drawing.Size(461, 22);
            this.startDateDateEdit.StyleController = this.layoutControl1;
            this.startDateDateEdit.TabIndex = 6;
            // 
            // EmployeelookUpEdit
            // 
            this.EmployeelookUpEdit.Location = new System.Drawing.Point(120, 12);
            this.EmployeelookUpEdit.Name = "EmployeelookUpEdit";
            this.EmployeelookUpEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeelookUpEdit.Properties.Appearance.Options.UseFont = true;
            this.EmployeelookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmployeelookUpEdit.Properties.NullText = "[Select Employee]";
            this.EmployeelookUpEdit.Size = new System.Drawing.Size(461, 22);
            this.EmployeelookUpEdit.StyleController = this.layoutControl1;
            this.EmployeelookUpEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.simpleSeparator1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(593, 194);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.EmployeelookUpEdit;
            this.layoutControlItem1.CustomizationFormText = "Employee Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(573, 26);
            this.layoutControlItem1.Text = "Employee Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.startDateDateEdit;
            this.layoutControlItem3.CustomizationFormText = "Start Date:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(573, 26);
            this.layoutControlItem3.Text = "Start Date:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.endDateDateEdit;
            this.layoutControlItem4.CustomizationFormText = "End Date:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(573, 26);
            this.layoutControlItem4.Text = "End Date:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.selaryAmountTextBox;
            this.layoutControlItem5.CustomizationFormText = "Selary Amount:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(573, 24);
            this.layoutControlItem5.Text = "Selary Amount:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TimelinetextBox;
            this.layoutControlItem2.CustomizationFormText = "Time line:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(573, 24);
            this.layoutControlItem2.Text = "Time line:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(105, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.AddBtn;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(34, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(164, 48);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(164, 126);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(409, 48);
            this.simpleSeparator1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // frmProjectContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 478);
            this.Controls.Add(this.ContractgroupControl);
            this.Name = "frmProjectContract";
            this.Text = "frmProjectContract";
            ((System.ComponentModel.ISupportInitialize)(this.ContractgroupControl)).EndInit();
            this.ContractgroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContractgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeelookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl ContractgroupControl;
        private DevExpress.XtraGrid.GridControl ContractgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private System.Windows.Forms.TextBox TimelinetextBox;
        private System.Windows.Forms.TextBox selaryAmountTextBox;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DevExpress.XtraEditors.DateEdit endDateDateEdit;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit EmployeelookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton NextBtn;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}