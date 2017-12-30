using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class LopHocPhan
    {
        private string maLopHP;
        private int soLuongSV;
        private string maHP;
        private string lopTruong;

        public LopHocPhan()
        {

        }

        public LopHocPhan(string maLopHP, string maHP, string lopTruong)
        {
            this.MaLopHP = maLopHP;
            this.MaHP = maHP;
            this.LopTruong = lopTruong;
        }

        public string MaLopHP { get => maLopHP; set => maLopHP = value; }
        public int SoLuongSV { get => soLuongSV; set => soLuongSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
        public string LopTruong { get => lopTruong; set => lopTruong = value; }
    }
}
