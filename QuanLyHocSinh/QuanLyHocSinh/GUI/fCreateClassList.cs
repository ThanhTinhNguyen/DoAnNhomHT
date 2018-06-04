using QuanLyHocSinh.BUS;
using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class fCreateClassList : Form
    {
        public fCreateClassList()
        {
            InitializeComponent();
            LoadGrade();
            
        }

        void LoadGrade()
        {
            GradeBUS.Instance.GetListGrade(cbGrade);
            cbGrade.ValueMember = "MAKHOI";
            cbGrade.DisplayMember = "TENKHOI";
        }

        void LoadClass(string id)
        {
            ClassBUS.Instance.GetListClass(cbClass, id);
            
        }



        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id =cbGrade.SelectedValue.ToString();    
            LoadClass(id);
            cbClass.ValueMember="MALOP";
            cbClass.DisplayMember = "TENLOP";
        }

        private void btnNewStudentList_Click(object sender, EventArgs e)
        {

            StudentBUS.Instance.WatchNewStudent(dgvClassList);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string malop = cbClass.SelectedValue.ToString();
            if (ClassBUS.Instance.InsertNewStudent(dgvClassList,malop))
            {
                MessageBox.Show("Thêm thành công");
                btnNewStudentList_Click(sender, e);
                
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
    }
}
