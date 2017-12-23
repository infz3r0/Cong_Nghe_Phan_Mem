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
    public class BanCanSuBUS
    {
        private BanCanSuDAO banCanSuDAO = new BanCanSuDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            //dt = BanCanSuDAO.getAll();
            return dt;
        }

        public bool Them(BanCanSu banCanSu)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(BanCanSu banCanSu)
        {
            bool result = false;

            return result;
        }

        public bool Sua(BanCanSu banCanSu)
        {
            bool result = false;

            return result;
        }
    }
}
