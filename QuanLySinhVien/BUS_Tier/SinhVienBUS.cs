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
            return sinhVienDAO.GetAll();
        }

        public bool Them(SinhVien sinhVien)
        {
            //Tuổi từ 18 trở lên
            if (DateTime.Now.Year - sinhVien.NgaySinh.Year <= 18)
            {
                return false;
            }

            return sinhVienDAO.Insert(sinhVien);
        }

        public bool Xoa(SinhVien sinhVien)
        {
            return sinhVienDAO.Delete(sinhVien);
        }

        public bool Sua(SinhVien sinhVien)
        {
            //Tuổi từ 18 trở lên
            if (DateTime.Now.Year - sinhVien.NgaySinh.Year <= 18)
            {
                return false;
            }

            return sinhVienDAO.Update(sinhVien);
        }
    }
}
