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
        public DataTable getAll()
        {
            string query = "Select MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoCMND, Sdt, Email, MaLop from SinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable getAll_TenLopHP()
        {
            string query = "SELECT SinhVien.MaSV, LopHocPhan.MaLopHP, SinhVien.HoTen, SinhVien.NgaySinh, SinhVien.GioiTinh, SinhVien.DiaChi, SinhVien.SoCMND, SinhVien.Sdt, SinhVien.Email, LopHocPhan.LopTruong"+
                            "FROM SinhVien INNER JOIN"+
                            "LopHocPhan ON SinhVien.MaSV = LopHocPhan.LopTruong";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable getAll_TenLopKH()
        {
            string query = "SELECT LopKhoaHoc.MaLop, SinhVien.MaSV, SinhVien.HoTen, SinhVien.NgaySinh, SinhVien.GioiTinh, SinhVien.DiaChi, SinhVien.SoCMND, SinhVien.Sdt, SinhVien.Email"+
                            "FROM SinhVien INNER JOIN"+
                            "LopKhoaHoc ON SinhVien.MaLop = LopKhoaHoc.MaLop";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable selectThongKe()
        {
            string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoCMND, Sdt, Email, DiemTB, MaLop, XepLoai"+
                            "FROM SinhVien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(SinhVien sv)
        {
            string query = "Insert into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoCMND, Sdt, Email, MaLop)"+
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
        public bool update(SinhVien sv)
        {
            string query = "Update SinhVien"+ 
                            " Set HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoCMND=@SoCMND, Sdt=@Sdt, Email=@Email, MaLop=@MaLop"+
                            " Where MaSV=@MaSV";
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
        public bool delete(SinhVien sv)
        {
            string query = "Delete From SinhVien"+ 
                           " Where MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.BigInt);
            sqlParameters[0].Value = sv.MaSV;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
