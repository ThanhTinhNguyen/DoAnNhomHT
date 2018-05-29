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
            string query = "SELECT* FROM LOP AS L INNER JOIN KHOI AS K ON L.MAKHOI = K.MAKHOI WHERE K.MAKHOI = @ID ";

            DataTable data = DataProvider.Instance.ExcuteQuery(query,par);
            foreach (DataRow item in data.Rows)
            {
                Class _class = new Class();
                listclass.Add(_class);

            }
            return listclass;
        }


    }
}
