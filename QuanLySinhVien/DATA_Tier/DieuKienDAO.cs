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
        public DataTable getAll()
        {
            string query = "Select * from DieuKien";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(DieuKien dieukien)
        {
            string query = "Insert into DieuKien (MaHP,LoaiDK,MaHPDK) " +
                           "Values (@MaHP,@LoaiDK,@MaHPDK)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dieukien.MaHP;
            sqlParameters[1] = new SqlParameter("@LoaiDK", SqlDbType.NVarChar);
            sqlParameters[1].Value = dieukien.LoaiDK;
            sqlParameters[2] = new SqlParameter("@MaHPDK", SqlDbType.VarChar);
            sqlParameters[2].Value = dieukien.MaHPDK;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(DieuKien dieukien)
        {
            string query = "Update DieuKien " +
                           "Set LoaiDK=@LoaiDK" +
                           "Where MaHP=@MaHP and MaHPDK=@MaHPDK";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dieukien.MaHP;
            sqlParameters[1] = new SqlParameter("@LoaiDK", SqlDbType.NVarChar);
            sqlParameters[1].Value = dieukien.LoaiDK;
            sqlParameters[2] = new SqlParameter("@MaHPDK", SqlDbType.VarChar);
            sqlParameters[2].Value = dieukien.MaHPDK;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(DieuKien dieukien)
        {
            string query = "Delete from DieuKien" +
                           "Where MaHP=@MaHP or MaHPDK=@MaHPDK";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dieukien.MaHP;
            sqlParameters[1] = new SqlParameter("@MaHPDK", SqlDbType.VarChar);
            sqlParameters[1].Value = dieukien.MaHPDK;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
