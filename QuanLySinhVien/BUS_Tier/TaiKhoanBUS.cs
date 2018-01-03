using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL_Tier;
using DATA_Tier;
using System.Data;
using System.Security.Cryptography;

namespace BUS_Tier
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public bool DangKi(TaiKhoan taiKhoan)
        {
            taiKhoan.Password = Md5(taiKhoan.Password);
            return taiKhoanDAO.Insert(taiKhoan);
        }

        public bool DangNhap(TaiKhoan taiKhoan)
        {
            taiKhoan.Password = Md5(taiKhoan.Password);
            return taiKhoanDAO.Login(taiKhoan);
        }

        public bool DoiPassword(TaiKhoan taiKhoanCu, TaiKhoan taiKhoanMoi)
        {
            taiKhoanCu.Password = Md5(taiKhoanCu.Password);
            if (!taiKhoanDAO.Login(taiKhoanCu))
            {
                return false;
            }

            taiKhoanMoi.Password = Md5(taiKhoanMoi.Password);
            return taiKhoanDAO.Update(taiKhoanMoi);
        }

        public int GetGID(TaiKhoan taiKhoan)
        {
            int gid = -1;
            DataTable dt;
            if (taiKhoanDAO.Login(taiKhoan))
            {
                dt = taiKhoanDAO.SelectByUsername(taiKhoan);
                gid = int.Parse(dt.Rows[0]["GID"].ToString());
            }
            return gid;
        }

        private string Md5(string input)
        {
            string output = "";
            using (MD5 md5Hash = MD5.Create())
            {
                output = GetMd5Hash(md5Hash, input);
            }
            return output;
        }

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
