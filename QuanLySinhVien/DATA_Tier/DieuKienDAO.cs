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
    public class DieuKienDAO : DBConnect
    {
        public DataTable GetAll()
        {
            string query = "SELECT * FROM DieuKien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(DieuKien dieukien)
        {
            string query = "INSERT INTO DieuKien (MaHP,LoaiDK,MaHPDK) " +
                           "VALUES (@MaHP,@LoaiDK,@MaHPDK)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dieukien.MaHP;
            sqlParameters[1] = new SqlParameter("@LoaiDK", SqlDbType.NVarChar);
            sqlParameters[1].Value = dieukien.LoaiDK;
            sqlParameters[2] = new SqlParameter("@MaHPDK", SqlDbType.VarChar);
            sqlParameters[2].Value = dieukien.MaHPDK;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(DieuKien dieukien)
        {
            string query = "UPDATE DieuKien" +
                           " SET LoaiDK=@LoaiDK" +
                           " WHERE MaHP=@MaHP AND MaHPDK=@MaHPDK";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dieukien.MaHP;
            sqlParameters[1] = new SqlParameter("@LoaiDK", SqlDbType.NVarChar);
            sqlParameters[1].Value = dieukien.LoaiDK;
            sqlParameters[2] = new SqlParameter("@MaHPDK", SqlDbType.VarChar);
            sqlParameters[2].Value = dieukien.MaHPDK;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(DieuKien dieukien)
        {
            string query = "DELETE FROM DieuKien" +
                           " WHERE MaHP=@MaHP or MaHPDK=@MaHPDK";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dieukien.MaHP;
            sqlParameters[1] = new SqlParameter("@MaHPDK", SqlDbType.VarChar);
            sqlParameters[1].Value = dieukien.MaHPDK;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
