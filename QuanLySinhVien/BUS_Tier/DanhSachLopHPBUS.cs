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
    public class DanhSachLopHPBUS
    {
        private DanhSachLopHPDAO danhSachLopHPDAO = new DanhSachLopHPDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = danhSachLopHPDAO.GetAll();
            return dt;
        }

        public bool Them(DanhSachLopHP danhSachLopHP)
        {
            bool result = false;
            result = danhSachLopHPDAO.Insert(danhSachLopHP);
            return result;
        }

        public bool Xoa(DanhSachLopHP danhSachLopHP)
        {
            bool result = false;
            result = danhSachLopHPDAO.Delete(danhSachLopHP);
            return result;
        }

        public bool Sua(DanhSachLopHP danhSachLopHP)
        {
            bool result = false;
            result = danhSachLopHPDAO.Update(danhSachLopHP);
            return result;
        }
    }
}
