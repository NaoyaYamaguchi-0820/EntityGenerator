
namespace EntityGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.BeforeTextBox = new System.Windows.Forms.TextBox();
            this.AfterTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BeforeTextBox
            // 
            this.BeforeTextBox.Location = new System.Drawing.Point(12, 12);
            this.BeforeTextBox.Multiline = true;
            this.BeforeTextBox.Name = "BeforeTextBox";
            this.BeforeTextBox.Size = new System.Drawing.Size(608, 763);
            this.BeforeTextBox.TabIndex = 0;
            // 
            // AfterTextBox
            // 
            this.AfterTextBox.Location = new System.Drawing.Point(754, 12);
            this.AfterTextBox.Multiline = true;
            this.AfterTextBox.Name = "AfterTextBox";
            this.AfterTextBox.Size = new System.Drawing.Size(608, 763);
            this.AfterTextBox.TabIndex = 1;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(626, 370);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(122, 72);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "→";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 787);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.AfterTextBox);
            this.Controls.Add(this.BeforeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BeforeTextBox;
        private System.Windows.Forms.TextBox AfterTextBox;
        private System.Windows.Forms.Button ConvertButton;
    }
}

