using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuaLySanPhamDAO
    {
        public static DataTable GetSanPham()
        {
            string query = string.Format("select masp, tensp, mota, donvitinh, soluong, dongia, mancc, ghichu, case when trangthai = 0 then N'không sử dụng' else N'Sử dụng' end as trangthai from sanpham where trangthai = 1");
            return DataProvider.getDataTable(query, null);
        }

        public static bool ThemSanTham(string txtTenSP, string txtmaSP, string txtmotaSP, string txtdonvitinhSP, string txtsonluongSP, int txtdongiasp, string txtmanccSP, string txtghichu, bool txttrangthai)
        {
            string query = String.Format("INSERT INTO  sanpham ( masp, mancc, tensp, mota, donvitinh, soluong , dongia, ghichu, trangthai) values (@masp, @mancc, @tensp, @mota,@donvitinh, @soluong, @dongia, @ghichu, @trangthai); ");
            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@masp", txtmaSP);
            paras[1] = new SqlParameter("@tensp", txtTenSP);
            paras[2] = new SqlParameter("@mota", txtmotaSP);
            paras[3] = new SqlParameter("@soluong", txtsonluongSP);
            paras[4] = new SqlParameter("@dongia", txtdongiasp);
            paras[5] = new SqlParameter("@mancc", txtmanccSP);
            paras[6] = new SqlParameter("@ghichu", txtghichu);
            paras[7] = new SqlParameter("@trangthai", txttrangthai);
            paras[8] = new SqlParameter("@donvitinh", txtdonvitinhSP);

            return DataProvider.executeNonQuery(query, paras);
        }

        public static DataSet GetListNhaCungCap(string table)
        {
            string query = "select mancc from nhacungcap where trangthai=1;";

            return DataProvider.getListCombobox(table, query, null);
        }


        public static bool SuaSanPham(string txtSuamaSP, string txtSuamanccSP, string txtSuatenSP, string txtSuadonvitinhSP, string txtSuasoluongSP, string txtSuadongiaSP, string txtSuamotaSP, string txtSuaghichuSP, string txttrangthai)
        {
            string query = String.Format("UPDATE sanpham SET tensp =@tensp, mancc = @mancc, mota =@mota, donvitinh =@donvitinh, soluong = @soluong, dongia = @dongia, ghichu = @ghichu, trangthai = @trangthai where masp = @masp ;");

            SqlParameter[] paras = new SqlParameter[9];
            paras[0] = new SqlParameter("@masp", txtSuamaSP);
            paras[1] = new SqlParameter("@tensp", txtSuatenSP);
            paras[2] = new SqlParameter("@mota", txtSuamotaSP);
            paras[3] = new SqlParameter("@soluong", txtSuasoluongSP);
            paras[4] = new SqlParameter("@dongia", txtSuadongiaSP);
            paras[5] = new SqlParameter("@mancc", txtSuamanccSP);
            paras[6] = new SqlParameter("@ghichu", txtSuaghichuSP);
            paras[7] = new SqlParameter("@trangthai", txttrangthai);
            paras[8] = new SqlParameter("@donvitinh", txtSuadonvitinhSP);

            return DataProvider.executeNonQuery(query, paras);
        }

        public static DataTable TimSanPham(string textSearch, bool sudung, bool khongSudung)
        {
            string query = string.Empty;

            if (sudung && khongSudung)
            {
                query = string.Format("select masp, tensp, mota, donvitinh, soluong, dongia, mancc, ghichu, case when trangthai = 0 then N'Không Sử Dụng' else N'Sử Dụng' end as trangthai from sanpham where tensp like N'%{0}%';", textSearch);
            }
            else
            {
                if (sudung && khongSudung == false)
                {
                    query = string.Format("select masp, tensp, mota, donvitinh, soluong, dongia, mancc, ghichu, case when trangthai = 0 then N'Không Sử Dụng' else N'Sử Dụng' end as trangthai from sanpham where tensp like N'%{0}%' and trangthai = '1';", textSearch);
                }
                else
                {
                    query = string.Format("select masp, tensp, mota, donvitinh, soluong, dongia, mancc, ghichu, case when trangthai = 0 then N'Không Sử Dụng' else N'Sử Dụng' end as trangthai from sanpham where tensp like N'%{0}%' and trangthai = '0';", textSearch);
                }
            }

            if (sudung == false && khongSudung == false)
            {
                query = string.Format("select masp, tensp, mota, donvitinh, soluong, dongia, mancc, ghichu, case when trangthai = 0 then N'Không Sử Dụng' else N'Sử Dụng' end as trangthai from sanpham  where 1 = 2");
            }

            return DataProvider.getDataTable(query, null);
        }
    }
}
