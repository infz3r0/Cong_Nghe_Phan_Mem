﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmkhoa : Form
    {
        public frmkhoa()
        {
            InitializeComponent();
        }

        private void txtmakhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthoatkhoa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmkhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }
    }
}