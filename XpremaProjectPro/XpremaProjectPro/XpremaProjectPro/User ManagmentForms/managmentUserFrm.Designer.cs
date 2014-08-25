namespace XpremaProjectPro.User_ManagmentForms
{
    partial class managmentUserFrm
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
            this.UsersgridControl = new DevExpress.XtraGrid.GridControl();
            this.userSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGroup_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContracts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersgridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceText.Options.UseFont = true;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 8;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(884, 98);
            this.tileBar1.TabIndex = 1;
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
            tileItemElement1.Text = "Add";
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
            // 
            // UsersgridControl
            // 
            this.UsersgridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsersgridControl.DataSource = this.userSystemBindingSource;
            this.UsersgridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersgridControl.Location = new System.Drawing.Point(0, 98);
            this.UsersgridControl.MainView = this.gridView1;
            this.UsersgridControl.Name = "UsersgridControl";
            this.UsersgridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.UsersgridControl.Size = new System.Drawing.Size(884, 483);
            this.UsersgridControl.TabIndex = 2;
            this.UsersgridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // userSystemBindingSource
            // 
            this.userSystemBindingSource.DataSource = typeof(Xprema.Base.UserSystem);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUserName,
            this.colPassword,
            this.colUserGroup_Id,
            this.colContracts,
            this.colUserGroup});
            this.gridView1.GridControl = this.UsersgridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 144;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            this.colUserName.Width = 144;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            this.colPassword.Width = 144;
            // 
            // colUserGroup_Id
            // 
            this.colUserGroup_Id.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colUserGroup_Id.FieldName = "UserGroup.GroupName";
            this.colUserGroup_Id.Name = "colUserGroup_Id";
            this.colUserGroup_Id.Visible = true;
            this.colUserGroup_Id.VisibleIndex = 3;
            this.colUserGroup_Id.Width = 164;
            // 
            // colContracts
            // 
            this.colContracts.FieldName = "Contracts";
            this.colContracts.Name = "colContracts";
            this.colContracts.Visible = true;
            this.colContracts.VisibleIndex = 4;
            this.colContracts.Width = 134;
            // 
            // colUserGroup
            // 
            this.colUserGroup.FieldName = "UserGroup";
            this.colUserGroup.Name = "colUserGroup";
            this.colUserGroup.Visible = true;
            this.colUserGroup.VisibleIndex = 5;
            this.colUserGroup.Width = 136;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // managmentUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.UsersgridControl);
            this.Controls.Add(this.tileBar1);
            this.Name = "managmentUserFrm";
            this.Text = "managmentUserFrm";
            ((System.ComponentModel.ISupportInitialize)(this.UsersgridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem SaveBtn;
        private DevExpress.XtraBars.Navigation.TileBarItem RefreshBtn;
        private DevExpress.XtraBars.Navigation.TileBarItem DeltBtn;
        private DevExpress.XtraGrid.GridControl UsersgridControl;
        private System.Windows.Forms.BindingSource userSystemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroup_Id;
        private DevExpress.XtraGrid.Columns.GridColumn colContracts;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroup;
        private DevExpress.XtraBars.Navigation.TileBarItem AddBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;

    }
}