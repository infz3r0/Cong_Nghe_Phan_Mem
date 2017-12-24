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

        //Kiểm tra mã khoa có đúng quy định hay không
        //6 ký tự, 2 ký tự đầu là chữ, 4 ký tự tiếp theo là số
        public bool MaKhoaHopLe(string makhoa)
        {
            if (makhoa.Length != 6)
            {
                return false;
            }                
            string s1 = makhoa.Substring(0, 2);
            string s2 = makhoa.Substring(2, 4);
            for (int i=0; i < 2; i++)
            {
                if (char.IsDigit(s1[i]))
                {
                    return false;
                }
            }
            for (int i=0; i < 4; i++)
            {
                if (char.IsLetter(s2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool Them(Khoa khoa)
        {
            bool result = false;

            if (!MaKhoaHopLe(khoa.MaKhoa))
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
