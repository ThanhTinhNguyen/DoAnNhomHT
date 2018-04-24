namespace QuanLyHocSinh
{
    partial class fEnterPoint
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
            this.lbGrade = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbSemester = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.btbSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.pnPointBoard = new System.Windows.Forms.Panel();
            this.dgvPointBoard = new System.Windows.Forms.DataGridView();
            this.lbPointBoard = new System.Windows.Forms.Label();
            this.pnPointBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(21, 24);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(46, 19);
            this.lbGrade.TabIndex = 0;
            this.lbGrade.Text = "Khối:";
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Location = new System.Drawing.Point(85, 24);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(108, 21);
            this.cbGrade.TabIndex = 1;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(85, 60);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(108, 21);
            this.cbClass.TabIndex = 3;
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(21, 60);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(41, 19);
            this.lbClass.TabIndex = 2;
            this.lbClass.Text = "Lớp:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 97);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // lbSemester
            // 
            this.lbSemester.AutoSize = true;
            this.lbSemester.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemester.Location = new System.Drawing.Point(21, 97);
            this.lbSemester.Name = "lbSemester";
            this.lbSemester.Size = new System.Drawing.Size(62, 19);
            this.lbSemester.TabIndex = 4;
            this.lbSemester.Text = "Học kỳ:";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(239, 26);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(261, 19);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Nhập họ tên hoặc mã HS để tìm kiếm:";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(243, 47);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(274, 20);
            this.txbSearch.TabIndex = 6;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // btbSearch
            // 
            this.btbSearch.Location = new System.Drawing.Point(542, 45);
            this.btbSearch.Name = "btbSearch";
            this.btbSearch.Size = new System.Drawing.Size(75, 23);
            this.btbSearch.TabIndex = 7;
            this.btbSearch.Text = "Tìm kiếm";
            this.btbSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(542, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(291, 93);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 7;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // pnPointBoard
            // 
            this.pnPointBoard.Controls.Add(this.dgvPointBoard);
            this.pnPointBoard.Location = new System.Drawing.Point(3, 170);
            this.pnPointBoard.Name = "pnPointBoard";
            this.pnPointBoard.Size = new System.Drawing.Size(658, 277);
            this.pnPointBoard.TabIndex = 8;
            // 
            // dgvPointBoard
            // 
            this.dgvPointBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointBoard.Location = new System.Drawing.Point(0, 3);
            this.dgvPointBoard.Name = "dgvPointBoard";
            this.dgvPointBoard.Size = new System.Drawing.Size(647, 271);
            this.dgvPointBoard.TabIndex = 0;
            // 
            // lbPointBoard
            // 
            this.lbPointBoard.AutoSize = true;
            this.lbPointBoard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPointBoard.Location = new System.Drawing.Point(256, 143);
            this.lbPointBoard.Name = "lbPointBoard";
            this.lbPointBoard.Size = new System.Drawing.Size(110, 24);
            this.lbPointBoard.TabIndex = 9;
            this.lbPointBoard.Text = "Bảng Điểm";
            // 
            // fEnterPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 444);
            this.Controls.Add(this.lbPointBoard);
            this.Controls.Add(this.pnPointBoard);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btbSearch);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbSemester);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lbGrade);
            this.Name = "fEnterPoint";
            this.Text = "fEnterPoint";
            this.Load += new System.EventHandler(this.fEnterPoint_Load);
            this.pnPointBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbSemester;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Button btbSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Panel pnPointBoard;
        private System.Windows.Forms.DataGridView dgvPointBoard;
        private System.Windows.Forms.Label lbPointBoard;
    }
}