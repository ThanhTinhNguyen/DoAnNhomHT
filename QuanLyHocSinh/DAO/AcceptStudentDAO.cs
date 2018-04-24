using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    class AcceptStudentDAO
    {
        private static AcceptStudentDAO instance;

        internal static AcceptStudentDAO Instance
        {
            get { if (instance == null) instance=new AcceptStudentDAO() ; return AcceptStudentDAO.instance; }
            set => instance = value;
        }

        private AcceptStudentDAO() { }

        public List<Student> LoadStudentList()
        {
            List<Student> studentList = new List<Student>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GETSTUDENTLIST");

            foreach(DataRow item in data.Rows)
            {
                Student student = new Student(item);
                studentList.Add(student);
            }

            return studentList;

        }

        public bool Delete(string mahs)

        {
            object[] para = new object[] { mahs };
            if (DataProvider.Instance.ExcuteNonQuery("DELETE HOCSINH WHERE MAHS = @MaHS ",para) > 0)
            {
                return true;

            }
            return false;
        }

        public bool Update(string mahs,Student student)
        {
            string query = "UPDATE HOCSINH SET HOTEN=@Hoten , GIOITINH=@Gioitinh , NGAYSINH=@Ngaysinh , DIACHI=@Diachi , EMAIL=@Email WHERE MAHS = @OldMaHS ";
            object[] para = new object[] { mahs,student.Hoten,student.Gioitinh,student.Ngaysinh,student.Diachi,student.Email};
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;

            }

            return false;
        }
        public bool Insert(Student student)
        {
            string query = "INSERT INTO HOCSINH VALUES( @MaHS , @Hoten , @Gioitinh , @Ngaysinh , @Diachi , @Email";
            object[] para = new object[] { student.Mahs, student.Hoten, student.Gioitinh, student.Ngaysinh, student.Diachi, student.Email };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;

            }

            return false;
        }
    }

}
