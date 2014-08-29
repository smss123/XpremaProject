namespace XpremaProjectPro.AddProjectSenario.ProjectPlane
{
    partial class frmProjectActivity
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
            this.NextBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ActivityGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.projectActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.activityNameTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.NextBtn);
            this.groupControl1.Controls.Add(this.ActivityGridControl);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(545, 438);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(420, 392);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(113, 41);
            this.NextBtn.TabIndex = 3;
            this.NextBtn.Text = "Next";
            // 
            // ActivityGridControl
            // 
            this.ActivityGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActivityGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActivityGridControl.Location = new System.Drawing.Point(2, 203);
            this.ActivityGridControl.MainView = this.gridView1;
            this.ActivityGridControl.Name = "ActivityGridControl";
            this.ActivityGridControl.Size = new System.Drawing.Size(541, 178);
            this.ActivityGridControl.TabIndex = 1;
            this.ActivityGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.ActivityGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddBtn);
            this.layoutControl1.Controls.Add(this.totalCostTextBox);
            this.layoutControl1.Controls.Add(this.endDateDateEdit);
            this.layoutControl1.Controls.Add(this.startDateDateEdit);
            this.layoutControl1.Controls.Add(this.descriptionTextBox);
            this.layoutControl1.Controls.Add(this.activityNameTextBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1017, 109, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(541, 182);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 136);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(133, 34);
            this.AddBtn.StyleController = this.layoutControl1;
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add";
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectActivityBindingSource, "TotalCost", true));
            this.totalCostTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTextBox.Location = new System.Drawing.Point(110, 112);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(419, 20);
            this.totalCostTextBox.TabIndex = 9;
            // 
            // projectActivityBindingSource
            // 
            this.projectActivityBindingSource.DataSource = typeof(Xprema.Base.ProjectActivity);
            // 
            // endDateDateEdit
            // 
            this.endDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectActivityBindingSource, "EndDate", true));
            this.endDateDateEdit.EditValue = null;
            this.endDateDateEdit.Location = new System.Drawing.Point(110, 86);
            this.endDateDateEdit.Name = "endDateDateEdit";
            this.endDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.endDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Size = new System.Drawing.Size(419, 22);
            this.endDateDateEdit.StyleController = this.layoutControl1;
            this.endDateDateEdit.TabIndex = 8;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectActivityBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(110, 60);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Size = new System.Drawing.Size(419, 22);
            this.startDateDateEdit.StyleController = this.layoutControl1;
            this.startDateDateEdit.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectActivityBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(110, 36);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(419, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // activityNameTextBox
            // 
            this.activityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectActivityBindingSource, "ActivityName", true));
            this.activityNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityNameTextBox.Location = new System.Drawing.Point(110, 12);
            this.activityNameTextBox.Name = "activityNameTextBox";
            this.activityNameTextBox.Size = new System.Drawing.Size(419, 20);
            this.activityNameTextBox.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.simpleSeparator1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(541, 182);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.activityNameTextBox;
            this.layoutControlItem2.CustomizationFormText = "Activity Name:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(521, 24);
            this.layoutControlItem2.Text = "Activity Name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.descriptionTextBox;
            this.layoutControlItem3.CustomizationFormText = "Description:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(521, 24);
            this.layoutControlItem3.Text = "Description:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.startDateDateEdit;
            this.layoutControlItem4.CustomizationFormText = "Start Date:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(521, 26);
            this.layoutControlItem4.Text = "Start Date:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.endDateDateEdit;
            this.layoutControlItem5.CustomizationFormText = "End Date:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(521, 26);
            this.layoutControlItem5.Text = "End Date:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.totalCostTextBox;
            this.layoutControlItem6.CustomizationFormText = "Total Cost:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(521, 24);
            this.layoutControlItem6.Text = "Total Cost:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.AddBtn;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(34, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(137, 38);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(137, 124);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(384, 38);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // frmProjectActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 438);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmProjectActivity";
            this.Text = "frmProjectActivity";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActivityGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl ActivityGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.BindingSource projectActivityBindingSource;
        private DevExpress.XtraEditors.DateEdit endDateDateEdit;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox activityNameTextBox;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton NextBtn;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}