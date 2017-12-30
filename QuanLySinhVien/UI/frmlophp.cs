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
    public partial class frmlophp : DevExpress.XtraEditors.XtraForm
    {
        LopHocPhanBUS lopHocPhanBUS = new LopHocPhanBUS();

        public frmlophp()
        {
            InitializeComponent();
        }

        private void frmlophp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatlophp_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmlophp_Load(object sender, EventArgs e)
        {
            gridLopHP.DataSource = lopHocPhanBUS.DanhSach();
        }

        private void btnthemlophp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbMaHPLopHP.Text) || cbbMaHPLopHP.SelectedValue == null)
            {
                MessageBox.Show("Mã học phần không tồn tại");
                return;
            }
            
        }

        private void btnsualophp_Click(object sender, EventArgs e)
        {
            if (gridLopHP.SelectedCells.Count <= 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(cbbMaHPLopHP.Text) || cbbMaHPLopHP.SelectedValue == null)
            {
                MessageBox.Show("Mã học phần không tồn tại");
                return;
            }

            
        }

        private void btnxoalophp_Click(object sender, EventArgs e)
        {
            if (gridLopHP.SelectedCells.Count <= 0)
            {
                return;
            }
        }
    }
}