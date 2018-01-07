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
    public partial class frmtracuu : DevExpress.XtraEditors.XtraForm
    {
        SinhVienBUS sinhVienBUS = new SinhVienBUS();

        public frmtracuu()
        {
            InitializeComponent();
        }

        private void frmtracuu_Load(object sender, EventArgs e)
        {

        }

        private void frmtracuu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatracuu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntracuu_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            bool isNumber = true;
            bool isString = true;

            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            for (int i=0; i < input.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    isString = false;
                }
            }

            for (int i=0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    isNumber = false;
                }
            }

            if (isNumber)
            {
                gridviewtracuu.DataSource = sinhVienBUS.TimKiemTheoMaSV(input);
            }
            if (isString)
            {
                gridviewtracuu.DataSource = sinhVienBUS.TimKiemTheoTen(input);
            }
        }
    }
}