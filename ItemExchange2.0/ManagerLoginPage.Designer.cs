namespace ItemExchange2._0
{
    partial class ManagerLoginPage
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
            this.ManagerPasswordLabel = new Sunny.UI.UILabel();
            this.ManagerPasswordtextBox = new System.Windows.Forms.TextBox();
            this.ManagerPasswordButton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // ManagerPasswordLabel
            // 
            this.ManagerPasswordLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManagerPasswordLabel.Location = new System.Drawing.Point(92, 138);
            this.ManagerPasswordLabel.Name = "ManagerPasswordLabel";
            this.ManagerPasswordLabel.Size = new System.Drawing.Size(149, 47);
            this.ManagerPasswordLabel.TabIndex = 1;
            this.ManagerPasswordLabel.Text = "管理员密码";
            this.ManagerPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManagerPasswordLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ManagerPasswordtextBox
            // 
            this.ManagerPasswordtextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManagerPasswordtextBox.Location = new System.Drawing.Point(279, 143);
            this.ManagerPasswordtextBox.Name = "ManagerPasswordtextBox";
            this.ManagerPasswordtextBox.PasswordChar = '*';
            this.ManagerPasswordtextBox.Size = new System.Drawing.Size(191, 39);
            this.ManagerPasswordtextBox.TabIndex = 2;
            // 
            // ManagerPasswordButton
            // 
            this.ManagerPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagerPasswordButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManagerPasswordButton.Location = new System.Drawing.Point(243, 238);
            this.ManagerPasswordButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ManagerPasswordButton.Name = "ManagerPasswordButton";
            this.ManagerPasswordButton.Size = new System.Drawing.Size(100, 35);
            this.ManagerPasswordButton.TabIndex = 3;
            this.ManagerPasswordButton.Text = "确认";
            this.ManagerPasswordButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManagerPasswordButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ManagerPasswordButton.Click += new System.EventHandler(this.ManagerPasswordButton_Click);
            // 
            // ManagerLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 324);
            this.Controls.Add(this.ManagerPasswordButton);
            this.Controls.Add(this.ManagerPasswordtextBox);
            this.Controls.Add(this.ManagerPasswordLabel);
            this.Name = "ManagerLoginPage";
            this.Text = "ManagerLoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel ManagerPasswordLabel;
        private System.Windows.Forms.TextBox ManagerPasswordtextBox;
        private Sunny.UI.UIButton ManagerPasswordButton;
    }
}