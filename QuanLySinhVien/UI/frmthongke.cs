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
using System.Data.SqlClient;

using BUS_Tier;
using MODEL_Tier;

namespace UI_Tier
{
    public partial class frmthongke : DevExpress.XtraEditors.XtraForm
    {
        private KhoaBUS khoaBUS = new KhoaBUS();
        private LopKhoaHocBUS lopKhoaHocBUS = new LopKhoaHocBUS();
        private SinhVienBUS sinhVienBUS = new SinhVienBUS();

        private DataSet ds;
        private DataTable dt_K;
        private DataTable dt_L;
        private DataTable dt_S;

        private BindingSource bsKhoa;
        private BindingSource bsLop;

        public frmthongke()
        {
            InitializeComponent();
        }

        private void frmthongke_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng Form?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoattk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmthongke_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            dt_K = new DataTable();
            dt_L = new DataTable();
            dt_S = new DataTable();

            dt_K = khoaBUS.DanhSach().Copy();
            dt_K.TableName = "KHOA";
            dt_L = lopKhoaHocBUS.DanhSach().Copy();
            dt_L.TableName = "LOP";

            ds.Tables.Add(dt_K);
            ds.Tables.Add(dt_L);

            ds.Relations.Add("K_L", ds.Tables["KHOA"].Columns["MaKhoa"], ds.Tables["LOP"].Columns["MaKhoa"]);

            bsKhoa = new BindingSource(ds, "KHOA");
            bsLop = new BindingSource(bsKhoa, "K_L");

            cbbKhoa.DataSource = bsKhoa;
            cbbKhoa.DisplayMember = "TenKhoa";
            cbbKhoa.ValueMember = "MaKhoa";

            cbbLop.DataSource = bsLop;
            cbbLop.DisplayMember = "MaLop";
            cbbLop.ValueMember = "MaLop";
           
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            if (cbbKhoa.SelectedValue == null || cbbLop.SelectedValue == null)
            {
                return;
            }

            string maKhoa = cbbKhoa.SelectedValue.ToString();
            string maLop = cbbLop.SelectedValue.ToString();

            rpThongKe rpObj = new rpThongKe();

            dsSinhVien dsSinhVien = new dsSinhVien();
            DataTable dtSV = dsSinhVien.dtSinhVien;

            sinhVienBUS.FillDataTable(ref dtSV, maLop);
            dsSinhVien.AcceptChanges();
            
            rpObj.SetDataSource(dsSinhVien);           

            CrystalDecisions.CrystalReports.Engine.TextObject textObj;
            textObj = (CrystalDecisions.CrystalReports.Engine.TextObject)rpObj.ReportDefinition.ReportObjects["txtKhoa"];
            textObj.Text = maKhoa;

            textObj = (CrystalDecisions.CrystalReports.Engine.TextObject)rpObj.ReportDefinition.ReportObjects["txtLop"];
            textObj.Text = maLop;

            crystalReportViewer1.ReportSource = rpObj;
        }
    }
}