
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
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new BindingSource(Program.bds_dspm, null);  // sao chép bds_dspm đã load ở form đăng nhập  qua
            comboBox1.DisplayMember = "TENCN";
            comboBox1.ValueMember = "TENSERVER";
            comboBox1.SelectedIndex = Program.mKhoa;

            if (Program.mGroup == "PGV")
              comboBox1.Enabled = true;  // bật tắt theo phân quyền
          else
              comboBox1.Enabled = false;
        //  initComboBoxGiangVien();

          if (Program.mGroup == "PGV")
          {
              cmbQuyen.Items.Add("PGV");
              cmbQuyen.Items.Add("KHOA");
              cmbQuyen.Items.Add("USER");
              cmbQuyen.SelectedIndex = 0;
              //this.panel1.Enabled = false;
              comboBox1.Enabled = true;
          }
          else
          {
              if (Program.mGroup == "KHOA")
              {
                  cmbQuyen.Items.Add("KHOA");
                  cmbQuyen.Items.Add("USER");
                  cmbQuyen.SelectedIndex = 0;
                  //this.panel1.Enabled = true;
              }
              else
              {
                  cmbQuyen.Items.Add("USER");
                  cmbQuyen.SelectedIndex = 0;
              }
              comboBox1.Enabled = false;
          } 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            initComboBoxGiangVien();
        }

        private void btnTaotaikhoan_Click(object sender, EventArgs e)
        {
            if (TbPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (tbLoginName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập username !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show(TbPassword.Text, tbLoginName.Text, MessageBoxButtons.OK);
            if (cmbGiangvien.ValueMember == Program.username)
            {
                MessageBox.Show("Tai khoan nay dang dang nhap !!!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show(cmbGiangvien.Text);

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh1 = "dbo.sp_KiemTraTaiKhoanDaDangKyTrongDatabase";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh1;
            Program.sqlcmd.Parameters.Add("@TENUSER", SqlDbType.NChar).Value = cmbGiangvien.Text.Trim();
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret.Equals("1"))
            {
                MessageBox.Show("LOGINNAME đã tồn tại!!!", "Thông báo");
                return;
            }
            if (Ret.Equals("-1"))
            {
                MessageBox.Show("LOGINNAME không có ID!!!", "Thông báo");
                return;
            }

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.sp_TaoTaiKhoan";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@LGNAME", SqlDbType.VarChar).Value = tbLoginName.Text;
            Program.sqlcmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = TbPassword.Text;
            Program.sqlcmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = cmbGiangvien.Text;
            Program.sqlcmd.Parameters.Add("@ROLE ", SqlDbType.VarChar).Value = cmbQuyen.Text;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret1.Equals("1"))
            {
                MessageBox.Show("LOGINNAME bị trùng!!!", "Thông báo");
                cmbGiangvien.Focus();
                return;
            }
            else if (Ret1.Equals("2"))
            {
                MessageBox.Show("USERNAME bị trùng !!!", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Thêm thành công", "thông báo");
                tbLoginName.Text = "";
                TbPassword.Text = "";
                return;
            }
        }

        private void initComboBoxGiangVien()
        {
            comboBox1.Enabled = true;
            try
            {

                String sql = "exec sp_LayDsGiaoVienTheoTenKhoaLink N'" + comboBox1.Text.ToString() + "'";
                DataTable tb = Program.ExecSqlDataTable(sql);
                if (tb.Columns.Count > 0)
                {
                    cmbGiangvien.DataSource = tb;
                    cmbGiangvien.DisplayMember = "MAGV";
                    cmbGiangvien.ValueMember = "TEN";

                    cmbGiangvien.SelectedIndex = 0;

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initComboBoxGiangVien();
        }
    }
}