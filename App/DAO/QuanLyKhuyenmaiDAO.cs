using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyKhuyenmaiDAO
    {
        public static DataTable GetKM()
        {
            string query = "select * from khuyenmai";
            return DataProvider.getDataTable(query, null);
        }

        public static bool ThemKM(string txtThemmasp, string txtThemmakm, DateTime txtThemthoigianbatdau, DateTime txtThemthoigianketthuc, string txtThemchietkhau)
        {

            string query = String.Format("INSERT INTO  khuyenmai ( masp, makm, thoigianbatdau, thoigianketthuc, chietkhau) values (@masp, @makm, @thoigianbatdau, @thoigianketthuc,@chietkhau ); ");
            SqlParameter[] paras = new SqlParameter[5];
            paras[0] = new SqlParameter("@masp", txtThemmasp);
            paras[1] = new SqlParameter("@makm", txtThemmakm);
            paras[2] = new SqlParameter("@thoigianbatdau", txtThemthoigianbatdau);
            paras[3] = new SqlParameter("@thoigianketthuc", txtThemthoigianketthuc);
            paras[4] = new SqlParameter("@chietkhau", txtThemchietkhau);
         
            return DataProvider.executeNonQuery(query, paras);
        }

        public static DataSet GetListSanPham(string table)
        {
            string query = "select masp from sanpham where trangthai=1;";

            return DataProvider.getListCombobox(table, query, null);
        }
    }
}
