using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuanLyKhachHangDAO
    {

        public static DataTable GetKH()
        {
            string query = string.Format("select * from khachhang");

            return DataProvider.getDataTable(query, null);
        }



        public static bool ThemKhachHang(string txtThemmaKH, string txtThemhovatenKH, string txtThemgioitinhKH, string txtThemghichuKH)
        {

            string ho = "";
            string tenlot = "";
            string ten = "";
            string[] arrName = txtThemhovatenKH.Split(' ');

            if (arrName.Length > 2)
            {
                ho = arrName[0].ToString();
                tenlot = arrName[1].ToString();
                ten = arrName[2].ToString();
            }

            if (arrName.Length == 2)
            {
                ho = arrName[0].ToString();
                ten = arrName[1].ToString();
            }

            string query = String.Format("INSERT INTO  khachhang ( makh, hokh, tenlotkh, tenkh , gioitinhkh, ghichu) values (@makh, @hokh, @tenlotkh, @tenkh, @gioitinhkh, @ghichu);");
            SqlParameter[] paras = new SqlParameter[6];
            paras[0] = new SqlParameter("@makh", txtThemmaKH);
            paras[1] = new SqlParameter("@hokh", ho);
            paras[2] = new SqlParameter("@tenlotkh", tenlot);
            paras[3] = new SqlParameter("@tenkh", ten);
            paras[4] = new SqlParameter("@gioitinhkh", txtThemgioitinhKH);
            paras[5] = new SqlParameter("@ghichu", txtThemghichuKH);


            return DataProvider.executeNonQuery(query, paras);

        }

        public static DataTable TimKiemKhachHang(string textSearch)
        {
            string query = string.Empty;

            query = string.Format("select makh,hokh,tenlotkh,tenkh,gioitinhkh,ghichu from khachhang where tenkh like N'%{0}%' or makh like '%{0}%';", textSearch);

            return DataProvider.getDataTable(query, null);
        }


           
        }

     
    }

