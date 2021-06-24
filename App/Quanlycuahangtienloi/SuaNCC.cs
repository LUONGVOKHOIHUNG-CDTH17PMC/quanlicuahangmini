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
    public partial class SuaNCC : Form
    {
        public QuanLyNhaCungCap frmQuanLyNCC;
        public SuaNCC(QuanLyNhaCungCap quanLyNhaCungCap)
        {
            InitializeComponent();
            frmQuanLyNCC = quanLyNhaCungCap;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyNCC.LoadData();
            frmQuanLyNCC.formDefault();
        }

        private void btnsuaNCC_Click(object sender, EventArgs e)
        {
            string txtSuatenNCC = txtsuatenNCC.Text;
            string txtSuamaNCC = txtsuamaNCC.Text;
            string txtSuadiachiNCC = txtsuadiachiNCC.Text;
            string txtSuaemailNCC = txtsuaemailNCC.Text;
            string txtSuasdtNCC = txtsuasdtNCC.Text;
            string trangthai = cksuatrangthaiNCC.Checked == true ? "1" : "0";

            bool checkUpdate = QuanLyNCCBUS.SuaNhaCungCap(txtSuatenNCC, txtSuamaNCC, txtSuadiachiNCC, txtSuaemailNCC, txtSuasdtNCC, trangthai);

            if (checkUpdate)
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
