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
        private KhoaBUS khoaBUS = new KhoaBUS();
        private BindingSource bs = new BindingSource();

        public frmkhoa()
        {
            InitializeComponent();
        }

        private void LoadDB()
        {
            bs.DataSource = khoaBUS.DanhSach();

            gridviewkhoa.DataSource = bs;
            
            txtmakhoa.DataBindings.Add("Text", bs, "MaKhoa", false, DataSourceUpdateMode.Never);
            txttenkhoa.DataBindings.Add("Text", bs, "TenKhoa", false, DataSourceUpdateMode.Never);
            txtsdtkhoa.DataBindings.Add("Text", bs, "Sdt", false, DataSourceUpdateMode.Never);
            txtmailkhoa.DataBindings.Add("Text", bs, "Email", false, DataSourceUpdateMode.Never);
        }        

        private void frmkhoa_Load(object sender, EventArgs e)
        {
            LoadDB();
            PhanQuyen();
        }

        private void frmkhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private bool DuLieuHopLe()
        {
            if (string.IsNullOrEmpty(txtmakhoa.Text))
            {
                MessageBox.Show("Mã khoa không được bỏ trống!");
                txtmakhoa.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txttenkhoa.Text))
            {
                MessageBox.Show("Tên khoa không được bỏ trống!");
                txttenkhoa.Focus();
                return false;
            }

            return true;
        }

        #region Chức năng

        private void btnthemkhoa_Click(object sender, EventArgs e)
        {
            if (!DuLieuHopLe())
            {
                return;
            }

            string ma = txtmakhoa.Text;
            string ten = txttenkhoa.Text;
            string email = txtmailkhoa.Text;
            string sdt = txtsdtkhoa.Text;

            Khoa khoa = new Khoa(ma, ten, sdt, email);

            if (khoaBUS.Them(khoa))
            {
                MessageBox.Show("Thành công !");
                
                bs.DataSource = khoaBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi !","", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            txtmakhoa.Focus();
        }

        private void btnsuakhoa_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridviewkhoa.SelectedCells.Count <= 0)
            {
                return;
            }

            if (!DuLieuHopLe())
            {
                return;
            }

            string ma = gridviewkhoa.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            string ten = txttenkhoa.Text;
            string email = txtmailkhoa.Text;
            string sdt = txtsdtkhoa.Text;

            Khoa khoa = new Khoa(ma, ten, sdt, email);

            if (khoaBUS.Sua(khoa))
            {
                MessageBox.Show("Thành công");
                
                bs.DataSource = khoaBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }

            txtmakhoa.Focus();
        }

        private void btnxoakhoa_Click(object sender, EventArgs e)
        {
            //Nếu k có dòng nào trong gridview được chọn
            if (gridviewkhoa.SelectedCells.Count <= 0)
            {
                return;
            }
            string ma = gridviewkhoa.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            
            Khoa khoa = new Khoa();
            khoa.MaKhoa = ma;

            if (khoaBUS.Xoa(khoa))
            {
                MessageBox.Show("Thành công");
                
                bs.DataSource = khoaBUS.DanhSach();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }

            txtmakhoa.Focus();
        }

        private void btnthoatkhoa_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Phân quyền
        //Disable các button thêm, xóa, sửa
        private void DisableAll()
        {
            btnthemkhoa.Enabled = false;
            btnxoakhoa.Enabled = false;
            btnsuakhoa.Enabled = false;
        }

        private void PhanQuyen()
        {
            DisableAll();
            ChangePermission(frmmain.f_khoa);
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
                    btnthemkhoa.Enabled = true;
                    break;
                case 2:
                    //-x-
                    btnxoakhoa.Enabled = true;
                    break;
                case 4:
                    //--s
                    btnsuakhoa.Enabled = true;
                    break;
                case 3:
                    //tx-
                    btnthemkhoa.Enabled = true;
                    btnxoakhoa.Enabled = true;
                    break;
                case 5:
                    //t-s
                    btnthemkhoa.Enabled = true;
                    btnsuakhoa.Enabled = true;
                    break;
                case 6:
                    //-xs
                    btnxoakhoa.Enabled = true;
                    btnsuakhoa.Enabled = true;
                    break;
                case 7:
                    //txs
                    btnthemkhoa.Enabled = true;
                    btnxoakhoa.Enabled = true;
                    btnsuakhoa.Enabled = true;
                    break;
            }
        }
#endregion
    }
}
