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
    class DiemHe4DAO : DBConnect
    {
        public DataTable GetAll()
        {
            string query = "SELECT * FROM DiemHe4";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(DiemHe4 diemhe4)
        {
            string query = "INSERT INTO DiemHe4 (DiemHe4Chu, DiemHe4So, DiemHe10Min, DiemHe10Max, XepLoai, DanhGia) " +
                           "VALUES (@DiemHe4Chu, @DiemHe4So, @DiemHe10Min, @DiemHe10Max, @XepLoai, @DanhGia)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@DiemHe4Chu", SqlDbType.VarChar);
            sqlParameters[0].Value = diemhe4.DiemHe4So;
            sqlParameters[1] = new SqlParameter("@DiemHe4So", SqlDbType.Float);
            sqlParameters[1].Value = diemhe4.DiemHe4So;
            sqlParameters[2] = new SqlParameter("@DiemHe10Min", SqlDbType.Float);
            sqlParameters[2].Value = diemhe4.DiemHe10Min;
            sqlParameters[3] = new SqlParameter("@DiemHe10Max", SqlDbType.Float);
            sqlParameters[3].Value = diemhe4.DiemHe10Max;
            sqlParameters[4] = new SqlParameter("@XepLoai", SqlDbType.VarChar);
            sqlParameters[4].Value = diemhe4.XepLoai;
            sqlParameters[5] = new SqlParameter("@DanhGia", SqlDbType.VarChar);
            sqlParameters[5].Value = diemhe4.DanhGia;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(DiemHe4 diemhe4)
        {
            string query = "UPDATE DiemHe4" +
                           " SET DiemHe4So=@DiemHe4So, DiemHe10Min=@DiemHe10Min, DiemHe10Max=DiemHe10Max, XepLoai=@XepLoai, DanhGia=@DanhGia" +
                           " WHERE DiemHe4Chu=@DiemHe4Chu";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@DiemHe4Chu", SqlDbType.VarChar);
            sqlParameters[0].Value = diemhe4.DiemHe4So;
            sqlParameters[1] = new SqlParameter("@DiemHe4So", SqlDbType.Float);
            sqlParameters[1].Value = diemhe4.DiemHe4So;
            sqlParameters[2] = new SqlParameter("@DiemHe10Min", SqlDbType.Float);
            sqlParameters[2].Value = diemhe4.DiemHe10Min;
            sqlParameters[3] = new SqlParameter("@DiemHe10Max", SqlDbType.Float);
            sqlParameters[3].Value = diemhe4.DiemHe10Max;
            sqlParameters[4] = new SqlParameter("@XepLoai", SqlDbType.VarChar);
            sqlParameters[4].Value = diemhe4.XepLoai;
            sqlParameters[5] = new SqlParameter("@DanhGia", SqlDbType.VarChar);
            sqlParameters[5].Value = diemhe4.DanhGia;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(DiemHe4 diemhe4)
        {
            string query = "DELETE FROM DiemHe4" +
                           " WHERE DiemHe4Chu=@DiemHe4Chu";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@DiemHe4Chu", SqlDbType.VarChar);
            sqlParameters[0].Value = diemhe4.DiemHe4So;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
