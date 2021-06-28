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
    public partial class ThemKM : Form
    {
        private QuanLyKhuyenMai frmQuanLyKM;
        public ThemKM(QuanLyKhuyenMai quanLyKhuyenMai)
        {
            InitializeComponent();
            frmQuanLyKM = quanLyKhuyenMai;
            LoadCbxSanPham();
        }

        private void btnthemKM_Click(object sender, EventArgs e)
        {

            string txtThemmasp = CBmasp.Text;
            string txtThemmakm = txtmaKM.Text;
            DateTime txtThemthoigianbatdau = txttgbdKM.Value;
            DateTime txtThemthoigianketthuc = txttgktKM.Value;
            string txtThemchietkhau = txtchietkhauKM.Text;
            

            bool checkAdd = QuanLyKhuyenMaiBUS.ThemKM(txtThemmasp, txtThemmakm, txtThemthoigianbatdau, txtThemthoigianketthuc, txtThemchietkhau);

            if (checkAdd)
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void LoadCbxSanPham()
        {
            string table = "sanpham";
            DataSet ds = QuanLyKhuyenMaiBUS.GetListSanPham(table);
            CBmasp.ValueMember = "masp";
            CBmasp.DataSource = ds.Tables["sanpham"];
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyKM.LoadData();
        }

        private void ThemKM_Load(object sender, EventArgs e)
        {

        }
    }
}
