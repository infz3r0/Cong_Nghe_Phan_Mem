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
    public class SinhVienBUS
    {
         private SinhVienDAO sinhVienDAO = new SinhVienDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = sinhVienDAO.getAll();
            return dt;
        }

        public bool Them(SinhVien sinhVien)
        {
            bool result = false;
            if (DateTime.Now.Year - sinhVien.NgaySinh.Year <= 18)
            {
                return false;
            }
            result = sinhVienDAO.insert(sinhVien);
            return result;
        }

        public bool Xoa(SinhVien sinhVien)
        {
            bool result = false;
            result = sinhVienDAO.delete(sinhVien);
            return result;
        }

        public bool Sua(SinhVien sinhVien)
        {
            bool result = false;
            if (DateTime.Now.Year - sinhVien.NgaySinh.Year <= 18)
            {
                return false;
            }
            result = sinhVienDAO.update(sinhVien);
            return result;
        }
    }
}
