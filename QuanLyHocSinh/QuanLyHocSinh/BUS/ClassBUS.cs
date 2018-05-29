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
    class ClassBUS
    {
        private static ClassBUS instance;

        public static ClassBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClassBUS();
                return ClassBUS.instance;
            }
            set => instance = value;
        }

        public void GetListClass(ComboBox box, string id)
        {
            List<Class> classes = ClassDAO.Instance.GetClass(id);
            box.DataSource = classes;

        }
    }
}
