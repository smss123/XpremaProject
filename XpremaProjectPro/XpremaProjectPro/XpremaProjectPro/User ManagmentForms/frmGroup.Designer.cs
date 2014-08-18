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
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.idLabel = new System.Windows.Forms.Label();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.AddBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SaveBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.DeltBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.RefreshBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.userGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.GroupgridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            groupNameLabel = new System.Windows.Forms.Label();
            groupDescriptionLabel = new System.Windows.Forms.Label();
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
            groupNameLabel.Location = new System.Drawing.Point(31, 64);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(70, 13);
            groupNameLabel.TabIndex = 7;
            groupNameLabel.Text = "Group Name:";
            // 
            // groupDescriptionLabel
            // 
            groupDescriptionLabel.AutoSize = true;
            groupDescriptionLabel.Location = new System.Drawing.Point(5, 100);
            groupDescriptionLabel.Name = "groupDescriptionLabel";
            groupDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            groupDescriptionLabel.TabIndex = 8;
            groupDescriptionLabel.Text = "Group Description:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(80, 27);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "Id:";
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 8;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(882, 98);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.AddBtn);
            this.tileBarGroup2.Items.Add(this.SaveBtn);
            this.tileBarGroup2.Items.Add(this.DeltBtn);
            this.tileBarGroup2.Items.Add(this.RefreshBtn);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // AddBtn
            // 
            this.AddBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Text = "ADD";
            this.AddBtn.Elements.Add(tileItemElement5);
            this.AddBtn.Id = 7;
            this.AddBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.AddBtn_ItemClick);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Text = "Save";
            this.SaveBtn.Elements.Add(tileItemElement6);
            this.SaveBtn.Id = 4;
            this.SaveBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // DeltBtn
            // 
            this.DeltBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.Text = "Delete";
            this.DeltBtn.Elements.Add(tileItemElement7);
            this.DeltBtn.Id = 6;
            this.DeltBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.DeltBtn.Name = "DeltBtn";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.Text = "Refresh";
            this.RefreshBtn.Elements.Add(tileItemElement8);
            this.RefreshBtn.Id = 5;
            this.RefreshBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.RefreshBtn.Name = "RefreshBtn";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.groupDescriptionTextBox);
            this.groupControl1.Controls.Add(groupDescriptionLabel);
            this.groupControl1.Controls.Add(groupNameLabel);
            this.groupControl1.Controls.Add(this.groupNameTextBox);
            this.groupControl1.Controls.Add(this.checkedListBox1);
            this.groupControl1.Controls.Add(this.idLabel);
            this.groupControl1.Controls.Add(this.idTextBox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(882, 221);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Permissions:";
            // 
            // groupDescriptionTextBox
            // 
            this.groupDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupDescription", true));
            this.groupDescriptionTextBox.Location = new System.Drawing.Point(107, 87);
            this.groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            this.groupDescriptionTextBox.Size = new System.Drawing.Size(229, 96);
            this.groupDescriptionTextBox.TabIndex = 2;
            this.groupDescriptionTextBox.Text = "";
            // 
            // userGroupBindingSource
            // 
            this.userGroupBindingSource.DataSource = typeof(Xprema.Base.UserGroup);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupName", true));
            this.groupNameTextBox.Location = new System.Drawing.Point(107, 61);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(229, 21);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(423, 48);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(447, 132);
            this.checkedListBox1.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(107, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 21);
            this.idTextBox.TabIndex = 7;
            // 
            // GroupgridControl
            // 
            this.GroupgridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.GroupgridControl.DataSource = this.userGroupBindingSource;
            this.GroupgridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupgridControl.Location = new System.Drawing.Point(0, 319);
            this.GroupgridControl.MainView = this.gridView1;
            this.GroupgridControl.Name = "GroupgridControl";
            this.GroupgridControl.Size = new System.Drawing.Size(882, 220);
            this.GroupgridControl.TabIndex = 2;
            this.GroupgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colGroupName,
            this.colGroupDescription});
            this.gridView1.GridControl = this.GroupgridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colGroupName
            // 
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 1;
            // 
            // colGroupDescription
            // 
            this.colGroupDescription.FieldName = "GroupDescription";
            this.colGroupDescription.Name = "colGroupDescription";
            this.colGroupDescription.Visible = true;
            this.colGroupDescription.VisibleIndex = 2;
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
            this.Load += new System.EventHandler(this.frmGroup_Load);
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
        private System.Windows.Forms.BindingSource userGroupBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DevExpress.XtraBars.Navigation.TileBarItem AddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox groupDescriptionTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupDescription;
    }
}