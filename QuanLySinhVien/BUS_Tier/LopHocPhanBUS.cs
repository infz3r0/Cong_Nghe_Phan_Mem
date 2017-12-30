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
    public class LopHocPhanBUS
    {
        private LopHocPhanDAO lopHocPhanDAO = new LopHocPhanDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = lopHocPhanDAO.getAll();
            return dt;
        }

        public bool Them(LopHocPhan lopHocPhan)
        {
            bool result = false;
            result = lopHocPhanDAO.insert(lopHocPhan);
            return result;
        }

        public bool Xoa(LopHocPhan lopHocPhan)
        {
            bool result = false;
            result = lopHocPhanDAO.delete(lopHocPhan);
            return result;
        }

        public bool Sua(LopHocPhan lopHocPhan)
        {
            bool result = false;
            result = lopHocPhanDAO.update(lopHocPhan);
            return result;
        }
    }
}
