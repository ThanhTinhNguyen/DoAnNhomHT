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


        public void GetListClass(ComboBox cb, string id)
        {
            List<Class> classes = ClassDAO.Instance.GetClass(id);
            cb.DataSource = classes;

        }

        public void GetClassInfo(DataGridView data,string id)
        {
            List<Class> listclass = ClassDAO.Instance.GetClass(id);
            data.DataSource = listclass;
        }
        public string UpdateSiSo(TextBox text,string malop)
        {
            return text.Text = ClassDAO.Instance.UpdateSiSo(malop).ToString();
        }
        public bool InsertNewStudent(DataGridView data,string idlop)
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
            string malop = idlop;

            Student student = new Student() { Mahs = mahs, Hoten = hoten, Gioitinh = gioitinh, Ngaysinh = ngaysinh, Diachi = diachi, Email = mail, Malop = malop };


            return ClassDAO.Instance.InsertNewStudent(Oldmahs, student);
        }
    }
}
