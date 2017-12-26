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
    public partial class frmlopkhoahoc : DevExpress.XtraEditors.XtraForm
    {
        public frmlopkhoahoc()
        {
            InitializeComponent();
        }

        private void frmlopkhoahoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatlopkh_Click(object sender, EventArgs e)
        {
            Close();
        }

        LopKhoaHocBUS lopKhoaHocBUS = new LopKhoaHocBUS();

        private void LoadDB()
        {
            gridviewlopkh.DataSource = lopKhoaHocBUS.DanhSach();
        }

        private void frmlopkhoahoc_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnthemlopkh_Click(object sender, EventArgs e)
        {
            string ma = txtmalopkhoahoc.Text;
            string ten = cbbTenKhoaLopKH.Text;

            LopKhoaHoc lopKhoaHoc = new LopKhoaHoc(ma, ten);
            bool thanhcong = lopKhoaHocBUS.Them(lopKhoaHoc);
            if (thanhcong)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDB();
        }
    }
}