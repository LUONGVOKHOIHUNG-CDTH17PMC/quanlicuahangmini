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
    public partial class SuaNV : Form
    {
        public QuanLyNhanVien frmQuanLyNV;
        public SuaNV(QuanLyNhanVien quanLyNhanVien)
        {
            InitializeComponent();
            frmQuanLyNV = quanLyNhanVien;
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLyNV.LoadData();
        }

        private void btnsuaNV_Click(object sender, EventArgs e)
        {
            string txtSuatkNV = txtsuatkNV.Text;
            string txtSuamatkhauNV = txtsuamkNV.Text;
            string txtSuamaNV = txtsuamaNV.Text;
            DateTime txtSuangsinhNV = dtp_ngsinhNV.Value;
            string txtSuadiachiNV = txtsuadiachiNV.Text;
            string txtSuasdtNV = txtsuasdtNV.Text;
            DateTime txtSuangvaolamNV = dtp_ngvaolamNV.Value;
            string txtSuachucvuNV = txtsuachucvuNV.Text;
            string txtSuaemailNV = txtsuaemailNV.Text;
            string txtSuatrangthaiNV = cksuatrangthaiNV.Checked == true ? "1" : "0";
            string txtSuagioitinhNV = "";
            bool isChecked = metroRadioButton1.Checked;
            if (isChecked)
                txtSuagioitinhNV = metroRadioButton1.Text;
            else
                txtSuagioitinhNV = metroRadioButton2.Text;

            string txtSuahovatenNV = txtsuahovatenNV.Text;
            string honv = "";
            string tenlotnv = "";
            string tennv = "";
            string[] arrName = txtSuahovatenNV.Split(' ');

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


                bool checkUpdate = QuanLyNhanVienBUS.SuaNhanVien(txtSuamaNV, txtSuatkNV, txtSuamatkhauNV, txtSuahovatenNV, txtSuagioitinhNV, txtSuangsinhNV, txtSuadiachiNV, txtSuasdtNV, txtSuaemailNV, txtSuangvaolamNV, txtSuachucvuNV, txtSuatrangthaiNV);

                if (checkUpdate)
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
}
