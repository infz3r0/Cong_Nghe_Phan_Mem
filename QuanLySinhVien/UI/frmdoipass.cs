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

namespace DXApplication1
{
    public partial class frmdoipass : DevExpress.XtraEditors.XtraForm
    {
        public frmdoipass()
        {
            InitializeComponent();
        }

        private void frmdoipass_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;
        }

        private void btnthoatdoipass_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmdoipass_Load(object sender, EventArgs e)
        {

        }
    }
}