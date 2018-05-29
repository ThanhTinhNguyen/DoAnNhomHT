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
