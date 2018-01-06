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
            return lopKhoaHocDAO.GetAll_TenKhoa();
        }
        
        public bool Them(LopKhoaHoc lopKhoaHoc)
        {
            return lopKhoaHocDAO.Insert(lopKhoaHoc);
        }

        public bool Xoa(LopKhoaHoc lopKhoaHoc)
        {
            return lopKhoaHocDAO.Delete(lopKhoaHoc);
        }

        public bool Sua(LopKhoaHoc lopKhoaHoc)
        {
            return lopKhoaHocDAO.Update(lopKhoaHoc);
        }
    }
}
