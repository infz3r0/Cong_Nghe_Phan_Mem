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
            return khoaDAO.GetAll();
        }

        public bool Them(Khoa khoa)
        {
            return khoaDAO.Insert(khoa);
        }

        public bool Xoa(Khoa khoa)
        {
            return khoaDAO.Delete(khoa);
        }

        public bool Sua(Khoa khoa)
        {
            return khoaDAO.Update(khoa);
        }
    }
}
