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

        public Student(string mahs, string hoten, string gioitinh, DateTime ngaysinh, string diachi, string email)
        {
            this.Mahs = mahs;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Email = email;
        }

        public Student(DataRow row)
        {
            this.Mahs = row["mahs"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Ngaysinh = (DateTime)row["ngaysinh"];
            this.Diachi = row["diachi"].ToString();
            this.Email = row["email"].ToString();
        }

        public Student()
        {
        }

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
       
    }
}
