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
    public partial class SuaCTPNK : Form
    {
        public QuanLyChiTietPhieuNhapKho frmQuanLyCTPNK;
        public SuaCTPNK(QuanLyChiTietPhieuNhapKho quanLyChiTietPhieuNhapKho)
        {
            InitializeComponent();
            frmQuanLyCTPNK = quanLyChiTietPhieuNhapKho;
        }

        private void btnsuaCTPNK_Click(object sender, EventArgs e)
        {
            txtsuamanhakhoCTPNK.ReadOnly = true;
            txtsuamaspCTPNK.ReadOnly = true;
            string txtSuasoluong = txtsúaoluongCTPNK.Text;
            DateTime txtSuanghethan = dtpnghethan.Value;
            string txtSuathanhtien = txtThanhTien.Text;
            string txtSuadongia = txtsuadongiaCTPNK.Text;
            string txtSuamasp = txtsuamaspCTPNK.Text;
            string txtSuamanhapkho = txtsuamanhakhoCTPNK.Text;

            string query = String.Format(" UPDATE ct_phieunhapkho SET thanhtien = @thanhtien', dongia = @@ ,soluong = @soluong, ngayhethan = @ngayhethan where manhapkho = @manhapkho and masp = @masp");


            bool checkUpdate = QuanLyCTPNKBUS.SuaCTPNK(txtSuamanhapkho, txtSuamasp, txtSuadongia, txtSuasoluong, txtSuathanhtien, txtSuanghethan);

            if (checkUpdate)
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private float tinhThanhTien(float dongia, float soluong)
        {
            return dongia * soluong;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyCTPNK.LoadData();
            
        }

        private void txtsuadongiaCTPNK_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.checkInputNumber(sender, e);
        }

        private void txtsúaoluongCTPNK_TextChanged(object sender, EventArgs e)
        {
            float dongia = float.Parse(txtsuadongiaCTPNK.Text.ToString() == "" ? "0" : txtsuadongiaCTPNK.Text.ToString());
            float soluong = float.Parse(txtsúaoluongCTPNK.Text.ToString() == "" ? "0" : txtsúaoluongCTPNK.Text.ToString());

            float thanhTien = tinhThanhTien(dongia, soluong);
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void txtsúaoluongCTPNK_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.checkInputNumber(sender, e);
        }
    }
}
