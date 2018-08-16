using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;



namespace QUANLYDIEMSINHVIEN
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            cmbKhoa.SelectedIndex = 1;
            cmbKhoa.SelectedIndex = 0;
            
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tfTenDangNhap.Text.Trim() == "" || tfMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = tfTenDangNhap.Text;
            Program.password = tfMatKhau.Text;
            if (Program.KetNoi() == 0) return;
            MessageBox.Show("Dang nhap thanh cong", "", MessageBoxButtons.OK);
            Program.mKhoa = cmbKhoa.SelectedIndex;
            Program.bds_dspm = vDSPHANMANHBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            Program.frmMain.HienThiMenu();


        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
                Program.servername = cmbKhoa.SelectedValue.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}