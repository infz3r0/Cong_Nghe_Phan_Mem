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
    public class BanCanSuDAO : DBConnect
    {
        public DataTable GetAll()
        {
            string query = "SELECT * FROM BanCanSu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(BanCanSu bancansu)
        {
            string query = "INSERT INTO BanCanSu (MaSV,ChucVu) " +
                           "VALUES (@MaSV,@ChucVu)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = bancansu.MaSV;
            sqlParameters[1] = new SqlParameter("@ChucVu", SqlDbType.NVarChar);
            sqlParameters[1].Value = bancansu.ChucVu;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(BanCanSu bancansu)
        {
            string query = "UPDATE BanCanSu " +
                           "SET ChucVu=@ChucVu " +
                           "WHERE MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = bancansu.MaSV;
            sqlParameters[1] = new SqlParameter("@ChuVu", SqlDbType.NVarChar);
            sqlParameters[1].Value = bancansu.ChucVu;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(BanCanSu bancansu)
        {
            string query = "DELETE FROM BanCanSu " +
                           "WHERE MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = bancansu.MaSV;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
