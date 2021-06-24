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
    public partial class QuanLyNhaCungCap : Form
    {
        public QuanLyNhaCungCap()
        {
            InitializeComponent();
            formDefault();
        }

        public void formDefault()
        {
            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = false;
        }

        public void LoadData()
        {
            DataTable dt = QuanLyNCCBUS.GetNhaCungCap();
            dgv_QLNCC.DataSource = dt;
        }

        private void btnthemNCC_Click(object sender, EventArgs e)
        {
            ThemNCC n1 = new ThemNCC(this);
            n1.Show();
        }

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btntimkiemNCC_Click(object sender, EventArgs e)
        {
            string textSearch = txttimkiemNCC.Text;
            bool sudung = metroCheckBox1.Checked;
            bool khongSudung = metroCheckBox2.Checked;

            //DataTable dt = QuanLyNCCBUS.TimKiemNhaCungCap(textSearch, sudung, khongSudung);

            dgv_QLNCC.DataSource = QuanLyNCCBUS.TimKiemNhaCungCap(textSearch, sudung, khongSudung);
        }

        private void dgv_QLNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaNCC ncc = new SuaNCC(this);
            int i;
            i = dgv_QLNCC.CurrentRow.Index;
            ncc.txtsuatenNCC.Text = dgv_QLNCC.Rows[i].Cells["tenncc"].Value.ToString();
            ncc.txtsuamaNCC.Text = dgv_QLNCC.Rows[i].Cells["mancc"].Value.ToString();
            ncc.txtsuasdtNCC.Text = dgv_QLNCC.Rows[i].Cells["sdt"].Value.ToString();
            ncc.txtsuadiachiNCC.Text = dgv_QLNCC.Rows[i].Cells["diachi"].Value.ToString();
            ncc.txtsuaemailNCC.Text = dgv_QLNCC.Rows[i].Cells["email"].Value.ToString();
            ncc.cksuatrangthaiNCC.Checked = dgv_QLNCC.Rows[i].Cells["trangthai"].Value.ToString().ToLower() == "sử dụng" ? true : false;
            ncc.ShowDialog();
        }
    }
}


