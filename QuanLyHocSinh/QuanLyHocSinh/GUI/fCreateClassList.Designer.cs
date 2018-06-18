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
            this.label1 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewClass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvClassList = new System.Windows.Forms.DataGridView();
            this.lbGrade = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txbSiSo = new System.Windows.Forms.TextBox();
            this.pnCreateStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCreateStudentList
            // 
            this.pnCreateStudentList.Controls.Add(this.txbSiSo);
            this.pnCreateStudentList.Controls.Add(this.btnUpdate);
            this.pnCreateStudentList.Controls.Add(this.btnExit);
            this.pnCreateStudentList.Controls.Add(this.cbClass);
            this.pnCreateStudentList.Controls.Add(this.button1);
            this.pnCreateStudentList.Controls.Add(this.btnNewClass);
            this.pnCreateStudentList.Controls.Add(this.label1);
            this.pnCreateStudentList.Controls.Add(this.btnDelete);
            this.pnCreateStudentList.Controls.Add(this.cbGrade);
            this.pnCreateStudentList.Controls.Add(this.btnInsert);
            this.pnCreateStudentList.Controls.Add(this.lbClass);
            this.pnCreateStudentList.Controls.Add(this.lbGrade);
            this.pnCreateStudentList.Location = new System.Drawing.Point(1, 2);
            this.pnCreateStudentList.Name = "pnCreateStudentList";
            this.pnCreateStudentList.Size = new System.Drawing.Size(624, 96);
            this.pnCreateStudentList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sỉ Số:";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(247, 9);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 3;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(200, 11);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(41, 19);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Lớp:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(116, 45);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 36);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNewClass
            // 
            this.btnNewClass.Location = new System.Drawing.Point(318, 45);
            this.btnNewClass.Name = "btnNewClass";
            this.btnNewClass.Size = new System.Drawing.Size(95, 36);
            this.btnNewClass.TabIndex = 5;
            this.btnNewClass.Text = "Lớp Mới";
            this.btnNewClass.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(526, 45);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvClassList
            // 
            this.dgvClassList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassList.Location = new System.Drawing.Point(4, 113);
            this.dgvClassList.Name = "dgvClassList";
            this.dgvClassList.Size = new System.Drawing.Size(621, 276);
            this.dgvClassList.TabIndex = 6;
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(11, 11);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(46, 19);
            this.lbGrade.TabIndex = 0;
            this.lbGrade.Text = "Khối:";
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbGrade.Location = new System.Drawing.Point(63, 9);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(121, 21);
            this.cbGrade.TabIndex = 1;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "DS Học Sinh Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbSiSo
            // 
            this.txbSiSo.Location = new System.Drawing.Point(444, 9);
            this.txbSiSo.Name = "txbSiSo";
            this.txbSiSo.Size = new System.Drawing.Size(70, 20);
            this.txbSiSo.TabIndex = 6;
            // 
            // fCreateClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 401);
            this.Controls.Add(this.dgvClassList);
            this.Controls.Add(this.pnCreateStudentList);
            this.Name = "fCreateClassList";
            this.Text = "Lập Danh Sách Lớp";
            this.pnCreateStudentList.ResumeLayout(false);
            this.pnCreateStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCreateStudentList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewClass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvClassList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.TextBox txbSiSo;
    }
}