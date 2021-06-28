using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class QuanLyNCCDAO
    {
        public static DataTable GetNhaCungCap()
        {
            string query = string.Format("select mancc, tenncc, diachi, email, sdt, case when trangthai = 0 then N'không sử dụng' else N'Sử dụng' end as trangthai from nhacungcap where trangthai = 1");
            return DataProvider.getDataTable(query, null);
        }

        
        public static bool ThemNhaCungCap(string txtThemtenNCC, string txtThemmaNCC, string txtThemtrangthaiNCC, string txtThemdiachiNCC, string txtThememailNCC, string txtThemsdtNCC)
        {
            string query = String.Format("INSERT INTO  nhacungcap ( mancc,tenncc ,diachi, email, sdt,trangthai) values (@mancc, @tenncc, @diachi, @email, @sdt, @trangthai);");
            SqlParameter[] paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@mancc", txtThemmaNCC);
            paras[1] = new SqlParameter("@tenncc", txtThemtenNCC);
            paras[2] = new SqlParameter("@diachi", txtThemdiachiNCC);
            paras[3] = new SqlParameter("@email", txtThememailNCC);
            paras[4] = new SqlParameter("@sdt", txtThemsdtNCC);
            paras[5] = new SqlParameter("@trangthai", txtThemtrangthaiNCC);

            return DataProvider.executeNonQuery(query, paras);
        }

        public static bool SuaNhaCungCap(string txtSuatenNCC, string txtSuamaNCC, string txtSuadiachiNCC, string txtSuaemailNCC, string txtSuasdtNCC, string trangthai)
        {
            string query = String.Format("UPDATE nhacungcap SET  tenncc= @tenncc, diachi = @diachi, email = @email, sdt = @sdt, trangthai = @trangthai where mancc = @mancc;");

            SqlParameter[] paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@mancc", txtSuamaNCC);
            paras[1] = new SqlParameter("@tenncc", txtSuamaNCC);
            paras[2] = new SqlParameter("@diachi", txtSuadiachiNCC);
            paras[3] = new SqlParameter("@email", txtSuaemailNCC);
            
            paras[4] = new SqlParameter("@trangthai", trangthai);
            paras[5] = new SqlParameter("@sdt", txtSuasdtNCC);

            return DataProvider.executeNonQuery(query, paras);
        }

        public static DataTable TimKiemNhaCungCap(string textSearch, bool sudung, bool khongSudung)
        {
            string query = string.Empty;

            if (sudung && khongSudung)
            {
                query = string.Format("select tenncc,mancc, diachi, sdt, email, case when trangthai = N'{0}' then N'không sử dụng' else N'sử dụng' end as trangthai from nhacungcap where tenncc like N'%{0}%' ;", textSearch);
            }
            else
            {
                if (sudung && khongSudung == false)
                {
                    query = string.Format("select tenncc,mancc, diachi, sdt, email, case when trangthai = 0 then N'không sử dụng' else N'sử dụng' end as trangthai from nhacungcap where tenncc like N'%{0}%' and trangthai = N'1';", textSearch);
                }
                else
                {
                    query = string.Format("select tenncc,mancc, diachi, sdt, email, case when trangthai = 0 then N'không sử dụng' else N'sử dụng' end as trangthai from nhacungcap where tenncc like N'%{0}%' and trangthai = N'0';", textSearch);
                }
            }

            if (sudung == false && khongSudung == false)
            {
                query = string.Format("select tenncc,mancc, diachi, sdt, email, case when trangthai = 0 then N'không sử dụng' else N'sử dụng' end as trangthai from nhacungcap where 1 = 2");
            }

            return DataProvider.getDataTable(query, null);
        }
    }
}
