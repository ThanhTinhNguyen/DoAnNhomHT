using QuanLyHocSinh.DAO;
using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.BUS
{
    public class StudentBUS
    {
        private static StudentBUS instance;

        public static StudentBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentBUS();
                return StudentBUS.instance;
            }
            set => instance = value;
        }

        public void Watch(DataGridView data)
        {
            data.DataSource = AcceptStudentDAO.Instance.LoadStudentList();
        }

        public bool Delete(DataGridView data)
        {

            string mahs = data.SelectedCells[0].OwningRow.Cells["MaHS"].Value.ToString();

            return AcceptStudentDAO.Instance.Delete(mahs);
        }

        public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            string Oldmahs = row.Cells["MaHS"].Value.ToString();

            Student student = new Student();
            
            return AcceptStudentDAO.Instance.Update(Oldmahs, student);
        }
        public bool Insert(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;
            

            Student student = new Student();

            return AcceptStudentDAO.Instance.Insert(student);
        }
    }
}

