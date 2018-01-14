using DATA_Tier;
using MODEL_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Tier
{
    public class DiemHe4BUS
    {
        private DiemHe4DAO diemhe4DAO = new DiemHe4DAO();

        public DataTable DanhSach()
        {
            return diemhe4DAO.GetAll();
        }

        public bool Them(DiemHe4 diemhe4)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(DiemHe4 diemhe4)
        {
            bool result = false;

            return result;
        }

        public bool Sua(DiemHe4 diemhe4)
        {
            bool result = false;

            return result;
        }
    }
}
