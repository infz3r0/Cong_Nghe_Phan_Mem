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
        public DataTable GetAll()
        {
            string query = "SELECT P.GID, TenNhom, P.MaQuyen, Mota FROM Nhom N, PhanQuyen P, Quyen Q WHERE N.GID = P.GID AND P.MaQuyen = Q.MaQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

        public DataTable SelectMaQuyenByGID(int gid)
        {
            string query = "SELECT MaQuyen FROM PhanQuyen WHERE GID = @gid";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[0].Value = gid;
            return executeSelectQuery(query, sqlParameters);
        }

        public bool Insert(PhanQuyen phanquyen)
        {
            string query = "INSERT INTO PhanQuyen (GID, MaQuyen) " +
                           "VALUES (@GID, @MaQuyen)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[1] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[1].Value = phanquyen.GID;
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = phanquyen.MaQuyen;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(PhanQuyen phanquyen)
        {
            string query = "UPDATE PhanQuyen" +
                           " SET MaQuyen=@MaQuyen" +
                           " WHERE GID=@GID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[1] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[1].Value = phanquyen.GID;
            sqlParameters[0] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[0].Value = phanquyen.MaQuyen;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(PhanQuyen phanquyen)
        {
            string query = "DELETE FROM PhanQuyen" +
                           " WHERE GID=@GID AND MaQuyen=@MaQuyen";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[0].Value = phanquyen.GID;
            sqlParameters[1] = new SqlParameter("@MaQuyen", SqlDbType.Int);
            sqlParameters[1].Value = phanquyen.MaQuyen;
            return executeDeleteQuery(query, sqlParameters);
        }
        public bool DeleteAll(PhanQuyen phanquyen)
        {
            string query = "DELETE FROM PhanQuyen WHERE GID = @GID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[0].Value = phanquyen.GID;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
