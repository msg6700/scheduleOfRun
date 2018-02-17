namespace scheduleOfRun.Forms
{
    partial class SystemList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.systemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endOrNotColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmptySystembutton = new System.Windows.Forms.Button();
            this.OccupiedُSystemButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.systemColumn,
            this.endDateColumn,
            this.endOrNotColumn,
            this.studentNumColumn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(500, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // systemColumn
            // 
            this.systemColumn.DataPropertyName = "systemNum";
            this.systemColumn.HeaderText = "نام سیستم";
            this.systemColumn.Name = "systemColumn";
            this.systemColumn.ReadOnly = true;
            // 
            // endDateColumn
            // 
            this.endDateColumn.DataPropertyName = "endDate";
            this.endDateColumn.HeaderText = "آخرین استفاده";
            this.endDateColumn.Name = "endDateColumn";
            this.endDateColumn.ReadOnly = true;
            // 
            // endOrNotColumn
            // 
            this.endOrNotColumn.DataPropertyName = "endOrNot";
            this.endOrNotColumn.HeaderText = "اتمام استفاده";
            this.endOrNotColumn.Name = "endOrNotColumn";
            this.endOrNotColumn.ReadOnly = true;
            // 
            // studentNumColumn
            // 
            this.studentNumColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentNumColumn.DataPropertyName = "studentNum";
            this.studentNumColumn.HeaderText = "شماره دانشحویی";
            this.studentNumColumn.Name = "studentNumColumn";
            this.studentNumColumn.ReadOnly = true;
            // 
            // EmptySystembutton
            // 
            this.EmptySystembutton.Location = new System.Drawing.Point(289, 228);
            this.EmptySystembutton.Name = "EmptySystembutton";
            this.EmptySystembutton.Size = new System.Drawing.Size(100, 21);
            this.EmptySystembutton.TabIndex = 1;
            this.EmptySystembutton.Text = "سیستم های خالی";
            this.EmptySystembutton.UseVisualStyleBackColor = true;
            this.EmptySystembutton.Click += new System.EventHandler(this.empty_Click);
            // 
            // OccupiedُSystemButton
            // 
            this.OccupiedُSystemButton.Location = new System.Drawing.Point(24, 229);
            this.OccupiedُSystemButton.Name = "OccupiedُSystemButton";
            this.OccupiedُSystemButton.Size = new System.Drawing.Size(121, 21);
            this.OccupiedُSystemButton.TabIndex = 2;
            this.OccupiedُSystemButton.Text = "سیستم های پر";
            this.OccupiedُSystemButton.UseVisualStyleBackColor = true;
            this.OccupiedُSystemButton.Click += new System.EventHandler(this.occupied_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1396/01/01";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SystemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OccupiedُSystemButton);
            this.Controls.Add(this.EmptySystembutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SystemList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیست سیستم ها";
            this.Load += new System.EventHandler(this.SystemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EmptySystembutton;
        private System.Windows.Forms.Button OccupiedُSystemButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endOrNotColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}