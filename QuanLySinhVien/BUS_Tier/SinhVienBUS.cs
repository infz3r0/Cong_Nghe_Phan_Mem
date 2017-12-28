﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL_Tier;
using DATA_Tier;
using System.Data;


namespace BUS_Tier
{
    public class SinhVienBUS
    {
         private SinhVienDAO sinhVienDAO = new SinhVienDAO();

        public DataTable DanhSach()
        {
            DataTable dt = new DataTable();
            dt = sinhVienDAO.getAll();
            return dt;
        }

        public bool Them(SinhVien sinhVien)
        {
            bool result = false;
            if (string.IsNullOrEmpty(sinhVien.MaSV))
            {
                return false;
            }
            if (string.IsNullOrEmpty(sinhVien.HoTen))
            {
                return false;
            }
            if (!sinhVien.GioiTinh.Equals('M') && !sinhVien.GioiTinh.Equals('F') && !sinhVien.GioiTinh.Equals('O'))
            {
                return false;
            }
            if (DateTime.Now.Year - sinhVien.NgaySinh.Year <= 18)
            {
                return false;
            }
            result = sinhVienDAO.insert(sinhVien);
            return result;
        }

        public bool Xoa(SinhVien sinhVien)
        {
            bool result = false;
            sinhVienDAO.delete(sinhVien);
            return result;
        }

        public bool Sua(SinhVien sinhVien)
        {
            bool result = false;
            sinhVienDAO.update(sinhVien);
            return result;
        }
    }
}
