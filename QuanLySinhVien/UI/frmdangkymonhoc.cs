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
    public partial class frmdangkymonhoc : DevExpress.XtraEditors.XtraForm
    {
        private DanhSachLopHPBUS danhsachlophpBUS = new DanhSachLopHPBUS();
        private LopHocPhanBUS lopHocPhanBUS = new LopHocPhanBUS();
        private MonHocBUS monhocBUS = new MonHocBUS();
        private BindingSource bs = new BindingSource();

        public frmdangkymonhoc()
        {
            InitializeComponent();
        }
        private void LoadDB()
        {
            bs.DataSource = monhocBUS.danhsachmon();

            GridViewmonhoc.DataSource = bs;
            
            
        }
        private void frmdangkymonhoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmdangkymonhoc_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void btnloc_Click_1(object sender, EventArgs e)
        {
               string input = txttimmon.Text;
               bool isNumber = true;
               bool isString = true;

               if (string.IsNullOrEmpty(input))
               {
                   return;
               }

               for (int i = 0; i < input.Length; i++)
               {
                   if (char.IsNumber(input[i]))
                   {
                       isString = false;
                   }
               }

               for (int i = 0; i < input.Length; i++)
               {
                   if (char.IsLetter(input[i]))
                   {
                       isNumber = false;
                   }
               }

               if (isNumber)
               {
                   GridViewmonhoc.DataSource = monhocBUS.Loctheoma(input);
               }
               if (isString)
               {
                   GridViewmonhoc.DataSource = monhocBUS.loctheoten(input);
               }
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}