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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
            LoadData();
            formDefault();
        }

        public void formDefault()
        {
            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = false;
        }

        public void LoadData()
        {
            DataTable dt = QuanLySanPhamBUS.GetSanPham();
            dgv_QLSP.DataSource = dt;
        }
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaSP sua = new SuaSP(this);
            int i;
            i = dgv_QLSP.CurrentRow.Index;
            sua.txtsuamaSP.Text = dgv_QLSP.Rows[i].Cells["masp"].Value.ToString();
            sua.txtsuatenSP.Text = dgv_QLSP.Rows[i].Cells["tensp"].Value.ToString();
            sua.cbxmancc.Text = dgv_QLSP.Rows[i].Cells["mancc"].Value.ToString();
            sua.txtsuamotaSP.Text = dgv_QLSP.Rows[i].Cells["mota"].Value.ToString();
            sua.txtsuadonvitinhSP.Text = dgv_QLSP.Rows[i].Cells["donvitinh"].Value.ToString();
            sua.txtsuasoluongSP.Text = dgv_QLSP.Rows[i].Cells["soluong"].Value.ToString();
            sua.txtsuadongiaSP.Text = dgv_QLSP.Rows[i].Cells["dongia"].Value.ToString();
            sua.txtsuaghichuSP.Text = dgv_QLSP.Rows[i].Cells["ghichu"].Value.ToString();
            sua.cksuatrangthaiSP.Text = "Sử dụng";
            sua.cksuatrangthaiSP.Checked = dgv_QLSP.Rows[i].Cells["trangthai"].Value.ToString().ToLower() == "sử dụng" ? true : false;
            sua.ShowDialog();
        }

        private void btnthemSP_Click(object sender, EventArgs e)
        {
            ThemSPcs n1 = new ThemSPcs(this);
            n1.Show();
        }

        private void btntimkiemSP_Click(object sender, EventArgs e)
        {
            string textSearch = txttimkiemSP.Text;
            bool sudung = metroCheckBox1.Checked;
            bool khongSudung = metroCheckBox2.Checked;

            //DataTable dt = QuanLyNCCBUS.TimKiemNhaCungCap(textSearch, sudung, khongSudung);

            dgv_QLSP.DataSource = QuanLySanPhamBUS.TimSanPham(textSearch, sudung, khongSudung);
        }
    }
}
