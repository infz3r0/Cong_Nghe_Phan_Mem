using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DATA_Tier;
using MODEL_Tier;
using System.Data;

namespace BUS_Tier
{
    public class ThamSo
    {
        private ThamSoDAO thamsoDAO = new ThamSoDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            //dt = ThamSoDAO.getAll();
            return dt;
        }

        public bool Them(ThamSo thamso)
        {
            bool result = false;

            return result;
        }

        public bool Xoa(ThamSo thamso)
        {
            bool result = false;

            return result;
        }

        public bool Sua(ThamSo thamso)
        {
            bool result = false;

            return result;
        }
    }
}
