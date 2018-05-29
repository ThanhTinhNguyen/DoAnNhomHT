using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DTO
{
    class Class
    {

        public Class(string malop, string tenlop, string siso, string makhoi)
        {
            this.Malop = malop;
            this.Tenlop = tenlop;
            this.Siso = siso;
            this.Makhoi = makhoi;

        }

        public Class(DataRow row)
        {
            this.Malop = row["malop"].ToString();
            this.Tenlop = row["tenlop"].ToString();
            this.Siso = row["siso"].ToString();
            this.Makhoi = row["makhoi"].ToString();

        }

        public Class()
        {

        }



        private string malop;

        private string tenlop;

        private string siso;

        private string makhoi;


        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Siso { get => siso; set => siso = value; }
        public string Makhoi { get => makhoi; set => makhoi = value; }
    }
}
