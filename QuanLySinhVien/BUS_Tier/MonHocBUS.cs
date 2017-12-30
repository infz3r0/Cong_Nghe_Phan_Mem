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

        private bool TrongSoHopLe(MonHoc monHoc)
        {
            if (monHoc.TrongSoDQT + monHoc.TrongSoDThi != (decimal)1.0)
            {
                return false;
            }
            return true;
        }

        public bool Them(MonHoc monHoc)
        {
            bool result = false;
            if (!TrongSoHopLe(monHoc))
            {
                return false;
            }
            result = monHocDAO.insert(monHoc);
            return result;
        }

        public bool Xoa(MonHoc monHoc)
        {
            bool result = false;
            result = monHocDAO.delete(monHoc);
            return result;
        }

        public bool Sua(MonHoc monHoc)
        {
            bool result = false;
            if (!TrongSoHopLe(monHoc))
            {
                return false;
            }
            result = monHocDAO.update(monHoc);
            return result;
        }
    }
}
