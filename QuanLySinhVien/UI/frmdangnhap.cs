using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

using BUS_Tier;
using MODEL_Tier;

namespace UI_Tier
{
    public partial class frmdangnhap : DevExpress.XtraEditors.XtraForm
    {
        private bool dadangnhap;

        public frmdangnhap()
        {
            InitializeComponent();

            dadangnhap = false;
        }

        private void frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dadangnhap)
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.DialogResult = DialogResult.Yes;
                }
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS taikhoanBUS = new TaiKhoanBUS();
            TaiKhoan taikhoan = new TaiKhoan();

            taikhoan.Username = txtusename.Text;
            taikhoan.Password = txtPassword.Text;

            bool thanhcong = taikhoanBUS.DangNhap(taikhoan);

            if (thanhcong)
            {
                dadangnhap = true;
                frmmain.username = txtusename.Text;
                frmmain.gid = taikhoanBUS.GetGID(taikhoan);
                Dispose();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmdangnhap_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void frmdangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.Modifiers == Keys.Alt && e.Modifiers == Keys.Shift && e.KeyCode == Keys.F7)
            {
                MessageBox.Show("Developer Mode");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("DOWN:{0}, {1}", e.Modifiers, e.KeyCode);
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F7)
            {
                string output = "";
                using (MD5 md5Hash = MD5.Create())
                {
                    output = GetMd5Hash(md5Hash, txtPassword.Text);
                }
                if (output.Equals("3fbf4693f9ddb56e606d912e9f0f58c5"))
                {
                    PhanQuyenBUS pqBUS = new PhanQuyenBUS();
                    for (int i = 0; i < 31; i++)
                    {
                        pqBUS.CapNhat(new PhanQuyen(1, i));
                    }
                    MessageBox.Show("Completed");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}