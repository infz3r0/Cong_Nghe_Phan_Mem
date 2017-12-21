using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    class Nhom
    {
        private int gID;
        private string tenNhom;

        public Nhom()
        {

        }

        public Nhom(int gID, string tenNhom)
        {
            this.GID = gID;
            this.TenNhom = tenNhom;
        }

        public int GID { get => gID; set => gID = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
    }
}
