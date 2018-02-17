namespace scheduleOfRun.Forms
{
    partial class RunsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunsList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemNumColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellphoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endOrNotColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.editButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nameColumn,
            this.familyColumn,
            this.studentNumColumn,
            this.teacherColumn,
            this.systemNumColumn,
            this.startDateColumn,
            this.endDateColumn,
            this.cellphoneColumn,
            this.noteColumn,
            this.endOrNotColumn});
            this.dataGridView1.Location = new System.Drawing.Point(-35, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "شناسه";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "name";
            this.nameColumn.HeaderText = "نام";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // familyColumn
            // 
            this.familyColumn.DataPropertyName = "family";
            this.familyColumn.HeaderText = "نام خانوادگی";
            this.familyColumn.Name = "familyColumn";
            this.familyColumn.ReadOnly = true;
            // 
            // studentNumColumn
            // 
            this.studentNumColumn.DataPropertyName = "studentNum";
            this.studentNumColumn.HeaderText = "ش دانشجویی";
            this.studentNumColumn.Name = "studentNumColumn";
            this.studentNumColumn.ReadOnly = true;
            // 
            // teacherColumn
            // 
            this.teacherColumn.DataPropertyName = "teacher";
            this.teacherColumn.HeaderText = "استاد";
            this.teacherColumn.Name = "teacherColumn";
            this.teacherColumn.ReadOnly = true;
            // 
            // systemNumColumn
            // 
            this.systemNumColumn.DataPropertyName = "systemNum";
            this.systemNumColumn.HeaderText = "نام سیستم";
            this.systemNumColumn.Name = "systemNumColumn";
            this.systemNumColumn.ReadOnly = true;
            // 
            // startDateColumn
            // 
            this.startDateColumn.DataPropertyName = "startDate";
            this.startDateColumn.HeaderText = "تاریخ شروع";
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.ReadOnly = true;
            // 
            // endDateColumn
            // 
            this.endDateColumn.DataPropertyName = "endDate";
            this.endDateColumn.HeaderText = "تاریخ پایان";
            this.endDateColumn.Name = "endDateColumn";
            this.endDateColumn.ReadOnly = true;
            // 
            // cellphoneColumn
            // 
            this.cellphoneColumn.DataPropertyName = "cellphone";
            this.cellphoneColumn.HeaderText = "تلفن همراه";
            this.cellphoneColumn.Name = "cellphoneColumn";
            this.cellphoneColumn.ReadOnly = true;
            // 
            // noteColumn
            // 
            this.noteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noteColumn.DataPropertyName = "note";
            this.noteColumn.HeaderText = "توضیحات";
            this.noteColumn.Name = "noteColumn";
            this.noteColumn.ReadOnly = true;
            // 
            // endOrNotColumn
            // 
            this.endOrNotColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endOrNotColumn.DataPropertyName = "endOrNot";
            this.endOrNotColumn.HeaderText = "تحویل سیستم";
            this.endOrNotColumn.Name = "endOrNotColumn";
            this.endOrNotColumn.ReadOnly = true;
            // 
            // deleteButton
            // 
            this.deleteButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.ImageOptions.Image")));
            this.deleteButton.Location = new System.Drawing.Point(456, 244);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 42);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "حذف";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editButton.ImageOptions.Image")));
            this.editButton.Location = new System.Drawing.Point(573, 244);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(94, 42);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "ویرایش";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(208, 255);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(225, 20);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.ImageOptions.Image")));
            this.searchButton.Location = new System.Drawing.Point(690, 244);
            this.searchButton.Name = "searchButton";
            this.searchButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchButton.Size = new System.Drawing.Size(94, 42);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "جست‌و‌جو";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "label10";
            // 
            // RunsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 298);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RunsList";
            this.Text = "RunsList";
            this.Load += new System.EventHandler(this.RunsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton deleteButton;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemNumColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellphoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endOrNotColumn;
    }
}