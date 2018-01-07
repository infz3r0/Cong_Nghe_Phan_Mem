﻿using MODEL_Tier;
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
        public DataTable GetAll()
        {
            string query = "SELECT MaLopHP, SoLuongSV, HP.MaHP, LopTruong, TenHP FROM LopHocPhan HP, MonHoc M WHERE HP.MaHP = M.MaHP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
        public bool Insert(LopHocPhan lophp)
        {
            string query = "INSERT INTO LopHocPhan (MaLopHP, MaHP, SoluongSV)" +
                           " VALUES (@MaLopHP, @MaHP, @SoLuongSV)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            sqlParameters[1] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[1].Value = lophp.MaHP;
            sqlParameters[2] = new SqlParameter("@SoLuongSV", SqlDbType.Int);
            sqlParameters[2].Value = lophp.SoLuongSV;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool Update(LopHocPhan lophp)
        {
            string query = "UPDATE LopHocPhan " +
                           "SET MaHP=@MaHP, LopTruong=@LopTruong " +
                           "WHERE MaLopHP=@MaLopHP";
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
            return executeUpdateQuery(query, sqlParameters);
        }
        public bool Delete(LopHocPhan lophp)
        {
            string query = "DELETE FROM LopHocPhan " +
                           "WHERE MaLopHP=@MaLopHP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaLopHP", SqlDbType.VarChar);
            sqlParameters[0].Value = lophp.MaLopHP;
            return executeDeleteQuery(query, sqlParameters);
        }
        public bool DangKi(string MaSV, string MaHP)
        {
            string query = "INSERT SinhVien (MaSV, MaHP)" +
                           " VALUES (@MaSV, @MaHP)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            sqlParameters[1] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[1].Value = MaHP;
            return executeInsertQuery(query, sqlParameters);
        }
        public bool HuyDangKi(string MaSV, string MaHP)
        {
            string query = "INSERT SinhVien (MaSV, MaHP)" +
                           " VALUES (@MaSV, @MaHP)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            sqlParameters[1] = new SqlParameter("@MaHP", SqlDbType.VarChar);
            sqlParameters[1].Value = MaHP;
            return executeInsertQuery(query, sqlParameters);
        }
        public DataTable DSHPChuaDangKi(string MaSV)
        {
            string query = "select MaHP, TenHP" +
                             "from MonHoc" +
                             "where MaHP not in " +
                             "(select MaHP from SinhVien where MaSV = @MaSV)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MaSV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaSV;
            return executeSelectQuery(query, sqlParameters);
        }
        public DataTable DSHPDaDangKi()
        {
            string query = "SELECT SinhVien.MaSV, LopHocPhan.MaHP, MonHoc.TenHP, MonHoc.SoTinChi, MonHoc.TrongSoDQT, MonHoc.TrongSoDThi, MonHoc.LoaiHP" +
                "FROM LopHocPhan INNER JOIN" +
                "MonHoc ON LopHocPhan.MaHP = MonHoc.MaHP INNER JOIN" +
                "SinhVien ON LopHocPhan.LopTruong = SinhVien.MaSV";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }
    }
}
