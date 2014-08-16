namespace XpremaProjectPro.Employee
{
    partial class EmployeeMangmentFrm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMangmentFrm));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.AddBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SaveBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.DeltBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.RefreshBtn = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.EmployeegridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeegridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.tileBar1.Size = new System.Drawing.Size(889, 98);
            this.tileBar1.TabIndex = 4;
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
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement1.Text = "Add";
            this.AddBtn.Elements.Add(tileItemElement1);
            this.AddBtn.Id = 7;
            this.AddBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.AddBtn.Name = "AddBtn";
            // 
            // SaveBtn
            // 
            this.SaveBtn.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
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
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
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
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement4.Text = "Refresh";
            this.RefreshBtn.Elements.Add(tileItemElement4);
            this.RefreshBtn.Id = 5;
            this.RefreshBtn.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.RefreshBtn.Name = "RefreshBtn";
            // 
            // EmployeegridControl
            // 
            this.EmployeegridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeegridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeegridControl.Location = new System.Drawing.Point(0, 98);
            this.EmployeegridControl.MainView = this.gridView1;
            this.EmployeegridControl.Name = "EmployeegridControl";
            this.EmployeegridControl.Size = new System.Drawing.Size(889, 469);
            this.EmployeegridControl.TabIndex = 5;
            this.EmployeegridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.EmployeegridControl;
            this.gridView1.Name = "gridView1";
            // 
            // EmployeeMangmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 567);
            this.Controls.Add(this.EmployeegridControl);
            this.Controls.Add(this.tileBar1);
            this.Name = "EmployeeMangmentFrm";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeegridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem AddBtn;
        private DevExpress.XtraBars.Navigation.TileBarItem SaveBtn;
        private DevExpress.XtraBars.Navigation.TileBarItem DeltBtn;
        private DevExpress.XtraBars.Navigation.TileBarItem RefreshBtn;
        private DevExpress.XtraGrid.GridControl EmployeegridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

    }
}