namespace QuanLyHocSinh
{
    partial class fCreateSummaryReport
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
            this.pnSubjectReport = new System.Windows.Forms.Panel();
            this.dgvSubjectReport = new System.Windows.Forms.DataGridView();
            this.btnCreateReport_Subject = new System.Windows.Forms.Button();
            this.btnPrintFile_Subject = new System.Windows.Forms.Button();
            this.cbSubject_Subject = new System.Windows.Forms.ComboBox();
            this.lbSubject_Subject = new System.Windows.Forms.Label();
            this.cbSemester_Subject = new System.Windows.Forms.ComboBox();
            this.lbSemester_Subject = new System.Windows.Forms.Label();
            this.lbSubjectReport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSemesterReport = new System.Windows.Forms.DataGridView();
            this.btnCreateReport_Semester = new System.Windows.Forms.Button();
            this.btnPrintFile_Semester = new System.Windows.Forms.Button();
            this.cbSubject_Semester = new System.Windows.Forms.ComboBox();
            this.lbSubject_Semester = new System.Windows.Forms.Label();
            this.cbSemester_Semester = new System.Windows.Forms.ComboBox();
            this.lbSemester_Semester = new System.Windows.Forms.Label();
            this.lbSemesterReport = new System.Windows.Forms.Label();
            this.pnExit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnSubjectReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectReport)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemesterReport)).BeginInit();
            this.pnExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSubjectReport
            // 
            this.pnSubjectReport.Controls.Add(this.dgvSubjectReport);
            this.pnSubjectReport.Controls.Add(this.btnCreateReport_Subject);
            this.pnSubjectReport.Controls.Add(this.btnPrintFile_Subject);
            this.pnSubjectReport.Controls.Add(this.cbSubject_Subject);
            this.pnSubjectReport.Controls.Add(this.lbSubject_Subject);
            this.pnSubjectReport.Controls.Add(this.cbSemester_Subject);
            this.pnSubjectReport.Controls.Add(this.lbSemester_Subject);
            this.pnSubjectReport.Controls.Add(this.lbSubjectReport);
            this.pnSubjectReport.Location = new System.Drawing.Point(12, 12);
            this.pnSubjectReport.Name = "pnSubjectReport";
            this.pnSubjectReport.Size = new System.Drawing.Size(575, 285);
            this.pnSubjectReport.TabIndex = 1;
            // 
            // dgvSubjectReport
            // 
            this.dgvSubjectReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectReport.Location = new System.Drawing.Point(11, 89);
            this.dgvSubjectReport.Name = "dgvSubjectReport";
            this.dgvSubjectReport.Size = new System.Drawing.Size(552, 153);
            this.dgvSubjectReport.TabIndex = 4;
            // 
            // btnCreateReport_Subject
            // 
            this.btnCreateReport_Subject.Location = new System.Drawing.Point(291, 248);
            this.btnCreateReport_Subject.Name = "btnCreateReport_Subject";
            this.btnCreateReport_Subject.Size = new System.Drawing.Size(110, 23);
            this.btnCreateReport_Subject.TabIndex = 3;
            this.btnCreateReport_Subject.Text = "Lập báo cáo";
            this.btnCreateReport_Subject.UseVisualStyleBackColor = true;
            // 
            // btnPrintFile_Subject
            // 
            this.btnPrintFile_Subject.Location = new System.Drawing.Point(121, 248);
            this.btnPrintFile_Subject.Name = "btnPrintFile_Subject";
            this.btnPrintFile_Subject.Size = new System.Drawing.Size(110, 23);
            this.btnPrintFile_Subject.TabIndex = 3;
            this.btnPrintFile_Subject.Text = "Xuất file";
            this.btnPrintFile_Subject.UseVisualStyleBackColor = true;
            // 
            // cbSubject_Subject
            // 
            this.cbSubject_Subject.FormattingEnabled = true;
            this.cbSubject_Subject.Location = new System.Drawing.Point(422, 45);
            this.cbSubject_Subject.Name = "cbSubject_Subject";
            this.cbSubject_Subject.Size = new System.Drawing.Size(121, 21);
            this.cbSubject_Subject.TabIndex = 2;
            // 
            // lbSubject_Subject
            // 
            this.lbSubject_Subject.AutoSize = true;
            this.lbSubject_Subject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject_Subject.Location = new System.Drawing.Point(342, 47);
            this.lbSubject_Subject.Name = "lbSubject_Subject";
            this.lbSubject_Subject.Size = new System.Drawing.Size(46, 19);
            this.lbSubject_Subject.TabIndex = 1;
            this.lbSubject_Subject.Text = "Môn:";
            // 
            // cbSemester_Subject
            // 
            this.cbSemester_Subject.FormattingEnabled = true;
            this.cbSemester_Subject.Location = new System.Drawing.Point(170, 45);
            this.cbSemester_Subject.Name = "cbSemester_Subject";
            this.cbSemester_Subject.Size = new System.Drawing.Size(121, 21);
            this.cbSemester_Subject.TabIndex = 2;
            // 
            // lbSemester_Subject
            // 
            this.lbSemester_Subject.AutoSize = true;
            this.lbSemester_Subject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemester_Subject.Location = new System.Drawing.Point(90, 47);
            this.lbSemester_Subject.Name = "lbSemester_Subject";
            this.lbSemester_Subject.Size = new System.Drawing.Size(62, 19);
            this.lbSemester_Subject.TabIndex = 1;
            this.lbSemester_Subject.Text = "Học kỳ:";
            // 
            // lbSubjectReport
            // 
            this.lbSubjectReport.AutoSize = true;
            this.lbSubjectReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubjectReport.Location = new System.Drawing.Point(164, 6);
            this.lbSubjectReport.Name = "lbSubjectReport";
            this.lbSubjectReport.Size = new System.Drawing.Size(266, 31);
            this.lbSubjectReport.TabIndex = 0;
            this.lbSubjectReport.Text = "Báo cáo tổng kết môn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSemesterReport);
            this.panel1.Controls.Add(this.btnCreateReport_Semester);
            this.panel1.Controls.Add(this.btnPrintFile_Semester);
            this.panel1.Controls.Add(this.cbSubject_Semester);
            this.panel1.Controls.Add(this.lbSubject_Semester);
            this.panel1.Controls.Add(this.cbSemester_Semester);
            this.panel1.Controls.Add(this.lbSemester_Semester);
            this.panel1.Controls.Add(this.lbSemesterReport);
            this.panel1.Location = new System.Drawing.Point(15, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 285);
            this.panel1.TabIndex = 1;
            // 
            // dgvSemesterReport
            // 
            this.dgvSemesterReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemesterReport.Location = new System.Drawing.Point(11, 89);
            this.dgvSemesterReport.Name = "dgvSemesterReport";
            this.dgvSemesterReport.Size = new System.Drawing.Size(552, 153);
            this.dgvSemesterReport.TabIndex = 4;
            // 
            // btnCreateReport_Semester
            // 
            this.btnCreateReport_Semester.Location = new System.Drawing.Point(291, 248);
            this.btnCreateReport_Semester.Name = "btnCreateReport_Semester";
            this.btnCreateReport_Semester.Size = new System.Drawing.Size(110, 23);
            this.btnCreateReport_Semester.TabIndex = 3;
            this.btnCreateReport_Semester.Text = "Lập báo cáo";
            this.btnCreateReport_Semester.UseVisualStyleBackColor = true;
            // 
            // btnPrintFile_Semester
            // 
            this.btnPrintFile_Semester.Location = new System.Drawing.Point(121, 248);
            this.btnPrintFile_Semester.Name = "btnPrintFile_Semester";
            this.btnPrintFile_Semester.Size = new System.Drawing.Size(110, 23);
            this.btnPrintFile_Semester.TabIndex = 3;
            this.btnPrintFile_Semester.Text = "Xuất file";
            this.btnPrintFile_Semester.UseVisualStyleBackColor = true;
            // 
            // cbSubject_Semester
            // 
            this.cbSubject_Semester.FormattingEnabled = true;
            this.cbSubject_Semester.Location = new System.Drawing.Point(422, 45);
            this.cbSubject_Semester.Name = "cbSubject_Semester";
            this.cbSubject_Semester.Size = new System.Drawing.Size(121, 21);
            this.cbSubject_Semester.TabIndex = 2;
            // 
            // lbSubject_Semester
            // 
            this.lbSubject_Semester.AutoSize = true;
            this.lbSubject_Semester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject_Semester.Location = new System.Drawing.Point(342, 47);
            this.lbSubject_Semester.Name = "lbSubject_Semester";
            this.lbSubject_Semester.Size = new System.Drawing.Size(46, 19);
            this.lbSubject_Semester.TabIndex = 1;
            this.lbSubject_Semester.Text = "Môn:";
            // 
            // cbSemester_Semester
            // 
            this.cbSemester_Semester.FormattingEnabled = true;
            this.cbSemester_Semester.Location = new System.Drawing.Point(170, 45);
            this.cbSemester_Semester.Name = "cbSemester_Semester";
            this.cbSemester_Semester.Size = new System.Drawing.Size(121, 21);
            this.cbSemester_Semester.TabIndex = 2;
            // 
            // lbSemester_Semester
            // 
            this.lbSemester_Semester.AutoSize = true;
            this.lbSemester_Semester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemester_Semester.Location = new System.Drawing.Point(90, 47);
            this.lbSemester_Semester.Name = "lbSemester_Semester";
            this.lbSemester_Semester.Size = new System.Drawing.Size(62, 19);
            this.lbSemester_Semester.TabIndex = 1;
            this.lbSemester_Semester.Text = "Học kỳ:";
            // 
            // lbSemesterReport
            // 
            this.lbSemesterReport.AutoSize = true;
            this.lbSemesterReport.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemesterReport.Location = new System.Drawing.Point(164, 6);
            this.lbSemesterReport.Name = "lbSemesterReport";
            this.lbSemesterReport.Size = new System.Drawing.Size(291, 31);
            this.lbSemesterReport.TabIndex = 0;
            this.lbSemesterReport.Text = "Báo cáo tổng kết học kỳ";
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.btnExit);
            this.pnExit.Location = new System.Drawing.Point(593, 12);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(136, 100);
            this.pnExit.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // fCreateSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 590);
            this.Controls.Add(this.pnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSubjectReport);
            this.Name = "fCreateSummaryReport";
            this.Text = "Lập báo cáo tổng kết";
            this.pnSubjectReport.ResumeLayout(false);
            this.pnSubjectReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemesterReport)).EndInit();
            this.pnExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSubjectReport;
        private System.Windows.Forms.DataGridView dgvSubjectReport;
        private System.Windows.Forms.Button btnCreateReport_Subject;
        private System.Windows.Forms.Button btnPrintFile_Subject;
        private System.Windows.Forms.ComboBox cbSubject_Subject;
        private System.Windows.Forms.Label lbSubject_Subject;
        private System.Windows.Forms.ComboBox cbSemester_Subject;
        private System.Windows.Forms.Label lbSemester_Subject;
        private System.Windows.Forms.Label lbSubjectReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSemesterReport;
        private System.Windows.Forms.Button btnCreateReport_Semester;
        private System.Windows.Forms.Button btnPrintFile_Semester;
        private System.Windows.Forms.ComboBox cbSubject_Semester;
        private System.Windows.Forms.Label lbSubject_Semester;
        private System.Windows.Forms.ComboBox cbSemester_Semester;
        private System.Windows.Forms.Label lbSemester_Semester;
        private System.Windows.Forms.Label lbSemesterReport;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button btnExit;
    }
}