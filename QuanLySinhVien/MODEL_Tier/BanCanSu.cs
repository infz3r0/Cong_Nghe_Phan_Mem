using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class BanCanSu
    {
        private string maSV;
        private string chucVu;

        public BanCanSu()
        {

        }

        public BanCanSu(string maSV, string chucVu)
        {
            this.MaSV = maSV;
            this.ChucVu = chucVu;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
