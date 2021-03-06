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
    public partial class frmmonhoc : DevExpress.XtraEditors.XtraForm
    {
        private MonHocBUS monhocBUS = new MonHocBUS();
        private BindingSource bs = new BindingSource();

        public frmmonhoc()
        {
            InitializeComponent();
        }

        private void LoadDB()
        {
            bs.DataSource = monhocBUS.DanhSach();

            gridviewhp.DataSource = bs;

            txtmahp.DataBindings.Add("Text", bs, "MaHP", false, DataSourceUpdateMode.Never);
            txttenhp.DataBindings.Add("Text", bs, "TenHP", false, DataSourceUpdateMode.Never);
            txtstchp.DataBindings.Add("Text", bs, "SoTinChi", false, DataSourceUpdateMode.Never);
            cbbLoaiHocPhan.DataBindings.Add("SelectedItem", bs, "LoaiHP");
            txtTrongSoDQT.DataBindings.Add("Text", bs, "TrongSoDQT", false, DataSourceUpdateMode.Never);
            txtTrongSoDThi.DataBindings.Add("Text", bs, "TrongSoDThi", false, DataSourceUpdateMode.Never);

        }

        private void frmmonhoc_Load(object sender, EventArgs e)
        {
            LoadDB();

            cbbLoaiHocPhan.SelectedIndex = 0;

            PhanQuyen();
        }

        private void frmmonhoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private bool DuLieuHopLe()
        {
            if (string.IsNullOrEmpty(txtmahp.Text))
            {
                MessageBox.Show("Mã học phần không được bỏ trống!");
                txtmahp.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txttenhp.Text))
            {
                MessageBox.Show("Tên học phần không được bỏ trống!");
                txttenhp.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTrongSoDQT.Text))
            {
                MessageBox.Show("Trọng số điểm quá trình không được bỏ trống!");
                txtTrongSoDQT.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTrongSoDThi.Text))
            {
                MessageBox.Show("Trọng số điểm thi không được bỏ trống!");
                txtTrongSoDThi.Focus();
                return false;
            }

            return true;
        }

        #region Chức năng
        private void btnthemhp_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }

            string mahp = txtmahp.Text;
            string tenhp = txttenhp.Text;
            int stc = string.IsNullOrEmpty(txtstchp.Text) ? 0 : int.Parse(txtstchp.Text);
            string loaihp = cbbLoaiHocPhan.Text;
            decimal tsdqt = decimal.Parse(txtTrongSoDQT.Text);
            decimal tsdt = decimal.Parse(txtTrongSoDThi.Text);

            MonHoc monhoc = new MonHoc(mahp, tenhp, stc, loaihp, tsdqt, tsdt);
            
            if (monhocBUS.Them(monhoc))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = monhocBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmahp.Focus();
        }

        private void btnsuahp_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridviewhp.SelectedCells.Count <= 0)
            {
                return;
            }

            if (!DuLieuHopLe())
            {
                return;
            }

            string mahp = gridviewhp.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string tenhp = txttenhp.Text;
            int stc = string.IsNullOrEmpty(txtstchp.Text) ? 0 : int.Parse(txtstchp.Text);
            string loaihp = cbbLoaiHocPhan.Text;
            decimal tsdqt = decimal.Parse(txtTrongSoDQT.Text);
            decimal tsdt = decimal.Parse(txtTrongSoDThi.Text);

            MonHoc monhoc = new MonHoc(mahp, tenhp, stc, loaihp, tsdqt, tsdt);

            if (monhocBUS.Sua(monhoc))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = monhocBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmahp.Focus();
        }

        private void btnxoahp_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridviewhp.SelectedCells.Count <= 0)
            {
                return;
            }

            string mahp = gridviewhp.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            MonHoc monhoc = new MonHoc();
            monhoc.MaHP = mahp;

            if (monhocBUS.Xoa(monhoc))
            {
                MessageBox.Show("Thành công !");

                bs.DataSource = monhocBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtmahp.Focus();
        }

        private void btnthoathp_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Phân quyền
        //Disable các button thêm, xóa, sửa
        private void DisableAll()
        {
            btnthemhp.Enabled = false;
            btnxoahp.Enabled = false;
            btnsuahp.Enabled = false;
        }

        private void PhanQuyen()
        {
            DisableAll();
            ChangePermission(frmmain.f_monHoc);
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
                    btnthemhp.Enabled = true;
                    break;
                case 2:
                    //-x-
                    btnxoahp.Enabled = true;
                    break;
                case 4:
                    //--s
                    btnsuahp.Enabled = true;
                    break;
                case 3:
                    //tx-
                    btnthemhp.Enabled = true;
                    btnxoahp.Enabled = true;
                    break;
                case 5:
                    //t-s
                    btnthemhp.Enabled = true;
                    btnsuahp.Enabled = true;
                    break;
                case 6:
                    //-xs
                    btnxoahp.Enabled = true;
                    btnsuahp.Enabled = true;
                    break;
                case 7:
                    //txs
                    btnthemhp.Enabled = true;
                    btnxoahp.Enabled = true;
                    btnsuahp.Enabled = true;
                    break;
            }
        }
        #endregion
    }
}