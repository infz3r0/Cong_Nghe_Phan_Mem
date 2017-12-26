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
        public DataTable getAll()
        {
            string query = "Select * from LopKhoaHoc";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable getAll_TenKhoa()
        {
            string query = "SELECT LopKhoaHoc.MaLop, Khoa.MaKhoa, Khoa.TenKhoa" +
                            " FROM Khoa INNER JOIN"+
                            " LopKhoaHoc ON Khoa.MaKhoa = LopKhoaHoc.MaKhoa";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(LopKhoaHoc lopkh)
        {
            string query = "Insert into LopKhoaHoc (MaLop, MaKhoa)"+
                           " Values (@MaLop, @MaKhoa)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[0].Value = lopkh.MaLop;
            sqlParameters[1] = new SqlParameter("@MaKhoa", SqlDbType.VarChar);
            sqlParameters[1].Value = lopkh.MaKhoa;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(LopKhoaHoc lopkh)
        {
            string query = "Update LopKhoaHoc" +
                           " Set MaKhoa=@MaKhoa"+
                           " Where MaLop=@MaLop";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[0].Value = lopkh.MaLop;
            sqlParameters[1] = new SqlParameter("@MaKhoa", SqlDbType.VarChar);
            sqlParameters[1].Value = lopkh.MaKhoa;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool delete(LopKhoaHoc lopkh)
        {
            string query = "Delete from LopKhoaHoc" +
                           "Where MaLop=@MaLop";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
            sqlParameters[0].Value = lopkh.MaLop;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
