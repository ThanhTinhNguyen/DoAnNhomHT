namespace QuanLyHocSinh
{
    partial class fHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangeRules = new System.Windows.Forms.Button();
            this.btnCreateSummaryReport = new System.Windows.Forms.Button();
            this.btnEnterPoint = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnCreateClassList = new System.Windows.Forms.Button();
            this.btnAcceptStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnChangeRules);
            this.panel1.Controls.Add(this.btnCreateSummaryReport);
            this.panel1.Controls.Add(this.btnEnterPoint);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Controls.Add(this.btnCreateClassList);
            this.panel1.Controls.Add(this.btnAcceptStudent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 472);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(661, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnChangeRules
            // 
            this.btnChangeRules.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRules.Location = new System.Drawing.Point(485, 265);
            this.btnChangeRules.Name = "btnChangeRules";
            this.btnChangeRules.Size = new System.Drawing.Size(214, 52);
            this.btnChangeRules.TabIndex = 1;
            this.btnChangeRules.Text = "Thay đổi qui định";
            this.btnChangeRules.UseVisualStyleBackColor = true;
            this.btnChangeRules.Click += new System.EventHandler(this.btnChangeRules_Click);
            // 
            // btnCreateSummaryReport
            // 
            this.btnCreateSummaryReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSummaryReport.Location = new System.Drawing.Point(485, 207);
            this.btnCreateSummaryReport.Name = "btnCreateSummaryReport";
            this.btnCreateSummaryReport.Size = new System.Drawing.Size(214, 52);
            this.btnCreateSummaryReport.TabIndex = 1;
            this.btnCreateSummaryReport.Text = "Lập báo cáo tổng kết";
            this.btnCreateSummaryReport.UseVisualStyleBackColor = true;
            this.btnCreateSummaryReport.Click += new System.EventHandler(this.btnCreateSummaryReport_Click);
            // 
            // btnEnterPoint
            // 
            this.btnEnterPoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPoint.Location = new System.Drawing.Point(485, 149);
            this.btnEnterPoint.Name = "btnEnterPoint";
            this.btnEnterPoint.Size = new System.Drawing.Size(214, 52);
            this.btnEnterPoint.TabIndex = 1;
            this.btnEnterPoint.Text = "Nhập bảng điểm môn học";
            this.btnEnterPoint.UseVisualStyleBackColor = true;
            this.btnEnterPoint.Click += new System.EventHandler(this.btnEnterPoint_Click);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(88, 265);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(217, 52);
            this.btnSearchStudent.TabIndex = 1;
            this.btnSearchStudent.Text = "Tra cứu học sinh";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnCreateClassList
            // 
            this.btnCreateClassList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateClassList.Location = new System.Drawing.Point(88, 207);
            this.btnCreateClassList.Name = "btnCreateClassList";
            this.btnCreateClassList.Size = new System.Drawing.Size(217, 52);
            this.btnCreateClassList.TabIndex = 1;
            this.btnCreateClassList.Text = "Lập danh sách lớp";
            this.btnCreateClassList.UseVisualStyleBackColor = true;
            this.btnCreateClassList.Click += new System.EventHandler(this.btnCreateClassList_Click);
            // 
            // btnAcceptStudent
            // 
            this.btnAcceptStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptStudent.Location = new System.Drawing.Point(88, 149);
            this.btnAcceptStudent.Name = "btnAcceptStudent";
            this.btnAcceptStudent.Size = new System.Drawing.Size(217, 52);
            this.btnAcceptStudent.TabIndex = 1;
            this.btnAcceptStudent.Text = "Tiếp nhận học sinh";
            this.btnAcceptStudent.UseVisualStyleBackColor = true;
            this.btnAcceptStudent.Click += new System.EventHandler(this.btnAcceptStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(78, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần Mềm Quản Lý Học Sinh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 433);
            this.Controls.Add(this.panel1);
            this.Name = "fHome";
            this.Text = "Phần mềm Quản Lý Học Sinh";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeRules;
        private System.Windows.Forms.Button btnCreateSummaryReport;
        private System.Windows.Forms.Button btnEnterPoint;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Button btnCreateClassList;
        private System.Windows.Forms.Button btnAcceptStudent;
        private System.Windows.Forms.Label label1;
    }
}