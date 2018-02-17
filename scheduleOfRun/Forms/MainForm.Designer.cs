namespace scheduleOfRun
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ثبتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستافرادToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سیستمهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 154);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(317, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتToolStripMenuItem,
            this.لیستToolStripMenuItem,
            this.سیستمهاToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ثبتToolStripMenuItem
            // 
            this.ثبتToolStripMenuItem.Name = "ثبتToolStripMenuItem";
            this.ثبتToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ثبتToolStripMenuItem.Text = "ثبت";
            this.ثبتToolStripMenuItem.Click += new System.EventHandler(this.ثبتToolStripMenuItem_Click);
            // 
            // لیستToolStripMenuItem
            // 
            this.لیستToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لیستافرادToolStripMenuItem});
            this.لیستToolStripMenuItem.Name = "لیستToolStripMenuItem";
            this.لیستToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.لیستToolStripMenuItem.Text = "لیست";
            // 
            // لیستافرادToolStripMenuItem
            // 
            this.لیستافرادToolStripMenuItem.Name = "لیستافرادToolStripMenuItem";
            this.لیستافرادToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.لیستافرادToolStripMenuItem.Text = "لیست افراد";
            this.لیستافرادToolStripMenuItem.Click += new System.EventHandler(this.لیستافرادToolStripMenuItem_Click);
            // 
            // سیستمهاToolStripMenuItem
            // 
            this.سیستمهاToolStripMenuItem.Name = "سیستمهاToolStripMenuItem";
            this.سیستمهاToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.سیستمهاToolStripMenuItem.Text = "سیستم ها";
            this.سیستمهاToolStripMenuItem.Click += new System.EventHandler(this.سیستمهاToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(317, 176);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه زمان بندی ران های دانشکده";
            this.TransparencyKey = System.Drawing.Color.BlueViolet;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ثبتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستافرادToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سیستمهاToolStripMenuItem;
    }
}