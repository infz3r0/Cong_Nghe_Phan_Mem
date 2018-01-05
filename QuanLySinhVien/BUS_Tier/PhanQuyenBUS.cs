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
            return phanQuyenDAO.GetAll();
        }

        public bool CapNhat(PhanQuyen phanQuyen)
        {
            return phanQuyenDAO.Insert(phanQuyen);
        }

        public bool Xoa(PhanQuyen phanQuyen)
        {
            return phanQuyenDAO.DeleteAll(phanQuyen);
        }

        public DataTable DanhSachQuyenTheoGID(int gid)
        {
            return phanQuyenDAO.SelectMaQuyenByGID(gid);
        }
    }
}
