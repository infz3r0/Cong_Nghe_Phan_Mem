using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class DanhSachLopHP
    {
        private string maLopHP;
        private string maSV;

        public DanhSachLopHP()
        {

        }

        public DanhSachLopHP(string maLopHP, string maSV)
        {
            this.MaLopHP = maLopHP;
            this.MaSV = maSV;
        }

        public string MaLopHP { get => maLopHP; set => maLopHP = value; }
        public string MaSV { get => maSV; set => maSV = value; }
    }
}
