using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    class MonHoc
    {
        private string maHP;
        private string tenHP;
        private int soTinChi;
        private string loaiHP;
        private float trongSoDQT;
        private float trongSoDThi;

        public MonHoc()
        {

        }

        public MonHoc(string maHP, string tenHP, int soTinChi, string loaiHP, float trongSoDQT, float trongSoDThi)
        {
            this.MaHP = maHP;
            this.TenHP = tenHP;
            this.SoTinChi = soTinChi;
            this.LoaiHP = loaiHP;
            this.TrongSoDQT = trongSoDQT;
            this.TrongSoDThi = trongSoDThi;
        }

        public string MaHP { get => maHP; set => maHP = value; }
        public string TenHP { get => tenHP; set => tenHP = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public string LoaiHP { get => loaiHP; set => loaiHP = value; }
        public float TrongSoDQT { get => trongSoDQT; set => trongSoDQT = value; }
        public float TrongSoDThi { get => trongSoDThi; set => trongSoDThi = value; }
    }
}
