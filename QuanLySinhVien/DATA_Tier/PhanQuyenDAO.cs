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
    public class PhanQuyenDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from PhanQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(PhanQuyen phanquyen)
        {
            string query = "Insert into PhanQuyen (GID,MaQuyen) " +
                           "Values (@GID,@MaQuyen)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[1] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[1].Value = phanquyen.GID;
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = phanquyen.MaQuyen;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(PhanQuyen phanquyen)
        {
            string query = "Update PhanQuyen " +
                           "Set MaQuyen=@MaQuyen" +
                           "Where GID=@GID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[1] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[1].Value = phanquyen.GID;
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = phanquyen.MaQuyen;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(PhanQuyen phanquyen)
        {
            string query = "Delete from PhanQuyen" +
                           "Where GID=@GID or MaQuyen=@MaQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[0].Value = phanquyen.GID;
            sqlParameters[1] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[1].Value = phanquyen.MaQuyen;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
