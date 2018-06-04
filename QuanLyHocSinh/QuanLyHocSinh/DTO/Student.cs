using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DTO
{
    public class Student
    {

        //public Student(string mahs, string hoten,string gioitinh,DateTime ngaysinh,string diachi,string email,string malop)
        //{
        //    this.Mahs =mahs;
        //    this.Hoten = hoten;
        //    this.Gioitinh = gioitinh;
        //    this.Ngaysinh = ngaysinh;
        //    this.Diachi = diachi;
        //    this.Email = email;
        //    this.Malop = malop;

        //}

        //public Student(DataRow row)
        //{
        //    string mahs = row["MaHS"].ToString();
        //    string hoten = row["HoTen"].ToString();
        //    string gioitinh = row["GioiTinh"].ToString();
        //    //DateTime ngaysinh = DateTime.ParseExact(row.Cells["NgaySinh"].Value.ToString(), "yyyy-MM-dd HH:mm:ss", null);
        //    DateTime ngaysinh = (DateTime)row["NgaySinh"];
        //    string diachi = row["DiaChi"].ToString();
        //    string email = row["Email"].ToString();
        //    string malop = row["Malop"].ToString();

        //}

        private string mahs;

        public string Mahs { get => mahs; set => mahs = value; }

        private string hoten;

        public string Hoten { get => hoten; set => hoten = value; }

        private string gioitinh;

        public string Gioitinh { get => gioitinh; set => gioitinh = value; }


        private DateTime ngaysinh;
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        private string diachi;
        public string Diachi { get => diachi; set => diachi = value; }


        private string email;
        public string Email { get => email; set => email = value; }
        

        private string malop;
        public string Malop { get => malop; set => malop = value; }
    }
}
