namespace ItemExchange2._0
{
    partial class ItemPage
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
            this.TagComboBox = new System.Windows.Forms.ComboBox();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.TagColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchButton = new Sunny.UI.UIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchItemName = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchProperty = new Sunny.UI.UITextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowButton = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TagComboBox
            // 
            this.TagComboBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.TagComboBox.FormattingEnabled = true;
            this.TagComboBox.Location = new System.Drawing.Point(202, 97);
            this.TagComboBox.Name = "TagComboBox";
            this.TagComboBox.Size = new System.Drawing.Size(121, 35);
            this.TagComboBox.TabIndex = 1;
            this.TagComboBox.SelectedIndexChanged += new System.EventHandler(this.TagComboBox_SelectedIndexChanged);
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagColumn,
            this.NameColumn,
            this.PropertyColumn,
            this.AddressColumn,
            this.PhoneColumn,
            this.EmailColumn});
            this.ItemGridView.Location = new System.Drawing.Point(3, 162);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            this.ItemGridView.RowHeadersWidth = 62;
            this.ItemGridView.RowTemplate.Height = 30;
            this.ItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGridView.Size = new System.Drawing.Size(1114, 368);
            this.ItemGridView.TabIndex = 2;
            this.ItemGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ItemGridView_MouseUp);
            // 
            // TagColumn
            // 
            this.TagColumn.HeaderText = "种类";
            this.TagColumn.MinimumWidth = 8;
            this.TagColumn.Name = "TagColumn";
            this.TagColumn.ReadOnly = true;
            this.TagColumn.Width = 150;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "物品名称";
            this.NameColumn.MinimumWidth = 8;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 150;
            // 
            // PropertyColumn
            // 
            this.PropertyColumn.HeaderText = "物品说明";
            this.PropertyColumn.MinimumWidth = 8;
            this.PropertyColumn.Name = "PropertyColumn";
            this.PropertyColumn.ReadOnly = true;
            this.PropertyColumn.Width = 200;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "所在地址";
            this.AddressColumn.MinimumWidth = 8;
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            this.AddressColumn.Width = 150;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "联系人手机";
            this.PhoneColumn.MinimumWidth = 8;
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            this.PhoneColumn.Width = 200;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "联系人邮箱";
            this.EmailColumn.MinimumWidth = 8;
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            this.EmailColumn.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "种类";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.label4.Location = new System.Drawing.Point(329, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "+";
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchButton.Location = new System.Drawing.Point(854, 87);
            this.SearchButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 39);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "搜索";
            this.SearchButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "物品名称";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItem,
            this.DelItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(117, 64);
            // 
            // AddItem
            // 
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(116, 30);
            this.AddItem.Text = "添加";
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // DelItem
            // 
            this.DelItem.Name = "DelItem";
            this.DelItem.Size = new System.Drawing.Size(116, 30);
            this.DelItem.Text = "删除";
            this.DelItem.Click += new System.EventHandler(this.DelItem_Click);
            // 
            // SearchItemName
            // 
            this.SearchItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchItemName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.SearchItemName.Location = new System.Drawing.Point(378, 97);
            this.SearchItemName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchItemName.MinimumSize = new System.Drawing.Size(1, 16);
            this.SearchItemName.Name = "SearchItemName";
            this.SearchItemName.ShowText = false;
            this.SearchItemName.Size = new System.Drawing.Size(193, 31);
            this.SearchItemName.TabIndex = 10;
            this.SearchItemName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchItemName.Watermark = "";
            this.SearchItemName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.label3.Location = new System.Drawing.Point(585, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "/";
            // 
            // SearchProperty
            // 
            this.SearchProperty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchProperty.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchProperty.Location = new System.Drawing.Point(624, 97);
            this.SearchProperty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchProperty.MinimumSize = new System.Drawing.Size(1, 16);
            this.SearchProperty.Name = "SearchProperty";
            this.SearchProperty.ShowText = false;
            this.SearchProperty.Size = new System.Drawing.Size(203, 29);
            this.SearchProperty.TabIndex = 12;
            this.SearchProperty.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchProperty.Watermark = "";
            this.SearchProperty.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "物品说明";
            // 
            // ShowButton
            // 
            this.ShowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowButton.Location = new System.Drawing.Point(1017, 121);
            this.ShowButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(100, 35);
            this.ShowButton.TabIndex = 14;
            this.ShowButton.Text = "所有物品";
            this.ShowButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ItemPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 533);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchProperty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemGridView);
            this.Controls.Add(this.TagComboBox);
            this.Name = "ItemPage";
            this.Text = "UserPage";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TagComboBox;
        private System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIButton SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddItem;
        private System.Windows.Forms.ToolStripMenuItem DelItem;
        private Sunny.UI.UITextBox SearchItemName;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox SearchProperty;
        private System.Windows.Forms.Label label5;
        private Sunny.UI.UIButton ShowButton;
    }
}