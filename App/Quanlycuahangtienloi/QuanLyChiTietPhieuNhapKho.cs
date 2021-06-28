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
    public partial class QuanLyChiTietPhieuNhapKho : Form
    {
        public QuanLyChiTietPhieuNhapKho()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = QuanLyCTPNKBUS.GetCTPNK();
            dataGridView2.DataSource = dt;
        }

        private void btnthemCTPNK_Click(object sender, EventArgs e)
        {
            ThemCTPNK kh = new ThemCTPNK(this);
            kh.Show();
        }

        private void btntimCTPNK_Click(object sender, EventArgs e)
        {
            string textSearch = txttimCTPNK.Text;
            dataGridView2.DataSource = QuanLyCTPNKBUS.TimKiemCTPNK(textSearch);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaCTPNK sua = new SuaCTPNK(this);
            int i;
            i = dataGridView2.CurrentRow.Index;
            sua.txtsuadongiaCTPNK.Text = dataGridView2.Rows[i].Cells["dongia"].Value.ToString();
            sua.txtsuamanhakhoCTPNK.Text = dataGridView2.Rows[i].Cells["manhapkho"].Value.ToString();
            sua.txtsuamaspCTPNK.Text = dataGridView2.Rows[i].Cells["masp"].Value.ToString();
            sua.txtThanhTien.Text = dataGridView2.Rows[i].Cells["thanhtien"].Value.ToString();
            sua.txtsúaoluongCTPNK.Text = dataGridView2.Rows[i].Cells["soluong"].Value.ToString();
            sua.dtpnghethan.Text = dataGridView2.Rows[i].Cells["ngayhethan"].Value.ToString();
            sua.ShowDialog();
        }

        private void QuanLyChiTietPhieuNhapKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
