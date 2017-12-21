using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    class LopKhoaHoc
    {
        private string maLop;
        private string maKhoa;

        public LopKhoaHoc()
        {

        }

        public LopKhoaHoc(string maLop, string maKhoa)
        {
            this.MaLop = maLop;
            this.MaKhoa = maKhoa;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
    }
}
