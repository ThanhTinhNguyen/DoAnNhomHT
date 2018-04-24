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
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void btnAcceptStudent_Click(object sender, EventArgs e)
        {
            fAcceptStudent f = new fAcceptStudent();
            f.ShowDialog();
        }

        private void btnCreateClassList_Click(object sender, EventArgs e)
        {
            fCreateClassList f = new fCreateClassList();
            f.ShowDialog();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            fSearchStudent f = new fSearchStudent();
            f.ShowDialog();
        }

        private void btnEnterPoint_Click(object sender, EventArgs e)
        {
            fEnterPoint f = new fEnterPoint();
            f.ShowDialog();
        }

        private void btnCreateSummaryReport_Click(object sender, EventArgs e)
        {
            fCreateSummaryReport f = new fCreateSummaryReport();
            f.ShowDialog();
        }

        private void btnChangeRules_Click(object sender, EventArgs e)
        {
            fChageRules f = new fChageRules();
            f.ShowDialog();
        }
    }
}
