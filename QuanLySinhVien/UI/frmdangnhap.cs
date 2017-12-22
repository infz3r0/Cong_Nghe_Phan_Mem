﻿using System;
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
                Application.Exit();
            }
            else
            {
                frmmain.username = txtusename.Text;
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
                Dispose();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}