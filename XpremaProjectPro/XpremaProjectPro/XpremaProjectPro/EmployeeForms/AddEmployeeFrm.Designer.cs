namespace XpremaProjectPro.Employee
{
    partial class AddEmployeeFrm
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
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            this.employeeNationalNumberTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mobilenumberTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.employeeGenderComboBox = new System.Windows.Forms.ComboBox();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.employeejobNumberTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 206);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(173, 49);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "add";
            // 
            // employeeNationalNumberTextBox
            // 
            this.employeeNationalNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeNationalNumber", true));
            this.employeeNationalNumberTextBox.Location = new System.Drawing.Point(147, 133);
            this.employeeNationalNumberTextBox.Name = "employeeNationalNumberTextBox";
            this.employeeNationalNumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.employeeNationalNumberTextBox.TabIndex = 10;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.mobilenumberTextBox;
            this.layoutControlItem6.CustomizationFormText = "Mobilenumber:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem6.Text = "Mobilenumber:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(132, 13);
            // 
            // mobilenumberTextBox
            // 
            this.mobilenumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Mobilenumber", true));
            this.mobilenumberTextBox.Location = new System.Drawing.Point(147, 109);
            this.mobilenumberTextBox.Name = "mobilenumberTextBox";
            this.mobilenumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.mobilenumberTextBox.TabIndex = 9;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.phoneNumberTextBox;
            this.layoutControlItem5.CustomizationFormText = "Phone Number:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem5.Text = "Phone Number:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(132, 13);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(147, 85);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.phoneNumberTextBox.TabIndex = 8;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.employeeGenderComboBox;
            this.layoutControlItem4.CustomizationFormText = "Employee Gender:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(396, 25);
            this.layoutControlItem4.Text = "Employee Gender:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(132, 13);
            // 
            // employeeGenderComboBox
            // 
            this.employeeGenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeGender", true));
            this.employeeGenderComboBox.FormattingEnabled = true;
            this.employeeGenderComboBox.Location = new System.Drawing.Point(147, 60);
            this.employeeGenderComboBox.Name = "employeeGenderComboBox";
            this.employeeGenderComboBox.Size = new System.Drawing.Size(257, 21);
            this.employeeGenderComboBox.TabIndex = 7;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.employeeNationalNumberTextBox;
            this.layoutControlItem7.CustomizationFormText = "Employee National Number:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(396, 38);
            this.layoutControlItem7.Text = "Employee National Number:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(132, 13);
            // 
            // employeejobNumberTextBox
            // 
            this.employeejobNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeejobNumber", true));
            this.employeejobNumberTextBox.Location = new System.Drawing.Point(147, 36);
            this.employeejobNumberTextBox.Name = "employeejobNumberTextBox";
            this.employeejobNumberTextBox.Size = new System.Drawing.Size(257, 20);
            this.employeejobNumberTextBox.TabIndex = 6;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.employeeNameTextBox;
            this.layoutControlItem2.CustomizationFormText = "Employee Name:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem2.Text = "Employee Name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(132, 13);
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployeeName", true));
            this.employeeNameTextBox.Location = new System.Drawing.Point(147, 12);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.employeeNameTextBox.TabIndex = 5;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(416, 179);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.employeejobNumberTextBox;
            this.layoutControlItem3.CustomizationFormText = "Employeejob Number:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(396, 24);
            this.layoutControlItem3.Text = "Employeejob Number:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(132, 13);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.employeeNationalNumberTextBox);
            this.layoutControl1.Controls.Add(this.mobilenumberTextBox);
            this.layoutControl1.Controls.Add(this.phoneNumberTextBox);
            this.layoutControl1.Controls.Add(this.employeeGenderComboBox);
            this.layoutControl1.Controls.Add(this.employeejobNumberTextBox);
            this.layoutControl1.Controls.Add(this.employeeNameTextBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(416, 179);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.AddBtn);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(420, 282);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Xprema.Base.Employee);
            // 
            // AddEmployeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 282);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddEmployeeFrm";
            this.Text = "AddEmployeeFrm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private System.Windows.Forms.TextBox employeeNationalNumberTextBox;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.TextBox mobilenumberTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ComboBox employeeGenderComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.TextBox employeejobNumberTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}