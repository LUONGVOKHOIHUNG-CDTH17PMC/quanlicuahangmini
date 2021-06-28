using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class QuanLyKhuyenMaiBUS
    {
        public static DataTable GetKM()
        {
            return QuanLyKhuyenmaiDAO.GetKM();
        }

        public static bool ThemKM(string txtThemmasp, string txtThemmakm, DateTime txtThemthoigianbatdau, DateTime txtThemthoigianketthuc, string txtThemchietkhau)
        {
            return QuanLyKhuyenmaiDAO.ThemKM( txtThemmasp,  txtThemmakm,  txtThemthoigianbatdau, txtThemthoigianketthuc, txtThemchietkhau);
        }

        public static DataSet GetListSanPham(string table)
        {
            return QuanLyKhuyenmaiDAO.GetListSanPham(table);
        }
    }
}
