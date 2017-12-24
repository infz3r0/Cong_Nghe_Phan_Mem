using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MODEL_Tier
{
    public class DiemHe4
    {
        private string diemHe4Chu;
        private float diemHe4So;
        private float diemHe10Min;
        private float diemHe10Max;
        private string xepLoai;
        private string danhGia;

        public DiemHe4()
        {

        }

        public DiemHe4(string diemHe4Chu, float diemHe4So, float diemHe10Min, float diemHe10Max, string xepLoai, string danhGia)
        {
            this.DiemHe4Chu = diemHe4Chu;
            this.DiemHe4So = diemHe4So;
            this.DiemHe10Min = diemHe10Min;
            this.DiemHe10Max = diemHe10Max;
            this.XepLoai = xepLoai;
            this.DanhGia = danhGia;
        }

        public string DiemHe4Chu { get => diemHe4Chu; set => diemHe4Chu = value; }
        public float DiemHe4So { get => diemHe4So; set => diemHe4So = value; }
        public float DiemHe10Min { get => diemHe10Min; set => diemHe10Min = value; }
        public float DiemHe10Max { get => diemHe10Max; set => diemHe10Max = value; }
        public string XepLoai { get => xepLoai; set => xepLoai = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
    }
}
