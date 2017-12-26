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
    public class LopKhoaHocBUS
    {
        private LopKhoaHocDAO lopKhoaHocDAO = new LopKhoaHocDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = lopKhoaHocDAO.getAll();
            return dt;
        }

        public bool MaKhoaHopLe(string malop)
        {
            if (malop.Length != 6)
            {
                return false;
            }
            string s1 = malop.Substring(0, 2);
            string s2 = malop.Substring(2, 4);
            string s3 = malop.Substring(4, 4);
            string s4 = malop.Substring();
            for (int i = 0; i < 2; i++)
            {
                if (char.IsDigit(s1[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (char.IsLetter(s2[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (char.IsLetter(s3[i]))
                {
                    return false;
                }
            }
            return true;
        }

            public bool Them(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;
            if (!MaKhoaHopLe(lopKhoaHoc.MaLop))
            {
                return false;
            }
            result = lopKhoaHocDAO.insert(lopKhoaHoc);
            return result;
        }

        public bool Xoa(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;

            return result;
        }

        public bool Sua(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;

            return result;
        }
    }
}
