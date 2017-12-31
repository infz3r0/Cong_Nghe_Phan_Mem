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
    public class QuyenDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from Quyen";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(Quyen quyen)
        {
            string query = "Insert into Quyen (MaQuyen,Mota) " +
                           "Values (@MaQuyen,@MoTa)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = quyen.MaQuyen;
            sqlParameters[1] = new SqlParameter("@MoTa", SqlDbType.NVarChar);
            sqlParameters[1].Value = quyen.MoTa;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(Quyen quyen)
        {
            string query = "Update Quyen " +
                           "Set MoTa=@MoTa" +
                           "Where MaQuyen=@MaQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = quyen.MaQuyen;
            sqlParameters[1] = new SqlParameter("@MoTa", SqlDbType.NVarChar);
            sqlParameters[1].Value = quyen.MoTa;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(Quyen quyen)
        {
            string query = "Delete from Quyen" +
                           "Where MaQuyen=@MaQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = quyen.MaQuyen;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
