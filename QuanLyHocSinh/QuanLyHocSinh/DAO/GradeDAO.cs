using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    class GradeDAO
    {
        private static GradeDAO instance;

        public static GradeDAO Instance
        {
            get { if (instance == null) instance = new GradeDAO(); return GradeDAO.instance; }
            set => instance = value;
        }

        private GradeDAO() { }

        public List<Grade> GetListGrades()
        {
            List<Grade> gradelist = new List<Grade>();

            string query = "SELECT * FROM KHOI";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Grade grade = new Grade(item);
                gradelist.Add(grade);
            }


            return gradelist;
        }
    }
}
