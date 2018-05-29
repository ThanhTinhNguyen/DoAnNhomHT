using QuanLyHocSinh.BUS;
using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class fCreateClassList : Form
    {
        public fCreateClassList()
        {
            InitializeComponent();
            LoadGrade();
            
        }

        void LoadGrade()
        {
            GradeBUS.Instance.GetGrade(cbGrade);
            cbGrade.DisplayMember = "MAKHOI";
        }

        void LoadClass(string id)
        {
            ClassBUS.Instance.GetListClass(cbClass, id);
            cbClass.DisplayMember = "TENLOP";
        }



        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = "";

            if (cbGrade.SelectedItem == null)
                return;
            Grade selected = cbGrade.SelectedItem as Grade;
            id = selected.Makhoi;
            LoadClass(id);
        }

        
    }
}
