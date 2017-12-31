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
    public class TaiKhoanDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from TaiKhoan";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(TaiKhoan taikhoan)
        {
            string query = "Insert into TaiKhoan (Usename,Password) " +
                           "Values (@Usename,@Password)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Usename", SqlDbType.VarChar);
            sqlParameters[0].Value = taikhoan.Username;
            sqlParameters[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            sqlParameters[1].Value = taikhoan.Password;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(TaiKhoan taikhoan)
        {
            string query = "Update TaiKhoan " +
                           "Set Password=@Password,GID=@GID" +
                           "Where Usename=@Usename";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Usename", SqlDbType.VarChar);
            sqlParameters[0].Value = taikhoan.Username;
            sqlParameters[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            sqlParameters[1].Value = taikhoan.Password;
            sqlParameters[2] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[2].Value = taikhoan.GID;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(TaiKhoan taikhoan)
        {
            string query = "Delete from TaiKhoan" +
                           "Where Usename=@Usename";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Usename", SqlDbType.VarChar);
            sqlParameters[0].Value = taikhoan.Username;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
