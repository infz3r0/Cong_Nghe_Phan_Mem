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

        private void btnthoatsv_Click(object sender, EventArgs e)
        {
            Close();
        }

        SinhVienBUS sinhvienBUS = new SinhVienBUS();
        BindingSource bs = new BindingSource();
       
        private void LoadDB()
        {
            
            bs.DataSource = sinhvienBUS.DanhSach();
            gridviewsv.DataSource = bs;
            

            txtmssv.DataBindings.Add("Text", bs, "MaSV", false, DataSourceUpdateMode.Never);
            txttensv.DataBindings.Add("Text", bs, "HoTen", false, DataSourceUpdateMode.Never);
            ngaysinhsv.DataBindings.Add("Value", bs, "NgaySinh",false, DataSourceUpdateMode.Never);
            
            cbbGioiTinh.DataBindings.Add("SelectedValue", bs, "GioiTinh");
            txtdicchisv.DataBindings.Add("Text", bs, "DiaChi", false, DataSourceUpdateMode.Never);
            txtcmndsv.DataBindings.Add("Text", bs, "SoCMND", false, DataSourceUpdateMode.Never);
            txtdienthoaisv.DataBindings.Add("Text", bs, "Sdt", false, DataSourceUpdateMode.Never);
            txtmailsv.DataBindings.Add("Text", bs, "Email", false, DataSourceUpdateMode.Never);
            
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

        private void frmsv_Load(object sender, EventArgs e)
        {
            DataTable gtTable = GioiTinhTable();

            cbbGioiTinh.DataSource = gtTable;
            cbbGioiTinh.ValueMember = "Value";
            cbbGioiTinh.DisplayMember = "Text";
            LoadDB();
        }

        private void btnthemsv_Click(object sender, EventArgs e)
        {

        }

        private void btnsuasv_Click(object sender, EventArgs e)
        {

        }

        private void btnxoasv_Click(object sender, EventArgs e)
        {

        }
    }
}