namespace ItemExchange2._0
{
    partial class ItemEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TagComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new Sunny.UI.UITextBox();
            this.PropertyTextBox = new Sunny.UI.UITextBox();
            this.AddressTextBox = new Sunny.UI.UITextBox();
            this.PhoneTextBox = new Sunny.UI.UITextBox();
            this.EmailTextBox = new Sunny.UI.UITextBox();
            this.ConfirmButton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "物品类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "物品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "物品说明";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "物品地址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "联系人电话";
            // 
            // TagComboBox
            // 
            this.TagComboBox.FormattingEnabled = true;
            this.TagComboBox.Location = new System.Drawing.Point(272, 55);
            this.TagComboBox.Name = "TagComboBox";
            this.TagComboBox.Size = new System.Drawing.Size(121, 26);
            this.TagComboBox.TabIndex = 5;
            this.TagComboBox.SelectionChangeCommitted += new System.EventHandler(this.TagComboBox_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "联系人邮箱";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ItemNameTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ItemNameTextBox.Location = new System.Drawing.Point(272, 121);
            this.ItemNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemNameTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.ShowText = false;
            this.ItemNameTextBox.Size = new System.Drawing.Size(270, 29);
            this.ItemNameTextBox.TabIndex = 7;
            this.ItemNameTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ItemNameTextBox.Watermark = "";
            this.ItemNameTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PropertyTextBox
            // 
            this.PropertyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PropertyTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PropertyTextBox.Location = new System.Drawing.Point(272, 184);
            this.PropertyTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PropertyTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.PropertyTextBox.Name = "PropertyTextBox";
            this.PropertyTextBox.ShowText = false;
            this.PropertyTextBox.Size = new System.Drawing.Size(270, 29);
            this.PropertyTextBox.TabIndex = 8;
            this.PropertyTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PropertyTextBox.Watermark = "";
            this.PropertyTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.AddressTextBox.Location = new System.Drawing.Point(272, 247);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ShowText = false;
            this.AddressTextBox.Size = new System.Drawing.Size(270, 29);
            this.AddressTextBox.TabIndex = 9;
            this.AddressTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddressTextBox.Watermark = "";
            this.AddressTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.PhoneTextBox.Location = new System.Drawing.Point(272, 310);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ShowText = false;
            this.PhoneTextBox.Size = new System.Drawing.Size(270, 29);
            this.PhoneTextBox.TabIndex = 10;
            this.PhoneTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhoneTextBox.Watermark = "";
            this.PhoneTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.EmailTextBox.Location = new System.Drawing.Point(272, 373);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ShowText = false;
            this.EmailTextBox.Size = new System.Drawing.Size(270, 29);
            this.EmailTextBox.TabIndex = 11;
            this.EmailTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmailTextBox.Watermark = "";
            this.EmailTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.Location = new System.Drawing.Point(572, 452);
            this.ConfirmButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(100, 35);
            this.ConfirmButton.TabIndex = 12;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PropertyTextBox);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TagComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ItemEdit";
            this.Text = "ItemEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TagComboBox;
        private System.Windows.Forms.Label label6;
        private Sunny.UI.UITextBox ItemNameTextBox;
        private Sunny.UI.UITextBox PropertyTextBox;
        private Sunny.UI.UITextBox AddressTextBox;
        private Sunny.UI.UITextBox PhoneTextBox;
        private Sunny.UI.UITextBox EmailTextBox;
        private Sunny.UI.UIButton ConfirmButton;
    }
}