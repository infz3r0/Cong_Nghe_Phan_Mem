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
        public DataTable getAll()
        {
            string query = "Select * from BanCanSu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(BanCanSu bancansu)
        {
            string query = "Insert into BanCanSu (ChucVu) " +
                           "Values (@ChucVu)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ChucVu", SqlDbType.NVarChar);
            sqlParameters[0].Value = bancansu.ChucVu;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(BanCanSu bancansu)
        {
            string query = "Update BanCanSu " +
                           "Set ChucVu=@ChucVu" +
                           "Where MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = bancansu.MaSV;
            sqlParameters[1] = new SqlParameter("@ChuVu", SqlDbType.NVarChar);
            sqlParameters[1].Value = bancansu.ChucVu;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(BanCanSu bancansu)
        {
            string query = "Delete from BanCanSu " +
                           "Where MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = bancansu.MaSV;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
