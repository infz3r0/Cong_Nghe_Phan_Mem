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
    public class LopHocPhanDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from LopHocPhan";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(LopHocPhan lophp)
        {
            string query = "Insert into LopHocPhan (MaLopHP, SoLuongSV, MaHP, LopTruong)" +
                           "Values (@MaLopHP, @SoLuongSV, @MaHP, @LopTruong)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            sqlParameters[1] = new SqlParameter("@SoLuongSV", SqlDbType.Int);
            sqlParameters[1].Value = lophp.SoLuongSV;
            sqlParameters[2] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[2].Value = lophp.MaHP;
            sqlParameters[3] = new SqlParameter("@LopTruong", SqlDbType.VarChar);
            sqlParameters[3].Value = lophp.LopTruong;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(LopHocPhan lophp)
        {
            string query = "Update LopHocPhan " +
                           "Set SoLuongSV=@SoLuongSV, MaHP=@MaHP, LopTruong=@LopTruong" +
                           "Where MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            sqlParameters[1] = new SqlParameter("@SoLuongSV", SqlDbType.Int);
            sqlParameters[1].Value = lophp.SoLuongSV;
            sqlParameters[2] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[2].Value = lophp.MaHP;
            sqlParameters[3] = new SqlParameter("@LopTruong", SqlDbType.VarChar);
            sqlParameters[3].Value = lophp.LopTruong;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool delete(LopHocPhan lophp)
        {
            string query = "Delete from LopHocPhan" +
                           "Where MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
