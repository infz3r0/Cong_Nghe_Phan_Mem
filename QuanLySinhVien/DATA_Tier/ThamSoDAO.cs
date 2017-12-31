using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL_Tier;
using System.Data;
using System.Data.SqlClient;

namespace DATA_Tier
{
    public class ThamSoDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from ThamSo";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(ThamSo thamso)
        {
            string query = "Insert into ThamSo (TenThamSo,Mota,GiaTri) " +
                           "Values (@TenThamSo,@MoTa,@GiaTri)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@TenThamSo", SqlDbType.VarChar);
            sqlParameters[0].Value = thamso.TenThamSo;
            sqlParameters[1] = new SqlParameter("@MoTa", SqlDbType.NVarChar);
            sqlParameters[1].Value = thamso.MoTa;
            sqlParameters[2] = new SqlParameter("@GiaTri", SqlDbType.VarChar);
            sqlParameters[2].Value = thamso.GiaTri;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(ThamSo thamso)
        {
            string query = "Update ThamSo " +
                           "Set MoTa=@MoTa,GiaTri=@GiaTri" +
                           "Where TenThamSo=@TenThamSo";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@TenThamSo", SqlDbType.VarChar);
            sqlParameters[0].Value = thamso.TenThamSo;
            sqlParameters[1] = new SqlParameter("@MoTa", SqlDbType.NVarChar);
            sqlParameters[1].Value = thamso.MoTa;
            sqlParameters[2] = new SqlParameter("@GiaTri", SqlDbType.VarChar);
            sqlParameters[2].Value = thamso.GiaTri;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(ThamSo thamso)
        {
            string query = "Delete from ThamSo" +
                           "Where TenThamSo=@TenThamSo";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TenThamSo", SqlDbType.VarChar);
            sqlParameters[0].Value = thamso.TenThamSo;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
