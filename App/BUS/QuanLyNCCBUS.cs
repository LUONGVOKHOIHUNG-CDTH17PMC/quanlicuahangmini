using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyNCCBUS
    {
        public static DataTable GetNhaCungCap()
        {
            return QuanLyNCCDAO.GetNhaCungCap();
        }

        public static bool ThemNhaCungCap(string txtThemtenNCC, string txtThemmaNCC, string txtThemtrangthaiNCC, string txtThemdiachiNCC, string txtThememailNCC, string txtThemsdtNCC)
        {
            return QuanLyNCCDAO.ThemNhaCungCap(txtThemtenNCC, txtThemmaNCC, txtThemtrangthaiNCC, txtThemdiachiNCC, txtThememailNCC, txtThemsdtNCC);
        }

        public static DataTable TimKiemNhaCungCap(string textSearch, bool sudung, bool khongSudung)
        {
            return QuanLyNCCDAO.TimKiemNhaCungCap(textSearch, sudung, khongSudung);
        }

        public static bool SuaNhaCungCap(string txtSuatenNCC, string txtSuamaNCC, string txtSuadiachiNCC, string txtSuaemailNCC, string txtSuasdtNCC, string trangthai)
        {
            return QuanLyNCCDAO.SuaNhaCungCap(txtSuatenNCC, txtSuamaNCC, txtSuadiachiNCC, txtSuaemailNCC,  txtSuasdtNCC,  trangthai);
        }
    }
}
