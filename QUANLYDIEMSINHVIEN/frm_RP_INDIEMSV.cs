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

namespace QUANLYDIEMSINHVIEN
{
    public partial class frm_RP_INDIEMSV : DevExpress.XtraEditors.XtraForm
    {
        public frm_RP_INDIEMSV()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}