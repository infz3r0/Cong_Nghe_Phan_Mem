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

namespace UI_Tier
{
    public partial class ThongTinPhanMem : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinPhanMem()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}