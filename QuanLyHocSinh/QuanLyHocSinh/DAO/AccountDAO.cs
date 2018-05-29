using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set => instance = value;
        }

        private AccountDAO() { }

        

        public bool Login(string Username, string PassWord)
        {

            string query = "SELECT* FROM ACCOUNT WHERE USERNAME= @UserName AND PASSWORD= @PassWord";

            DataTable result = DataProvider.Instance.ExcuteQuery1(query, new object[] { Username, PassWord });

            return result.Rows.Count > 0;
        }
    }



    
}
