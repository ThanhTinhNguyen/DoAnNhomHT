namespace QuanLyHocSinh
{
    partial class fAcceptStudent
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
            this.pnAcceptStudent = new System.Windows.Forms.Panel();
            this.dgvInfoStudent = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gbInfoStudent = new System.Windows.Forms.GroupBox();
            this.pnDateAcception = new System.Windows.Forms.Panel();
            this.dtpDateAcception = new System.Windows.Forms.DateTimePicker();
            this.lbDateAcception = new System.Windows.Forms.Label();
            this.pnDateStudent = new System.Windows.Forms.Panel();
            this.dtpDateStudent = new System.Windows.Forms.DateTimePicker();
            this.lbDateStudent = new System.Windows.Forms.Label();
            this.pnEmail = new System.Windows.Forms.Panel();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.pnIdStudent = new System.Windows.Forms.Panel();
            this.txbIdStudent = new System.Windows.Forms.TextBox();
            this.lbIdStudent = new System.Windows.Forms.Label();
            this.pnAddress = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.pnSex = new System.Windows.Forms.Panel();
            this.lbSex = new System.Windows.Forms.Label();
            this.pnName = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txbSex = new System.Windows.Forms.TextBox();
            this.pnAcceptStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoStudent)).BeginInit();
            this.gbInfoStudent.SuspendLayout();
            this.pnDateAcception.SuspendLayout();
            this.pnDateStudent.SuspendLayout();
            this.pnEmail.SuspendLayout();
            this.pnIdStudent.SuspendLayout();
            this.pnAddress.SuspendLayout();
            this.pnSex.SuspendLayout();
            this.pnName.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAcceptStudent
            // 
            this.pnAcceptStudent.Controls.Add(this.dgvInfoStudent);
            this.pnAcceptStudent.Controls.Add(this.btnExit);
            this.pnAcceptStudent.Controls.Add(this.btnWatch);
            this.pnAcceptStudent.Controls.Add(this.btnDelete);
            this.pnAcceptStudent.Controls.Add(this.btnUpdate);
            this.pnAcceptStudent.Controls.Add(this.btnInsert);
            this.pnAcceptStudent.Controls.Add(this.gbInfoStudent);
            this.pnAcceptStudent.Location = new System.Drawing.Point(1, 3);
            this.pnAcceptStudent.Name = "pnAcceptStudent";
            this.pnAcceptStudent.Size = new System.Drawing.Size(824, 489);
            this.pnAcceptStudent.TabIndex = 0;
            // 
            // dgvInfoStudent
            // 
            this.dgvInfoStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoStudent.Location = new System.Drawing.Point(16, 272);
            this.dgvInfoStudent.Name = "dgvInfoStudent";
            this.dgvInfoStudent.Size = new System.Drawing.Size(799, 200);
            this.dgvInfoStudent.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(682, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnWatch
            // 
            this.btnWatch.Location = new System.Drawing.Point(531, 229);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(86, 23);
            this.btnWatch.TabIndex = 1;
            this.btnWatch.Text = "Xem";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 229);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(375, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(57, 229);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gbInfoStudent
            // 
            this.gbInfoStudent.Controls.Add(this.pnDateAcception);
            this.gbInfoStudent.Controls.Add(this.pnDateStudent);
            this.gbInfoStudent.Controls.Add(this.pnEmail);
            this.gbInfoStudent.Controls.Add(this.pnIdStudent);
            this.gbInfoStudent.Controls.Add(this.pnAddress);
            this.gbInfoStudent.Controls.Add(this.pnSex);
            this.gbInfoStudent.Controls.Add(this.pnName);
            this.gbInfoStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoStudent.Location = new System.Drawing.Point(10, 9);
            this.gbInfoStudent.Name = "gbInfoStudent";
            this.gbInfoStudent.Size = new System.Drawing.Size(811, 214);
            this.gbInfoStudent.TabIndex = 0;
            this.gbInfoStudent.TabStop = false;
            this.gbInfoStudent.Text = "Thông tin học sinh";
            // 
            // pnDateAcception
            // 
            this.pnDateAcception.Controls.Add(this.dtpDateAcception);
            this.pnDateAcception.Controls.Add(this.lbDateAcception);
            this.pnDateAcception.Location = new System.Drawing.Point(401, 117);
            this.pnDateAcception.Name = "pnDateAcception";
            this.pnDateAcception.Size = new System.Drawing.Size(404, 40);
            this.pnDateAcception.TabIndex = 0;
            // 
            // dtpDateAcception
            // 
            this.dtpDateAcception.Location = new System.Drawing.Point(134, 8);
            this.dtpDateAcception.Name = "dtpDateAcception";
            this.dtpDateAcception.Size = new System.Drawing.Size(256, 26);
            this.dtpDateAcception.TabIndex = 1;
            // 
            // lbDateAcception
            // 
            this.lbDateAcception.AutoSize = true;
            this.lbDateAcception.Location = new System.Drawing.Point(13, 10);
            this.lbDateAcception.Name = "lbDateAcception";
            this.lbDateAcception.Size = new System.Drawing.Size(115, 19);
            this.lbDateAcception.TabIndex = 0;
            this.lbDateAcception.Text = "Ngày tiếp nhận:";
            // 
            // pnDateStudent
            // 
            this.pnDateStudent.Controls.Add(this.dtpDateStudent);
            this.pnDateStudent.Controls.Add(this.lbDateStudent);
            this.pnDateStudent.Location = new System.Drawing.Point(6, 117);
            this.pnDateStudent.Name = "pnDateStudent";
            this.pnDateStudent.Size = new System.Drawing.Size(360, 40);
            this.pnDateStudent.TabIndex = 0;
            // 
            // dtpDateStudent
            // 
            this.dtpDateStudent.Location = new System.Drawing.Point(108, 7);
            this.dtpDateStudent.Name = "dtpDateStudent";
            this.dtpDateStudent.Size = new System.Drawing.Size(249, 26);
            this.dtpDateStudent.TabIndex = 1;
            // 
            // lbDateStudent
            // 
            this.lbDateStudent.AutoSize = true;
            this.lbDateStudent.Location = new System.Drawing.Point(13, 11);
            this.lbDateStudent.Name = "lbDateStudent";
            this.lbDateStudent.Size = new System.Drawing.Size(81, 19);
            this.lbDateStudent.TabIndex = 0;
            this.lbDateStudent.Text = "Ngày sinh:";
            // 
            // pnEmail
            // 
            this.pnEmail.Controls.Add(this.txbEmail);
            this.pnEmail.Controls.Add(this.lbEmail);
            this.pnEmail.Location = new System.Drawing.Point(401, 71);
            this.pnEmail.Name = "pnEmail";
            this.pnEmail.Size = new System.Drawing.Size(404, 40);
            this.pnEmail.TabIndex = 0;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(108, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(282, 26);
            this.txbEmail.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(13, 11);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(52, 19);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // pnIdStudent
            // 
            this.pnIdStudent.Controls.Add(this.txbIdStudent);
            this.pnIdStudent.Controls.Add(this.lbIdStudent);
            this.pnIdStudent.Location = new System.Drawing.Point(6, 163);
            this.pnIdStudent.Name = "pnIdStudent";
            this.pnIdStudent.Size = new System.Drawing.Size(360, 40);
            this.pnIdStudent.TabIndex = 0;
            // 
            // txbIdStudent
            // 
            this.txbIdStudent.Location = new System.Drawing.Point(108, 4);
            this.txbIdStudent.Name = "txbIdStudent";
            this.txbIdStudent.Size = new System.Drawing.Size(249, 26);
            this.txbIdStudent.TabIndex = 1;
            // 
            // lbIdStudent
            // 
            this.lbIdStudent.AutoSize = true;
            this.lbIdStudent.Location = new System.Drawing.Point(19, 11);
            this.lbIdStudent.Name = "lbIdStudent";
            this.lbIdStudent.Size = new System.Drawing.Size(59, 19);
            this.lbIdStudent.TabIndex = 0;
            this.lbIdStudent.Text = "MaHS:";
            // 
            // pnAddress
            // 
            this.pnAddress.Controls.Add(this.txbAddress);
            this.pnAddress.Controls.Add(this.lbAddress);
            this.pnAddress.Location = new System.Drawing.Point(401, 25);
            this.pnAddress.Name = "pnAddress";
            this.pnAddress.Size = new System.Drawing.Size(404, 40);
            this.pnAddress.TabIndex = 0;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(108, 4);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(282, 26);
            this.txbAddress.TabIndex = 1;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(13, 11);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(61, 19);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // pnSex
            // 
            this.pnSex.Controls.Add(this.txbSex);
            this.pnSex.Controls.Add(this.lbSex);
            this.pnSex.Location = new System.Drawing.Point(6, 71);
            this.pnSex.Name = "pnSex";
            this.pnSex.Size = new System.Drawing.Size(360, 40);
            this.pnSex.TabIndex = 0;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(13, 11);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(72, 19);
            this.lbSex.TabIndex = 0;
            this.lbSex.Text = "Giới tính:";
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.txbName);
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Location = new System.Drawing.Point(6, 25);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(360, 40);
            this.pnName.TabIndex = 0;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(108, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(249, 26);
            this.txbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 11);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ và tên:";
            // 
            // txbSex
            // 
            this.txbSex.Location = new System.Drawing.Point(108, 4);
            this.txbSex.Name = "txbSex";
            this.txbSex.Size = new System.Drawing.Size(249, 26);
            this.txbSex.TabIndex = 1;
            // 
            // fAcceptStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 529);
            this.Controls.Add(this.pnAcceptStudent);
            this.Name = "fAcceptStudent";
            this.Text = "Tiếp nhận học sinh";
            this.pnAcceptStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoStudent)).EndInit();
            this.gbInfoStudent.ResumeLayout(false);
            this.pnDateAcception.ResumeLayout(false);
            this.pnDateAcception.PerformLayout();
            this.pnDateStudent.ResumeLayout(false);
            this.pnDateStudent.PerformLayout();
            this.pnEmail.ResumeLayout(false);
            this.pnEmail.PerformLayout();
            this.pnIdStudent.ResumeLayout(false);
            this.pnIdStudent.PerformLayout();
            this.pnAddress.ResumeLayout(false);
            this.pnAddress.PerformLayout();
            this.pnSex.ResumeLayout(false);
            this.pnSex.PerformLayout();
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAcceptStudent;
        private System.Windows.Forms.GroupBox gbInfoStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnDateAcception;
        private System.Windows.Forms.DateTimePicker dtpDateAcception;
        private System.Windows.Forms.Label lbDateAcception;
        private System.Windows.Forms.Panel pnDateStudent;
        private System.Windows.Forms.DateTimePicker dtpDateStudent;
        private System.Windows.Forms.Label lbDateStudent;
        private System.Windows.Forms.Panel pnEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel pnIdStudent;
        private System.Windows.Forms.TextBox txbIdStudent;
        private System.Windows.Forms.Label lbIdStudent;
        private System.Windows.Forms.Panel pnAddress;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Panel pnSex;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgvInfoStudent;
        private System.Windows.Forms.TextBox txbSex;
    }
}