namespace ItemExchange2._0
{
    partial class TagEdit
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
            this.TagNameTextBox = new System.Windows.Forms.TextBox();
            this.TagPropertyTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "类别名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "属性(分号隔开)";
            // 
            // TagNameTextBox
            // 
            this.TagNameTextBox.Location = new System.Drawing.Point(258, 102);
            this.TagNameTextBox.Name = "TagNameTextBox";
            this.TagNameTextBox.Size = new System.Drawing.Size(281, 28);
            this.TagNameTextBox.TabIndex = 2;
            // 
            // TagPropertyTextBox
            // 
            this.TagPropertyTextBox.Location = new System.Drawing.Point(258, 207);
            this.TagPropertyTextBox.Name = "TagPropertyTextBox";
            this.TagPropertyTextBox.Size = new System.Drawing.Size(281, 28);
            this.TagPropertyTextBox.TabIndex = 3;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(599, 306);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(84, 41);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "确认";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // TagAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 359);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.TagPropertyTextBox);
            this.Controls.Add(this.TagNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TagAdd";
            this.Text = "TagAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TagNameTextBox;
        private System.Windows.Forms.TextBox TagPropertyTextBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}