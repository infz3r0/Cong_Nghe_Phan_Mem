using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    public class SinhVien
    {
        private string maSV;
        private string hoTen;
        private DateTime ngaySinh;
        private char gioiTinh;
        private string diaChi;
        private string soCMND;
        private string sdt;
        private string email;
        private float diemTB;
        private string maLop;
        private string xeploai;

        public SinhVien()
        {

        }

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, char gioiTinh, string diaChi, string soCMND, string sdt, string email, float diemTB, string maLop, string xeploai)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.SoCMND = soCMND;
            this.Sdt = sdt;
            this.Email = email;
            this.DiemTB = diemTB;
            this.MaLop = maLop;
            this.Xeploai = xeploai;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public char GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoCMND { get => soCMND; set => soCMND = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string Xeploai { get => xeploai; set => xeploai = value; }
    }
}
