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
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        private NhomBUS nhomBUS = new NhomBUS();
        private QuyenBUS quyenBUS = new QuyenBUS();
        private PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();
        private DataTable bangPhanQuyen;

        private bool isSelectAll;
        private bool isDefault;
        private bool isRead;
        private bool isWrite;
        private bool isSystem;

        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            cbbGID.DataSource = nhomBUS.DanhSach();
            cbbGID.DisplayMember = "TenNhom";
            cbbGID.ValueMember = "GID";
            cbbGID.SelectedIndex = 0;

            clbPhanQuyen.DataSource = quyenBUS.DanhSach();
            clbPhanQuyen.DisplayMember = "Mota";
            clbPhanQuyen.ValueMember = "MaQuyen";

            bangPhanQuyen = phanQuyenBUS.DanhSach();

            PhanQuyenTheoGID();

            isSelectAll = false;
            isDefault = false;
            isRead = false;
            isWrite = false;
            isSystem = false;
        }

        private void PhanQuyenTheoGID()
        {
            if (cbbGID.SelectedValue == null)
            {
                return;
            }
            int gid = int.Parse(cbbGID.SelectedValue.ToString());

            List<int> danhsachquyen = new List<int>();
            for (int r = 0; r < bangPhanQuyen.Rows.Count; r++)
            {
                int id = int.Parse(bangPhanQuyen.Rows[r]["GID"].ToString());
                if (id == gid)
                {
                    int maquyen = int.Parse(bangPhanQuyen.Rows[r]["MaQuyen"].ToString());
                    danhsachquyen.Add(maquyen);
                }
            }

            clbPhanQuyen.UnCheckAll();
            for (int i = 0; i < danhsachquyen.Count; i++)
            {
                int index = danhsachquyen[i];
                clbPhanQuyen.SetItemChecked(index, true);
            }
        }

        private void btnOKPhanQuyen_Click(object sender, EventArgs e)
        {
            List<int> danhsachquyen = new List<int>();
            for (int i = 0; i < clbPhanQuyen.ItemCount; i++)
            {
                if (clbPhanQuyen.GetItemChecked(i))
                {
                    danhsachquyen.Add((int)clbPhanQuyen.GetItemValue(i));
                }
            }

            int gid = int.Parse(cbbGID.SelectedValue.ToString());

            phanQuyenBUS.Xoa(new PhanQuyen(gid, -1));
            bool thanhcong = false;
            foreach (int maquyen in danhsachquyen)
            {
                PhanQuyen phanQuyen = new PhanQuyen(gid, maquyen);
                thanhcong = phanQuyenBUS.CapNhat(phanQuyen);
            }
            if (thanhcong)
            {
                MessageBox.Show("Cập nhật thành công");
                bangPhanQuyen = phanQuyenBUS.DanhSach();
                PhanQuyenTheoGID();
                return;
            }
            else
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }

        private void btnThoatPhanQuyen_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbbGID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PhanQuyenTheoGID();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (clbPhanQuyen.ItemCount > 0)
            {
                if (isSelectAll)
                {
                    clbPhanQuyen.UnCheckAll();
                    isSelectAll = false;
                }
                else
                {
                    clbPhanQuyen.CheckAll();
                    isSelectAll = true;
                }
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            if (clbPhanQuyen.ItemCount > 0)
            {
                int[] danhsachquyen = { 0, 11, 12, 16, 20, 21, 22, 24, 29 };
                if (isDefault)
                {
                    isDefault = false;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isDefault);
                    }
                }
                else
                {
                    isDefault = true;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isDefault);
                    }
                }                
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (clbPhanQuyen.ItemCount > 0)
            {
                int[] danhsachquyen = { 0, 4, 8, 12, 16, 22 };
                if (isRead)
                {
                    isRead = false;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isRead);
                    }
                }
                else
                {
                    isRead = true;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isRead);
                    }
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (clbPhanQuyen.ItemCount > 0)
            {
                int[] danhsachquyen = { 1, 2, 3, 5, 6, 7, 9, 10, 11, 13, 14, 15, 17, 18, 19, 23 };
                if (isWrite)
                {
                    isWrite = false;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isWrite);
                    }
                }
                else
                {
                    isWrite = true;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isWrite);
                    }
                }
            }
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            if (clbPhanQuyen.ItemCount > 0)
            {
                int[] danhsachquyen = { 24, 25, 26, 27, 28 };
                if (isSystem)
                {
                    isSystem = false;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isSystem);
                    }
                }
                else
                {
                    isSystem = true;
                    foreach (int maquyen in danhsachquyen)
                    {
                        clbPhanQuyen.SetItemChecked(maquyen, isSystem);
                    }
                }
            }
        }

        private void frmPhanQuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }
    }
}