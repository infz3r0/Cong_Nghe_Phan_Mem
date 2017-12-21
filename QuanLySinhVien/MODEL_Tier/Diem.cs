using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    class Diem
    {
        private string maSV;
        private string maHP;
        private float diemQT;
        private float diemThi;
        private float diemHP;

        public Diem()
        {

        }

        public Diem(string maSV, string maHP, float diemQT, float diemThi, float diemHP)
        {
            this.MaSV = maSV;
            this.MaHP = maHP;
            this.DiemQT = diemQT;
            this.DiemThi = diemThi;
            this.DiemHP = diemHP;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHP { get => maHP; set => maHP = value; }
        public float DiemQT { get => diemQT; set => diemQT = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
        public float DiemHP { get => diemHP; set => diemHP = value; }
    }
}
