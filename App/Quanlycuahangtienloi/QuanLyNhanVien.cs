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
    public partial class QuanLyNhanVien : Form
    {

        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
            CBsudung.Checked = true;
            CBkhongsudung.Checked = false;
        }
        public void resetCheckBox()
        {
            CBsudung.Checked = true;
            CBkhongsudung.Checked = false;
        }
            private void dgv_NV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaNV sua = new SuaNV(this);
            int i = dgv_NV.CurrentRow.Index;
            sua.txtsuatkNV.Text = dgv_NV.Rows[i].Cells["taikhoan"].Value.ToString();
            sua.txtsuaemailNV.Text = dgv_NV.Rows[i].Cells["email"].Value.ToString();

            string gioitinh = dgv_NV.Rows[i].Cells["gioitinh"].Value.ToString();
            if (gioitinh.Trim().ToLower().ToString() == "nam")
                sua.metroRadioButton1.Checked = true;
            else
                sua.metroRadioButton2.Checked = true;
            sua.txtsuachucvuNV.Text = dgv_NV.Rows[i].Cells["chucvu"].Value.ToString();
            sua.txtsuadiachiNV.Text = dgv_NV.Rows[i].Cells["diachi"].Value.ToString();
            sua.txtsuamaNV.Text = dgv_NV.Rows[i].Cells["manv"].Value.ToString();
            sua.txtsuamkNV.Text = dgv_NV.Rows[i].Cells["matkhau"].Value.ToString();
            sua.dtp_ngsinhNV.Text = dgv_NV.Rows[i].Cells["ngaysinh"].Value.ToString();
            sua.dtp_ngvaolamNV.Text = dgv_NV.Rows[i].Cells["ngayvaolam"].Value.ToString();
            sua.txtsuasdtNV.Text = dgv_NV.Rows[i].Cells["sdt"].Value.ToString();
            sua.cksuatrangthaiNV.Text = "Sử dụng";
            sua.cksuatrangthaiNV.Checked = dgv_NV.Rows[i].Cells["trangthai"].Value.ToString().ToLower() == "sử dụng" ? true : false;
            sua.txtsuahovatenNV.Text = dgv_NV.Rows[i].Cells["honv"].Value.ToString() + " " + dgv_NV.Rows[i].Cells["tenlot"].Value.ToString() + " " + dgv_NV.Rows[i].Cells["tennv"].Value.ToString();
            sua.ShowDialog();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = QuanLyNhanVienBUS.GetNhanVien();
            dgv_NV.DataSource = dt;
        }

        private void btnthemNV_Click(object sender, EventArgs e)
        {
            ThemNV n1 = new ThemNV(this);
            n1.Show();
        }

        private void btntimkiemNV_Click(object sender, EventArgs e)
        {
            string textSearch = txttimkiemNV.Text;
            bool sudung = CBsudung.Checked;
            bool khongSudung = CBkhongsudung.Checked;

           

            dgv_NV.DataSource = QuanLyNhanVienBUS.TimKiemNhanVien(textSearch, sudung, khongSudung);
        }

       
    }
}
