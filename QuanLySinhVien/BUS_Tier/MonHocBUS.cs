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
            return monHocDAO.GetAll();
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
            if (!TrongSoHopLe(monHoc))
            {
                return false;
            }

            return monHocDAO.Insert(monHoc);
        }

        public bool Xoa(MonHoc monHoc)
        {
            return monHocDAO.Delete(monHoc);
        }

        public bool Sua(MonHoc monHoc)
        {
            if (!TrongSoHopLe(monHoc))
            {
                return false;
            }

            return monHocDAO.Update(monHoc);
        }
    }
}
