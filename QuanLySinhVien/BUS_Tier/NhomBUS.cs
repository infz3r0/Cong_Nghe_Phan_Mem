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
    public class NhomBUS
    {
        private NhomDAO nhomDAO = new NhomDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public bool Them(Nhom nhom)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(Nhom nhom)
        {
            bool result = false;

            return result;
        }

        public bool Sua(Nhom nhom)
        {
            bool result = false;

            return result;
        }
    }
}
