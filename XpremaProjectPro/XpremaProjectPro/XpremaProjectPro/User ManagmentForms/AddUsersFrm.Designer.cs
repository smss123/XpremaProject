namespace XpremaProjectPro.User_ManagmentForms
{
    partial class AddUsersFrm
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            this.userSystemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.GroupNamelookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.AddBtn = new DevExpress.XtraEditors.SimpleButton();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNamelookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSystemBindingSource
            // 
            this.userSystemBindingSource.DataSource = typeof(Xprema.Base.UserSystem);
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(18, 35);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(87, 32);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.userNameTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(23, 64);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 13);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userSystemBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(87, 61);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(176, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // GroupNamelookUpEdit
            // 
            this.GroupNamelookUpEdit.Location = new System.Drawing.Point(86, 94);
            this.GroupNamelookUpEdit.Name = "GroupNamelookUpEdit";
            this.GroupNamelookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GroupNamelookUpEdit.Size = new System.Drawing.Size(176, 20);
            this.GroupNamelookUpEdit.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 6;
            label1.Text = "Group:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.AddBtn);
            this.groupControl1.Controls.Add(this.GroupNamelookUpEdit);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(this.userNameTextBox);
            this.groupControl1.Controls.Add(userNameLabel);
            this.groupControl1.Controls.Add(passwordLabel);
            this.groupControl1.Controls.Add(this.passwordTextBox);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(307, 230);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "groupControl1";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 164);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(150, 34);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add";
            // 
            // AddUsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 230);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddUsersFrm";
            this.Text = "AddUsersFrm";
            ((System.ComponentModel.ISupportInitialize)(this.userSystemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupNamelookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource userSystemBindingSource;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private DevExpress.XtraEditors.LookUpEdit GroupNamelookUpEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton AddBtn;
    }
}