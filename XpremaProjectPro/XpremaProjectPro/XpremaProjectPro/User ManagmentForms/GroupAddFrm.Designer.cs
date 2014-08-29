namespace XpremaProjectPro.User_ManagmentForms
{
    partial class GroupAddFrm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.groupDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator4 = new DevExpress.XtraLayout.SimpleSeparator();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Controls.Add(this.AddBtn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(393, 342);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Add Group";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupNameTextBox);
            this.layoutControl1.Controls.Add(this.groupDescriptionRichTextBox);
            this.layoutControl1.Controls.Add(this.checkedListBox1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(693, 97, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(389, 250);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameTextBox.Location = new System.Drawing.Point(135, 14);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.groupNameTextBox.TabIndex = 7;
            // 
            // groupDescriptionRichTextBox
            // 
            this.groupDescriptionRichTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDescriptionRichTextBox.Location = new System.Drawing.Point(135, 40);
            this.groupDescriptionRichTextBox.Name = "groupDescriptionRichTextBox";
            this.groupDescriptionRichTextBox.Size = new System.Drawing.Size(242, 52);
            this.groupDescriptionRichTextBox.TabIndex = 11;
            this.groupDescriptionRichTextBox.Text = "";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(135, 98);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(242, 124);
            this.checkedListBox1.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.simpleSeparator2,
            this.simpleSeparator3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.simpleSeparator1,
            this.simpleSeparator4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(389, 250);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.checkedListBox1;
            this.layoutControlItem3.CustomizationFormText = "Permissions:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(369, 142);
            this.layoutControlItem3.Text = "Permissions:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(120, 16);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 26);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(369, 2);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.CustomizationFormText = "simpleSeparator3";
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 228);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(369, 2);
            this.simpleSeparator3.Text = "simpleSeparator3";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.groupDescriptionRichTextBox;
            this.layoutControlItem4.CustomizationFormText = "Group Description:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(369, 56);
            this.layoutControlItem4.Text = "Group Description:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.groupNameTextBox;
            this.layoutControlItem1.CustomizationFormText = "Group Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 2);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(369, 24);
            this.layoutControlItem1.Text = "Group Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(120, 16);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 84);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(369, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // simpleSeparator4
            // 
            this.simpleSeparator4.AllowHotTrack = false;
            this.simpleSeparator4.CustomizationFormText = "simpleSeparator4";
            this.simpleSeparator4.Location = new System.Drawing.Point(0, 0);
            this.simpleSeparator4.Name = "simpleSeparator4";
            this.simpleSeparator4.Size = new System.Drawing.Size(369, 2);
            this.simpleSeparator4.Text = "simpleSeparator4";
            // 
            // AddBtn
            // 
            this.AddBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Appearance.Options.UseFont = true;
            this.AddBtn.Image = global::XpremaProjectPro.Properties.Resources.add_32x32;
            this.AddBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.AddBtn.Location = new System.Drawing.Point(12, 277);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(117, 50);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Add";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // GroupAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 342);
            this.Controls.Add(this.groupControl1);
            this.Name = "GroupAddFrm";
            this.Text = "Add Group";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private System.Windows.Forms.RichTextBox groupDescriptionRichTextBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator4;
    }
}