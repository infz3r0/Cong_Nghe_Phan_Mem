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
        private float diemHP4So;
        private float diemHP4Chu;
        private string danhGia;
        private string hocKi;

        public Diem()
        {

        }

        public Diem(string maSV, string maHP, float diemQT, float diemThi, float diemHP10, float diemHP4So, float diemHP4Chu, string danhGia, string hocKi)
        {
            this.MaSV = maSV;
            this.MaHP = maHP;
            this.DiemQT = diemQT;
            this.DiemThi = diemThi;
            this.DiemHP10 = diemHP10;
            this.DiemHP4So = diemHP4So;
            this.DiemHP4Chu = diemHP4Chu;
            this.DanhGia = danhGia;
            this.HocKi = hocKi;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
        public float DiemQT { get => diemQT; set => diemQT = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
        public float DiemHP10 { get => diemHP10; set => diemHP10 = value; }
        public float DiemHP4So { get => diemHP4So; set => diemHP4So = value; }
        public float DiemHP4Chu { get => diemHP4Chu; set => diemHP4Chu = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public string HocKi { get => hocKi; set => hocKi = value; }
    }
}
