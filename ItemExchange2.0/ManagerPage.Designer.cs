namespace ItemExchange2._0
{
    partial class ManagerPage
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
            this.tmpGridView = new System.Windows.Forms.DataGridView();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pass = new System.Windows.Forms.ToolStripMenuItem();
            this.Reject = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagManageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tmpGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmpGridView
            // 
            this.tmpGridView.AllowUserToAddRows = false;
            this.tmpGridView.AllowUserToResizeColumns = false;
            this.tmpGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tmpGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameColumn,
            this.AddressColumn,
            this.PhoneNumberColumn,
            this.PasswordColumn});
            this.tmpGridView.Location = new System.Drawing.Point(3, 93);
            this.tmpGridView.Name = "tmpGridView";
            this.tmpGridView.RowHeadersWidth = 62;
            this.tmpGridView.RowTemplate.Height = 30;
            this.tmpGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tmpGridView.Size = new System.Drawing.Size(965, 224);
            this.tmpGridView.TabIndex = 2;
            this.tmpGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tmpGridView_MouseUp);
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Location = new System.Drawing.Point(17, 46);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(158, 31);
            this.ApplicationLabel.TabIndex = 3;
            this.ApplicationLabel.Text = "未处理的申请";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pass,
            this.Reject});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 64);
            // 
            // Pass
            // 
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(116, 30);
            this.Pass.Text = "通过";
            this.Pass.Click += new System.EventHandler(this.PassStrip_Click);
            // 
            // Reject
            // 
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(116, 30);
            this.Reject.Text = "拒绝";
            this.Reject.Click += new System.EventHandler(this.RejectionStrip_Click);
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "用户名";
            this.UserNameColumn.MinimumWidth = 8;
            this.UserNameColumn.Name = "UserNameColumn";
            this.UserNameColumn.Width = 150;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "地址";
            this.AddressColumn.MinimumWidth = 8;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.Width = 250;
            // 
            // PhoneNumberColumn
            // 
            this.PhoneNumberColumn.HeaderText = "手机号";
            this.PhoneNumberColumn.MinimumWidth = 8;
            this.PhoneNumberColumn.Name = "PhoneNumberColumn";
            this.PhoneNumberColumn.Width = 250;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.HeaderText = "密码";
            this.PasswordColumn.MinimumWidth = 8;
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.Width = 250;
            // 
            // TagManageButton
            // 
            this.TagManageButton.Location = new System.Drawing.Point(839, 461);
            this.TagManageButton.Name = "TagManageButton";
            this.TagManageButton.Size = new System.Drawing.Size(129, 40);
            this.TagManageButton.TabIndex = 4;
            this.TagManageButton.Text = "标签管理";
            this.TagManageButton.UseVisualStyleBackColor = true;
            this.TagManageButton.Click += new System.EventHandler(this.TagManageButton_Click);
            // 
            // ManagerPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(971, 504);
            this.Controls.Add(this.TagManageButton);
            this.Controls.Add(this.ApplicationLabel);
            this.Controls.Add(this.tmpGridView);
            this.Name = "ManagerPage";
            this.Text = "ManagerPage";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.tmpGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tmpGridView;
        private System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Pass;
        private System.Windows.Forms.ToolStripMenuItem Reject;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
        private System.Windows.Forms.Button TagManageButton;
    }
}