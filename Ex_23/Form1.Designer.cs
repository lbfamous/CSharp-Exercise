namespace Ex_23
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_catchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_catchMe
            // 
            this.btn_catchMe.Location = new System.Drawing.Point(100, 100);
            this.btn_catchMe.Name = "btn_catchMe";
            this.btn_catchMe.Size = new System.Drawing.Size(75, 23);
            this.btn_catchMe.TabIndex = 0;
            this.btn_catchMe.Text = "来抓我呀";
            this.btn_catchMe.UseVisualStyleBackColor = true;
            this.btn_catchMe.Click += new System.EventHandler(this.btn_catchMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_catchMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_catchMe;
    }
}

