using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class Diem
    {
        private string maSV;
        private string maHP;
        private float diemQT;
        private float diemThi;
        private float diemHP10;
        private float diemHe4So;
        private float diemHe4Chu;
        private string xepLoai;
        private string danhGia;
        private string hocKi;

        public Diem()
        {

        }

        public Diem(string maSV, string maHP, float diemQT, float diemThi, float diemHP10, float diemHe4So, float diemHe4Chu, string xepLoai, string danhGia, string hocKi)
        {
            this.MaSV = maSV;
            this.MaHP = maHP;
            this.DiemQT = diemQT;
            this.DiemThi = diemThi;
            this.DiemHP10 = diemHP10;
            this.DiemHe4So = diemHe4So;
            this.DiemHe4Chu = diemHe4Chu;
            this.XepLoai = xepLoai;
            this.DanhGia = danhGia;
            this.HocKi = hocKi;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
        public float DiemQT { get => diemQT; set => diemQT = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
        public float DiemHP10 { get => diemHP10; set => diemHP10 = value; }
        public float DiemHe4So { get => diemHe4So; set => diemHe4So = value; }
        public float DiemHe4Chu { get => diemHe4Chu; set => diemHe4Chu = value; }
        public string XepLoai { get => xepLoai; set => xepLoai = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public string HocKi { get => hocKi; set => hocKi = value; }
    }
}
