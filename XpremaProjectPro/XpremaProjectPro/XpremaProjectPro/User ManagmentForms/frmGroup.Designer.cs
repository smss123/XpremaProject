namespace XpremaProjectPro.User_ManagmentForms
{
    partial class frmGroup
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
            System.Windows.Forms.Label groupNameLabel;
            System.Windows.Forms.Label groupDescriptionLabel;
            System.Windows.Forms.Label idLabel;
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.SaveBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.RefreshBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.DeltBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.userGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.GroupgridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupNameLabel = new System.Windows.Forms.Label();
            groupDescriptionLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.Location = new System.Drawing.Point(38, 82);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(70, 13);
            groupNameLabel.TabIndex = 0;
            groupNameLabel.Text = "Group Name:";
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.Location = new System.Drawing.Point(12, 125);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            groupDescriptionLabel.TabIndex = 2;
            groupDescriptionLabel.Text = "Group Description:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(87, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 7;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(882, 98);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.SaveBtn);
            this.tileBarGroup2.Items.Add(this.DeltBtn);
            this.tileBarGroup2.Items.Add(this.RefreshBtn);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // SaveBtn
            // 
            this.SaveBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "Save";
            this.SaveBtn.Elements.Add(tileItemElement1);
            this.SaveBtn.Id = 4;
            this.SaveBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Refresh";
            this.RefreshBtn.Elements.Add(tileItemElement3);
            this.RefreshBtn.Id = 5;
            this.RefreshBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.RefreshBtn.Name = "RefreshBtn";
            // 
            // DeltBtn
            // 
            this.DeltBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "Delete";
            this.DeltBtn.Elements.Add(tileItemElement2);
            this.DeltBtn.Id = 6;
            this.DeltBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.DeltBtn.Name = "DeltBtn";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkedListBox1);
            this.groupControl1.Controls.Add(idLabel);
            this.groupControl1.Controls.Add(this.idTextBox);
            this.groupControl1.Controls.Add(groupDescriptionLabel);
            this.groupControl1.Controls.Add(this.groupDescriptionTextBox);
            this.groupControl1.Controls.Add(groupNameLabel);
            this.groupControl1.Controls.Add(this.groupNameTextBox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(882, 179);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(412, 44);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(412, 109);
            this.checkedListBox1.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(114, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(101, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // userGroupBindingSource
            // 
            this.userGroupBindingSource.DataSource = typeof(Xprema.Base.UserGroup);
            // 
            // groupDescriptionTextBox
            // 
            this.groupDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupDescription", true));
            this.groupDescriptionTextBox.Location = new System.Drawing.Point(114, 122);
            this.groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            this.groupDescriptionTextBox.Size = new System.Drawing.Size(212, 20);
            this.groupDescriptionTextBox.TabIndex = 3;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupName", true));
            this.groupNameTextBox.Location = new System.Drawing.Point(114, 79);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(212, 20);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // GroupgridControl
            // 
            this.GroupgridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupgridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupgridControl.Location = new System.Drawing.Point(0, 277);
            this.GroupgridControl.MainView = this.gridView1;
            this.GroupgridControl.Name = "GroupgridControl";
            this.GroupgridControl.Size = new System.Drawing.Size(882, 262);
            this.GroupgridControl.TabIndex = 2;
            this.GroupgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GroupgridControl;
            this.gridView1.Name = "gridView1";
            // 
            // frmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 539);
            this.Controls.Add(this.GroupgridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileBar1);
            this.Name = "frmGroup";
            this.Text = "frmGroup";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem SaveBtn;
        private DevExpress.XtraBars.Navigation.TileBarItem RefreshBtn;
        private DevExpress.XtraBars.Navigation.TileBarItem DeltBtn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GroupgridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource userGroupBindingSource;
        private System.Windows.Forms.TextBox groupDescriptionTextBox;
        private System.Windows.Forms.TextBox groupNameTextBox;
    }
}