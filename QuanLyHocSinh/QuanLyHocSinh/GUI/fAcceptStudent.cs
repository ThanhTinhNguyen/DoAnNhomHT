using QuanLyHocSinh.BUS;
using QuanLyHocSinh.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.GUI
{
    public partial class fAcceptStudent : Form
    {
        public fAcceptStudent()
        {
            InitializeComponent();
        }

        

        
        private void btnWatch_Click(object sender, EventArgs e)
        {
          

            StudentBUS.Instance.Watch(dgvInfoStudent);
 
        }
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (StudentBUS.Instance.Delete(dgvInfoStudent))
            {
                MessageBox.Show("Xóa thành công");
                btnWatch_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (StudentBUS.Instance.Update(dgvInfoStudent))
            {
                MessageBox.Show("Sửa thành công");
                btnWatch_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (StudentBUS.Instance.Insert(dgvInfoStudent))
            {
                MessageBox.Show("Thêm thành công");
                btnWatch_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void dgvInfoStudent_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        
        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void dgvInfoStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvInfoStudent.Rows[e.RowIndex];
                txbIDStudent.Text = row.Cells["MaHS"].Value.ToString();
                txbAddress.Text = row.Cells["DiaChi"].Value.ToString();
                txbEmail.Text = row.Cells["Email"].Value.ToString();
                txbSex.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpDate.Value = (DateTime)row.Cells["NgaySinh"].Value;
                txbName.Text = row.Cells["HoTen"].Value.ToString();
                txbMalop.Text = row.Cells["MaLop"].Value.ToString();
            }
        }
    }
}
