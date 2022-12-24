namespace ItemExchange2._0
{
    partial class TagPage
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
            this.TagGridView = new System.Windows.Forms.DataGridView();
            this.TagColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddTag = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyTag = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TagGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TagGridView
            // 
            this.TagGridView.AllowUserToAddRows = false;
            this.TagGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagColumn,
            this.PropertyColumn});
            this.TagGridView.Location = new System.Drawing.Point(3, 35);
            this.TagGridView.Name = "TagGridView";
            this.TagGridView.ReadOnly = true;
            this.TagGridView.RowHeadersWidth = 62;
            this.TagGridView.RowTemplate.Height = 30;
            this.TagGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TagGridView.Size = new System.Drawing.Size(794, 150);
            this.TagGridView.TabIndex = 0;
            this.TagGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TagGridView_MouseUp);
            // 
            // TagColumn
            // 
            this.TagColumn.HeaderText = "类别";
            this.TagColumn.MinimumWidth = 8;
            this.TagColumn.Name = "TagColumn";
            this.TagColumn.Width = 200;
            // 
            // PropertyColumn
            // 
            this.PropertyColumn.HeaderText = "属性";
            this.PropertyColumn.MinimumWidth = 8;
            this.PropertyColumn.Name = "PropertyColumn";
            this.PropertyColumn.Width = 400;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTag,
            this.ModifyTag});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 64);
            // 
            // AddTag
            // 
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(116, 30);
            this.AddTag.Text = "添加";
            this.AddTag.Click += new System.EventHandler(this.AddTag_Click);
            // 
            // ModifyTag
            // 
            this.ModifyTag.Name = "ModifyTag";
            this.ModifyTag.Size = new System.Drawing.Size(116, 30);
            this.ModifyTag.Text = "修改";
            this.ModifyTag.Click += new System.EventHandler(this.ModifyTag_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(539, 409);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 38);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TagPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TagGridView);
            this.Name = "TagPage";
            this.Text = "TagPage";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.TagGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TagGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddTag;
        private System.Windows.Forms.ToolStripMenuItem ModifyTag;
        private System.Windows.Forms.Button SaveButton;
    }
}