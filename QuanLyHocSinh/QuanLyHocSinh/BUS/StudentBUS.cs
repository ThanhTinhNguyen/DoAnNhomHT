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
        public void WatchNewStudent(DataGridView data)
        {
            string malop = "";
            data.DataSource = AcceptStudentDAO.Instance.LoadNewStudentList(malop);

        }



        public bool Delete(DataGridView data)
        {

            string mahs = data.SelectedCells[0].OwningRow.Cells["MaHS"].Value.ToString();


            return AcceptStudentDAO.Instance.Delete(mahs);
        }

        public bool Update(DataGridView data)
        {
            DataGridViewRow row = data.SelectedCells[0].OwningRow;//Lấy ra dòng được chọn
            string Oldmahs = row.Cells["MaHS"].Value.ToString();
            

            string mahs = row.Cells["MaHS"].Value.ToString();
            string hoten = row.Cells["HoTen"].Value.ToString();
            string gioitinh = row.Cells["GioiTinh"].Value.ToString();
            // DateTime ngaysinh = DateTime.ParseExact(row.Cells["Ngày Sinh"].Value.ToString(), "yyyy-MM-dd HH:mm:ss", null);
            DateTime ngaysinh = (DateTime)row.Cells["NgaySinh"].Value;
            string diachi = row.Cells["DiaChi"].Value.ToString();
            string mail = row.Cells["Email"].Value.ToString();
            string malop = row.Cells["MaLop"].Value.ToString();

            Student student = new Student() {Mahs=mahs,Hoten=hoten,Gioitinh=gioitinh,Ngaysinh=ngaysinh,Diachi=diachi,Email=mail,Malop=malop };


            return AcceptStudentDAO.Instance.Update(Oldmahs, student);
        }
        public bool Insert(DataGridView data)
        {

            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string mahs = row.Cells["MaHS"].Value.ToString();
            string hoten = row.Cells["HoTen"].Value.ToString();
            string gioitinh = row.Cells["GioiTinh"].Value.ToString();
            //DateTime ngaysinh = DateTime.ParseExact(row.Cells["NgaySinh"].Value.ToString(), "yyyy-MM-dd HH:mm:ss", null);
            DateTime ngaysinh = (DateTime)row.Cells["NgaySinh"].Value;
            string diachi = row.Cells["DiaChi"].Value.ToString();
            string mail = row.Cells["Email"].Value.ToString();
            string malop = row.Cells["MaLop"].Value.ToString();

            Student student = new Student() { Mahs = mahs, Hoten = hoten, Gioitinh = gioitinh, Ngaysinh = ngaysinh, Diachi = diachi, Email = mail ,Malop=malop};


            return AcceptStudentDAO.Instance.Insert(student);
        }
    }
}

