using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlycuahangtienloi
{
    public partial class ThemNCC : Form
    {
        private QuanLyNhaCungCap frmQuanLyNCC;
        public ThemNCC(QuanLyNhaCungCap quanLyNhaCungCap)
        {
            InitializeComponent();
            frmQuanLyNCC = quanLyNhaCungCap;
        }

        private void btnthemNCC_Click(object sender, EventArgs e)
        {

            string txtThemtenNCC = txtthemmaNCC.Text;
            string txtThemmaNCC = txtthemmaNCC.Text;
            string txtThemtrangthaiNCC = ckthemtrangthaiNCC.Checked == true ? "1" : "0";
            string txtThemdiachiNCC = txtthemdiachiNCC.Text;
            string txtThememailNCC = txtthememailNCC.Text;
            string txtThemsdtNCC = txtthemsdtNCC.Text;

            bool checkAdd = QuanLyNCCBUS.ThemNhaCungCap(txtThemtenNCC, txtThemmaNCC, txtThemtrangthaiNCC, txtThemdiachiNCC, txtThememailNCC, txtThemsdtNCC);

            if (checkAdd)
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyNCC.LoadData();
        }
    }
}
