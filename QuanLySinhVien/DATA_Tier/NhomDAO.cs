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
    public class NhomDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from Nhom";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(Nhom nhom)
        {
            string query = "Insert into Nhom (GID,TenNhom) " +
                           "Values (@GID,@TenNhom)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[0].Value = nhom.GID;
            sqlParameters[1] = new SqlParameter("@TenNhom", SqlDbType.NVarChar);
            sqlParameters[1].Value = nhom.TenNhom;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(Nhom nhom)
        {
            string query = "Update Nhom " +
                           "Set TenNhom=@TenNhom" +
                           "Where GID=@GID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[0].Value = nhom.GID;
            sqlParameters[1] = new SqlParameter("@TenNhom", SqlDbType.NVarChar);
            sqlParameters[1].Value = nhom.TenNhom;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(Nhom nhom)
        {
            string query = "Delete from Nhom" +
                           "Where GID=@GID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[0].Value = nhom.GID;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
