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
            return lopHocPhanDAO.GetAll();
        }

        public bool Them(LopHocPhan lopHocPhan)
        {
            return lopHocPhanDAO.Insert(lopHocPhan);
        }

        public bool Xoa(LopHocPhan lopHocPhan)
        {
            return lopHocPhanDAO.Delete(lopHocPhan);
        }

        public bool Sua(LopHocPhan lopHocPhan)
        {
            return lopHocPhanDAO.Update(lopHocPhan);
        }
    }
}
