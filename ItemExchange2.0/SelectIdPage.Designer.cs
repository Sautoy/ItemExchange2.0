namespace ItemExchange2._0
{
    partial class SelectIdPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userBotton = new Sunny.UI.UIButton();
            this.managerButton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // userBotton
            // 
            this.userBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBotton.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.userBotton.Location = new System.Drawing.Point(148, 117);
            this.userBotton.MinimumSize = new System.Drawing.Size(1, 1);
            this.userBotton.Name = "userBotton";
            this.userBotton.Size = new System.Drawing.Size(170, 70);
            this.userBotton.TabIndex = 0;
            this.userBotton.Text = "普通用户";
            this.userBotton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userBotton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.userBotton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // managerButton
            // 
            this.managerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managerButton.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.managerButton.Location = new System.Drawing.Point(491, 117);
            this.managerButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(170, 70);
            this.managerButton.TabIndex = 1;
            this.managerButton.Text = "管理员";
            this.managerButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.managerButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // SelectIdPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.userBotton);
            this.Name = "SelectIdPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton userBotton;
        private Sunny.UI.UIButton managerButton;
    }
}

