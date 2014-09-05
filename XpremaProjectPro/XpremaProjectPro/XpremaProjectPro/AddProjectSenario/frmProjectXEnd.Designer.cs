namespace XpremaProjectPro.AddProjectSenario
{
    partial class frmProjectXEnd
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
            this.btnFinsh = new DevExpress.XtraEditors.SimpleButton();
            this.FinshedList = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.FinshedList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinsh
            // 
            this.btnFinsh.Location = new System.Drawing.Point(585, 416);
            this.btnFinsh.Name = "btnFinsh";
            this.btnFinsh.Size = new System.Drawing.Size(121, 44);
            this.btnFinsh.TabIndex = 0;
            this.btnFinsh.Text = "Finsh";
            // 
            // FinshedList
            // 
            this.FinshedList.Location = new System.Drawing.Point(12, 98);
            this.FinshedList.Name = "FinshedList";
            this.FinshedList.Size = new System.Drawing.Size(220, 269);
            this.FinshedList.TabIndex = 1;
            this.FinshedList.SelectedValueChanged += new System.EventHandler(this.FinshedList_SelectedValueChanged);
            // 
            // frmProjectXEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 472);
            this.Controls.Add(this.FinshedList);
            this.Controls.Add(this.btnFinsh);
            this.Name = "frmProjectXEnd";
            this.Text = "frmProjectXEnd";
            this.Load += new System.EventHandler(this.frmProjectXEnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FinshedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnFinsh;
        private DevExpress.XtraEditors.CheckedListBoxControl FinshedList;
    }
}