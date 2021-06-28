using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class QuanLyNhanVienBUS
    {
        public static DataTable GetNhanVien()
        {
            return QuanLyNhanVienDAO.GetNhanVien();
        }

       

        public static bool SuaNhanVien(string txtSuamaNV, string txtSuatkNV, string txtSuamatkhauNV, string txtSuahovatenNV, string txtSuagioitinhNV, DateTime txtSuangsinhNV, string txtSuadiachiNV, string txtSuasdtNV, string txtSuaemailNV, DateTime txtSuangvaolamNV, string txtSuachucvuNV, string txtSuatrangthaiNV)
        {
            return QuanLyNhanVienDAO.SuaNhanVien(txtSuamaNV, txtSuatkNV, txtSuamatkhauNV, txtSuahovatenNV, txtSuagioitinhNV, txtSuangsinhNV, txtSuadiachiNV, txtSuasdtNV, txtSuaemailNV, txtSuangvaolamNV, txtSuachucvuNV, txtSuatrangthaiNV);
        }

        public static bool ThemNV(string txtThemmaNV, string txtThemtkNV, string txtThemmatkhauNV, string txtThemhovatenNV, DateTime txtThemngsinhNV, string txtThemdiachiNV, string txtThemsdtNV, DateTime txtThemngvaolamNV, string txtThemchucvuNV, string txtThememailNV, string txtThemtrangthaiNV, string txtThemgioitinhNV)
        {
            return QuanLyNhanVienDAO.ThemNV(txtThemmaNV, txtThemtkNV, txtThemmatkhauNV, txtThemhovatenNV, txtThemdiachiNV, txtThemngsinhNV, txtThemsdtNV, txtThememailNV, txtThemchucvuNV, txtThemngvaolamNV, txtThemtrangthaiNV, txtThemgioitinhNV);
        }

        public static object TimKiemNhanVien(string textSearch, bool sudung, bool khongSudung)
        {
            return QuanLyNhanVienDAO.TimKiemNhanVien(textSearch, sudung, khongSudung);
        }

       
    }
}
