using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class PhanQuyen
    {
        private int gID;
        private int maQuyen;
        
        public PhanQuyen()
        {

        }

        public PhanQuyen(int gID, int maQuyen)
        {
            this.GID = gID;
            this.MaQuyen = maQuyen;
        }

        public int GID { get => gID; set => gID = value; }
        public int MaQuyen { get => maQuyen; set => maQuyen = value; }
    }
}
