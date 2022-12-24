namespace ItemExchange2._0
{
    partial class UserRegisterPage
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
            this.RegisterConfirmButton = new Sunny.UI.UIButton();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserAddressLabel = new System.Windows.Forms.Label();
            this.UserPhoneNumberLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserAddressTextBox = new System.Windows.Forms.TextBox();
            this.UserPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterConfirmButton
            // 
            this.RegisterConfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterConfirmButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterConfirmButton.Location = new System.Drawing.Point(303, 365);
            this.RegisterConfirmButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.RegisterConfirmButton.Name = "RegisterConfirmButton";
            this.RegisterConfirmButton.Size = new System.Drawing.Size(165, 35);
            this.RegisterConfirmButton.TabIndex = 0;
            this.RegisterConfirmButton.Text = "提交注册申请";
            this.RegisterConfirmButton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegisterConfirmButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.RegisterConfirmButton.Click += new System.EventHandler(this.RegisterConfirmButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(164, 105);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(62, 18);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "用户名";
            // 
            // UserAddressLabel
            // 
            this.UserAddressLabel.AutoSize = true;
            this.UserAddressLabel.Location = new System.Drawing.Point(182, 166);
            this.UserAddressLabel.Name = "UserAddressLabel";
            this.UserAddressLabel.Size = new System.Drawing.Size(44, 18);
            this.UserAddressLabel.TabIndex = 2;
            this.UserAddressLabel.Text = "地址";
            // 
            // UserPhoneNumberLabel
            // 
            this.UserPhoneNumberLabel.AutoSize = true;
            this.UserPhoneNumberLabel.Location = new System.Drawing.Point(173, 233);
            this.UserPhoneNumberLabel.Name = "UserPhoneNumberLabel";
            this.UserPhoneNumberLabel.Size = new System.Drawing.Size(62, 18);
            this.UserPhoneNumberLabel.TabIndex = 3;
            this.UserPhoneNumberLabel.Text = "手机号";
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(182, 294);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(44, 18);
            this.UserPasswordLabel.TabIndex = 4;
            this.UserPasswordLabel.Text = "密码";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(270, 102);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(291, 28);
            this.UserNameTextBox.TabIndex = 5;
            // 
            // UserAddressTextBox
            // 
            this.UserAddressTextBox.Location = new System.Drawing.Point(270, 163);
            this.UserAddressTextBox.Name = "UserAddressTextBox";
            this.UserAddressTextBox.Size = new System.Drawing.Size(291, 28);
            this.UserAddressTextBox.TabIndex = 6;
            // 
            // UserPhoneNumberTextBox
            // 
            this.UserPhoneNumberTextBox.Location = new System.Drawing.Point(270, 230);
            this.UserPhoneNumberTextBox.Name = "UserPhoneNumberTextBox";
            this.UserPhoneNumberTextBox.Size = new System.Drawing.Size(291, 28);
            this.UserPhoneNumberTextBox.TabIndex = 7;
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.Location = new System.Drawing.Point(270, 291);
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.PasswordChar = '*';
            this.UserPasswordTextBox.Size = new System.Drawing.Size(291, 28);
            this.UserPasswordTextBox.TabIndex = 8;
            // 
            // UserRegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.UserPasswordTextBox);
            this.Controls.Add(this.UserPhoneNumberTextBox);
            this.Controls.Add(this.UserAddressTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserPhoneNumberLabel);
            this.Controls.Add(this.UserAddressLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.RegisterConfirmButton);
            this.Name = "UserRegisterPage";
            this.Text = "UserRegisterPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton RegisterConfirmButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserAddressLabel;
        private System.Windows.Forms.Label UserPhoneNumberLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox UserAddressTextBox;
        private System.Windows.Forms.TextBox UserPhoneNumberTextBox;
        private System.Windows.Forms.TextBox UserPasswordTextBox;
    }
}