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

namespace UI_Tier
{
    public partial class frmdangnhap : DevExpress.XtraEditors.XtraForm
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void hyperlinkLabeCntrol1_Click(object sender, EventArgs e)
        {

        }

        private void hypertextdk_Click(object sender, EventArgs e)
        {
            frmdangki f = new frmdangki();
            f.ShowDialog();
        }

        private void btnhthoatdangnhap_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }
    }
}