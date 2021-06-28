using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyCTPNKDAO
    {
        public static DataTable GetCTPNK()
        {
            string query = "select * from ct_phieunhapkho";
            return DataProvider.getDataTable(query, null);

        }

        public static bool ThemCTPNK(string txtThemmanhapkho, string txtThemmasp, string txtThemsoluong, string txtThemdongia, string txtThemthanhtien, DateTime txtThemnghethan)
        {
            string query = String.Format("INSERT INTO  ct_phieunhapkho ( masp,manhapkho ,soluong, dongia, ngayhethan,thanhtien ) values (@masp,@manhapkho, @soluong, @dongia, @ngayhethan, @thanhtien);");

            SqlParameter[] paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@masp", txtThemmasp);
            paras[1] = new SqlParameter("@manhapkho", txtThemmanhapkho);
            paras[2] = new SqlParameter("@soluong", txtThemsoluong);
            paras[3] = new SqlParameter("@dongia", txtThemdongia);
            paras[4] = new SqlParameter("@ngayhethan", txtThemnghethan);
            paras[5] = new SqlParameter("@thanhtien", txtThemthanhtien);
          
            return DataProvider.executeNonQuery(query, paras);

        }

        public static object TimKiemCTPNK(string textSearch)
        {
            string query = string.Format("select manhapkho,masp,soluong,dongia,thanhtien,ngayhethan from ct_phieunhapkho where manhapkho like N'%{0}%' ;", textSearch);

            return DataProvider.getDataTable(query, null);
        }

            public static bool SuaCTPNK(string txtSuamanhapkho, string txtSuamasp, string txtSuadongia, string txtSuasoluong,string txtSuathanhtien, DateTime txtSuanghethan)
        {

            string query = String.Format(" UPDATE ct_phieunhapkho SET thanhtien = @thanhtien, dongia = @dongia ,soluong = @soluong, ngayhethan = @ngayhethan where manhapkho = @manhapkho and masp = @masp ;");

            SqlParameter[] paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@masp", txtSuamasp);
            paras[1] = new SqlParameter("@manhapkho", txtSuamanhapkho);
            paras[2] = new SqlParameter("@soluong", txtSuasoluong);
            paras[3] = new SqlParameter("@dongia", txtSuadongia);
            paras[4] = new SqlParameter("@ngayhethan", txtSuanghethan);
            paras[5] = new SqlParameter("@thanhtien", txtSuathanhtien);

            return DataProvider.executeNonQuery(query, paras);

        }

        public static DataSet GetListSanPham(string table)
        {
            string query ="select masp from sanpham where trangthai = 1;";
            return DataProvider.getListCombobox(table, query, null);
        }

        public static DataSet GetListPhieuNhapKho(string table)
        {
            string query = "select manhapkho from phieunhapkho  ;";
            return DataProvider.getListCombobox(table, query, null);

        } 
    }
}
