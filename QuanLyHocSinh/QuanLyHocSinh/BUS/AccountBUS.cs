using QuanLyHocSinh.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.BUS
{
     public class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return AccountBUS.instance;
            }
            set => instance = value;

        }

        public bool Login(string UserName, string PassWord)
        {
            return AccountDAO.Instance.Login(UserName, PassWord);
        }
    }
}
