using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class DieuKien
    {
        private string maHP;
        private string loaiDK;
        private string maHPDK;

        public DieuKien()
        {

        }

        public DieuKien(string maHP, string loaiDK, string maHPDK)
        {
            this.MaHP = maHP;
            this.LoaiDK = loaiDK;
            this.MaHPDK = maHPDK;
        }

        public string MaHP { get => maHP; set => maHP = value; }
        public string LoaiDK { get => loaiDK; set => loaiDK = value; }
        public string MaHPDK { get => maHPDK; set => maHPDK = value; }
    }
}
