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

namespace QUANLYDIEMSINHVIEN
{
    public partial class frmRP_DSSV : DevExpress.XtraEditors.XtraForm
    {
        public frmRP_DSSV()
        {
            InitializeComponent();
        }

        private void frmRP_DSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetCmbLop.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSetCmbLop.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet2.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLDSVDataSet2.DIEM);
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
           
            cmbKhoa.DataSource = new BindingSource(Program.bds_dspm, null);  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            setupCmbLop();
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            else
                cmbKhoa.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-OBANFPJ;Initial Catalog=QLDSV;Persist Security Info=True;User ID=sa;Password=1");
        private void setupCmbLop()
        {
            cnn.Open();
            string khoa = "";
            string sql = "";
            if (cmbKhoa.SelectedIndex == 1)
            {
                sql = "select LOP.MALOP from LOP where MAKH = 'VT'";
            }
            else
            {
                sql = "select LOP.MALOP from LOP where MAKH = 'CNTT'";
            }
            //string sql = "select LOP.MALOP, LOP.TENLOP from LOP where MAKH = " + khoa;  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            cmbLop.DataSource = dt; //đổ dữ liệu vào datagridview
            cmbLop.DisplayMember = "MALOP";
            cmbLop.ValueMember = "TENLOP";
            cmbLop.Text = "";
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupCmbLop();
        }
    }
}