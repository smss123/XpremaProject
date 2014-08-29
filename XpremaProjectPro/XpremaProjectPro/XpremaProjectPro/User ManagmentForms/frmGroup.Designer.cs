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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.AddBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SaveBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.DeltBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.RefreshBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceItem.Normal.Options.UseFont = true;
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
            tileItemElement1.Image = global::XpremaProjectPro.Properties.Resources.AddBtn;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement1.Text = "ADD";
            this.AddBtn.Elements.Add(tileItemElement1);
            this.AddBtn.Id = 7;
            this.AddBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.AddBtn_ItemClick);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = global::XpremaProjectPro.Properties.Resources.savebt;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement2.Text = "Save";
            this.SaveBtn.Elements.Add(tileItemElement2);
            this.SaveBtn.Id = 4;
            this.SaveBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.SaveBtn_ItemClick);
            // 
            // DeltBtn
            // 
            this.DeltBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = global::XpremaProjectPro.Properties.Resources.delbtn;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement3.Text = "Delete";
            this.DeltBtn.Elements.Add(tileItemElement3);
            this.DeltBtn.Id = 6;
            this.DeltBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.DeltBtn.Name = "DeltBtn";
            this.DeltBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.DeltBtn_ItemClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = global::XpremaProjectPro.Properties.Resources.refbtn;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement4.Text = "Refresh";
            this.RefreshBtn.Elements.Add(tileItemElement4);
            this.RefreshBtn.Id = 5;
            this.RefreshBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.RefreshBtn_ItemClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(882, 221);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupDescriptionTextBox
            // 
            this.groupDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "GroupDescription", true));
            this.groupDescriptionTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDescriptionTextBox.Location = new System.Drawing.Point(136, 64);
            this.groupDescriptionTextBox.Name = "groupDescriptionTextBox";
            this.groupDescriptionTextBox.Size = new System.Drawing.Size(193, 122);
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
            this.groupNameTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameTextBox.Location = new System.Drawing.Point(136, 38);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.groupNameTextBox.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(421, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(445, 169);
            this.checkedListBox1.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userGroupBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(136, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(193, 20);
            this.idTextBox.TabIndex = 7;
            this.idTextBox.Visible = false;
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
            this.gridView1.OptionsFind.AlwaysVisible = true;
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupDescriptionTextBox);
            this.layoutControl1.Controls.Add(this.checkedListBox1);
            this.layoutControl1.Controls.Add(this.idTextBox);
            this.layoutControl1.Controls.Add(this.groupNameTextBox);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(878, 198);
            this.layoutControl1.TabIndex = 12;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.simpleSeparator1,
            this.simpleSeparator2,
            this.simpleSeparator3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(878, 198);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupNameTextBox;
            this.layoutControlItem1.CustomizationFormText = "Group Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem1.Text = "Group Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupDescriptionTextBox;
            this.layoutControlItem2.CustomizationFormText = "Group Description:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(321, 126);
            this.layoutControlItem2.Text = "Group Description:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(120, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkedListBox1;
            this.layoutControlItem3.CustomizationFormText = "Permissions:";
            this.layoutControlItem3.Location = new System.Drawing.Point(323, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(535, 178);
            this.layoutControlItem3.Text = "Permissions:";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 16);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.idTextBox;
            this.layoutControlItem4.CustomizationFormText = "ID";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(321, 24);
            this.layoutControlItem4.Text = "ID";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(120, 16);
            this.layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(321, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 178);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 24);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(321, 2);
            this.simpleSeparator2.Text = "simpleSeparator2";
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.CustomizationFormText = "simpleSeparator3";
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 50);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(321, 2);
            this.simpleSeparator3.Text = "simpleSeparator3";
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
            ((System.ComponentModel.ISupportInitialize)(this.userGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
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
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private DevExpress.XtraBars.Navigation.TileBarItem AddBtn;
        private System.Windows.Forms.RichTextBox groupDescriptionTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupDescription;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
    }
}