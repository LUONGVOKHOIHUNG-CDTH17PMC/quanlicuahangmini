using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Quanlycuahangtienloi
{
    public partial class QuanLyKhuyenMai : Form
    {
        public QuanLyKhuyenMai()
        {
            InitializeComponent();
            LoadData();
        }


        public void LoadData()
        {
            DataTable dt = QuanLyKhuyenMaiBUS.GetKM();
            dgv_KM.DataSource = dt;
        }

        private void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnthemKM_Click(object sender, EventArgs e)
        {
            ThemKM km = new ThemKM(this);
            km.Show();
        }
    }
}
