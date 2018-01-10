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
        
        public bool dangki(string MaSV, string[] dshp)
        {
            foreach (string MaLopHP in dshp)
            {
                if (danhSachLopHPDAO.DangKi(MaSV, MaLopHP))
                {
                    return false;
                }
            }
            return true;
        }

        public bool huydangki(string MaSV, string MaLopHP)
        {
            return danhSachLopHPDAO.HuyDangKi(MaSV, MaLopHP);
        }

        public DataTable dshpdadangki(string MaSV)
        {
            return danhSachLopHPDAO.DSHPDaDangKi(MaSV);
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
