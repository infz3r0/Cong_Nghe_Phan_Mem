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
    public partial class frmlophp : DevExpress.XtraEditors.XtraForm
    {
        private LopHocPhanBUS lopHocPhanBUS = new LopHocPhanBUS();
        private LopHocPhanBUS lophpBUS = new LopHocPhanBUS();
        private MonHocBUS monhocBUS = new MonHocBUS();
        private DanhSachLopHPBUS danhsachlophpBUS = new DanhSachLopHPBUS();
        private BindingSource bs = new BindingSource();

        public frmlophp()
        {
            InitializeComponent();
        }

        private void LoadDB()
        {
            bs.DataSource = lophpBUS.DanhSach();
            gridLopHP.DataSource = bs;

            txtmalophp.DataBindings.Add("Text", bs, "MaLopHP");
            txtSLSVLopHP.DataBindings.Add("Text", bs, "SoLuongSV");

            cbbMaHPLopHP.DataSource = monhocBUS.DanhSach();
            cbbMaHPLopHP.DisplayMember = "TenHP";
            cbbMaHPLopHP.ValueMember = "MaHP";
            cbbMaHPLopHP.DataBindings.Add("SelectedValue", bs, "MaHP");

            /*cbbLopTruong.DataSource = danhsachlophpBUS.DanhSach();
            cbbLopTruong.DisplayMember = "MaSV";
            cbbLopTruong.ValueMember = "MaSV";*/
        }

        //Danh sách chuỗi dùng cho thuộc tính AutoCompleteCustomSource
        public AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = monhocBUS.DanhSach();
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["TenHP"]));
            }
            return stringCol;
        }

        private void frmlophp_Load(object sender, EventArgs e)
        {
            LoadDB();

            cbbMaHPLopHP.AutoCompleteCustomSource = LoadAutoComplete();

            PhanQuyen();
        }

        private void frmlophp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private bool DuLieuHopLe()
        {
            if (string.IsNullOrEmpty(txtmalophp.Text))
            {
                MessageBox.Show("Mã lớp không được để trống");
                txtmalophp.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbbMaHPLopHP.Text) || cbbMaHPLopHP.SelectedValue == null)
            {
                MessageBox.Show("Mã học phần không tồn tại");
                cbbMaHPLopHP.Focus();
                return false;
            }

            return true;
        }

        #region Chức năng
        private void btnthemlophp_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }

            string malophp = txtmalophp.Text;
            string mahp = cbbMaHPLopHP.SelectedValue.ToString();

            LopHocPhan lophp = new LopHocPhan(malophp, mahp, null);
            lophp.SoLuongSV = 0;
            
            if (lophpBUS.Them(lophp))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = lophpBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmalophp.Focus();

        }

        private void btnsualophp_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridLopHP.SelectedCells.Count <= 0)
            {
                return;
            }

            if (!DuLieuHopLe())
            {
                return;
            }

            string malophp = gridLopHP.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string mahp = cbbMaHPLopHP.SelectedValue.ToString();
            //string loptruong = cbbLopTruong.SelectedValue.ToString();

            LopHocPhan lophp = new LopHocPhan(malophp, mahp, null);
            
            if (lophpBUS.Sua(lophp))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = lophpBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmalophp.Focus();
        }

        private void btnxoalophp_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridLopHP.SelectedCells.Count <= 0)
            {
                return;
            }

            string malophp = gridLopHP.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            LopHocPhan lophp = new LopHocPhan();
            lophp.MaLopHP = malophp;
            
            if (lophpBUS.Xoa(lophp))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = lophpBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmalophp.Focus();
        }

        private void btnthoatlophp_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Phân quyền
        //Disable các button thêm, xóa, sửa
        private void DisableAll()
        {
            btnthemlophp.Enabled = false;
            btnxoalophp.Enabled = false;
            btnsualophp.Enabled = false;
        }

        private void PhanQuyen()
        {
            DisableAll();
            ChangePermission(frmmain.f_lopHocPhan);
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
                    btnthemlophp.Enabled = true;
                    break;
                case 2:
                    //-x-
                    btnxoalophp.Enabled = true;
                    break;
                case 4:
                    //--s
                    btnsualophp.Enabled = true;
                    break;
                case 3:
                    //tx-
                    btnthemlophp.Enabled = true;
                    btnxoalophp.Enabled = true;
                    break;
                case 5:
                    //t-s
                    btnthemlophp.Enabled = true;
                    btnsualophp.Enabled = true;
                    break;
                case 6:
                    //-xs
                    btnxoalophp.Enabled = true;
                    btnsualophp.Enabled = true;
                    break;
                case 7:
                    //txs
                    btnthemlophp.Enabled = true;
                    btnxoalophp.Enabled = true;
                    btnsualophp.Enabled = true;
                    break;
            }
        }
        #endregion
    }
}