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
            string query = "Select * from SinhVien";
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
            string query = "exec sp_insertSinhVien @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoCMND, @Sdt, @Email, @MaLop";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@HoTen", SqlDbType.BigInt);
            sqlParameters[0].Value = sv.HoTen;
            sqlParameters[1] = new SqlParameter("@NgaySinh", SqlDbType.NVarChar);
            sqlParameters[1].Value = sv.NgaySinh;
            sqlParameters[2] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[2].Value = sv.GioiTinh;
            sqlParameters[3] = new SqlParameter("@DiaChi", SqlDbType.DateTime);
            sqlParameters[3].Value = sv.DiaChi;
            sqlParameters[4] = new SqlParameter("@SoCMND", SqlDbType.NVarChar);
            sqlParameters[4].Value = sv.SoCMND;
            sqlParameters[5] = new SqlParameter("@Sdt", SqlDbType.Char);
            sqlParameters[5].Value = sv.Sdt;
            sqlParameters[6] = new SqlParameter("@Email", SqlDbType.NVarChar);
            sqlParameters[6].Value = sv.Email;
            sqlParameters[7] = new SqlParameter("@MaLop", SqlDbType.NVarChar);
            sqlParameters[7].Value = sv.MaLop;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(SinhVien sv)
        {
            string query = "exec sp_updateSinhVien @MaSV, @new_HoTen, @new_NgaySinh, @new_GioiTinh, @new_DiaChi, @new_SoCMND, @new_Sdt, @new_Email, @new_MaLop";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.BigInt);
            sqlParameters[0].Value = sv.MaSV;
            sqlParameters[1] = new SqlParameter("@HoTen", SqlDbType.BigInt);
            sqlParameters[1].Value = sv.HoTen;
            sqlParameters[2] = new SqlParameter("@NgaySinh", SqlDbType.NVarChar);
            sqlParameters[2].Value = sv.NgaySinh;
            sqlParameters[3] = new SqlParameter("@GioiTinh", SqlDbType.NVarChar);
            sqlParameters[3].Value = sv.GioiTinh;
            sqlParameters[4] = new SqlParameter("@DiaChi", SqlDbType.DateTime);
            sqlParameters[4].Value = sv.DiaChi;
            sqlParameters[5] = new SqlParameter("@SoCMND", SqlDbType.NVarChar);
            sqlParameters[5].Value = sv.SoCMND;
            sqlParameters[6] = new SqlParameter("@Sdt", SqlDbType.Char);
            sqlParameters[6].Value = sv.Sdt;
            sqlParameters[7] = new SqlParameter("@Email", SqlDbType.NVarChar);
            sqlParameters[7].Value = sv.Email;
            sqlParameters[8] = new SqlParameter("@MaLop", SqlDbType.NVarChar);
            sqlParameters[8].Value = sv.MaLop;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool delete(SinhVien sv)
        {
            string query = "exec sp_deleteSinhVien @MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.BigInt);
            sqlParameters[0].Value = sv.MaSV;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
