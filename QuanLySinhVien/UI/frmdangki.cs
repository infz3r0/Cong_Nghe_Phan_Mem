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
    public partial class frmdangki : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        NhomBUS nhomBUS = new NhomBUS();

        public frmdangki()
        {
            InitializeComponent();
        }

        private void frmdangki_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng From?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatdk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            string username = txtusenamedk.Text;
            string password1 = txtmkdk.Text;
            string password2 = txtnhaplaimkdk.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Tên tài khoản không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Password không được để trống");
                return;
            }
            if (!password1.Equals(password2))
            {
                MessageBox.Show("Password không trùng khớp");
                return;
            }
            if (cbbGID.SelectedValue == null)
            {
                return;
            }

            int gid = int.Parse(cbbGID.SelectedValue.ToString());

            TaiKhoan taiKhoan = new TaiKhoan(username, password1, gid);

            if(taiKhoanBUS.DangKi(taiKhoan))
            {
                MessageBox.Show("Thành công");
                txtusenamedk.ResetText();
                txtmkdk.ResetText();
                txtnhaplaimkdk.ResetText();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            txtusenamedk.Focus();
        }

        private void frmdangki_Load(object sender, EventArgs e)
        {
            cbbGID.DataSource = nhomBUS.DanhSach();
            cbbGID.DisplayMember = "TenNhom";
            cbbGID.ValueMember = "GID";
        }
    }
}