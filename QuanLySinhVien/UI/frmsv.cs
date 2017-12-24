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
    public partial class frmsv : DevExpress.XtraEditors.XtraForm
    {
        public frmsv()
        {
            InitializeComponent();
        }

        private void frmsv_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatsv_Click(object sender, EventArgs e)
        {
            Close();
        }

        SinhVienBUS sinhvienBUS = new SinhVienBUS();
        private void frmsv_Load(object sender, EventArgs e)
        {
            gridviewsv.DataSource = sinhvienBUS.DanhSach();
        }
    }
}