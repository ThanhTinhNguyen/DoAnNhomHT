namespace QuanLyHocSinh
{
    partial class fCreateClassList
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
            this.pnCreateStudentList = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbNumber = new System.Windows.Forms.Label();
            this.gbInfoStudent = new System.Windows.Forms.GroupBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.lbGrade = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvClassList = new System.Windows.Forms.DataGridView();
            this.pnCreateStudentList.SuspendLayout();
            this.gbInfoStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCreateStudentList
            // 
            this.pnCreateStudentList.Controls.Add(this.btnUpdate);
            this.pnCreateStudentList.Controls.Add(this.textBox1);
            this.pnCreateStudentList.Controls.Add(this.lbNumber);
            this.pnCreateStudentList.Controls.Add(this.gbInfoStudent);
            this.pnCreateStudentList.Location = new System.Drawing.Point(1, 2);
            this.pnCreateStudentList.Name = "pnCreateStudentList";
            this.pnCreateStudentList.Size = new System.Drawing.Size(603, 154);
            this.pnCreateStudentList.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(512, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(281, 31);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(63, 19);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Text = "Mã HS:";
            // 
            // gbInfoStudent
            // 
            this.gbInfoStudent.Controls.Add(this.cbName);
            this.gbInfoStudent.Controls.Add(this.lbName);
            this.gbInfoStudent.Controls.Add(this.cbClass);
            this.gbInfoStudent.Controls.Add(this.lbClass);
            this.gbInfoStudent.Controls.Add(this.cbGrade);
            this.gbInfoStudent.Controls.Add(this.lbGrade);
            this.gbInfoStudent.Location = new System.Drawing.Point(3, 3);
            this.gbInfoStudent.Name = "gbInfoStudent";
            this.gbInfoStudent.Size = new System.Drawing.Size(250, 144);
            this.gbInfoStudent.TabIndex = 0;
            this.gbInfoStudent.TabStop = false;
            this.gbInfoStudent.Text = "Thông tin học sinh";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(97, 106);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(8, 108);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(46, 19);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Sỉ số:";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(97, 65);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 3;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(8, 67);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(41, 19);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Lớp:";
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbGrade.Location = new System.Drawing.Point(97, 25);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(121, 21);
            this.cbGrade.TabIndex = 1;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(8, 27);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(46, 19);
            this.lbGrade.TabIndex = 0;
            this.lbGrade.Text = "Khối:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(147, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNewClass
            // 
            this.btnNewClass.Location = new System.Drawing.Point(270, 162);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(75, 23);
            this.btnNewClass.TabIndex = 5;
            this.btnNewClass.Text = "Lớp Mới";
            this.btnNewClass.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(404, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvClassList
            // 
            this.dgvClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassList.Location = new System.Drawing.Point(4, 191);
            this.dgvClassList.Name = "dgvClassList";
            this.dgvClassList.Size = new System.Drawing.Size(596, 198);
            this.dgvClassList.TabIndex = 6;
            // 
            // fCreateClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 401);
            this.Controls.Add(this.dgvClassList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewClass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnCreateStudentList);
            this.Name = "fCreateClassList";
            this.Text = "Lập Danh Sách Lớp";
            this.pnCreateStudentList.ResumeLayout(false);
            this.pnCreateStudentList.PerformLayout();
            this.gbInfoStudent.ResumeLayout(false);
            this.gbInfoStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCreateStudentList;
        private System.Windows.Forms.GroupBox gbInfoStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvClassList;
    }
}