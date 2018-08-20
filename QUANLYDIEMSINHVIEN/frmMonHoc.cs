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
using DevExpress.Skins;
using System.Data.SqlClient;

namespace QUANLYDIEMSINHVIEN
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        int check = 0;

        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check = 2;
            btnThemMonHoc.Enabled = btnXoamonHoc.Enabled = false;
        }

        private void dataGridViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewMonHoc.CurrentCell.RowIndex;
            int columnindex = dataGridViewMonHoc.CurrentCell.ColumnIndex;

            string malop = dataGridViewMonHoc.Rows[rowindex].Cells[0].Value.ToString();
            string tenlop = dataGridViewMonHoc.Rows[rowindex].Cells[1].Value.ToString();
            if (check == 2)
            {
                txbMaMonHoc.Text = malop;
                txbTenMonHoc.Text = tenlop;
                txbMaMonHoc.Enabled = false;
                txbTenMonHoc.Enabled = true;
            }

            if (check == 3)
            {
                txbMaMonHoc.Text = malop;
                txbTenMonHoc.Text = tenlop;
                txbMaMonHoc.Enabled = false;
                txbTenMonHoc.Enabled = false;
            }
            MessageBox.Show(malop, tenlop, MessageBoxButtons.OK);
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-OBANFPJ;Initial Catalog=QLDSV;Persist Security Info=True;User ID=sa;Password=1");
        private void ketnoicsdl()
        {
            cnn.Open();
            string khoa = "";
            string sql = "";
            sql = "select MAMH, TENMH from MONHOC";

            //string sql = "select LOP.MALOP, LOP.TENLOP from LOP where MAKH = " + khoa;  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridViewMonHoc.DataSource = dt; //đổ dữ liệu vào datagridview
            dataGridViewMonHoc.Columns[0].Width = 100;
            dataGridViewMonHoc.Columns[1].Width = 250;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            check = 1;
            txbMaMonHoc.Enabled = true;
            txbTenMonHoc.Enabled = true;
            btnChinhsuaMonhoc.Enabled = btnXoamonHoc.Enabled = false;
        }

        private bool checkText()
        {
            if (txbMaMonHoc.Text == "" || txbTenMonHoc.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == 1 && checkText())
            {
                txbMaMonHoc.Enabled = false;
                txbTenMonHoc.Enabled = false;

                if (kiemTraMaMonhoc(txbMaMonHoc.Text))
                {
                    MessageBox.Show("Mã môn học đã tồn tại! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                    txbMaMonHoc.Enabled = true;
                    return;
                }

                if (kiemTraTenMonhoc(txbTenMonHoc.Text))
                {
                    MessageBox.Show("Tên môn học đã tồn tại! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);

                    txbTenMonHoc.Enabled = true;
                    return;
                }
                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
                String strLenh = "dbo.sp_InsertMonHoc";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;

                MessageBox.Show(txbMaMonHoc.Text.Trim(), txbTenMonHoc.Text, MessageBoxButtons.OK);
                //string mamonhoc = txbMaMonHoc.Text;
                //string tenmonhoc = txbTenMonHoc.Text;
                Program.sqlcmd.Parameters.Add("@mamh", SqlDbType.NVarChar).Value = txbMaMonHoc.Text.Trim();
                Program.sqlcmd.Parameters.Add("@tenmh",SqlDbType.NVarChar ).Value = txbTenMonHoc.Text.Trim();
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret1.Equals("0"))
                {
                    MessageBox.Show("Thông tin bị trùng!!!", "Thông báo");
                    txbTenMonHoc.Enabled = txbTenMonHoc.Enabled = true;

                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "thông báo");
                    txbTenMonHoc.Enabled = txbTenMonHoc.Enabled = true;
                    txbTenMonHoc.Text = txbMaMonHoc.Text = "";
                    ketnoicsdl();
                    dataGridViewMonHoc.Update();
                    dataGridViewMonHoc.Refresh();
                    btnThemMonHoc.Enabled = btnChinhsuaMonhoc.Enabled = btnXoamonHoc.Enabled = true;
                    return;
                }

            }
                catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
          }
            if (check == 2 && checkText())
            {
                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "sp_HieuChinhMonHoc";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;

                    MessageBox.Show(txbTenMonHoc.Text.Trim(), txbMaMonHoc.Text, MessageBoxButtons.OK);
                    Program.sqlcmd.Parameters.Add("@mamh", SqlDbType.NChar).Value = txbMaMonHoc.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@tenmh", SqlDbType.NChar).Value = txbTenMonHoc.Text.Trim();

                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret1.Equals("0"))
                    {
                        MessageBox.Show("Thông tin bị trùng!!!", "Thông báo");
                        txbTenMonHoc.Enabled = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công", "thông báo");
                        txbMaMonHoc.Text = "";
                        txbMaMonHoc.Enabled = true;
                        txbTenMonHoc.Text = "";
                        txbTenMonHoc.Enabled = true;
                        ketnoicsdl();
                        btnChinhsuaMonhoc.Enabled = btnThemMonHoc.Enabled = btnXoamonHoc.Enabled = true;
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (check == 3 && checkText())
            {
                txbMaMonHoc.Enabled = false;
                txbTenMonHoc.Enabled = false;
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh1 = "dbo.sp_KiemTraMonHocTonTaiDiem";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh1;
                Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NVarChar).Value = txbMaMonHoc.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret.Equals("1"))
                {
                    MessageBox.Show("Môn học đã tồn tại điểm! Không thể xóa!!", "Thông báo");
                    return;
                }


                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.sp_UndoThemMonHoc";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MAMH", SqlDbType.NChar).Value = txbMaMonHoc.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret1.Equals("1"))
                {
                    MessageBox.Show("Xóa môn học thành công!!", "Thông báo");
                    txbMaMonHoc.Text = "";
                    txbMaMonHoc.Enabled = true;
                    txbTenMonHoc.Text = "";
                    txbTenMonHoc.Enabled = true;
                    ketnoicsdl();
                    btnChinhsuaMonhoc.Enabled = btnThemMonHoc.Enabled = btnXoamonHoc.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa môn học thất bại! Vui lòng thử lại!", "Thông báo");
                    return;
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbTenMonHoc.Enabled = txbMaMonHoc.Enabled = btnXoamonHoc.Enabled = btnThemMonHoc.Enabled = btnChinhsuaMonhoc.Enabled = true;
            txbMaMonHoc.Text = txbTenMonHoc.Text = "";
            check = 0;
        }

        private bool kiemTraMaMonhoc(String maMonHoc)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.sp_TIMMONHOC ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@x", SqlDbType.Text).Value = maMonHoc;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret.Equals("1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool kiemTraTenMonhoc(String tenmonhoc)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.sp_KiemTraTenMonHoc";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@TENMH", SqlDbType.Text).Value = tenmonhoc;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if (Ret.Equals("1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnXoamonHoc_Click(object sender, EventArgs e)
        {
            check = 3;
            btnThemMonHoc.Enabled = btnChinhsuaMonhoc.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}