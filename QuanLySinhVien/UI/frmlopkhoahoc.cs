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

        BindingSource bs = new BindingSource();
        LopKhoaHocBUS lopKhoaHocBUS = new LopKhoaHocBUS();
        KhoaBUS khoaBUS = new KhoaBUS();
  
        private void LoadDB()
        {
            bs.DataSource = lopKhoaHocBUS.DanhSach();
            gridviewlopkh.DataSource = bs;

            cbbTenKhoaLopKH.DataSource = khoaBUS.DanhSach();
            cbbTenKhoaLopKH.DisplayMember = "TenKhoa";
            cbbTenKhoaLopKH.ValueMember = "MaKhoa";

            txtmalopkhoahoc.DataBindings.Add("Text", bs, "MaLop", false, DataSourceUpdateMode.Never);
            cbbTenKhoaLopKH.DataBindings.Add("SelectedValue", bs, "MaKhoa");
        }

        private void frmlopkhoahoc_Load(object sender, EventArgs e)
        {
            LoadDB();

            cbbTenKhoaLopKH.AutoCompleteCustomSource = LoadAutoComplete();
        }

        public AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = khoaBUS.DanhSach();
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["TenKhoa"]));
            }
            return stringCol;
        }

        private bool IsNull(string input)
        {
            if (string.IsNullOrEmpty(input.Trim(' ')))
            {
                return true;
            }
            return false;
        }

        private void btnthemlopkh_Click(object sender, EventArgs e)
        {
            bool isNull = IsNull(cbbTenKhoaLopKH.Text);
            if (isNull)
            {
                MessageBox.Show("Mã khoa không được để trống");
                return;
            }

            string malop = txtmalopkhoahoc.Text;
            string makhoa = cbbTenKhoaLopKH.SelectedValue.ToString();

            LopKhoaHoc lopKhoaHoc = new LopKhoaHoc(malop,makhoa);

            bool thanhcong = lopKhoaHocBUS.Them(lopKhoaHoc);
            if (thanhcong)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bs.DataSource = lopKhoaHocBUS.DanhSach();
            txtmalopkhoahoc.Focus();
        }

        private void btnsualopkh_Click(object sender, EventArgs e)
        {
            if (gridviewlopkh.SelectedCells.Count <= 0)
            {
                return;
            }
            bool isNull = IsNull(cbbTenKhoaLopKH.Text);
            if (isNull)
            {
                MessageBox.Show("Mã khoa không được để trống");
                return;
            }

            string malop = gridviewlopkh.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            if (cbbTenKhoaLopKH.SelectedValue == null)
            {
                MessageBox.Show("Khoa không tồn tại");
                return;
            }
            string makhoa = cbbTenKhoaLopKH.SelectedValue.ToString();

            LopKhoaHoc lopKhoaHoc = new LopKhoaHoc(malop, makhoa);
            bool thanhcong = lopKhoaHocBUS.Sua(lopKhoaHoc);
            if(thanhcong)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bs.DataSource = lopKhoaHocBUS.DanhSach();
            txtmalopkhoahoc.Focus();
        }

        private void btnxoalopkh_Click(object sender, EventArgs e)
        {
            if (gridviewlopkh.SelectedCells.Count <= 0)
            {
                return;
            }
            string malop = gridviewlopkh.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            LopKhoaHoc lopKhoaHoc = new LopKhoaHoc();
            lopKhoaHoc.MaLop = malop;
            bool thanhcong = lopKhoaHocBUS.Xoa(lopKhoaHoc);
            if (thanhcong)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bs.DataSource = lopKhoaHocBUS.DanhSach();
           

        }
    }
}