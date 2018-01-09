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
        public bool dangki(string MaSV, string[] dshp)
        {
            foreach (string MaLopHP in dshp)
            {
                bool isOK = danhSachLopHPDAO.DangKi(MaSV, MaLopHP);
                if (!isOK)
                {
                    return false;
                }
            }
            return true;
        }
        public bool huydangki(string MaSV, string MaLopHP)
        {
            bool isOK = danhSachLopHPDAO.HuyDangKi(MaSV, MaLopHP);
            return isOK;
        }
        public DataTable dshpdadangki()
        {
            return danhSachLopHPDAO.DSHPDaDangKi();
        }
        public Dictionary<string, string> dshpchuadangki(string MaSV)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            DataTable dt = danhSachLopHPDAO.DSHPChuaDangKi(MaSV);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dict.Add(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString());
            }

            return dict;
        }


    }
}
