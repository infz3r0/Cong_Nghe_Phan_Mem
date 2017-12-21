using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    class Quyen
    {
        private int maQuyen;
        private string moTa;
        
        public Quyen()
        {

        }

        public Quyen(int maQuyen, string moTa)
        {
            this.MaQuyen = maQuyen;
            this.MoTa = moTa;
        }

        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
        public string MoTa { get => moTa; set => moTa = value; }
    }
}
