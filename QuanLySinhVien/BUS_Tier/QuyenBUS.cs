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
    public class QuyenBUS
    {
        private QuyenDAO quyenDAO = new QuyenDAO();

        public DataTable DanhSach()
        {
            return quyenDAO.getAll();
        }

        public bool Them(Quyen quyen)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(Quyen quyen)
        {
            bool result = false;

            return result;
        }

        public bool Sua(Quyen quyen)
        {
            bool result = false;

            return result;
        }
    }
}
