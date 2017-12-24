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
    public class LopKhoaHocBUS
    {
        private LopKhoaHocDAO lopKhoaHocDAO = new LopKhoaHocDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = lopKhoaHocDAO.getAll();
            return dt;
        }

        public bool Them(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;

            return result;
        }

        public bool Sua(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;

            return result;
        }
    }
}
