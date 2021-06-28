using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class QuanLySanPhamBUS
    {
        public static DataTable GetSanPham()
        {
            return QuaLySanPhamDAO.GetSanPham();
        }

        public static bool ThemSanPham(string txtTenSP, string txtmaSP, string txtmotaSP, string txtdonvitinhSP, string txtsonluongSP, int txtdongiasp, string txtmanccSP, string txtghichu, bool txttrangthaiSP)
        {
            return QuaLySanPhamDAO.ThemSanTham(txtTenSP, txtmaSP, txtmotaSP, txtdonvitinhSP, txtsonluongSP, txtdongiasp, txtmanccSP, txtghichu, txttrangthaiSP);
        }

        public static DataTable TimSanPham(string textSearch, bool sudung, bool khongSudung)
        {
            return QuaLySanPhamDAO.TimSanPham(textSearch, sudung, khongSudung);
        }

        public static bool SuaSanPham(string txtSuamaSP, string txtSuamanccSP, string txtSuatenSP, string txtSuadonvitinhSP, string txtSuasoluongSP, string txtSuadongiaSP, string txtSuamotaSP, string txtSuaghichuSP, string txttrangthai)
        {
            return QuaLySanPhamDAO.SuaSanPham(txtSuamaSP, txtSuamanccSP, txtSuatenSP, txtSuadonvitinhSP, txtSuasoluongSP, txtSuadongiaSP, txtSuamotaSP, txtSuaghichuSP, txttrangthai);
        }

        public static DataSet GetListNhaCungCap(string table)
        {
            return QuaLySanPhamDAO.GetListNhaCungCap(table);
        }

       
    }
}
