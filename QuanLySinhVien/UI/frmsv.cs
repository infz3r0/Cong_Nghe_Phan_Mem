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

        private bool IsNull(string input)
        {
            if (string.IsNullOrEmpty(input.Trim(' ')))
            {
                return true;
            }
            return false;
        }

        private void frmsv_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }


        SinhVienBUS sinhvienBUS = new SinhVienBUS();
        LopKhoaHocBUS lopkhoahocBUS = new LopKhoaHocBUS();
        BindingSource bs = new BindingSource();

        private void LoadDB()
        {

            bs.DataSource = sinhvienBUS.DanhSach();
            gridviewsv.DataSource = bs;


            txtmssv.DataBindings.Add("Text", bs, "MaSV", false, DataSourceUpdateMode.Never);
            txttensv.DataBindings.Add("Text", bs, "HoTen", false, DataSourceUpdateMode.Never);
            ngaysinhsv.DataBindings.Add("Value", bs, "NgaySinh", false, DataSourceUpdateMode.Never);

            cbbGioiTinh.DataBindings.Add("SelectedValue", bs, "GioiTinh");
            txtdicchisv.DataBindings.Add("Text", bs, "DiaChi", false, DataSourceUpdateMode.Never);
            txtcmndsv.DataBindings.Add("Text", bs, "SoCMND", false, DataSourceUpdateMode.Never);
            txtdienthoaisv.DataBindings.Add("Text", bs, "Sdt", false, DataSourceUpdateMode.Never);
            txtmailsv.DataBindings.Add("Text", bs, "Email", false, DataSourceUpdateMode.Never);

            cbbMaLopSV.DataSource = lopkhoahocBUS.DanhSach();
            cbbMaLopSV.DisplayMember = "MaLop";
            cbbMaLopSV.ValueMember = "MaLop";
            cbbMaLopSV.DataBindings.Add("SelectedValue", bs, "MaLop");

        }

        private DataTable GioiTinhTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Value");

            DataRow row;
            row = dt.NewRow();
            row["Text"] = "Nam";
            row["Value"] = "M";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Text"] = "Nữ";
            row["Value"] = "F";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Text"] = "Khác";
            row["Value"] = "O";
            dt.Rows.Add(row);

            return dt;
        }

        public AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = lopkhoahocBUS.DanhSach();
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["MaLop"]));
            }
            return stringCol;
        }

        private void frmsv_Load(object sender, EventArgs e)
        {
            cbbMaLopSV.AutoCompleteCustomSource = LoadAutoComplete();
            DataTable gtTable = GioiTinhTable();

            cbbGioiTinh.DataSource = gtTable;
            cbbGioiTinh.ValueMember = "Value";
            cbbGioiTinh.DisplayMember = "Text";
            LoadDB();

            PhanQuyen();
        }

        private bool DuLieuHopLe()
        {
            if (string.IsNullOrEmpty(txtmssv.Text))
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống!");
                txtmssv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txttensv.Text))
            {
                MessageBox.Show("Tên sinh viên không được bỏ trống!");
                txttensv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbbMaLopSV.Text) || cbbMaLopSV.SelectedValue == null)
            {
                MessageBox.Show("Lớp không tồn tại!");
                cbbMaLopSV.Focus();
                return false;
            }
            return true;
        }

        #region Chức năng
        private void btnthemsv_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }

            string masv = txtmssv.Text;
            string hoten = txttensv.Text;
            DateTime ngaysinh = ngaysinhsv.Value;
            char gt = char.Parse(cbbGioiTinh.SelectedValue.ToString());
            string diachi = txtdicchisv.Text;
            string cmnd = txtcmndsv.Text;
            string sdt = txtdienthoaisv.Text;
            string mail = txtmailsv.Text;
            string malop = cbbMaLopSV.SelectedValue.ToString();

            SinhVien sv = new SinhVien(masv, hoten, ngaysinh, gt, diachi, cmnd, sdt, mail, 0, malop, null);

            bool thanhcong = sinhvienBUS.Them(sv);

            if (thanhcong)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            bs.DataSource = sinhvienBUS.DanhSach();
        }

        private void btnsuasv_Click(object sender, EventArgs e)
        {
            if (gridviewsv.SelectedCells.Count <= 0)
            {
                return;
            }
            if (!DuLieuHopLe())
            {
                return;
            }

            string masv = gridviewsv.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string hoten = txttensv.Text;
            DateTime ngaysinh = ngaysinhsv.Value;
            char gt = char.Parse(cbbGioiTinh.SelectedValue.ToString());
            string diachi = txtdicchisv.Text;
            string cmnd = txtcmndsv.Text;
            string sdt = txtdienthoaisv.Text;
            string mail = txtmailsv.Text;
            string malop = cbbMaLopSV.SelectedValue.ToString();

            SinhVien sv = new SinhVien(masv, hoten, ngaysinh, gt, diachi, cmnd, sdt, mail, 0, malop, null);

            bool thanhcong = sinhvienBUS.Sua(sv);

            if (thanhcong)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtmssv.Focus();
            bs.DataSource = sinhvienBUS.DanhSach();
        }

        private void btnxoasv_Click(object sender, EventArgs e)
        {
            if (gridviewsv.SelectedCells.Count <= 0)
            {
                return;
            }
            string masv = gridviewsv.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            SinhVien sv = new SinhVien();
            sv.MaSV = masv;
            bool thanhcong = sinhvienBUS.Xoa(sv);
            if (thanhcong)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bs.DataSource = sinhvienBUS.DanhSach();

        }

        private void btnthoatsv_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Phân quyền
        private void DisableAll()
        {
            btnthemsv.Enabled = false;
            btnxoasv.Enabled = false;
            btnsuasv.Enabled = false;
        }

        private void PhanQuyen()
        {
            DisableAll();
            ChangePermission(frmmain.f_sinhVien);
        }

        private void ChangePermission(int value)
        {
            //t: Thêm
            //x: Xóa
            //s: Sửa
            switch (value)
            {
                case 0:
                    //---
                    break;
                case 1:
                    //t--
                    btnthemsv.Enabled = true;
                    break;
                case 2:
                    //-x-
                    btnxoasv.Enabled = true;
                    break;
                case 4:
                    //--s
                    btnsuasv.Enabled = true;
                    break;
                case 3:
                    //tx-
                    btnthemsv.Enabled = true;
                    btnxoasv.Enabled = true;
                    break;
                case 5:
                    //t-s
                    btnthemsv.Enabled = true;
                    btnsuasv.Enabled = true;
                    break;
                case 6:
                    //-xs
                    btnxoasv.Enabled = true;
                    btnsuasv.Enabled = true;
                    break;
                case 7:
                    //txs
                    btnthemsv.Enabled = true;
                    btnxoasv.Enabled = true;
                    btnsuasv.Enabled = true;
                    break;
            }
        }
        #endregion
    }
}