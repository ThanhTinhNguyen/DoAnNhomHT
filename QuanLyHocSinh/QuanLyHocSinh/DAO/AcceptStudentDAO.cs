using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.DAO
{
    class AcceptStudentDAO
    {
        private static AcceptStudentDAO instance;

        public static AcceptStudentDAO Instance
        {
            get { if (instance == null) instance = new AcceptStudentDAO(); return AcceptStudentDAO.instance; }
            set => instance = value;
        }

        private AcceptStudentDAO() { }

        public DataTable LoadStudentList()
        {
            //List<Student> studentList = new List<Student>();

            return  DataProvider.Instance.ExcuteQuery("USP_GETSTUDENTLIST");

            //foreach (DataRow item in data.Rows)
            //{
            //    string mahs = item["MaHS"].ToString();
            //    string hoten = item["Hoten"].ToString();
            //    //DateTime.ParseExact(txtPunchDate.Text, "yyyy-MM-dd HH:mm:ss", null);
            //    DateTime ngaysinh = (DateTime)item["Ngaysinh"];
            //    string gioitinh = item["Gioitinh"].ToString();
            //    string diachi = item["Diachi"].ToString();
            //    string email = item["Email"].ToString();
            //    Student student = new Student(mahs, hoten, gioitinh, ngaysinh, diachi, email);

            //    studentList.Add(student);


            //}

           // return studentList;

        }

        

        public bool Delete(string mahs)

        {
            object[] para = new object[] { mahs };
            if (DataProvider.Instance.ExcuteNonQuery1("DELETE HOCSINH WHERE MAHS = @MaHS ", para) > 0)
            {
                return true;

            }
            return false;
        }

        public bool Update(string mahs, Student student)
        {
            string query = "UPDATE HOCSINH SET HOTEN= @Hoten , GIOITINH= @Gioitinh , NGAYSINH= @Ngaysinh , DIACHI= @Diachi , EMAIL= @Email WHERE MAHS = @OldMaHS";
            object[] para = new object[] {student.Hoten, student.Gioitinh, student.Ngaysinh, student.Diachi, student.Email,mahs };
            if (DataProvider.Instance.ExcuteNonQuery1(query, para) > 0)
            {
                return true;

            }

            return false;
        }
        public bool Insert(Student student)
        {
            string query = "INSERT INTO HOCSINH VALUES( @MaHS , @Hoten , @Gioitinh , @Ngaysinh , @Diachi , @Email , @Malop )";
            object[] para = new object[] { student.Mahs, student.Hoten, student.Gioitinh, student.Ngaysinh, student.Diachi, student.Email ,student.Malop};
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;

            }

            return false;
        }
    }

}
