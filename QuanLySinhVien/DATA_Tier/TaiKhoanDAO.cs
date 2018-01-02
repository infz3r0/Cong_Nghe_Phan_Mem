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
    public class TaiKhoanDAO : DBConnect
    {
        public DataTable getAll()
        {
            string query = "Select * from TaiKhoan";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return executeSelectQuery(query, sqlParameters);
        }

        public bool Insert(TaiKhoan taikhoan)
        {
            string query = "Insert into TaiKhoan (Username, Password, GID) " +
                           "Values (@Username, @Password, @GID)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Username", SqlDbType.VarChar);
            sqlParameters[0].Value = taikhoan.Username;
            sqlParameters[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            sqlParameters[1].Value = taikhoan.Password;
            sqlParameters[2] = new SqlParameter("@GID", SqlDbType.Int);
            sqlParameters[2].Value = taikhoan.GID;
            return executeInsertQuery(query, sqlParameters);
        }

        public bool Update(TaiKhoan taikhoan)
        {
            string query = "Update TaiKhoan set Password = @Password where Username = @Username";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Username", SqlDbType.VarChar);
            sqlParameters[0].Value = taikhoan.Username;
            sqlParameters[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            sqlParameters[1].Value = taikhoan.Password;
            return executeUpdateQuery(query, sqlParameters);
        }

        public bool Login(TaiKhoan taikhoan)
        {
            string query = "Select count(*) from TaiKhoan where Username = @Username and Password = @Password";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@Username", SqlDbType.VarChar);
            sqlParameters[0].Value = taikhoan.Username;
            sqlParameters[1] = new SqlParameter("@Password", SqlDbType.VarChar);
            sqlParameters[1].Value = taikhoan.Password;
            int ret =  executeNonQuery(query, sqlParameters);
            if (ret == 1)
            {
                return true;
            }
            return false;
        }
    }
}
