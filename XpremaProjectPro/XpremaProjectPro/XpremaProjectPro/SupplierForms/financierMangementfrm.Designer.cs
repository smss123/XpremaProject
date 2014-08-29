namespace XpremaProjectPro.SupplierForms
{
    partial class financierMangementfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(financierMangementfrm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.RefreshBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.FinanciergridControl = new DevExpress.XtraGrid.GridControl();
            this.thefinancierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinanciername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colagentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdderss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaveColm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaveBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.DeleteColom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.FinanciergridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).BeginInit();
            this.SuspendLayout();
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
            this.tileBar1.Size = new System.Drawing.Size(1103, 98);
            this.tileBar1.TabIndex = 3;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.RefreshBtn);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "Refresh";
            this.RefreshBtn.Elements.Add(tileItemElement1);
            this.RefreshBtn.Id = 5;
            this.RefreshBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.RefreshBtn.Name = "RefreshBtn";
            // 
            // FinanciergridControl
            // 
            this.FinanciergridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.FinanciergridControl.DataSource = this.thefinancierBindingSource;
            this.FinanciergridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinanciergridControl.Location = new System.Drawing.Point(0, 98);
            this.FinanciergridControl.MainView = this.gridView1;
            this.FinanciergridControl.Name = "FinanciergridControl";
            this.FinanciergridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SaveBtn,
            this.BtnDelete});
            this.FinanciergridControl.Size = new System.Drawing.Size(1103, 471);
            this.FinanciergridControl.TabIndex = 4;
            this.FinanciergridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.FinanciergridControl.Click += new System.EventHandler(this.FinanciergridControl_Click);
            // 
            // thefinancierBindingSource
            // 
            this.thefinancierBindingSource.DataSource = typeof(Xprema.Base.Thefinancier);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colfinanciername,
            this.colPhoneNumber,
            this.colagentName,
            this.colFax,
            this.colEmail,
            this.colAdderss,
            this.SaveColm,
            this.DeleteColom});
            this.gridView1.GridControl = this.FinanciergridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colfinanciername
            // 
            this.colfinanciername.Caption = "Name";
            this.colfinanciername.FieldName = "financiername";
            this.colfinanciername.Name = "colfinanciername";
            this.colfinanciername.Visible = true;
            this.colfinanciername.VisibleIndex = 1;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Phone Number";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            // 
            // colagentName
            // 
            this.colagentName.Caption = "Agent Name";
            this.colagentName.FieldName = "agentName";
            this.colagentName.Name = "colagentName";
            this.colagentName.Visible = true;
            this.colagentName.VisibleIndex = 2;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // colAdderss
            // 
            this.colAdderss.Caption = "Adderss";
            this.colAdderss.FieldName = "Adderss";
            this.colAdderss.Name = "colAdderss";
            this.colAdderss.Visible = true;
            this.colAdderss.VisibleIndex = 6;
            // 
            // SaveColm
            // 
            this.SaveColm.Caption = "Save";
            this.SaveColm.ColumnEdit = this.SaveBtn;
            this.SaveColm.Name = "SaveColm";
            this.SaveColm.Visible = true;
            this.SaveColm.VisibleIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoHeight = false;
            this.SaveBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("SaveBtn.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteColom
            // 
            this.DeleteColom.Caption = "Delete";
            this.DeleteColom.ColumnEdit = this.BtnDelete;
            this.DeleteColom.Name = "DeleteColom";
            this.DeleteColom.Visible = true;
            this.DeleteColom.VisibleIndex = 8;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoHeight = false;
            this.BtnDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("BtnDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // financierMangementfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 569);
            this.Controls.Add(this.FinanciergridControl);
            this.Controls.Add(this.tileBar1);
            this.Name = "financierMangementfrm";
            this.Text = "financierMangementfrm";
            this.Load += new System.EventHandler(this.financierMangementfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinanciergridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thefinancierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem RefreshBtn;
        private DevExpress.XtraGrid.GridControl FinanciergridControl;
        private System.Windows.Forms.BindingSource thefinancierBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colfinanciername;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colagentName;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAdderss;
        private DevExpress.XtraGrid.Columns.GridColumn SaveColm;
        private DevExpress.XtraGrid.Columns.GridColumn DeleteColom;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit SaveBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnDelete;
    }
}