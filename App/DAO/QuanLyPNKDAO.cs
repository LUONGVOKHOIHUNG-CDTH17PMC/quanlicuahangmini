using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyPNKDAO
    {
        public static DataTable GetKH()
        {
            string query = "select * from phieunhapkho";
            return DataProvider.getDataTable(query, null);
        }

        public static bool ThemNV(string txtThemMaPNK, string txtThemmanvPNK, string txtThemmanccPNK, string txtThemghichuPNK, DateTime dtpNgayNhap)
        {
            string query = String.Format("INSERT INTO  phieunhapkho (manhapkho, manv, mancc, ngaynhap, ghichu) values (@manhapkho, @manv, @mancc, @ngaynhap, @ghichu);");

            SqlParameter[] paras = new SqlParameter[5];
            paras[0] = new SqlParameter("@manhapkho", txtThemMaPNK);
            paras[1] = new SqlParameter("@manv", txtThemmanvPNK);
            paras[2] = new SqlParameter("@mancc", txtThemmanccPNK);
            paras[3] = new SqlParameter("@ngaynhap", dtpNgayNhap);
            paras[4] = new SqlParameter("@ghichu", txtThemghichuPNK);
           

            return DataProvider.executeNonQuery(query, paras);

        }

        public static object TimKiemNhanVien(string textSearch)
        {
            string query = string.Format("select manhapkho,manv,mancc,ngaynhap,ghichu from phieunhapkho where manhapkho like '%{0}%';", textSearch);
            return DataProvider.getDataTable(query, null);
        }

        public static bool SuaPNK(string txtsuaMaPNK, string txtsuamanvPNK, string txtThemmanccPNK, string txtsuaGhichuPNK, DateTime dtpNgayNhap)
        {
          string query = String.Format(" UPDATE phieunhapkho SET manv =@manv , mancc =@mancc , ngaynhap =@ngaynhap , ghichu =@ghichu  where manhapkho = @manhapkho;");

            SqlParameter[] paras = new SqlParameter[5];
            paras[0] = new SqlParameter("@manv", txtsuamanvPNK);
            paras[1] = new SqlParameter("@mancc", txtThemmanccPNK);
            paras[2] = new SqlParameter("@ngaynhap", dtpNgayNhap);
            paras[3] = new SqlParameter("@ghichu", txtsuaGhichuPNK);

            paras[4] = new SqlParameter("@manhapkho", txtsuaMaPNK);
            

            return DataProvider.executeNonQuery(query, paras);
        }

        public static DataSet GetListNhanVien(string table)
        {
            string query = "select manv from nhanvien where trangthai=1;";

            return DataProvider.getListCombobox(table, query, null);
        }

        public static DataSet GetListNhaCungCap(string table)
        {
            string query = "select mancc from nhacungcap where trangthai=1;";

            return DataProvider.getListCombobox(table, query, null);
        }
    }
}
