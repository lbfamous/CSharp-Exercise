namespace Ex_26
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip0 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBarFileExit = new System.Windows.Forms.ToolStripButton();
            this.toolBarViewRed = new System.Windows.Forms.ToolStripButton();
            this.toolBarViewYellow = new System.Windows.Forms.ToolStripButton();
            this.toolbarViewBlue = new System.Windows.Forms.ToolStripButton();
            this.toolBarHelpAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip0.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip0
            // 
            this.MenuStrip0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.View,
            this.Help});
            this.MenuStrip0.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip0.Name = "MenuStrip0";
            this.MenuStrip0.Size = new System.Drawing.Size(284, 25);
            this.MenuStrip0.TabIndex = 0;
            this.MenuStrip0.Text = "MenuStrip0";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(58, 21);
            this.File.Text = "文件(&F)";
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(152, 22);
            this.FileExit.Text = "退出(&E)";
            this.FileExit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewRed,
            this.ViewYellow,
            this.ViewBlue});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(60, 21);
            this.View.Text = "视图(&V)";
            // 
            // ViewRed
            // 
            this.ViewRed.Name = "ViewRed";
            this.ViewRed.Size = new System.Drawing.Size(152, 22);
            this.ViewRed.Text = "红色(&R)";
            this.ViewRed.Click += new System.EventHandler(this.ViewRed_Click);
            // 
            // ViewYellow
            // 
            this.ViewYellow.Name = "ViewYellow";
            this.ViewYellow.Size = new System.Drawing.Size(152, 22);
            this.ViewYellow.Text = "黄色(Y)";
            this.ViewYellow.Click += new System.EventHandler(this.ViewYellow_Click);
            // 
            // ViewBlue
            // 
            this.ViewBlue.Name = "ViewBlue";
            this.ViewBlue.Size = new System.Drawing.Size(152, 22);
            this.ViewBlue.Text = "蓝色(&B)";
            this.ViewBlue.Click += new System.EventHandler(this.ViewBlue_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(61, 21);
            this.Help.Text = "帮助(&H)";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.Size = new System.Drawing.Size(152, 22);
            this.HelpAbout.Text = "关于...";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarFileExit,
            this.toolStripSeparator1,
            this.toolBarViewRed,
            this.toolBarViewYellow,
            this.toolbarViewBlue,
            this.toolStripSeparator2,
            this.toolBarHelpAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolBarFileExit
            // 
            this.toolBarFileExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarFileExit.Image = ((System.Drawing.Image)(resources.GetObject("toolBarFileExit.Image")));
            this.toolBarFileExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarFileExit.Name = "toolBarFileExit";
            this.toolBarFileExit.Size = new System.Drawing.Size(36, 22);
            this.toolBarFileExit.Text = "退出";
            this.toolBarFileExit.ToolTipText = "退出程序";
            // 
            // toolBarViewRed
            // 
            this.toolBarViewRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarViewRed.Image = ((System.Drawing.Image)(resources.GetObject("toolBarViewRed.Image")));
            this.toolBarViewRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarViewRed.Name = "toolBarViewRed";
            this.toolBarViewRed.Size = new System.Drawing.Size(24, 22);
            this.toolBarViewRed.Text = "红";
            this.toolBarViewRed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolBarViewYellow
            // 
            this.toolBarViewYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarViewYellow.Image = ((System.Drawing.Image)(resources.GetObject("toolBarViewYellow.Image")));
            this.toolBarViewYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarViewYellow.Name = "toolBarViewYellow";
            this.toolBarViewYellow.Size = new System.Drawing.Size(24, 22);
            this.toolBarViewYellow.Text = "黄";
            // 
            // toolbarViewBlue
            // 
            this.toolbarViewBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarViewBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolbarViewBlue.Image")));
            this.toolbarViewBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarViewBlue.Name = "toolbarViewBlue";
            this.toolbarViewBlue.Size = new System.Drawing.Size(24, 22);
            this.toolbarViewBlue.Text = "蓝";
            // 
            // toolBarHelpAbout
            // 
            this.toolBarHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBarHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolBarHelpAbout.Image")));
            this.toolBarHelpAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBarHelpAbout.Name = "toolBarHelpAbout";
            this.toolBarHelpAbout.Size = new System.Drawing.Size(36, 22);
            this.toolBarHelpAbout.Text = "关于";
            this.toolBarHelpAbout.ToolTipText = "帮助信息";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MenuStrip0);
            this.MainMenuStrip = this.MenuStrip0;
            this.Name = "Form1";
            this.Text = "使用菜单";
            this.MenuStrip0.ResumeLayout(false);
            this.MenuStrip0.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip0;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem ViewRed;
        private System.Windows.Forms.ToolStripMenuItem ViewYellow;
        private System.Windows.Forms.ToolStripMenuItem ViewBlue;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBarFileExit;
        private System.Windows.Forms.ToolStripButton toolBarViewRed;
        private System.Windows.Forms.ToolStripButton toolBarViewYellow;
        private System.Windows.Forms.ToolStripButton toolbarViewBlue;
        private System.Windows.Forms.ToolStripButton toolBarHelpAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

