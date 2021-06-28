using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class QuanLyNhanVienDAO
    {
        public static DataTable GetNhanVien()
        {
            string query = "select manv, taikhoan, matkhau, honv, tenlot, tennv, gioitinh, ngaysinh, diachi, sdt, ngayvaolam,email, chucvu, case when trangthai = 0 then N'không sử dụng' else N'Sử dụng' end as trangthai from nhanvien where trangthai = 1 ;";
            return DataProvider.getDataTable(query, null);

        }

        public static bool ThemNV(string txtThemmaNV,string txtThemtkNV,string txtThemmatkhauNV,string txtThemhovatenNV,string txtThemdiachiNV,DateTime txtThemngsinhNV,string txtThemsdtNV,string txtThememailNV,string txtThemchucvuNV,DateTime txtThemngvaolamNV,string txtThemtrangthaiNV,string txtThemgioitinhNV)
        {
            string honv = "";
            string tenlotnv = "";
            string tennv = "";
            string[] arrName = txtThemhovatenNV.Split(' ');

            if (arrName.Length < 2)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên");
            }
            else
            {
                if (arrName.Length > 2)
                {
                    honv = arrName[0].ToString();
                    tenlotnv = arrName[1].ToString();
                    tennv = arrName[2].ToString();
                }

                if (arrName.Length == 2)
                {
                    honv = arrName[0].ToString();
                    tennv = arrName[1].ToString();
                }
            }


            string query = String.Format(" INSERT INTO nhanvien  (manv ,taikhoan ,matkhau ,honv,  tenlot, tennv, gioitinh, ngaysinh, diachi, sdt,email, ngayvaolam, chucvu, trangthai) values (@manv,  @taikhoan, @matkhau, @honv, @tenlot, @tennv, @gioitinh, @ngaysinh, @diachi, @sdt, @email, @ngayvaolam, @chucvu, @trangthai);");

                SqlParameter[] paras = new SqlParameter[14];
                paras[0] = new SqlParameter("@manv", txtThemmaNV);
                paras[1] = new SqlParameter("@taikhoan", txtThemtkNV);
                paras[2] = new SqlParameter("@matkhau", txtThemmatkhauNV);
                paras[3] = new SqlParameter("@honv", honv);
                paras[4] = new SqlParameter("@tenlot", tenlotnv);
                paras[5] = new SqlParameter("@tennv", tennv);
                paras[6] = new SqlParameter("@gioitinh", txtThemgioitinhNV);
                paras[7] = new SqlParameter("@ngaysinh", txtThemngsinhNV);
                paras[8] = new SqlParameter("@diachi", txtThemdiachiNV);
                paras[9] = new SqlParameter("@sdt", txtThemsdtNV);
                paras[10] = new SqlParameter("@email", txtThememailNV);
                paras[11] = new SqlParameter("@ngayvaolam", txtThemngvaolamNV);
                paras[12] = new SqlParameter("@chucvu", txtThemchucvuNV);
                paras[13] = new SqlParameter("@trangthai", txtThemtrangthaiNV);

                return DataProvider.executeNonQuery(query, paras);
                
        }

      

        public static object TimKiemNhanVien(string textSearch, bool sudung, bool khongSudung)
        {
            string query = string.Empty;

         

            if (sudung && khongSudung)
            {
                query = string.Format("select tennv,taikhoan,manv,matkhau, honv, tenlot, gioitinh,ngaysinh,diachi,sdt,ngayvaolam,chucvu,email, case when trangthai = 0 then N'Không Hoạt Động' else N'Đang Hoạt Động' end as trangthai from nhanvien where tennv like N'%{0}%' ;", textSearch);
            }
            else
            {
                if (sudung && khongSudung == false)
                {
                    query = string.Format("select tennv,taikhoan,manv,matkhau, honv, tenlot, gioitinh,ngaysinh,diachi,sdt,ngayvaolam,chucvu,email, case when trangthai = 0 then N'Không Hoạt Động' else N'Đang Hoạt Động' end as trangthai from nhanvien where tennv like N'%{0}%'  and trangthai = '1';", textSearch);
                }
                else
                {
                    query = string.Format("select tennv,taikhoan,manv,matkhau, honv, tenlot, gioitinh,ngaysinh,diachi,sdt,ngayvaolam,chucvu,email, case when trangthai = 0 then N'Không Hoạt Động' else N'Đang Hoạt Động' end as trangthai from nhanvien where tennv like N'%{0}%'  and trangthai = '0';", textSearch);
                }
            }

            if (sudung == false && khongSudung == false)
            {
                query = string.Format("select tennv,taikhoan,manv,matkhau, honv, tenlot, gioitinh,ngaysinh,diachi,sdt,ngayvaolam,chucvu,email, case when trangthai = 0 then N'Không Hoạt Động' else N'Đang Hoạt Động' end as trangthai from nhanvien where 1 = 2");
            }

            return DataProvider.getDataTable(query, null);
        }

        public static bool SuaNhanVien(string txtSuamaNV, string txtSuatkNV, string txtSuamatkhauNV, string txtSuahovatenNV, string txtSuagioitinhNV, DateTime txtSuangsinhNV, string txtSuadiachiNV, string txtSuasdtNV, string txtSuaemailNV, DateTime txtSuangvaolamNV, string txtSuachucvuNV, string txtSuatrangthaiNV)
        {
            string honv = "";
            string tenlotnv = "";
            string tennv = "";
            string[] arrName = txtSuahovatenNV.Split(' ');

            if (arrName.Length < 2)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên");
            }
            else
            {
                if (arrName.Length > 2)
                {
                    honv = arrName[0].ToString();
                    tenlotnv = arrName[1].ToString();
                    tennv = arrName[2].ToString();
                }

                if (arrName.Length == 2)
                {
                    honv = arrName[0].ToString();
                    tennv = arrName[1].ToString();
                }
            }
                string query = String.Format("UPDATE nhanvien SET   taikhoan=@taikhoan ,matkhau=@matkhau ,honv=@honv,  tenlot=@tenlot, tennv=@tennv, gioitinh=@gioitinh, ngaysinh=@ngaysinh, diachi=@diachi, sdt=@sdt,email=@email, ngayvaolam=@ngayvaolam, chucvu=@chucvu, trangthai=@trangthai where manv = @manv;");

                SqlParameter[] paras = new SqlParameter[14];
                paras[0] = new SqlParameter("@manv", txtSuamaNV);
                paras[1] = new SqlParameter("@taikhoan", txtSuatkNV);
                paras[2] = new SqlParameter("@matkhau", txtSuamatkhauNV);
                paras[3] = new SqlParameter("@honv", honv);
                paras[4] = new SqlParameter("@tenlot", tenlotnv);
                paras[5] = new SqlParameter("@tennv", tennv);
                paras[6] = new SqlParameter("@gioitinh", txtSuagioitinhNV);
                paras[7] = new SqlParameter("@ngaysinh", txtSuangsinhNV);
                paras[8] = new SqlParameter("@diachi", txtSuadiachiNV);
                paras[9] = new SqlParameter("@sdt", txtSuasdtNV);
                paras[10] = new SqlParameter("@email", txtSuaemailNV);
                paras[11] = new SqlParameter("@ngayvaolam", txtSuangvaolamNV);
                paras[12] = new SqlParameter("@chucvu", txtSuachucvuNV);
                paras[13] = new SqlParameter("@trangthai", txtSuatrangthaiNV);

                return DataProvider.executeNonQuery(query, paras);

            }
        }
}
