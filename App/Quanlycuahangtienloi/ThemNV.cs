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
    public partial class ThemNV : Form
    {
        private QuanLyNhanVien frmQuanLyNhanVien;
        public ThemNV(QuanLyNhanVien quanLyNhanVien)
        {
            InitializeComponent();
            frmQuanLyNhanVien = quanLyNhanVien;
        }

        private void btnthemNV_Click(object sender, EventArgs e)
        {
            string txtThemtkNV = txtthemtkNV.Text.Trim();
            string txtThemmatkhauNV = txtthemmkNV.Text.Trim();
            string txtThemmaNV = txtthemmaNV.Text;
            DateTime txtThemngsinhNV = dateTimePicker1.Value;
            string txtThemdiachiNV = txtthemdiachiNV.Text.Trim();
            string txtThemsdtNV = txtthemsdtNV.Text.Trim();
            DateTime txtThemngvaolamNV = dateTimePicker2.Value;
            string txtThemchucvuNV = metroComboBox1.Text;
            string txtThememailNV = txtthememailNV.Text;
            string txtThemtrangthaiNV = ckthemtrangthaiNV.Checked == true ? "1" : "0";
            string txtThemgioitinhNV = "";
            bool isChecked = metroRadioButton1.Checked;
            if (isChecked)
                txtThemgioitinhNV = metroRadioButton1.Text;
            else
                txtThemgioitinhNV = metroRadioButton2.Text;

            string txtThemhovatenNV = txtthemhovatenNV.Text;
            string honv = "";
            string tenlotnv = "";
            string tennv = "";
            string[] arrName = txtThemhovatenNV.Split(' ');

            if (arrName.Length < 2)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên");
            }
            else
            {
                if (arrName.Length > 2)
                {
                    honv = arrName[0].ToString();
                    tenlotnv = arrName[1].ToString();
                    tennv = arrName[2].ToString();
                }

                if (arrName.Length == 2)
                {
                    honv = arrName[0].ToString();
                    tennv = arrName[1].ToString();
                }

                bool checkAdd = QuanLyNhanVienBUS.ThemNV(txtThemmaNV, txtThemtkNV, txtThemmatkhauNV, txtThemhovatenNV, txtThemngsinhNV, txtThemdiachiNV, txtThemsdtNV, txtThemngvaolamNV, txtThemchucvuNV, txtThememailNV, txtThemtrangthaiNV, txtThemgioitinhNV);

                if (checkAdd)
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyNhanVien.LoadData();

        }
    }
}
