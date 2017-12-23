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
    public class PhanQuyenBUS
    {
        private PhanQuyenDAO phanQuyenDAO = new PhanQuyenDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public bool Them(PhanQuyen phanQuyen)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(PhanQuyen phanQuyen)
        {
            bool result = false;

            return result;
        }

        public bool Sua(PhanQuyen phanQuyen)
        {
            bool result = false;

            return result;
        }
    }
}
