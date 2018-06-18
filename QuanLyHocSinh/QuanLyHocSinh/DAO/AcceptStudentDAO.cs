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
            

           return DataProvider.Instance.ExcuteQuery("USP_GETSTUDENTLIST");

        }

        public DataTable LoadNewStudentList(string Malop)
        {
            object[] para = new object[] { Malop };
            return DataProvider.Instance.ExcuteQuery1("SELECT* FROM HOCSINH WHERE MALOP= @MALOP ",para);

        }
     


        public bool Delete(string mahs)

        {
            object[] para = new object[] { mahs };
            if (DataProvider.Instance.ExcuteNonQuery("DELETE HOCSINH WHERE MAHS = @MaHS ", para) > 0)
            {
                return true;

            }
            return false;
        }

        public bool Update(string mahs, Student student)
        {
            string query = "UPDATE HOCSINH SET HOTEN= @Hoten , GIOITINH= @Gioitinh , NGAYSINH= @Ngaysinh , DIACHI= @Diachi , EMAIL= @Email ,MALOP= @Malop WHERE MAHS = @OldMaHS";
            object[] para = new object[] {student.Hoten, student.Gioitinh, student.Ngaysinh, student.Diachi, student.Email,student.Malop,mahs };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
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
