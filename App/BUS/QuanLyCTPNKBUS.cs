using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class QuanLyCTPNKBUS
    {
        public static DataTable GetCTPNK()
        {
            return QuanLyCTPNKDAO.GetCTPNK();
        }

        public static bool ThemCTPNK(string txtThemmanhapkho, string txtThemmasp, string txtThemsoluong, string txtThemdongia, string txtThemthanhtien, DateTime txtThemnghethan)
        {
            return QuanLyCTPNKDAO.ThemCTPNK( txtThemmanhapkho,  txtThemmasp,  txtThemsoluong,  txtThemdongia,  txtThemthanhtien,  txtThemnghethan);
        }

    
        public static DataSet GetListPhieuNhapKho(string table)
        {
            return QuanLyCTPNKDAO.GetListPhieuNhapKho(table);
        }

      

        public static DataSet GetListSanPham(string table)
        {
            return QuanLyCTPNKDAO.GetListSanPham(table);
        }

        public static object TimKiemCTPNK(string textSearch)
        {
            return QuanLyCTPNKDAO.TimKiemCTPNK(textSearch);
        }

        public static bool SuaCTPNK(string txtSuamanhapkho, string txtSuamasp, string txtSuadongia, string txtSuasoluong,string txtSuathanhtien, DateTime txtSuanghethan)
        {
            return QuanLyCTPNKDAO.SuaCTPNK(txtSuamanhapkho, txtSuamasp, txtSuadongia, txtSuasoluong, txtSuathanhtien,  txtSuanghethan);
        }
    }
}
