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
            return phanQuyenDAO.getAll();
        }

        public bool CapNhat(PhanQuyen phanQuyen)
        {
            return phanQuyenDAO.insert(phanQuyen);
        }

        public bool Xoa(PhanQuyen phanQuyen)
        {
            return phanQuyenDAO.deleteAll(phanQuyen);
        }
    }
}
