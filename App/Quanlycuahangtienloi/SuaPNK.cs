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
    public partial class SuaPNK : Form
    {
        public QuanLyPhieuNhapKho frmQuaLyPNK;
        public SuaPNK(QuanLyPhieuNhapKho quanLyPhieuNhapKho)
        {
            InitializeComponent();
            frmQuaLyPNK = quanLyPhieuNhapKho;
            LoadCbxNhaCungCap();
            LoadCbxNhanVien();
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

        private void btnsuaPNK_Click(object sender, EventArgs e)
        {
            txtsuamaPNK.ReadOnly = true;
            string txtsuaMaPNK = txtsuamaPNK.Text;
            string txtsuamanvPNK = (string)((System.Data.DataRowView)cbmanv.SelectedItem).Row.ItemArray[0];
            string txtThemmanccPNK = (string)((System.Data.DataRowView)cbmancc.SelectedItem).Row.ItemArray[0];
            string txtsuaGhichuPNK = txtsuaghichuPNK.Text;
            DateTime dtpNgayNhap = dateTimePicker1.Value;


            bool checkUpdate = QuanLyPNKBUS.SuaPNK(txtsuaMaPNK, txtsuamanvPNK, txtThemmanccPNK, txtsuaGhichuPNK, dtpNgayNhap);

            if (checkUpdate)
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuaLyPNK.LoadData();
        }
    }
}
