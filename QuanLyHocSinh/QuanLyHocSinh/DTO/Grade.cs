using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DTO
{
    class Grade
    {
        public Grade(string makhoi, string tenkhoi)
        {
            this.Makhoi = makhoi;
            this.Tenkhoi = tenkhoi;

        }

        public Grade(DataRow row)
        {
            this.Makhoi = row["makhoi"].ToString();
            this.Tenkhoi = row["tenkhoi"].ToString();

        }

        public Grade()
        {

        }



        private string makhoi;

        public string Makhoi { get => makhoi; set => makhoi = value; }

        private string tenkhoi;

        public string Tenkhoi { get => tenkhoi; set => tenkhoi = value; }
    }
}
