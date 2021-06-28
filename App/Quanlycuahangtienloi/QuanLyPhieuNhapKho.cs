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
    public partial class QuanLyPhieuNhapKho : Form
    {
    

        public QuanLyPhieuNhapKho()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            DataTable dt = QuanLyNCCBUS.GetPNK();
            dgv_PNK.DataSource = dt;
        }

        private void btnthemPNK_Click(object sender, EventArgs e)
        {
            ThemPNK pnk = new ThemPNK(this);
            pnk.Show();
        }

        private void btntimkiemPNK_Click(object sender, EventArgs e)
        {
            string textSearch = txttimkiemPNK.Text;
            dgv_PNK.DataSource = QuanLyPNKBUS.TimKiemNhanVien(textSearch);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void QuanLyPhieuNhapKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            SuaPNK sua = new SuaPNK(this);
            
            int i = dgv_PNK.CurrentRow.Index;
            sua.txtsuaghichuPNK.Text = dgv_PNK.Rows[i].Cells["ghichu"].Value.ToString();
            sua.txtsuamaPNK.Text = dgv_PNK.Rows[i].Cells["manhapkho"].Value.ToString();
            sua.dateTimePicker1.Value = (DateTime)(dgv_PNK.Rows[i].Cells["ngaynhap"].Value);
            sua.cbmanv.SelectedValue = dgv_PNK.Rows[i].Cells["manv"].Value.ToString();
            sua.cbmancc.Text = dgv_PNK.Rows[i].Cells["mancc"].Value.ToString();

            sua.ShowDialog();
        }
    }
}
