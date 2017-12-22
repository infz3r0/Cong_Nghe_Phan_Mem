using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class Khoa
    {
        private string maKhoa;
        private string tenKhoa;
        private string sdt;
        private string email;

        public Khoa()
        {

        }

        public Khoa(string maKhoa, string tenKhoa, string sdt, string email)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
            this.Sdt = sdt;
            this.Email = email;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
}
