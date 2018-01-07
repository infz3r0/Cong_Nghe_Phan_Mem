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
    public class SinhVienBUS
    {
         private SinhVienDAO sinhVienDAO = new SinhVienDAO();

        public DataTable DanhSach()
        {
            return sinhVienDAO.GetAll();
        }

        public bool Them(SinhVien sinhVien)
        {
            //Tuổi từ 18 trở lên
            if (DateTime.Now.Year - sinhVien.NgaySinh.Year <= 18)
            {
                return false;
            }

            return sinhVienDAO.Insert(sinhVien);
        }

        public bool Xoa(SinhVien sinhVien)
        {
            return sinhVienDAO.Delete(sinhVien);
        }

        public bool Sua(SinhVien sinhVien)
        {
            //Tuổi từ 18 trở lên
            if (DateTime.Now.Year - sinhVien.NgaySinh.Year <= 18)
            {
                return false;
            }

            return sinhVienDAO.Update(sinhVien);
        }

        public DataTable TimKiemTheoTen(string input)
        {
            DataTable dt = sinhVienDAO.Search().Copy();
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MaSV");
            ketqua.Columns.Add("HoTen");
            ketqua.Columns.Add("NgaySinh");
            ketqua.Columns.Add("GioiTinh");
            ketqua.Columns.Add("Sdt");
            ketqua.Columns.Add("MaLop");

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                string hoten = dt.Rows[r]["HoTen"].ToString();
                if (hoten.ToLower().Contains(input.ToLower()))
                {
                    DataRow row = dt.Rows[r];
                    DataRow newrow = ketqua.NewRow();
                    for (int i = 0; i < ketqua.Columns.Count; i++)
                    {
                        newrow[i] = row[i];
                    }
                    ketqua.Rows.Add(newrow);
                }
            }

            return ketqua;
        }

        public DataTable TimKiemTheoMaSV(string input)
        {
            DataTable dt = sinhVienDAO.Search().Copy();
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MaSV");
            ketqua.Columns.Add("HoTen");
            ketqua.Columns.Add("NgaySinh");
            ketqua.Columns.Add("GioiTinh");
            ketqua.Columns.Add("Sdt");
            ketqua.Columns.Add("MaLop");

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                string masv = dt.Rows[r]["MaSV"].ToString();
                if (masv.Contains(input))
                {
                    DataRow row = dt.Rows[r];
                    DataRow newrow = ketqua.NewRow();
                    for (int i = 0; i < ketqua.Columns.Count; i++)
                    {
                        newrow[i] = row[i];
                    }
                    ketqua.Rows.Add(newrow);
                }
            }

            return ketqua;
        }

        public void FillDataTable(ref DataTable dt, string malop)
        {
            sinhVienDAO.FillDataTable(ref dt, malop);
        }
    }
}
