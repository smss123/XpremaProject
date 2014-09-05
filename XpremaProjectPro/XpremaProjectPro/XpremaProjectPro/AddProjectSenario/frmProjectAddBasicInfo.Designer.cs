namespace XpremaProjectPro.AddProjectSenario
{
    partial class frmProjectAddBasicInfo
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
            this.projectProfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectAddgroupControl = new DevExpress.XtraEditors.GroupControl();
            this.Nextbtn = new DevExpress.XtraEditors.SimpleButton();
            this.SummarygroupControl = new DevExpress.XtraEditors.GroupControl();
            this.lblSummry = new System.Windows.Forms.Label();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TimeLinetextBox = new System.Windows.Forms.TextBox();
            this.endDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.projectProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAddgroupControl)).BeginInit();
            this.ProjectAddgroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummarygroupControl)).BeginInit();
            this.SummarygroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectProfileBindingSource
            // 
            this.projectProfileBindingSource.DataSource = typeof(Xprema.Base.ProjectProfile);
            // 
            // ProjectAddgroupControl
            // 
            this.ProjectAddgroupControl.Controls.Add(this.Nextbtn);
            this.ProjectAddgroupControl.Controls.Add(this.SummarygroupControl);
            this.ProjectAddgroupControl.Controls.Add(this.layoutControl1);
            this.ProjectAddgroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectAddgroupControl.Location = new System.Drawing.Point(0, 0);
            this.ProjectAddgroupControl.Name = "ProjectAddgroupControl";
            this.ProjectAddgroupControl.Size = new System.Drawing.Size(618, 490);
            this.ProjectAddgroupControl.TabIndex = 0;
            this.ProjectAddgroupControl.Text = "Add Project ";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(496, 446);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(114, 38);
            this.Nextbtn.TabIndex = 3;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // SummarygroupControl
            // 
            this.SummarygroupControl.Controls.Add(this.lblSummry);
            this.SummarygroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SummarygroupControl.Location = new System.Drawing.Point(2, 237);
            this.SummarygroupControl.Name = "SummarygroupControl";
            this.SummarygroupControl.Size = new System.Drawing.Size(614, 193);
            this.SummarygroupControl.TabIndex = 2;
            this.SummarygroupControl.Text = "Summary";
            // 
            // lblSummry
            // 
            this.lblSummry.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummry.Location = new System.Drawing.Point(16, 35);
            this.lblSummry.Name = "lblSummry";
            this.lblSummry.Size = new System.Drawing.Size(554, 140);
            this.lblSummry.TabIndex = 1;
            this.lblSummry.Text = "Project Summry";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TimeLinetextBox);
            this.layoutControl1.Controls.Add(this.endDateDateEdit);
            this.layoutControl1.Controls.Add(this.projectDescriptionTextBox);
            this.layoutControl1.Controls.Add(this.projectNameTextBox);
            this.layoutControl1.Controls.Add(this.startDateDateEdit);
            this.layoutControl1.Controls.Add(this.totalCostTextBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1158, 98, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(614, 216);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TimeLinetextBox
            // 
            this.TimeLinetextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLinetextBox.Location = new System.Drawing.Point(144, 86);
            this.TimeLinetextBox.Name = "TimeLinetextBox";
            this.TimeLinetextBox.Size = new System.Drawing.Size(458, 20);
            this.TimeLinetextBox.TabIndex = 16;
            this.TimeLinetextBox.Text = "{Enter Time Line as Month}";
            this.TimeLinetextBox.TextChanged += new System.EventHandler(this.TimeLinetextBox_TextChanged);
            // 
            // endDateDateEdit
            // 
            this.endDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectProfileBindingSource, "EndDate", true));
            this.endDateDateEdit.EditValue = null;
            this.endDateDateEdit.Location = new System.Drawing.Point(144, 110);
            this.endDateDateEdit.Name = "endDateDateEdit";
            this.endDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.endDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Size = new System.Drawing.Size(458, 22);
            this.endDateDateEdit.StyleController = this.layoutControl1;
            this.endDateDateEdit.TabIndex = 5;
            this.endDateDateEdit.EditValueChanged += new System.EventHandler(this.endDateDateEdit_EditValueChanged);
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectProfileBindingSource, "ProjectDescription", true));
            this.projectDescriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(144, 36);
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(458, 20);
            this.projectDescriptionTextBox.TabIndex = 9;
            this.projectDescriptionTextBox.TextChanged += new System.EventHandler(this.projectDescriptionTextBox_TextChanged);
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectProfileBindingSource, "ProjectName", true));
            this.projectNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameTextBox.Location = new System.Drawing.Point(144, 12);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(458, 20);
            this.projectNameTextBox.TabIndex = 11;
            this.projectNameTextBox.TextChanged += new System.EventHandler(this.projectNameTextBox_TextChanged);
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectProfileBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(144, 60);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateDateEdit.Properties.Appearance.Options.UseFont = true;
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Size = new System.Drawing.Size(458, 22);
            this.startDateDateEdit.StyleController = this.layoutControl1;
            this.startDateDateEdit.TabIndex = 13;
            this.startDateDateEdit.EditValueChanged += new System.EventHandler(this.startDateDateEdit_EditValueChanged);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectProfileBindingSource, "TotalCost", true));
            this.totalCostTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostTextBox.Location = new System.Drawing.Point(144, 136);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(458, 20);
            this.totalCostTextBox.TabIndex = 15;
            this.totalCostTextBox.TextChanged += new System.EventHandler(this.totalCostTextBox_TextChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem12,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.simpleSeparator1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(614, 216);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.endDateDateEdit;
            this.layoutControlItem2.CustomizationFormText = "End Date:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(594, 26);
            this.layoutControlItem2.Text = "End Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(129, 16);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.totalCostTextBox;
            this.layoutControlItem12.CustomizationFormText = "Total Cost:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(594, 24);
            this.layoutControlItem12.Text = "Total Cost:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(129, 16);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.projectNameTextBox;
            this.layoutControlItem8.CustomizationFormText = "Project Name:";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(594, 24);
            this.layoutControlItem8.Text = "Project Name:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(129, 16);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.startDateDateEdit;
            this.layoutControlItem10.CustomizationFormText = "Start Date:";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(594, 26);
            this.layoutControlItem10.Text = "Start Date:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(129, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.projectDescriptionTextBox;
            this.layoutControlItem6.CustomizationFormText = "Project Description:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(594, 24);
            this.layoutControlItem6.Text = "Project Description:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(129, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TimeLinetextBox;
            this.layoutControlItem1.CustomizationFormText = "Time Line:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(594, 24);
            this.layoutControlItem1.Text = "Time Line:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(129, 16);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 148);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(594, 48);
            this.simpleSeparator1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // frmProjectAddBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 490);
            this.Controls.Add(this.ProjectAddgroupControl);
            this.Name = "frmProjectAddBasicInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProjectAddBasicInfo";
            ((System.ComponentModel.ISupportInitialize)(this.projectProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAddgroupControl)).EndInit();
            this.ProjectAddgroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SummarygroupControl)).EndInit();
            this.SummarygroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource projectProfileBindingSource;
        private DevExpress.XtraEditors.GroupControl ProjectAddgroupControl;
        private DevExpress.XtraEditors.GroupControl SummarygroupControl;
        private System.Windows.Forms.Label lblSummry;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox TimeLinetextBox;
        private DevExpress.XtraEditors.DateEdit endDateDateEdit;
        private System.Windows.Forms.TextBox projectDescriptionTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton Nextbtn;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}