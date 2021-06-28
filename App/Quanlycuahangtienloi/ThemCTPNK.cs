using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using System.Windows.Forms;

namespace Quanlycuahangtienloi
{
    public partial class ThemCTPNK : Form
    {
        private QuanLyChiTietPhieuNhapKho frmQuanLyCTPNK;
        public ThemCTPNK(QuanLyChiTietPhieuNhapKho quanLyChiTietPhieuNhapKho)
        {
            InitializeComponent();
            frmQuanLyCTPNK = quanLyChiTietPhieuNhapKho;
            LoadCbxPNK();
            LoadCbxSanPham();
        }

        private void btnthemCTPNK_Click(object sender, EventArgs e)
        {
            string txtThemsoluong = txtthemsoluongCTPNK.Text;
            DateTime txtThemnghethan = dateTimePicker1.Value;
            string txtThemthanhtien = txtThanhTien.Text;
            string txtThemdongia = txtthemdongiaCTPNK.Text;
            string txtThemmasp = (string)((System.Data.DataRowView)cbmasp.SelectedItem).Row.ItemArray[0];
            string txtThemmanhapkho = (string)((System.Data.DataRowView)cbmank.SelectedItem).Row.ItemArray[0];

            bool checkAdd = QuanLyCTPNKBUS.ThemCTPNK(txtThemmanhapkho, txtThemmasp, txtThemsoluong, txtThemdongia, txtThemthanhtien, txtThemnghethan);

            if (checkAdd)
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadCbxPNK()
        {
            string table = "phieunhapkho";
            DataSet ds = QuanLyCTPNKBUS.GetListPhieuNhapKho(table);
            cbmank.ValueMember = "manhapkho";
            cbmank.DataSource = ds.Tables["phieunhapkho"];
        }
        public void LoadCbxSanPham()
        {
            string table = "sanpham";
            DataSet ds = QuanLyCTPNKBUS.GetListSanPham(table);
            cbmasp.ValueMember = "masp";
            cbmasp.DataSource = ds.Tables["sanpham"];
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyCTPNK.LoadData();
        }

        private float tinhThanhTien(float dongia, float soluong)
        {
            return dongia * soluong;
        }

        private void txtthemdongiaCTPNK_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Common.checkInputNumber(sender, e);
        }

        private void txtthemsoluongCTPNK_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Common.checkInputNumber(sender, e);
        }

        private void txtthemsoluongCTPNK_TextChanged(object sender, EventArgs e)
        {
            float dongia = float.Parse(txtthemdongiaCTPNK.Text.ToString() == "" ? "0" : txtthemdongiaCTPNK.Text.ToString());
            float soluong = float.Parse(txtthemsoluongCTPNK.Text.ToString() == "" ? "0" : txtthemsoluongCTPNK.Text.ToString());

            float thanhTien = tinhThanhTien(dongia, soluong);
            txtThanhTien.Text = thanhTien.ToString();
        }
    }
}
