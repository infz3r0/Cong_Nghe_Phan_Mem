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
    public class DiemBUS
    {
        private DiemDAO diemDAO = new DiemDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public bool Them(Diem diem)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(Diem diem)
        {
            bool result = false;

            return result;
        }

        public bool Sua(Diem diem)
        {
            bool result = false;

            return result;
        }
    }
}
