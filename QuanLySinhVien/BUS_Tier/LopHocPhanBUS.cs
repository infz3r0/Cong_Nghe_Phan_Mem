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
        public bool dangki(string MaSV, string[] dshp)
        {
            foreach (string MaHP in dshp)
            {
                bool isOK = lopHocPhanDAO.DangKi(MaSV, MaHP);
                if (!isOK)
                {
                    return false;
                }
            }
            return true;
        }
        public bool huydangki(string MaSV, string MaHP)
        {
            bool isOK = lopHocPhanDAO.HuyDangKi(MaSV, MaHP);
            return isOK;
        }
        public DataTable dshpdadangki()
        {
            return lopHocPhanDAO.DSHPDaDangKi();
        }
    }
}
