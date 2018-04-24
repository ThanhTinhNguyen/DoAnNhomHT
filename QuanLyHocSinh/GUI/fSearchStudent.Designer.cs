namespace QuanLyHocSinh
{
    partial class fSearchStudent
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
            this.pnSearchStudent = new System.Windows.Forms.Panel();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvSearchStudent = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbIdStudent = new System.Windows.Forms.Label();
            this.gbSearchLimit = new System.Windows.Forms.GroupBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lbGrade = new System.Windows.Forms.Label();
            this.pnSearchStudent.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchStudent)).BeginInit();
            this.gbSearchInfo.SuspendLayout();
            this.gbSearchLimit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearchStudent
            // 
            this.pnSearchStudent.Controls.Add(this.gbList);
            this.pnSearchStudent.Controls.Add(this.btnExit);
            this.pnSearchStudent.Controls.Add(this.btnSearch);
            this.pnSearchStudent.Controls.Add(this.gbSearchInfo);
            this.pnSearchStudent.Controls.Add(this.gbSearchLimit);
            this.pnSearchStudent.Location = new System.Drawing.Point(1, 1);
            this.pnSearchStudent.Name = "pnSearchStudent";
            this.pnSearchStudent.Size = new System.Drawing.Size(584, 382);
            this.pnSearchStudent.TabIndex = 0;
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.dgvSearchStudent);
            this.gbList.Location = new System.Drawing.Point(3, 134);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(576, 228);
            this.gbList.TabIndex = 2;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh sách học sinh cần tra cứu";
            // 
            // dgvSearchStudent
            // 
            this.dgvSearchStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchStudent.Location = new System.Drawing.Point(12, 19);
            this.dgvSearchStudent.Name = "dgvSearchStudent";
            this.dgvSearchStudent.Size = new System.Drawing.Size(558, 226);
            this.dgvSearchStudent.TabIndex = 0;
            this.dgvSearchStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(433, 57);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(433, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Controls.Add(this.comboBox1);
            this.gbSearchInfo.Controls.Add(this.lbIdStudent);
            this.gbSearchInfo.Location = new System.Drawing.Point(220, 3);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Size = new System.Drawing.Size(188, 109);
            this.gbSearchInfo.TabIndex = 0;
            this.gbSearchInfo.TabStop = false;
            this.gbSearchInfo.Text = "Thông tin tìm kiếm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lbIdStudent
            // 
            this.lbIdStudent.AutoSize = true;
            this.lbIdStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdStudent.Location = new System.Drawing.Point(19, 46);
            this.lbIdStudent.Name = "lbIdStudent";
            this.lbIdStudent.Size = new System.Drawing.Size(63, 19);
            this.lbIdStudent.TabIndex = 2;
            this.lbIdStudent.Text = "Mã HS:";
            // 
            // gbSearchLimit
            // 
            this.gbSearchLimit.Controls.Add(this.cbClass);
            this.gbSearchLimit.Controls.Add(this.lbClass);
            this.gbSearchLimit.Controls.Add(this.cbGrade);
            this.gbSearchLimit.Controls.Add(this.lbGrade);
            this.gbSearchLimit.Location = new System.Drawing.Point(3, 3);
            this.gbSearchLimit.Name = "gbSearchLimit";
            this.gbSearchLimit.Size = new System.Drawing.Size(197, 109);
            this.gbSearchLimit.TabIndex = 0;
            this.gbSearchLimit.TabStop = false;
            this.gbSearchLimit.Text = "Phạm vi tìm kiếm";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(73, 62);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(101, 21);
            this.cbClass.TabIndex = 1;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(8, 64);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(41, 19);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Lớp:";
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Location = new System.Drawing.Point(73, 27);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(101, 21);
            this.cbGrade.TabIndex = 0;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(8, 29);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(46, 19);
            this.lbGrade.TabIndex = 0;
            this.lbGrade.Text = "Khối:";
            // 
            // fSearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 383);
            this.Controls.Add(this.pnSearchStudent);
            this.Name = "fSearchStudent";
            this.Text = "Tra Cứu Học Sinh";
            this.pnSearchStudent.ResumeLayout(false);
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchStudent)).EndInit();
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.gbSearchLimit.ResumeLayout(false);
            this.gbSearchLimit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearchStudent;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvSearchStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbSearchInfo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbIdStudent;
        private System.Windows.Forms.GroupBox gbSearchLimit;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lbGrade;
    }
}