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

namespace UI_Tier
{
    public partial class frmmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmmain()
        {
            
            InitializeComponent();
         
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            for(int i=0; i<100; i++)
            {
                Thread.Sleep(50);
            }

            frmdangnhap f = new frmdangnhap();
            f.ShowDialog();

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
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatmain_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        
    }
}