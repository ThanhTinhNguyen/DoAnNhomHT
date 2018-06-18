using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    class ClassDAO

    {
        private static ClassDAO instance;

        public static ClassDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassDAO();
                return ClassDAO.instance;
            }
            set => instance = value;
        }

        private ClassDAO()
        {

        }

        public List<Class> GetClass(string id)
        {
            List<Class> listclass = new List<Class>();
            object[] par = new object[] { id };
            string query = "SELECT* FROM LOP WHERE MAKHOI = @ID ";

            DataTable data = DataProvider.Instance.ExcuteQuery1(query,par);
            foreach (DataRow item in data.Rows)
            {
                Class _class = new Class(item);
                listclass.Add(_class);

            }
            return listclass;
        }
        public int UpdateSiSo(string malop)
        {
            string query = "SELECT COUNT(MAHS) FROM HOCSINH WHERE MALOP = @Malop";
            object[] para = new object[] { malop };
            return (Int32.Parse(System.Convert.ToString(DataProvider.Instance.ExcuteScalar1(query, para))));
            
        }
        public bool InsertNewStudent(string mahs, Student student)
        {

            string query = "UPDATE HOCSINH SET MALOP= @Malop WHERE MAHS = @OldMaHS";
            object[] para = new object[] { student.Malop, mahs };
            if (DataProvider.Instance.ExcuteNonQuery(query, para) > 0)
            {
                return true;

            }

            return false;
        }
    }
}
