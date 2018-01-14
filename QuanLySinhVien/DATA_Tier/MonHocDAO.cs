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
    public class MonHocDAO : DBConnect
    {
        public DataTable GetAll()
        {
            string query = "SELECT * FROM MonHoc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(MonHoc monhoc)
        {
            string query = "INSERT INTO MonHoc (MaHP, TenHP, SoTinChi, LoaiHP, TrongSoDQT, TrongSoDThi) " +
                           "VALUES (@MaHP, @TenHP, @SoTinChi, @LoaiHP, @TrongSoDQT, @TrongSoDThi)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = monhoc.MaHP;
            sqlParameters[1] = new SqlParameter("@TenHP", SqlDbType.NVarChar);
            sqlParameters[1].Value = monhoc.TenHP;
            sqlParameters[2] = new SqlParameter("@SoTinChi", SqlDbType.Int);
            sqlParameters[2].Value = monhoc.SoTinChi;
            sqlParameters[3] = new SqlParameter("@LoaiHP", SqlDbType.NVarChar);
            sqlParameters[3].Value = monhoc.LoaiHP;
            sqlParameters[4] = new SqlParameter("@TrongSoDQT", SqlDbType.Decimal);
            sqlParameters[4].Value = monhoc.TrongSoDQT;
            sqlParameters[5] = new SqlParameter("@TrongSoDThi", SqlDbType.Decimal);
            sqlParameters[5].Value = monhoc.TrongSoDThi;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(MonHoc monhoc)
        {
            string query = "UPDATE MonHoc" +
                           " SET TenHP=@TenHP, SoTinChi=@SoTinChi, LoaiHP=@LoaiHP, TrongSoDQT=@TrongSoDQT, TrongSoDThi=@TrongSoDThi" +
                           " WHERE MaHP=@MaHP";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = monhoc.MaHP;
            sqlParameters[1] = new SqlParameter("@TenHP", SqlDbType.NVarChar);
            sqlParameters[1].Value = monhoc.TenHP;
            sqlParameters[2] = new SqlParameter("@SoTinChi", SqlDbType.Int);
            sqlParameters[2].Value = monhoc.SoTinChi;
            sqlParameters[3] = new SqlParameter("@LoaiHP", SqlDbType.NVarChar);
            sqlParameters[3].Value = monhoc.LoaiHP;
            sqlParameters[4] = new SqlParameter("@TrongSoDQT", SqlDbType.Decimal);
            sqlParameters[4].Value = monhoc.TrongSoDQT;
            sqlParameters[5] = new SqlParameter("@TrongSoDThi", SqlDbType.Decimal);
            sqlParameters[5].Value = monhoc.TrongSoDThi;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(MonHoc monhoc)
        {
            string query = "DELETE FROM MonHoc " +
                           "WHERE MaHP=@MaHP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = monhoc.MaHP;
            return executeDeleteQuery(query, sqlParameters);
        }
        public DataTable Search()
        {
            string query = "SELECT MonHoc.MaHP, TenHP, MaLopHP, SoTinChi, SoLuongSV FROM MonHoc, LopHocPhan WHERE MonHoc.MaHP = LopHocPhan.MaHP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
      
    }
}
