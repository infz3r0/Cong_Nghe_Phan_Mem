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

        private string MaSV;
        Dictionary<string, string> dict;
        public frmdangkymonhoc()
        {
            InitializeComponent();
        }

        public frmdangkymonhoc(string MaSV)
        {
            InitializeComponent();
            this.MaSV = MaSV;
        }
        private void frmdangkymonhoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnthoatdk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmdangkymonhoc_Load(object sender, EventArgs e)
        {
            if (MaSV == null)
            {
                MaSV = "";
            }
            dict = danhsachlophpBUS.dshpchuadangki(MaSV);
            foreach (string MaLopHP in dict.Keys)
            {
                checkedListBoxmonhoc.Items.Add(MaLopHP);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string[] dshp = new string[checkedListBoxmonhoc.CheckedItems.Count];
            for (int i = 0; i < checkedListBoxmonhoc.CheckedItems.Count; i++)
            {
                dshp[i] = dict[checkedListBoxmonhoc.CheckedItems[i].ToString()];
            }
            bool isOK = danhsachlophpBUS.dangki(MaSV, dshp);
            if (isOK)
            {
                MessageBox.Show("Đăng kí thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            Dispose();
        }
    }
}