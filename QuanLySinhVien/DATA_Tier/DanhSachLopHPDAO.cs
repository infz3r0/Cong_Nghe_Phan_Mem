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
    public class DanhSachLopHPDAO : DBConnect
    {
        public bool DangKi(string MaSV, string MaLopHP)
        {
            string query = "INSERT DanhSachLopHP (MaSV, MaLopHP)" +
                           " VALUES (@MaSV, @MaLopHP)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            sqlParameters[1] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[1].Value = MaLopHP;
            return executeInsertQuery(query, sqlParameters);
        }

        public bool HuyDangKi(string MaSV, string MaLopHP)
        {
            string query = "INSERT DanhSachLopHP (MaSV, MaLopHP)" +
                           " VALUES (@MaSV, @MaLopHP)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            sqlParameters[1] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[1].Value = MaLopHP;
            return executeInsertQuery(query, sqlParameters);
        }

        public DataTable DSHPChuaDangKi(string MaSV)
        {
            string query = "SELECT MaLopHP, LopHocPhan.SoLuongSV, LopHocPhan.MaHP, MonHoc.TenHP, MonHoc.SoTinChi" +
                             " FROM LopHocPhan INNER JOIN"+
                             " MonHoc ON LopHocPhan.MaHP = MonHoc.MaHP"+
                           " where MaLopHP not in " +
                           " (select MaLopHP from DanhSachLopHP where MaSV = @MaSV)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            return executeSelectQuery(query, sqlParameters);
        }

        public DataTable DSHPDaDangKi(string MaSV)
        {
            string query = "SELECT DanhSachLopHP.MaLopHP, LopHocPhan.SoLuongSV, LopHocPhan.MaHP, MonHoc.TenHP, MonHoc.SoTinChi" +
                             " FROM DanhSachLopHP INNER JOIN" +
                             " LopHocPhan ON DanhSachLopHP.MaLopHP = LopHocPhan.MaLopHP INNER JOIN" +
                             " MonHoc ON LopHocPhan.MaHP = MonHoc.MaHP" +
                             " WHERE MaSV = @MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            return executeSelectQuery(query, sqlParameters);
        }
    }
}
