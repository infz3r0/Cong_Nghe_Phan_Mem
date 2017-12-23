using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL_Tier;
using DATA_Tier;
using System.Data;

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

        public bool Them(TaiKhoan taiKhoan)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(TaiKhoan taiKhoan)
        {
            bool result = false;

            return result;
        }

        public bool Sua(TaiKhoan taiKhoan)
        {
            bool result = false;

            return result;
        }

        public bool DangNhap(TaiKhoan taikhoan)
        {
            if (taikhoan.Username.Equals("admin"))
            {
                return true;
            }
            return false;
        }
    }
}
