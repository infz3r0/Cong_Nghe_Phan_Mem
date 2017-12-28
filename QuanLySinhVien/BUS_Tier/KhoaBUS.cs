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
    public class KhoaBUS
    {
        private KhoaDAO khoaDAO = new KhoaDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = khoaDAO.getAll();
            return dt;
        }

        public bool Them(Khoa khoa)
        {
            bool result = false;

            if (string.IsNullOrEmpty(khoa.MaKhoa))
            {
                return false;
            }
            if (string.IsNullOrEmpty(khoa.TenKhoa))
            {
                return false;
            }

            result = khoaDAO.insert(khoa);
            return result;
        }

        public bool Xoa(Khoa khoa)
        {
            bool result = false;
            result = khoaDAO.delete(khoa);
            return result;
        }

        public bool Sua(Khoa khoa)
        {
            bool result = false;
            result = khoaDAO.update(khoa);
            return result;
        }
    }
}
