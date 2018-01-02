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

using BUS_Tier;
using MODEL_Tier;

namespace UI_Tier
{
    public partial class frmdoipass : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public frmdoipass()
        {
            InitializeComponent();
        }

        private void frmdoipass_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatdoipass_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmdoipass_Load(object sender, EventArgs e)
        {
            txtsuausename.Text = frmmain.username;
        }

        private void btnokdoipass_Click(object sender, EventArgs e)
        {
            string username = txtsuausename.Text;
            string oldpass = txtmkcu.Text;
            string password1 = txtmkmoi.Text;
            string password2 = txtNhapLaiMK.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên tài khoản không được để trống");
                txtsuausename.Focus();
                return;
            }
            if (string.IsNullOrEmpty(oldpass) || string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Password không được để trống");
                txtmkcu.Focus();
                return;
            }
            if (!password1.Equals(password2))
            {
                MessageBox.Show("Password không trùng khớp");
                txtmkmoi.Focus();
                return;
            }

            TaiKhoan old = new TaiKhoan(username, oldpass, -1);
            TaiKhoan taiKhoan = new TaiKhoan(username, password1, 0);

            if (taiKhoanBUS.DoiPassword(old, taiKhoan))
            {
                MessageBox.Show("Thành công");
                txtmkcu.ResetText();
                txtmkmoi.ResetText();
                txtNhapLaiMK.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            txtmkcu.Focus();
        }
    }
}