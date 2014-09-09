namespace XpremaProjectPro.AddProjectSenario.ProjectPlane
{
    partial class frmProjectSubActivity
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
            this.SubActivitygroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Nextbtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.TimelinetextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectSubActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.enddateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.startdateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.subActivityNameTextBox = new System.Windows.Forms.TextBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.ActivtiybindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.SubActivebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubActiveName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivateID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivitygroupControl)).BeginInit();
            this.SubActivitygroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectSubActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enddateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enddateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startdateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startdateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivtiybindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivebindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SubActivitygroupControl
            // 
            this.SubActivitygroupControl.Controls.Add(this.Nextbtn);
            this.SubActivitygroupControl.Controls.Add(this.gridControl1);
            this.SubActivitygroupControl.Controls.Add(this.layoutControl1);
            this.SubActivitygroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubActivitygroupControl.Location = new System.Drawing.Point(0, 0);
            this.SubActivitygroupControl.Name = "SubActivitygroupControl";
            this.SubActivitygroupControl.Size = new System.Drawing.Size(609, 502);
            this.SubActivitygroupControl.TabIndex = 0;
            this.SubActivitygroupControl.Text = "Add Sub Activity";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(490, 452);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(114, 38);
            this.Nextbtn.TabIndex = 4;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.SubActivebindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(2, 257);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(605, 196);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colSubActiveName,
            this.colStartDate,
            this.colEndDate,
            this.colTimeLine,
            this.colTotalCost,
            this.colActivateID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddBtn);
            this.layoutControl1.Controls.Add(this.TimelinetextBox);
            this.layoutControl1.Controls.Add(this.descriptionTextBox);
            this.layoutControl1.Controls.Add(this.totalCostTextBox);
            this.layoutControl1.Controls.Add(this.enddateDateEdit);
            this.layoutControl1.Controls.Add(this.startdateDateEdit);
            this.layoutControl1.Controls.Add(this.subActivityNameTextBox);
            this.layoutControl1.Controls.Add(this.lookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(960, 138, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(605, 236);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 186);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(149, 38);
            this.AddBtn.StyleController = this.layoutControl1;
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // TimelinetextBox
            // 
            this.TimelinetextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimelinetextBox.Location = new System.Drawing.Point(138, 112);
            this.TimelinetextBox.Name = "TimelinetextBox";
            this.TimelinetextBox.Size = new System.Drawing.Size(455, 20);
            this.TimelinetextBox.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectSubActivityBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(138, 62);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(455, 20);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // projectSubActivityBindingSource
            // 
            this.projectSubActivityBindingSource.DataSource = typeof(Xprema.Base.ProjectSubActivity);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectSubActivityBindingSource, "TotalCost", true));
            this.totalCostTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTextBox.Location = new System.Drawing.Point(138, 162);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(455, 20);
            this.totalCostTextBox.TabIndex = 9;
            // 
            // enddateDateEdit
            // 
            this.enddateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectSubActivityBindingSource, "enddate", true));
            this.enddateDateEdit.EditValue = null;
            this.enddateDateEdit.Location = new System.Drawing.Point(138, 136);
            this.enddateDateEdit.Name = "enddateDateEdit";
            this.enddateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.enddateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.enddateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.enddateDateEdit.Size = new System.Drawing.Size(455, 22);
            this.enddateDateEdit.StyleController = this.layoutControl1;
            this.enddateDateEdit.TabIndex = 8;
            // 
            // startdateDateEdit
            // 
            this.startdateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectSubActivityBindingSource, "Startdate", true));
            this.startdateDateEdit.EditValue = null;
            this.startdateDateEdit.Location = new System.Drawing.Point(138, 86);
            this.startdateDateEdit.Name = "startdateDateEdit";
            this.startdateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.startdateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startdateDateEdit.Size = new System.Drawing.Size(455, 22);
            this.startdateDateEdit.StyleController = this.layoutControl1;
            this.startdateDateEdit.TabIndex = 7;
            // 
            // subActivityNameTextBox
            // 
            this.subActivityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectSubActivityBindingSource, "SubActivityName", true));
            this.subActivityNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subActivityNameTextBox.Location = new System.Drawing.Point(138, 38);
            this.subActivityNameTextBox.Name = "subActivityNameTextBox";
            this.subActivityNameTextBox.Size = new System.Drawing.Size(455, 20);
            this.subActivityNameTextBox.TabIndex = 6;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(138, 12);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.ActivtiybindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "ActivityName";
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(455, 22);
            this.lookUpEdit1.StyleController = this.layoutControl1;
            this.lookUpEdit1.TabIndex = 4;
            // 
            // ActivtiybindingSource
            // 
            this.ActivtiybindingSource.DataSource = typeof(XpremaProjectPro.AddProjectSenario.ProjectPlane.ActivateObj);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem8,
            this.simpleSeparator1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(605, 236);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEdit1;
            this.layoutControlItem1.CustomizationFormText = "Select Activity:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(585, 26);
            this.layoutControlItem1.Text = "Select Activity:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.subActivityNameTextBox;
            this.layoutControlItem3.CustomizationFormText = "Sub Activity Name:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem3.Text = "Sub Activity Name:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.startdateDateEdit;
            this.layoutControlItem4.CustomizationFormText = "Startdate:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(585, 26);
            this.layoutControlItem4.Text = "Startdate:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.enddateDateEdit;
            this.layoutControlItem5.CustomizationFormText = "enddate:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(585, 26);
            this.layoutControlItem5.Text = "enddate:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.totalCostTextBox;
            this.layoutControlItem6.CustomizationFormText = "Total Cost:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem6.Text = "Total Cost:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.descriptionTextBox;
            this.layoutControlItem7.CustomizationFormText = "Description:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem7.Text = "Description:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TimelinetextBox;
            this.layoutControlItem2.CustomizationFormText = "Time Line:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(585, 24);
            this.layoutControlItem2.Text = "Time Line:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(123, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.AddBtn;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 174);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(34, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(153, 42);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(153, 174);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(432, 42);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // SubActivebindingSource
            // 
            this.SubActivebindingSource.DataSource = typeof(XpremaProjectPro.AddProjectSenario.ProjectPlane.SubActivityObj);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colSubActiveName
            // 
            this.colSubActiveName.FieldName = "SubActiveName";
            this.colSubActiveName.Name = "colSubActiveName";
            this.colSubActiveName.Visible = true;
            this.colSubActiveName.VisibleIndex = 1;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 3;
            // 
            // colTimeLine
            // 
            this.colTimeLine.FieldName = "TimeLine";
            this.colTimeLine.Name = "colTimeLine";
            this.colTimeLine.Visible = true;
            this.colTimeLine.VisibleIndex = 4;
            // 
            // colTotalCost
            // 
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 5;
            // 
            // colActivateID
            // 
            this.colActivateID.FieldName = "ActivateID";
            this.colActivateID.Name = "colActivateID";
            this.colActivateID.Visible = true;
            this.colActivateID.VisibleIndex = 6;
            // 
            // frmProjectSubActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 502);
            this.Controls.Add(this.SubActivitygroupControl);
            this.Name = "frmProjectSubActivity";
            this.Text = "frmProjectSubActivity";
            this.Load += new System.EventHandler(this.frmProjectSubActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubActivitygroupControl)).EndInit();
            this.SubActivitygroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectSubActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enddateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enddateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startdateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startdateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActivtiybindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubActivebindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl SubActivitygroupControl;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource projectSubActivityBindingSource;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private DevExpress.XtraEditors.DateEdit enddateDateEdit;
        private DevExpress.XtraEditors.DateEdit startdateDateEdit;
        private System.Windows.Forms.TextBox subActivityNameTextBox;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private System.Windows.Forms.TextBox TimelinetextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Nextbtn;
        private System.Windows.Forms.BindingSource ActivtiybindingSource;
        private System.Windows.Forms.BindingSource SubActivebindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colSubActiveName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeLine;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colActivateID;
    }
}