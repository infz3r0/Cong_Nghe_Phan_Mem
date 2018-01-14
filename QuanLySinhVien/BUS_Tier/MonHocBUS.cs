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
    public class MonHocBUS
    {
        private MonHocDAO monHocDAO = new MonHocDAO();

        public DataTable DanhSach()
        {
            return monHocDAO.GetAll();
        }
        
        private bool TrongSoHopLe(MonHoc monHoc)
        {
            if (monHoc.TrongSoDQT + monHoc.TrongSoDThi != (decimal)1.0)
            {
                return false;
            }

            return true;
        }

        public bool Them(MonHoc monHoc)
        {
            if (!TrongSoHopLe(monHoc))
            {
                return false;
            }

            return monHocDAO.Insert(monHoc);
        }

        public bool Xoa(MonHoc monHoc)
        {
            return monHocDAO.Delete(monHoc);
        }

        public bool Sua(MonHoc monHoc)
        {
            if (!TrongSoHopLe(monHoc))
            {
                return false;
            }

            return monHocDAO.Update(monHoc);
        }
        public DataTable loctheoten(string input)
        {
            DataTable dt = monHocDAO.Search().Copy();
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MaHP");
            ketqua.Columns.Add("TenHP");
            ketqua.Columns.Add("MaLopHP");
            ketqua.Columns.Add("SoTinChi");
            ketqua.Columns.Add("SoLongSV");

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                string tenhp = dt.Rows[r]["TenHP"].ToString();
                if (tenhp.ToLower().Contains(input.ToLower()))
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
        public DataTable Loctheoma(string input)
        {
            DataTable dt = monHocDAO.Search().Copy();
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MaHP");
            ketqua.Columns.Add("TenHP");
            ketqua.Columns.Add("MaLopHP");
            ketqua.Columns.Add("SoTinChi");
            ketqua.Columns.Add("SoLongSV");

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                string mahp = dt.Rows[r]["MaHP"].ToString();
                if (mahp.Contains(input))
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
        public DataTable danhsachmon()
        {
            return monHocDAO.Search();
        }
    }
}
