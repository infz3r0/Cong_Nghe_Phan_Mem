using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Threading;

using BUS_Tier;
using MODEL_Tier;

namespace UI_Tier
{
    public partial class frmmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        PhanQuyenBUS phanQuyenBUS = new PhanQuyenBUS();

        public static string username;
        public static int gid;
        private bool exit_dangnhap;

        #region biến phân quyền
        public static int f_khoa;
        public static int f_lopKhoaHoc;
        public static int f_sinhVien;
        public static int f_monHoc;
        public static int f_lopHocPhan;

        public static int f_diem;
        public static int f_traCuu;
        public static int f_thongKe;

        public static int f_doiPassword;
        public static int f_dangKiTK;
        public static int f_heThong;
        #endregion

        public frmmain()
        {
            InitializeComponent();
            username = "";
            exit_dangnhap = false;
        }

        private void InitPermission()
        {
            f_khoa = 0;
            f_lopKhoaHoc = 0;
            f_sinhVien = 0;
            f_monHoc = 0;
            f_lopHocPhan = 0;

            f_diem = 0;
            f_traCuu = 0;
            f_thongKe = 0;

            f_doiPassword = 0;
            f_dangKiTK = 0;
            f_heThong = 0;
        }

        private void DisableAll()
        {
            navBarItem1.Enabled = false;
            navBarItem2.Enabled = false;
            navBarItem3.Enabled = false;
            navBarItem4.Enabled = false;
            navBarItem5.Enabled = false;
            navBarItem13.Enabled = false;

            navBarItem6.Enabled = false;
            navBarItem7.Enabled = false;

            navBarItem8.Enabled = false;

            navBarItem9.Enabled = false;

            navBarItem11.Enabled = false;
            navBarItem12.Enabled = false;
            navBarItem12.Visible = false;
            navBarItem16.Enabled = false;
            navBarItem16.Visible = false;


            navBarItem14.Enabled = false;
            navBarItem14.Visible = false;
            navBarItem15.Enabled = false;
        }

        private void PhanQuyen()
        {
            DisableAll();
            InitPermission();
            DataTable dsQuyen = phanQuyenBUS.DanhSachQuyenTheoGID(gid);
            ChangePermission(dsQuyen);
        }

        private void OpenFormDangNhap()
        {
            frmdangnhap f = new frmdangnhap();
            DialogResult dlr = f.ShowDialog(this);
            txtusername.EditValue = username;
            if (dlr == DialogResult.Yes)
            {
                exit_dangnhap = true;
                Application.Exit();
            }
            PhanQuyen();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    Console.WriteLine(exc.ToString());
                }
            }

            OpenFormDangNhap();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit_dangnhap)
            {
                return;
            }

            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnthoatmain_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Các chức năng

        private void navBarItem1_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmkhoa));
            if (frm == null)
            {
                frmkhoa forms = new frmkhoa();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmlopkhoahoc));
            if (frm == null)
            {
                frmlopkhoahoc forms = new frmlopkhoahoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmlophp));
            if (frm == null)
            {
                frmlophp forms = new frmlophp();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmsv));
            if (frm == null)
            {
                frmsv forms = new frmsv();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmmonhoc));
            if (frm == null)
            {
                frmmonhoc forms = new frmmonhoc();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmnhapdiem));
            if (frm == null)
            {
                frmnhapdiem forms = new frmnhapdiem();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmxemdiem));
            if (frm == null)
            {
                frmxemdiem forms = new frmxemdiem();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmtracuu));
            if (frm == null)
            {
                frmtracuu forms = new frmtracuu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmthongke));
            if (frm == null)
            {
                frmthongke forms = new frmthongke();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmdoipass));
            if (frm == null)
            {
                frmdoipass forms = new frmdoipass();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmdangki));
            if (frm == null)
            {
                frmdangki forms = new frmdangki();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmbancansu));
            if (frm == null)
            {
                frmbancansu forms = new frmbancansu();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form[] fchilds = this.MdiChildren;
            foreach (Form f in fchilds)
            {
                f.Dispose();
            }
            username = "";
            txtusername.EditValue = username;
            OpenFormDangNhap();
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmDiemHe4));
            if (frm == null)
            {
                frmDiemHe4 forms = new frmDiemHe4();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThongTinPhanMem t = new ThongTinPhanMem();
            t.ShowDialog();
        }

        private void btnThoat_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = kiemtraform(typeof(frmPhanQuyen));
            if (frm == null)
            {
                frmPhanQuyen forms = new frmPhanQuyen();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        #endregion

        private void ChangePermission(DataTable danhSachQuyen)
        {
            for (int r = 0; r < danhSachQuyen.Rows.Count; r++)
            {
                int ma = int.Parse(danhSachQuyen.Rows[r]["MaQuyen"].ToString());
                switch (ma)
                {
                    case 0:
                        //Xem danh sách khoa
                        navBarItem1.Enabled = true;
                        break;
                    case 1:
                        //Thêm thông tin khoa
                        f_khoa += 1;
                        break;
                    case 2:
                        //Xóa thông tin khoa
                        f_khoa += 2;
                        break;
                    case 3:
                        //Sửa thông tin khoa
                        f_khoa += 4;
                        break;
                    case 4:
                        //Xem danh sách lớp khóa học
                        navBarItem2.Enabled = true;
                        break;
                    case 5:
                        //Thêm thông tin lớp khóa học
                        navBarItem13.Enabled = true;
                        f_lopKhoaHoc += 1;
                        break;
                    case 6:
                        //Xóa thông tin lớp khóa học
                        navBarItem13.Enabled = true;
                        f_lopKhoaHoc += 2;
                        break;
                    case 7:
                        //Sửa thông tin lớp khóa học
                        navBarItem13.Enabled = true;
                        f_lopKhoaHoc += 4;
                        break;
                    case 8:
                        //Xem danh sách sinh viên
                        navBarItem4.Enabled = true;
                        break;
                    case 9:
                        //Thêm thông tin sinh viên
                        f_sinhVien += 1;
                        break;
                    case 10:
                        //Xóa thông tin sinh viên
                        f_sinhVien += 2;
                        break;
                    case 11:
                        //Sửa thông tin sinh viên
                        f_sinhVien += 4;
                        break;
                    case 12:
                        //Xem danh sách môn học
                        navBarItem5.Enabled = true;
                        break;
                    case 13:
                        //Thêm thông tin môn học
                        f_monHoc += 1;
                        break;
                    case 14:
                        //Xóa thông tin môn học
                        f_monHoc += 2;
                        break;
                    case 15:
                        //Sửa thông tin môn học
                        f_monHoc += 4;
                        break;
                    case 16:
                        //Xem danh sách lớp học phần
                        navBarItem3.Enabled = true;
                        break;
                    case 17:
                        //Thêm thông tin lớp học phần
                        f_lopHocPhan += 1;
                        break;
                    case 18:
                        //Xóa thông tin lớp học phần
                        f_lopHocPhan += 1;
                        break;
                    case 19:
                        //Sửa thông tin lớp học phần
                        f_lopHocPhan += 1;
                        break;
                    case 20:
                        //Đăng kí môn học

                        break;
                    case 21:
                        //Hủy môn học

                        break;
                    case 22:
                        //Xem điểm
                        navBarItem7.Enabled = true;
                        f_diem += 1;
                        break;
                    case 23:
                        //Nhập điểm
                        navBarItem6.Enabled = true;
                        f_diem += 2;
                        break;
                    case 24:
                        //Đổi password
                        navBarItem11.Enabled = true;
                        f_doiPassword += 1;
                        break;
                    case 25:
                        //Đăng kí tài khoản
                        navBarItem12.Enabled = true;
                        navBarItem12.Visible = true;
                        f_dangKiTK += 1;
                        break;
                    case 26:
                        //Phân quyền
                        navBarItem16.Enabled = true;
                        navBarItem16.Visible = true;
                        f_heThong += 1;
                        break;
                    case 27:
                        //Xem danh sách tham số
                        navBarItem14.Enabled = true;
                        navBarItem14.Visible = true;
                        f_heThong += 2;
                        break;
                    case 28:
                        //Sửa giá trị tham số
                        f_heThong += 4;
                        break;
                    case 29:
                        //Tra cứu thông tin sinh viên
                        navBarItem8.Enabled = true;
                        f_traCuu += 1;
                        break;
                    case 30:
                        //Thống kê
                        navBarItem9.Enabled = true;
                        f_thongKe += 1;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}