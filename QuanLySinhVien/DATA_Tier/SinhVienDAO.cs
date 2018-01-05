using MODEL_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DATA_Tier
{
    public class SinhVienDAO : DBConnect
    {
        public DataTable GetAll()
        {
            string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoCMND, Sdt, Email, MaLop FROM SinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable GetAll_TenLopHP()
        {
            string query = "SELECT SinhVien.MaSV, LopHocPhan.MaLopHP, SinhVien.HoTen, SinhVien.NgaySinh, SinhVien.GioiTinh, SinhVien.DiaChi, SinhVien.SoCMND, SinhVien.Sdt, SinhVien.Email, LopHocPhan.LopTruong"+
                            " FROM SinhVien INNER JOIN"+
                            " LopHocPhan ON SinhVien.MaSV = LopHocPhan.LopTruong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable GetAll_TenLopKH()
        {
            string query = "SELECT * FROM SinhVien ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable SelectThongKe()
        {
            string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoCMND, Sdt, Email, DiemTB, MaLop, XepLoai"+
                            " FROM SinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(SinhVien sv)
        {
            string query = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoCMND, Sdt, Email, MaLop)"+
                            " VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoCMND, @Sdt, @Email, @MaLop)";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = sv.MaSV;
            sqlParameters[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar);
            sqlParameters[1].Value = sv.HoTen;
            sqlParameters[2] = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
            sqlParameters[2].Value = sv.NgaySinh;
            sqlParameters[3] = new SqlParameter("@GioiTinh", SqlDbType.Char);
            sqlParameters[3].Value = sv.GioiTinh;
            sqlParameters[4] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[4].Value = sv.DiaChi;
            sqlParameters[5] = new SqlParameter("@SoCMND", SqlDbType.VarChar);
            sqlParameters[5].Value = sv.SoCMND;
            sqlParameters[6] = new SqlParameter("@Sdt", SqlDbType.VarChar);
            sqlParameters[6].Value = sv.Sdt;
            sqlParameters[7] = new SqlParameter("@Email", SqlDbType.NVarChar);
            sqlParameters[7].Value = sv.Email;
            sqlParameters[8] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[8].Value = sv.MaLop;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(SinhVien sv)
        {
            string query = "UPDATE SinhVien"+ 
                            " SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoCMND=@SoCMND, Sdt=@Sdt, Email=@Email, MaLop=@MaLop"+
                            " WHERE MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = sv.MaSV;
            sqlParameters[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar);
            sqlParameters[1].Value = sv.HoTen;
            sqlParameters[2] = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
            sqlParameters[2].Value = sv.NgaySinh;
            sqlParameters[3] = new SqlParameter("@GioiTinh", SqlDbType.Char);
            sqlParameters[3].Value = sv.GioiTinh;
            sqlParameters[4] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            sqlParameters[4].Value = sv.DiaChi;
            sqlParameters[5] = new SqlParameter("@SoCMND", SqlDbType.VarChar);
            sqlParameters[5].Value = sv.SoCMND;
            sqlParameters[6] = new SqlParameter("@Sdt", SqlDbType.VarChar);
            sqlParameters[6].Value = sv.Sdt;
            sqlParameters[7] = new SqlParameter("@Email", SqlDbType.NVarChar);
            sqlParameters[7].Value = sv.Email;
            sqlParameters[8] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[8].Value = sv.MaLop;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Delete(SinhVien sv)
        {
            string query = "DELETE From SinhVien"+ 
                           " WHERE MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = sv.MaSV;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
