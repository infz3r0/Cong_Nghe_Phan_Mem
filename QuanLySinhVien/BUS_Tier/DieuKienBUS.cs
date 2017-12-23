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
    public class DieuKienBUS
    {
        private DieuKienDAO dieuKienDAO = new DieuKienDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public bool Them(DieuKien dieuKien)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(DieuKien dieuKien)
        {
            bool result = false;

            return result;
        }

        public bool Sua(DieuKien dieuKien)
        {
            bool result = false;

            return result;
        }
    }
}
