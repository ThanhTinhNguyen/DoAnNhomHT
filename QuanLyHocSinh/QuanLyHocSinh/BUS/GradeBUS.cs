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
    class GradeBUS
    {
        private static GradeBUS instance;

        public static GradeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GradeBUS();
                return GradeBUS.instance;
            }
            set => instance = value;
        }

        public void GetGrade(ComboBox box)
        {
            List<Grade> listgrades = GradeDAO.Instance.GetListGrades();
            box.DataSource = listgrades;


        }
    }
}
