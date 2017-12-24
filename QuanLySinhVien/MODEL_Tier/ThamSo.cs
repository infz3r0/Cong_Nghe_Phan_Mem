using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MODEL_Tier
{
    public class ThamSo
    {
        private string tenThamSo;
        private string moTa;
        private string giaTri;

        public ThamSo()
        {

        }

        public ThamSo(string tenThamSo, string moTa, string giaTri)
        {
            this.TenThamSo = tenThamSo;
            this.MoTa = moTa;
            this.GiaTri = giaTri;
        }

        public string TenThamSo { get => tenThamSo; set => tenThamSo = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string GiaTri { get => giaTri; set => giaTri = value; }
    }
}
