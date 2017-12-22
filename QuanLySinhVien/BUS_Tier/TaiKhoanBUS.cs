using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL_Tier;
using DATA_Tier;

namespace BUS_Tier
{
    public class TaiKhoanBUS
    {
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
