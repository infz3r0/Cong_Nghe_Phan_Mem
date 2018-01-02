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
    public class DanhSachLopHPDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from DanhSachLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(DanhSachLopHP dslophp)
        {
            string query = "Insert into DanhSachLopHP (MaLopHP, MaSV) " +
                           "Values (@MaLopHP,@MaSV)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaSV;
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaLopHP;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(DanhSachLopHP dslophp)
        {
            string query = "Update  DanhSachLopHP" +
                           "Set MaSV=@MaSV" +
                           "Where MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaSV;
            sqlParameters[1] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[1].Value = dslophp.MaLopHP;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(DanhSachLopHP dslophp)
        {
            string query = "Delete from DanhSachLopHP " +
                           "Where MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = dslophp.MaLopHP;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
