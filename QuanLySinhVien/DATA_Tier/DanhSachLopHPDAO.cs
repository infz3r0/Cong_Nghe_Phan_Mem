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
        public DataTable GetAll()
        {
            string query = "SELECT * FROM DanhSachLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(DanhSachLopHP dslophp)
        {
            string query = "INSERT INTO DanhSachLopHP (MaLopHP, MaSV) " +
                           "VALUES (@MaLopHP,@MaSV)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaSV;
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaLopHP;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(DanhSachLopHP dslophp)
        {
            string query = "UPDATE  DanhSachLopHP" +
                           " SET MaSV=@MaSV" +
                           " WHERE MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaSV;
            sqlParameters[1] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[1].Value = dslophp.MaLopHP;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(DanhSachLopHP dslophp)
        {
            string query = "DELETE FROM DanhSachLopHP " +
                           "WHERE MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaLopHP;
            return executeDeleteQuery(query, sqlParameters);
        }
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
            string query = "SELECT  DanhSachLopHP.MaLopHP, LopHocPhan.SoLuongSV, LopHocPhan.MaHP, MonHoc.TenHP, MonHoc.SoTinChi" +
                             "FROM DanhSachLopHP INNER JOIN"+
                             "LopHocPhan ON DanhSachLopHP.MaLopHP = LopHocPhan.MaLopHP INNER JOIN"+
                             " MonHoc ON LopHocPhan.MaHP = MonHoc.MaHP "+
                           "where MaLopHP not in " +
                           "(select MaLopHP from DanhSachLopHP where MaSV = @MaSV)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable DSHPDaDangKi()
        {
            string query = "SELECT  DanhSachLopHP.MaLopHP, LopHocPhan.SoLuongSV, LopHocPhan.MaHP, MonHoc.TenHP, MonHoc.SoTinChi" +
                             "FROM DanhSachLopHP INNER JOIN" +
                             "LopHocPhan ON DanhSachLopHP.MaLopHP = LopHocPhan.MaLopHP INNER JOIN" +
                             " MonHoc ON LopHocPhan.MaHP = MonHoc.MaHP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
    }
}
