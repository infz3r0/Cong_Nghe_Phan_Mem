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

namespace UI_Tier
{
    public partial class frmDiemHe4 : DevExpress.XtraEditors.XtraForm
    {
        public frmDiemHe4()
        {
            InitializeComponent();
        }

        private void btnSuaHe4_Click(object sender, EventArgs e)
        {

        }

        private void btnthoaHe4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDiemHe4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }
    }
}