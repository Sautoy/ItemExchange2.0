namespace ItemExchange2._0
{
    partial class UserLoginPage
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
            this.UserRegisterButton = new Sunny.UI.UIButton();
            this.UserNameTextBox = new Sunny.UI.UITextBox();
            this.UserPasswordTextBox = new Sunny.UI.UITextBox();
            this.UserLogInButton = new Sunny.UI.UIButton();
            this.UserNameLabel = new Sunny.UI.UILabel();
            this.PasswordLabel = new Sunny.UI.UILabel();
            this.CheckLabel = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // UserRegisterButton
            // 
            this.UserRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserRegisterButton.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.UserRegisterButton.Location = new System.Drawing.Point(324, 355);
            this.UserRegisterButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserRegisterButton.Name = "UserRegisterButton";
            this.UserRegisterButton.Size = new System.Drawing.Size(100, 50);
            this.UserRegisterButton.TabIndex = 1;
            this.UserRegisterButton.Text = "注册";
            this.UserRegisterButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserRegisterButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.UserRegisterButton.Click += new System.EventHandler(this.UserRegisterButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTextBox.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.UserNameTextBox.Location = new System.Drawing.Point(220, 87);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserNameTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.ShowText = false;
            this.UserNameTextBox.Size = new System.Drawing.Size(333, 37);
            this.UserNameTextBox.TabIndex = 4;
            this.UserNameTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameTextBox.Watermark = "";
            this.UserNameTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPasswordTextBox.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.UserPasswordTextBox.Location = new System.Drawing.Point(220, 167);
            this.UserPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserPasswordTextBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.ShowText = false;
            this.UserPasswordTextBox.Size = new System.Drawing.Size(333, 40);
            this.UserPasswordTextBox.TabIndex = 5;
            this.UserPasswordTextBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserPasswordTextBox.Watermark = "";
            this.UserPasswordTextBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserLogInButton
            // 
            this.UserLogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserLogInButton.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.UserLogInButton.Location = new System.Drawing.Point(324, 256);
            this.UserLogInButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserLogInButton.Name = "UserLogInButton";
            this.UserLogInButton.Size = new System.Drawing.Size(100, 50);
            this.UserLogInButton.TabIndex = 6;
            this.UserLogInButton.Text = "登录";
            this.UserLogInButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserLogInButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.UserLogInButton.Click += new System.EventHandler(this.UserLogInButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.UserNameLabel.Location = new System.Drawing.Point(85, 80);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(100, 44);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "用户名";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLabel.Location = new System.Drawing.Point(103, 167);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 40);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "密码";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasswordLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CheckLabel
            // 
            this.CheckLabel.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.CheckLabel.Location = new System.Drawing.Point(97, 355);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(175, 50);
            this.CheckLabel.TabIndex = 9;
            this.CheckLabel.Text = "还未注册？";
            this.CheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserLogInButton);
            this.Controls.Add(this.UserPasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserRegisterButton);
            this.Name = "UserLoginPage";
            this.Text = "UserLoginPage";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIButton UserRegisterButton;
        private Sunny.UI.UITextBox UserNameTextBox;
        private Sunny.UI.UITextBox UserPasswordTextBox;
        private Sunny.UI.UIButton UserLogInButton;
        private Sunny.UI.UILabel UserNameLabel;
        private Sunny.UI.UILabel PasswordLabel;
        private Sunny.UI.UILabel CheckLabel;
    }
}