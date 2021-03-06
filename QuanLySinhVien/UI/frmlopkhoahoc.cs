﻿using System;
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
        private BindingSource bs = new BindingSource();
        private LopKhoaHocBUS lopKhoaHocBUS = new LopKhoaHocBUS();
        private KhoaBUS khoaBUS = new KhoaBUS();

        public frmlopkhoahoc()
        {
            InitializeComponent();
        }

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

            PhanQuyen();
        }

        private void frmlopkhoahoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        //Danh sách chuỗi dùng cho thuộc tính AutoCompleteCustomSource
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

        private bool DuLieuHopLe()
        {
            if (string.IsNullOrEmpty(txtmalopkhoahoc.Text))
            {
                MessageBox.Show("Mã lớp không được bỏ trống!");
                txtmalopkhoahoc.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbbTenKhoaLopKH.Text) || cbbTenKhoaLopKH.SelectedValue == null)
            {
                MessageBox.Show("Tên khoa không được bỏ trống!");
                cbbTenKhoaLopKH.Focus();
                return false;
            }

            return true;
        }

        #region Chức năng
        private void btnthemlopkh_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }
            string malop = txtmalopkhoahoc.Text;
            string makhoa = cbbTenKhoaLopKH.SelectedValue.ToString();

            LopKhoaHoc lopKhoaHoc = new LopKhoaHoc(malop, makhoa);

            bool thanhcong = lopKhoaHocBUS.Them(lopKhoaHoc);
            if (thanhcong)
            {
                MessageBox.Show("Thành công !");
                
                bs.DataSource = lopKhoaHocBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            txtmalopkhoahoc.Focus();
        }

        private void btnsualopkh_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridviewlopkh.SelectedCells.Count <= 0)
            {
                return;
            }

            if (!DuLieuHopLe())
            {
                return;
            }

            if (cbbTenKhoaLopKH.SelectedValue == null)
            {
                MessageBox.Show("Khoa không tồn tại");
                return;
            }

            string malop = gridviewlopkh.SelectedCells[0].OwningRow.Cells[0].Value.ToString();           
            string makhoa = cbbTenKhoaLopKH.SelectedValue.ToString();

            LopKhoaHoc lopKhoaHoc = new LopKhoaHoc(malop, makhoa);
            
            if (lopKhoaHocBUS.Sua(lopKhoaHoc))
            {
                MessageBox.Show("Thành công !");
                
                bs.DataSource = lopKhoaHocBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmalopkhoahoc.Focus();
        }

        private void btnxoalopkh_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridviewlopkh.SelectedCells.Count <= 0)
            {
                return;
            }

            string malop = gridviewlopkh.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            LopKhoaHoc lopKhoaHoc = new LopKhoaHoc();
            lopKhoaHoc.MaLop = malop;

            if (lopKhoaHocBUS.Xoa(lopKhoaHoc))
            {
                MessageBox.Show("Thành công !");
                
                bs.DataSource = lopKhoaHocBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmalopkhoahoc.Focus();
        }

        private void btnthoatlopkh_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Phân quyền
        //Disable các button thêm, xóa, sửa
        private void DisableAll()
        {
            btnthemlopkh.Enabled = false;
            btnxoalopkh.Enabled = false;
            btnsualopkh.Enabled = false;
        }

        private void PhanQuyen()
        {
            DisableAll();
            ChangePermission(frmmain.f_lopKhoaHoc);
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
                    btnthemlopkh.Enabled = true;
                    break;
                case 2:
                    //-x-
                    btnxoalopkh.Enabled = true;
                    break;
                case 4:
                    //--s
                    btnsualopkh.Enabled = true;
                    break;
                case 3:
                    //tx-
                    btnthemlopkh.Enabled = true;
                    btnxoalopkh.Enabled = true;
                    break;
                case 5:
                    //t-s
                    btnthemlopkh.Enabled = true;
                    btnsualopkh.Enabled = true;
                    break;
                case 6:
                    //-xs
                    btnxoalopkh.Enabled = true;
                    btnsualopkh.Enabled = true;
                    break;
                case 7:
                    //txs
                    btnthemlopkh.Enabled = true;
                    btnxoalopkh.Enabled = true;
                    btnsualopkh.Enabled = true;
                    break;
            }
        }
        #endregion
    }
}