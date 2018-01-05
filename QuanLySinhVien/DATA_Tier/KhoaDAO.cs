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
    public class KhoaDAO : DBConnect
    {
        public DataTable GetAll()
        {
            string query = "SELECT * FROM Khoa";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

        public bool Insert(Khoa khoa)
        {
            string query = "INSERT INTO Khoa (MaKhoa, TenKhoa, Sdt, Email) Values (@Makhoa, @TenKhoa, @Sdt, @Email)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@MaKhoa", SqlDbType.VarChar);
            sqlParameters[0].Value = khoa.MaKhoa;
            sqlParameters[1] = new SqlParameter("@TenKhoa", SqlDbType.NVarChar);
            sqlParameters[1].Value = khoa.TenKhoa;
            sqlParameters[2] = new SqlParameter("@Sdt", SqlDbType.VarChar);
            sqlParameters[2].Value = khoa.Sdt;
            sqlParameters[3] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[3].Value = khoa.Email;
            return executeInsertQuery(query, sqlParameters);
        }

        public bool Update(Khoa khoa)
        {
            string query = "UPDATE Khoa SET TenKhoa=@TenKhoa, Sdt=@Sdt, Email=@Email WHERE MaKhoa=@MaKhoa";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@MaKhoa", SqlDbType.VarChar);
            sqlParameters[0].Value = khoa.MaKhoa;
            sqlParameters[1] = new SqlParameter("@TenKhoa", SqlDbType.NVarChar);
            sqlParameters[1].Value = khoa.TenKhoa;
            sqlParameters[2] = new SqlParameter("@Sdt", SqlDbType.VarChar);
            sqlParameters[2].Value = khoa.Sdt;
            sqlParameters[3] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParameters[3].Value = khoa.Email;
            return executeUpdateQuery(query, sqlParameters);
        }

        public bool Delete(Khoa khoa)
        {
            string query = "DELETE FROM Khoa " +
                           "WHERE MaKhoa=@MaKhoa";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaKhoa", SqlDbType.VarChar);
            sqlParameters[0].Value = khoa.MaKhoa;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
