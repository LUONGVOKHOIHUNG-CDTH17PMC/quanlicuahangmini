using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
   public class QuanLyKhacHangBUS
    {
        public static DataTable GetKH()
        {
            return QuanLyKhachHangDAO.GetKH();
        }

       


        public static DataTable TimKiemKhachHang(string textSearch)
        {
            return QuanLyKhachHangDAO.TimKiemKhachHang(textSearch);
        }

        public static bool ThemKhachHang(string txtThemmaKH, string txtThemhovatenKH, string txtThemgioitinhKH, string txtThemghichuKH)
        {
            return QuanLyKhachHangDAO.ThemKhachHang(txtThemmaKH, txtThemhovatenKH, txtThemgioitinhKH, txtThemghichuKH);
        }
    }
}
