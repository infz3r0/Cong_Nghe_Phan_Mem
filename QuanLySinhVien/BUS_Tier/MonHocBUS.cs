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
    public class MonHocBUS
    {
        private MonHocDAO monHocDAO = new MonHocDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = monHocDAO.getAll();

            return dt;
        }

        public bool Them(MonHoc monHoc)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(MonHoc monHoc)
        {
            bool result = false;

            return result;
        }

        public bool Sua(MonHoc monHoc)
        {
            bool result = false;

            return result;
        }
    }
}
