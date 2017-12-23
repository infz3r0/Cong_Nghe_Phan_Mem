using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MODEL_Tier
{
    public class DiemHe4
    {
        private string DiemHe4Chu;
        private float DiemHe4So;
        private float DiemHe10Min;
        private float DiemHe10Max;
        private string XepLoai;
        private string DanhGia;

        public DiemHe4()
        {

        }

        public DiemHe4(string diemHe4Chu, float diemHe4So, float diemHe10Min, float diemHe10Max, string xepLoai, string danhGia)
        {
            DiemHe4Chu1 = diemHe4Chu;
            DiemHe4So1 = diemHe4So;
            DiemHe10Min1 = diemHe10Min;
            DiemHe10Max1 = diemHe10Max;
            XepLoai1 = xepLoai;
            DanhGia1 = danhGia;
        }

        public string DiemHe4Chu1 { get => DiemHe4Chu; set => DiemHe4Chu = value; }
        public float DiemHe4So1 { get => DiemHe4So; set => DiemHe4So = value; }
        public float DiemHe10Min1 { get => DiemHe10Min; set => DiemHe10Min = value; }
        public float DiemHe10Max1 { get => DiemHe10Max; set => DiemHe10Max = value; }
        public string XepLoai1 { get => XepLoai; set => XepLoai = value; }
        public string DanhGia1 { get => DanhGia; set => DanhGia = value; }
    }
}
