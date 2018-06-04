using QuanLyHocSinh.DAO;
using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.BUS
{
    class ClassBUS
    {
        private static ClassBUS instance;

        public static ClassBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassBUS();
                return ClassBUS.instance;
            }
            set => instance = value;
        }

        public void GetListClass(ComboBox box, string id)
        {
            List<Class> classes = ClassDAO.Instance.GetClass(id);
            box.DataSource = classes;

        }
        public bool InsertNewStudent(DataGridView data,string malop)
        {

            DataGridViewRow row = data.SelectedCells[0].OwningRow;

            string mahs = row.Cells["MaHS"].Value.ToString();
            string hoten = row.Cells["HoTen"].Value.ToString();
            string gioitinh = row.Cells["GioiTinh"].Value.ToString();
            //DateTime ngaysinh = DateTime.ParseExact(row.Cells["NgaySinh"].Value.ToString(), "yyyy-MM-dd HH:mm:ss", null);
            DateTime ngaysinh = (DateTime)row.Cells["NgaySinh"].Value;
            string diachi = row.Cells["DiaChi"].Value.ToString();
            string mail = row.Cells["Email"].Value.ToString();
            

            Student student = new Student() { Mahs = mahs, Hoten = hoten, Gioitinh = gioitinh, Ngaysinh = ngaysinh, Diachi = diachi, Email = mail, Malop=malop };


            return ClassDAO.Instance.InsertNewStudent(student,malop);
        }
    }
}
