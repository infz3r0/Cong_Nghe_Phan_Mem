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
    public class DiemDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from Diem";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool insert(Diem d)
        {
            string query = "Insert into Diem (MaSV, MaHP, DiemQT, DiemThi, DiemHP10, DiemHe4So, DiemHe4Chu, XepLoai, DanhGia, HocKi) " +
                           "Values (@MaSV, @MaHP, @DiemQT, @DiemThi, @DiemHP10, @DiemHe4So, @DiemHe4Chu, @XepLoai, @DanhGia, @HocKi)";
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = d.MaSV;
            sqlParameters[1] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[1].Value = d.MaHP;
            sqlParameters[2] = new SqlParameter("@DiemQT", SqlDbType.Float);
            sqlParameters[2].Value = d.DiemQT;
            sqlParameters[3] = new SqlParameter("@DiemThi", SqlDbType.Float);
            sqlParameters[3].Value = d.DiemThi;
            sqlParameters[4] = new SqlParameter("@DiemHP10", SqlDbType.Float);
            sqlParameters[4].Value = d.DiemHP10;
            sqlParameters[5] = new SqlParameter("@DiemHe4So", SqlDbType.Float);
            sqlParameters[5].Value = d.DiemHe4So;
            sqlParameters[6] = new SqlParameter("@DiemHe4Chu", SqlDbType.VarChar);
            sqlParameters[6].Value = d.DiemHe4Chu;
            sqlParameters[7] = new SqlParameter("@XepLoai", SqlDbType.VarChar);
            sqlParameters[7].Value = d.XepLoai;
            sqlParameters[8] = new SqlParameter("@DanhGia", SqlDbType.VarChar);
            sqlParameters[8].Value = d.DanhGia;
            sqlParameters[9] = new SqlParameter("@HocKi", SqlDbType.VarChar);
            sqlParameters[9].Value = d.HocKi;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool update(Diem d)
        {
            string query = "Update  Diem" +
                           "Set DiemQT=@DemQT, DiemThi=@DiemThi, DiemHP10=@DiemHP10, DiemHe4So=@DiemHe4So, DiemHe4Chu=@DiemHe4Chu, XepLoai=@XepLoai, DanhGia=@DanhGia, HocKi=@HocKi" +
                           "Where MaSV=@MaSV, MaHP=@MaHP";
            SqlParameter[] sqlParameters = new SqlParameter[10];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = d.MaSV;
            sqlParameters[1] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[1].Value = d.MaHP;
            sqlParameters[2] = new SqlParameter("@DiemQT", SqlDbType.Float);
            sqlParameters[2].Value = d.DiemQT;
            sqlParameters[3] = new SqlParameter("@DiemThi", SqlDbType.Float);
            sqlParameters[3].Value = d.DiemThi;
            sqlParameters[4] = new SqlParameter("@DiemHP10", SqlDbType.Float);
            sqlParameters[4].Value = d.DiemHP10;
            sqlParameters[5] = new SqlParameter("@DiemHe4So", SqlDbType.Float);
            sqlParameters[5].Value = d.DiemHe4So;
            sqlParameters[6] = new SqlParameter("@DiemHe4Chu", SqlDbType.VarChar);
            sqlParameters[6].Value = d.DiemHe4Chu;
            sqlParameters[7] = new SqlParameter("@XepLoai", SqlDbType.VarChar);
            sqlParameters[7].Value = d.XepLoai;
            sqlParameters[8] = new SqlParameter("@DanhGia", SqlDbType.VarChar);
            sqlParameters[8].Value = d.DanhGia;
            sqlParameters[9] = new SqlParameter("@HocKi", SqlDbType.VarChar);
            sqlParameters[9].Value = d.HocKi;
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool delete(Diem d)
        {
            string query = "Delete from Diem " +
                           "Where MaSV=@MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = d.MaSV;
            return executeDeleteQuery(query, sqlParameters);
        }
    }
}
