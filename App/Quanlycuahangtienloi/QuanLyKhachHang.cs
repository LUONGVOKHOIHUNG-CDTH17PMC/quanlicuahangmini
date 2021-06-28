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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = QuanLyKhacHangBUS.GetKH();
            dgv_KH.DataSource = dt;
        }

        private void btnthemKH_Click(object sender, EventArgs e)
        {
            ThemKH kh = new ThemKH(this);
                kh.Show();
        }

        private void btntimkiemKH_Click(object sender, EventArgs e)
        {
            string textSearch = txttimkiemKH.Text;
            dgv_KH.DataSource = QuanLyKhacHangBUS.TimKiemKhachHang(textSearch);
           
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
