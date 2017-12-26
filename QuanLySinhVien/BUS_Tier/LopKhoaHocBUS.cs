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
            dt = lopKhoaHocDAO.getAll_TenKhoa();
            return dt;
        }

        public bool MaHopLe(string ma)
        {
            if (ma.Length != 7)
            {
                return false;
            }
            //khóa học = số
            string s1 = ma.Substring(0, 2);
            //trình độ đào tạo = chữ = D hoặc C
            string s2 = ma.Substring(2, 1);
            //ngành = chữ
            string s3 = ma.Substring(3, 2);
            //stt = số
            string s4 = ma.Substring(5, 2);

            for (int i = 0; i < s1.Length; i++)
            {
                if (!char.IsDigit(s1[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (!s2[i].Equals('D') && !s2[i].Equals('C'))
                {
                    return false;
                }
            }
            for (int i = 0; i < s3.Length; i++)
            {
                if (!char.IsLetter(s3[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < s4.Length; i++)
            {
                if (!char.IsDigit(s4[i]))
                {
                    return false;
                }
            }
            return true;
        }

       
        
        public bool Them(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;
            if (!MaHopLe(lopKhoaHoc.MaLop))
            {
                return false;
            }
            result = lopKhoaHocDAO.insert(lopKhoaHoc);
            return result;
        }

        public bool Xoa(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;
            lopKhoaHocDAO.delete(lopKhoaHoc);
            return result;
        }

        public bool Sua(LopKhoaHoc lopKhoaHoc)
        {
            bool result = false;
            lopKhoaHocDAO.update(lopKhoaHoc);
            return result;
        }
    }
}
