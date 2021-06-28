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
    public partial class ThemSPcs : Form
    {
        private QuanLySanPham frmQuanLySP;
        public ThemSPcs(QuanLySanPham quanLySanPham)
        {
            InitializeComponent();
            LoadCbxNhaCungCap();
            frmQuanLySP = quanLySanPham;
        }

        private void btnthemSP_Click(object sender, EventArgs e)
        {
            string txtTenSP = txtthemtenSP.Text;
            string txtmaSP = txtthemmaSP.Text;
            string txtmotaSP = txtthemmotaSP.Text;
            string txtdonvitinhSP = txtthemdonvitinhSP.Text;
            string txtsonluongSP = txtthemsoluongSP.Text;
            int txtdongiasp = Convert.ToInt32(txtthemdongiaSP.Text);
            string txtmanccSP = (string)((System.Data.DataRowView)cbxmancc.SelectedItem).Row.ItemArray[0];
            string txtghichu = txtthemghichuSP.Text;
            bool txttrangthaiSP = ckthemtrangthaiSP.Checked;

            bool checkAdd = QuanLySanPhamBUS.ThemSanPham(txtTenSP, txtmaSP, txtmotaSP, txtdonvitinhSP, txtsonluongSP, txtdongiasp, txtmanccSP, txtghichu, txttrangthaiSP);

            if (checkAdd)
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
