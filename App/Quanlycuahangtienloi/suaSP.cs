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
    public partial class SuaSP : Form
    {

        public QuanLySanPham frmQuanLySP;
        public SuaSP(QuanLySanPham quanLySanPham)
        {
            InitializeComponent();
            frmQuanLySP = quanLySanPham;
            LoadCbxNhaCungCap();
        }

        private void btnsuaSP_Click(object sender, EventArgs e)
        {
            txtsuamaSP.ReadOnly = true;
            string txtSuamaSP = txtsuamaSP.Text;
            string txtSuamanccSP = cbxmancc.Text;
            string txtSuatenSP = txtsuatenSP.Text;
            string txtSuadonvitinhSP = txtsuadonvitinhSP.Text;
            string txtSuasoluongSP = txtsuasoluongSP.Text;
            string txtSuadongiaSP = txtsuadongiaSP.Text;
            string txttrangthai = cksuatrangthaiSP.Checked == true ? "1" : "0";
            string txtSuamotaSP = txtsuamotaSP.Text;
            string txtSuaghichuSP = txtsuaghichuSP.Text;

            bool checkUpdate = QuanLySanPhamBUS.SuaSanPham(txtSuamaSP, txtSuamanccSP, txtSuatenSP, txtSuadonvitinhSP, txtSuasoluongSP, txtSuadongiaSP, txtSuamotaSP, txtSuaghichuSP, txttrangthai);

            if (checkUpdate)
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadCbxNhaCungCap()
        {
            string table = "nhacungcap";
            DataSet ds = QuanLySanPhamBUS.GetListNhaCungCap(table);
            cbxmancc.ValueMember = "mancc";
            cbxmancc.DataSource = ds.Tables["nhacungcap"];
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLySP.LoadData();
        }
    }
}
