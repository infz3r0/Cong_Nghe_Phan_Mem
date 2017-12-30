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
            string query = "Select MaLopHP, SoLuongSV, HP.MaHP, LopTruong, TenHP From LopHocPhan HP, MonHoc M Where HP.MaHP = M.MaHP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(LopHocPhan lophp)
        {
            string query = "Insert into LopHocPhan (MaLopHP, MaHP, SoluongSV)" +
                           "Values (@MaLopHP, @MaHP, @SoLuongSV)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            sqlParameters[1] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[1].Value = lophp.MaHP;
            sqlParameters[2] = new SqlParameter("@SoLuongSV", SqlDbType.Int);
            sqlParameters[2].Value = lophp.SoLuongSV;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(LopHocPhan lophp)
        {
            string query = "Update LopHocPhan " +
                           "Set MaHP=@MaHP, LopTruong=@LopTruong " +
                           "Where MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            sqlParameters[1] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[1].Value = lophp.MaHP;
            sqlParameters[2] = new SqlParameter("@LopTruong", SqlDbType.VarChar);
            if (lophp.LopTruong == null)
            {
                sqlParameters[2].Value = DBNull.Value;
            }
            else
            {
                sqlParameters[2].Value = lophp.LopTruong;
            }
            return executeInsertQuery(query, sqlParameters);
        }
        public bool delete(LopHocPhan lophp)
        {
            string query = "Delete from LopHocPhan " +
                           "Where MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
