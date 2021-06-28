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
    public partial class ThemKH : Form
    {
        private QuanLyKhachHang frmQuanLyKH;
        public ThemKH(QuanLyKhachHang quanLyKhachHang)
        {
            InitializeComponent();
            frmQuanLyKH = quanLyKhachHang;
        }

        private void btnthemKH_Click(object sender, EventArgs e)
        {
            string txtThemhovatenKH = txtthemhovatenKH.Text;
            
            string[] arrName = txtThemhovatenKH.Split(' ');

            if (arrName.Length < 2)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên");
            }
            else
            {
                
                string txtThemmaKH = txtthemmaKH.Text;
                string txtThemghichuKH = txtthemghichuKH.Text;

                string txtThemgioitinhKH = "";
                bool isChecked = metroRadioButton1.Checked;
                if (isChecked)
                    txtThemgioitinhKH = metroRadioButton1.Text;
                else
                    txtThemgioitinhKH = metroRadioButton2.Text;

                bool checkAdd = QuanLyKhacHangBUS.ThemKhachHang(txtThemmaKH, txtThemhovatenKH, txtThemgioitinhKH, txtThemghichuKH);

                if (checkAdd)
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyKH.LoadData();
        }
    }
}
