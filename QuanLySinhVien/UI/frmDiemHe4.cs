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
    public partial class frmDiemHe4 : DevExpress.XtraEditors.XtraForm
    {
        private DiemHe4BUS diemhe4BUS = new DiemHe4BUS();
        private BindingSource bs = new BindingSource();
        public frmDiemHe4()
        {
            InitializeComponent();
        }
        private void LoadDB()
        {
            bs.DataSource = diemhe4BUS.DanhSach();

            gridviewxemdiem.DataSource = bs;

            txtDiemHe4So.DataBindings.Add("Text", bs, "DiemHe4So", false, DataSourceUpdateMode.Never);
            txtDiemHe4Chu.DataBindings.Add("Text", bs, "DiemHe4Chu", false, DataSourceUpdateMode.Never);
            txtDiemHe10Min.DataBindings.Add("Text", bs, "DiemHe10Min", false, DataSourceUpdateMode.Never);
            txtDiemHe10Max.DataBindings.Add("Text", bs, "DiemHe10Max", false, DataSourceUpdateMode.Never);
            txtXepLoaiHe4.DataBindings.Add("Text", bs, "XepLoai", false, DataSourceUpdateMode.Never);
            txtDanhGiaHe4.DataBindings.Add("Text", bs, "DanhGia", false, DataSourceUpdateMode.Never);

        }
        private void frmDiemHe4_Load(object sender, EventArgs e)
        {
            LoadDB();
        }
        private bool DuLieuHopLe()
        {
            if (string.IsNullOrEmpty(txtDiemHe4Chu.Text))
            {
                MessageBox.Show("Điểm hệ 4 chữ không được bỏ trống!");
                txtDiemHe4Chu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtXepLoaiHe4.Text))
            {
                MessageBox.Show("Xếp loại không được bỏ trống!");
                txtXepLoaiHe4.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDanhGiaHe4.Text))
            {
                MessageBox.Show("Đánh giá không được bỏ trống!");
                txtDanhGiaHe4.Focus();
                return false;
            }
            return true;
        }
        private void btnSuaHe4_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDiemHe4_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatHe4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemHe4_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }
            string diemhe4chu = txtDiemHe4Chu.Text;
            string xeploai = txtXepLoaiHe4.Text;
            string danhgia = txtDanhGiaHe4.Text;
            float diemhe4so = float.Parse(txtDiemHe4So.Text);
            float diemhe10min = float.Parse(txtDiemHe10Min.Text);
            float diemhe10max = float.Parse(txtDiemHe10Max.Text);
            DiemHe4 diemhe4 = new DiemHe4(diemhe4chu, diemhe4so, diemhe10min, diemhe10max, xeploai, danhgia);

            if (diemhe4BUS.Them(diemhe4))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = diemhe4BUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDiemHe4Chu.Focus();
        }

        private void btnXoaHe4_Click(object sender, EventArgs e)
        {
            if (gridviewxemdiem.SelectedCells.Count <= 0)
            {
                return;
            }
            string diemhe4chu = gridviewxemdiem.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            DiemHe4 diemhe4 = new DiemHe4();
            diemhe4.DiemHe4Chu = diemhe4chu;
            if (diemhe4BUS.Xoa(diemhe4))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = diemhe4BUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtDiemHe4Chu.Focus();
        }
    }
}