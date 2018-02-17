namespace scheduleOfRun.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.systemNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teacherTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentNumTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.familyTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.submitButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endDateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.endOrNotcheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام  :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(429, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // systemNumTextBox
            // 
            this.systemNumTextBox.Location = new System.Drawing.Point(12, 66);
            this.systemNumTextBox.Name = "systemNumTextBox";
            this.systemNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.systemNumTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 69);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره سیستم:";
            // 
            // teacherTextBox
            // 
            this.teacherTextBox.Location = new System.Drawing.Point(429, 66);
            this.teacherTextBox.Name = "teacherTextBox";
            this.teacherTextBox.Size = new System.Drawing.Size(100, 20);
            this.teacherTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 70);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "استاد:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 116);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاریخ شروع تحلیل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 151);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاریخ پایان تحلیل:";
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.Location = new System.Drawing.Point(233, 66);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.cellphoneTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 69);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "شماره همراه:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // studentNumTextBox
            // 
            this.studentNumTextBox.Location = new System.Drawing.Point(12, 26);
            this.studentNumTextBox.Name = "studentNumTextBox";
            this.studentNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentNumTextBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 29);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "شماره دانشجویی:";
            // 
            // familyTextBox
            // 
            this.familyTextBox.Location = new System.Drawing.Point(233, 26);
            this.familyTextBox.Name = "familyTextBox";
            this.familyTextBox.Size = new System.Drawing.Size(100, 20);
            this.familyTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 29);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = " نام خانوادگی :";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(12, 113);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(167, 116);
            this.noteTextBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 116);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "توضیحات :";
            // 
            // submitButton
            // 
            this.submitButton.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Appearance.Options.UseBackColor = true;
            this.submitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("submitButton.ImageOptions.Image")));
            this.submitButton.Location = new System.Drawing.Point(472, 190);
            this.submitButton.Name = "submitButton";
            this.submitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.submitButton.Size = new System.Drawing.Size(89, 39);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "ثبت";
            this.submitButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Appearance.Options.UseBackColor = true;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.ImageOptions.Image")));
            this.cancelButton.Location = new System.Drawing.Point(358, 190);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelButton.Size = new System.Drawing.Size(89, 39);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "بی خیال";
            this.cancelButton.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(207, 190);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(126, 39);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "مجموع استفاده";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateColumn,
            this.endDateColumn});
            this.dataGridView1.Location = new System.Drawing.Point(606, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(270, 240);
            this.dataGridView1.TabIndex = 24;
            // 
            // startDateColumn
            // 
            this.startDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateColumn.DataPropertyName = "startDate";
            this.startDateColumn.HeaderText = "startDateColumn";
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.ReadOnly = true;
            // 
            // endDateColumn
            // 
            this.endDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateColumn.DataPropertyName = "endDate";
            this.endDateColumn.HeaderText = "endDateColumn";
            this.endDateColumn.Name = "endDateColumn";
            this.endDateColumn.ReadOnly = true;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(371, 109);
            this.startDateTextBox.Mask = "0000/00/00";
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.startDateTextBox.TabIndex = 7;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(371, 148);
            this.endDateTextBox.Mask = "0000/00/00";
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.endDateTextBox.TabIndex = 8;
            // 
            // endOrNotcheckBox
            // 
            this.endOrNotcheckBox.AutoSize = true;
            this.endOrNotcheckBox.Enabled = false;
            this.endOrNotcheckBox.Location = new System.Drawing.Point(247, 111);
            this.endOrNotcheckBox.Name = "endOrNotcheckBox";
            this.endOrNotcheckBox.Size = new System.Drawing.Size(86, 17);
            this.endOrNotcheckBox.TabIndex = 45;
            this.endOrNotcheckBox.Text = "اتمام استفاده";
            this.endOrNotcheckBox.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(877, 241);
            this.Controls.Add(this.endOrNotcheckBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.familyTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.studentNumTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cellphoneTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.systemNumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox systemNumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teacherTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentNumTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox familyTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton submitButton;
        private DevExpress.XtraEditors.SimpleButton cancelButton;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox startDateTextBox;
        private System.Windows.Forms.MaskedTextBox endDateTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateColumn;
        private System.Windows.Forms.CheckBox endOrNotcheckBox;
    }
}