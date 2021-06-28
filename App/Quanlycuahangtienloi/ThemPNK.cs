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
    public partial class ThemPNK : Form
    {
        private QuanLyPhieuNhapKho frmQuanLyPNK;
        public ThemPNK(QuanLyPhieuNhapKho quanLyPhieuNhapKho)
        {
            InitializeComponent();
            frmQuanLyPNK = quanLyPhieuNhapKho;
            LoadCbxNhaCungCap();
            LoadCbxNhanVien();
        }

        private void btnthemPNK_Click(object sender, EventArgs e)
        {
            string txtThemMaPNK = txtthemmaPNK.Text;
            string txtThemmanvPNK = (string)((System.Data.DataRowView)cbmanv.SelectedItem).Row.ItemArray[0];
            string txtThemmanccPNK = (string)((System.Data.DataRowView)cbmancc.SelectedItem).Row.ItemArray[0];
            string txtThemghichuPNK = txtthemghichuPNK.Text;
            DateTime dtpNgayNhap = dateTimePicker1.Value;

            bool checkAdd = QuanLyPNKBUS.ThemNV(txtThemMaPNK, txtThemmanvPNK, txtThemmanccPNK, txtThemghichuPNK, dtpNgayNhap);

            if (checkAdd)
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LoadCbxNhaCungCap()
        {
            string table = "nhacungcap";
            DataSet ds = QuanLyPNKBUS.GetListNhaCungCap(table);
            cbmancc.ValueMember = "mancc";
            cbmancc.DataSource = ds.Tables["nhacungcap"];
        }
        public void LoadCbxNhanVien()
        {
            string table = "nhanvien";
            DataSet ds = QuanLyPNKBUS.GetListNhanVien(table);
            cbmanv.ValueMember = "manv";
            cbmanv.DataSource = ds.Tables["nhanvien"];
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyPNK.LoadData();

        }
    }
}
