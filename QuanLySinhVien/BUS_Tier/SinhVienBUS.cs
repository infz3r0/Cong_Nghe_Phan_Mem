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
    public class SinhVienBUS
    {
        private SinhVienDAO sinhVienDAO = new SinhVienDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public bool Them(SinhVien sinhVien)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(SinhVien sinhVien)
        {
            bool result = false;

            return result;
        }

        public bool Sua(SinhVien sinhVien)
        {
            bool result = false;

            return result;
        }
    }
}
