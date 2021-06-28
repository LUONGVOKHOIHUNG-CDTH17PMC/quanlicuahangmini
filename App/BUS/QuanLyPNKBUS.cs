using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class QuanLyPNKBUS
    {
        public static bool ThemNV(string txtThemMaPNK, string txtThemmanvPNK, string txtThemmanccPNK, string txtThemghichuPNK, DateTime dtpNgayNhap)
        {
            return QuanLyPNKDAO.ThemNV(txtThemMaPNK, txtThemmanvPNK, txtThemmanccPNK, txtThemghichuPNK, dtpNgayNhap);
        }

        public static DataSet GetListNhaCungCap(string table)
        {
            return QuanLyPNKDAO.GetListNhaCungCap(table);
        }

        public static DataSet GetListNhanVien(string table)
        {
            return QuanLyPNKDAO.GetListNhanVien(table);
        }

        public static bool SuaPNK(string txtsuaMaPNK, string txtsuamanvPNK, string txtThemmanccPNK, string txtsuaGhichuPNK, DateTime dtpNgayNhap)
        {
            return QuanLyPNKDAO.SuaPNK(txtsuaMaPNK, txtsuamanvPNK, txtThemmanccPNK, txtsuaGhichuPNK, dtpNgayNhap);
        }

        public static object TimKiemNhanVien(string textSearch)
        {
            return QuanLyPNKDAO.TimKiemNhanVien(textSearch);
        }
    }
}
