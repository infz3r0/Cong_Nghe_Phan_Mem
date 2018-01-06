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
        public DataTable GetAll()
        {
            string query = "SELECT * FROM Quyen";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(Quyen quyen)
        {
            string query = "INSERT INTO Quyen (MaQuyen, Mota) " +
                           "VALUES (@MaQuyen, @MoTa)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = quyen.MaQuyen;
            sqlParameters[1] = new SqlParameter("@MoTa", SqlDbType.NVarChar);
            sqlParameters[1].Value = quyen.MoTa;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(Quyen quyen)
        {
            string query = "UPDATE Quyen" +
                           " SET MoTa=@MoTa" +
                           " WHERE MaQuyen=@MaQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = quyen.MaQuyen;
            sqlParameters[1] = new SqlParameter("@MoTa", SqlDbType.NVarChar);
            sqlParameters[1].Value = quyen.MoTa;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(Quyen quyen)
        {
            string query = "DELETE FROM Quyen" +
                           "WHERE MaQuyen=@MaQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = quyen.MaQuyen;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
