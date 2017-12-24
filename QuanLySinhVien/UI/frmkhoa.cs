using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_Tier;
using MODEL_Tier;

namespace UI_Tier
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

        KhoaBUS khoaBUS = new KhoaBUS();
        BindingSource bs = new BindingSource();
        private void LoadDB()
        {
            bs.DataSource = khoaBUS.DanhSach();
            gridviewkhoa.DataSource = bs;
            txtmakhoa.DataBindings.Add("Text", bs, "MaKhoa");
            txttenkhoa.DataBindings.Add("Text", bs, "TenKhoa");
            txtsdtkhoa.DataBindings.Add("Text", bs, "Sdt");
            txtmailkhoa.DataBindings.Add("Text", bs, "Email");
        }
        
        private void frmkhoa_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnthemkhoa_Click(object sender, EventArgs e)
        {
            string ma = txtmakhoa.Text;
            string ten = txttenkhoa.Text;
            string email = txtmailkhoa.Text;
            string sdt = txtsdtkhoa.Text;

            Khoa khoa = new Khoa(ma, ten, sdt, email);
            bool thanhcong = khoaBUS.Them(khoa);
            if (thanhcong)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            bs.DataSource = khoaBUS.DanhSach();
        }

        private void btnsuakhoa_Click(object sender, EventArgs e)
        {
            string ma = gridviewkhoa.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string ten = txttenkhoa.Text;
            string email = txtmailkhoa.Text;
            string sdt = txtsdtkhoa.Text;

            Khoa khoa = new Khoa(ma, ten, sdt, email);
            bool thanhcong = khoaBUS.Sua(khoa);
            if (thanhcong)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            bs.DataSource = khoaBUS.DanhSach();
        }

        private void btnxoakhoa_Click(object sender, EventArgs e)
        {
            string ma = gridviewkhoa.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            
            Khoa khoa = new Khoa();
            khoa.MaKhoa = ma;
            bool thanhcong = khoaBUS.Xoa(khoa);
            if (thanhcong)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            bs.DataSource = khoaBUS.DanhSach();
        }
    }
}
