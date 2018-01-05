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
    public class LopKhoaHocDAO : DBConnect
    {
        public DataTable GetAll()
        {
            string query = "SELECT LopKhoaHoc.MaLop, LopKhoaHoc.MaKhoa, Khoa.TenKhoa FROM Khoa INNER JOIN LopKhoaHoc ON Khoa.MaKhoa = LopKhoaHoc.MaKhoa";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

        public DataTable GetAll_TenKhoa()
        {
            string query = "SELECT LopKhoaHoc.MaLop, Khoa.MaKhoa, Khoa.TenKhoa FROM Khoa INNER JOIN LopKhoaHoc ON Khoa.MaKhoa = LopKhoaHoc.MaKhoa";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

        public bool Insert(LopKhoaHoc lopkh)
        {
            string query = "INSERT INTO LopKhoaHoc (MaLop, MaKhoa) VALUES (@MaLop, @MaKhoa)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[0].Value = lopkh.MaLop;
            sqlParameters[1] = new SqlParameter("@MaKhoa", SqlDbType.VarChar);
            sqlParameters[1].Value = lopkh.MaKhoa;
            return executeInsertQuery(query, sqlParameters);
        }

        public bool Update(LopKhoaHoc lopkh)
        {
            string query = "UPDATE LopKhoaHoc SET MaKhoa=@MaKhoa WHERE MaLop=@MaLop";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[0].Value = lopkh.MaLop;
            sqlParameters[1] = new SqlParameter("@MaKhoa", SqlDbType.VarChar);
            sqlParameters[1].Value = lopkh.MaKhoa;
            return executeUpdateQuery(query, sqlParameters);
        }

        public bool Delete(LopKhoaHoc lopkh)
        {
            string query = "DELETE FROM LopKhoaHoc WHERE MaLop=@MaLop";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[0].Value = lopkh.MaLop;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
