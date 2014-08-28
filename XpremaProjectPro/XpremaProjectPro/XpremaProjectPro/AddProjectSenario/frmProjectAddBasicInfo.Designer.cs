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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.endDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.TimeLinetextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Addbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.projectProfileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectProfileBindingSource
            // 
            this.projectProfileBindingSource.DataSource = typeof(Xprema.Base.ProjectProfile);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Addbtn);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(620, 389);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
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
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(616, 166);
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
            this.layoutControlItem12,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem6,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(616, 166);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // endDateDateEdit
            // 
            this.endDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectProfileBindingSource, "EndDate", true));
            this.endDateDateEdit.EditValue = null;
            this.endDateDateEdit.Location = new System.Drawing.Point(110, 108);
            this.endDateDateEdit.Name = "endDateDateEdit";
            this.endDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Size = new System.Drawing.Size(494, 20);
            this.endDateDateEdit.StyleController = this.layoutControl1;
            this.endDateDateEdit.TabIndex = 5;
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectProfileBindingSource, "ProjectDescription", true));
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(110, 36);
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(494, 20);
            this.projectDescriptionTextBox.TabIndex = 9;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectProfileBindingSource, "ProjectName", true));
            this.projectNameTextBox.Location = new System.Drawing.Point(110, 12);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(494, 20);
            this.projectNameTextBox.TabIndex = 11;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.projectProfileBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(110, 60);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Size = new System.Drawing.Size(494, 20);
            this.startDateDateEdit.StyleController = this.layoutControl1;
            this.startDateDateEdit.TabIndex = 13;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectProfileBindingSource, "TotalCost", true));
            this.totalCostTextBox.Location = new System.Drawing.Point(110, 132);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(494, 20);
            this.totalCostTextBox.TabIndex = 15;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.endDateDateEdit;
            this.layoutControlItem2.CustomizationFormText = "End Date:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem2.Text = "End Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.projectDescriptionTextBox;
            this.layoutControlItem6.CustomizationFormText = "Project Description:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem6.Text = "Project Description:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.projectNameTextBox;
            this.layoutControlItem8.CustomizationFormText = "Project Name:";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem8.Text = "Project Name:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.startDateDateEdit;
            this.layoutControlItem10.CustomizationFormText = "Start Date:";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem10.Text = "Start Date:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.totalCostTextBox;
            this.layoutControlItem12.CustomizationFormText = "Total Cost:";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(596, 26);
            this.layoutControlItem12.Text = "Total Cost:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(94, 13);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Summry";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 187);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(616, 121);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Summary";
            // 
            // TimeLinetextBox
            // 
            this.TimeLinetextBox.Location = new System.Drawing.Point(110, 84);
            this.TimeLinetextBox.Name = "TimeLinetextBox";
            this.TimeLinetextBox.Size = new System.Drawing.Size(494, 20);
            this.TimeLinetextBox.TabIndex = 16;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TimeLinetextBox;
            this.layoutControlItem1.CustomizationFormText = "Time Line:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(596, 24);
            this.layoutControlItem1.Text = "Time Line:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(94, 13);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(492, 339);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(114, 38);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "Next";
            // 
            // frmProjectAddBasicInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 389);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmProjectAddBasicInfo";
            this.Text = "frmProjectAddBasicInfo";
            ((System.ComponentModel.ISupportInitialize)(this.projectProfileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource projectProfileBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label1;
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
        private DevExpress.XtraEditors.SimpleButton Addbtn;
    }
}