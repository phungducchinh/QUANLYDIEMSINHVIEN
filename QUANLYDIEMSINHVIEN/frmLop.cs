
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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        int dem = 0;

        int check = 0; // 0 : binh thuong, 1: Them, 2: Chinh Sua, 3: Xoa
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            comboBox1.DataSource = new BindingSource(Program.bds_dspm, null);  // sao chép bds_dspm đã load ở form đăng nhập  qua
          //  comboBox1.DisplayMember = "TENCN";
            comboBox1.ValueMember = "TENSERVER";
            comboBox1.SelectedIndex = Program.mKhoa;

            if (Program.mGroup == "PGV")
                comboBox1.Enabled = true;  // bật tắt theo phân quyền
            else
                comboBox1.Enabled = false;

            ketnoicsdl();
            txbMaLop.Enabled = false;
            txbTenlop.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoicsdl();
            updateGridView();           
        }

        private void updateGridView()
        {
            dataGridViewLop.Update();
            dataGridViewLop.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewLop.CurrentCell.RowIndex;
            int columnindex = dataGridViewLop.CurrentCell.ColumnIndex;

            string malop = dataGridViewLop.Rows[rowindex].Cells[0].Value.ToString();
            string tenlop = dataGridViewLop.Rows[rowindex].Cells[1].Value.ToString();
            if (check == 2 )
            {
                txbMaLop.Text = malop;
                txbTenlop.Text = tenlop;
                txbMaLop.Enabled = false;
                txbTenlop.Enabled = true;
            }

            if (check == 3)
            {
                txbMaLop.Text = malop;
                txbTenlop.Text = tenlop;
                txbMaLop.Enabled = false;
                txbTenlop.Enabled = false;
            }
            MessageBox.Show(malop, tenlop, MessageBoxButtons.OK);
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-OBANFPJ;Initial Catalog=QLDSV;Persist Security Info=True;User ID=sa;Password=1");
        private void ketnoicsdl()
        {
            cnn.Open();
            string khoa = "";
            string sql = "";
            if (comboBox1.SelectedIndex == 1)
            {
                 sql = "select LOP.MALOP, LOP.TENLOP from LOP where MAKH = 'VT'" ;
            }
            else
            {
                 sql = "select LOP.MALOP, LOP.TENLOP from LOP where MAKH = 'CNTT'";
            }
            //string sql = "select LOP.MALOP, LOP.TENLOP from LOP where MAKH = " + khoa;  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridViewLop.DataSource = dt; //đổ dữ liệu vào datagridview
            dataGridViewLop.Columns[0].Width = 100;
            dataGridViewLop.Columns[1].Width = 250;
        }

        private void btnThemlop_Click(object sender, EventArgs e)
        {
            txbMaLop.Enabled = true;
            txbTenlop.Enabled = true;
            btnChinhsualop.Enabled = false;
            btnXoalop.Enabled = false;
            check = 1;

        }

        private bool checkText() 
        {
            if (txbMaLop.Text == "" || txbTenlop.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin lớp", "Thông báo", MessageBoxButtons.OK);
                txbTenlop.Enabled = true;
                txbMaLop.Enabled = true;
                return false;
            }
            if (check != 2)
            {
                if (!kiemTraMaLop(txbMaLop.Text))
                {
                    MessageBox.Show("Mã lớp bị trùng!", "", MessageBoxButtons.OK);
                    txbMaLop.Enabled = true;
                    Program.conn.Close();
                    return false;
                }
            }
            

            if (!kiemTraTenLop(txbTenlop.Text))
            {
                MessageBox.Show("Tên lớp bị trùng !");
                txbTenlop.Enabled = true;
                return false;
            }

            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (check == 1 && checkText())
            {
                txbTenlop.Enabled = false;
                txbMaLop.Enabled = false;

                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.sp_InsertLop";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    string khoa = "";
                    if (comboBox1.SelectedIndex == 1)
                    {
                        khoa = "VT";
                    }else
                    {
                        khoa = "CNTT";
                    }
                    MessageBox.Show(txbMaLop.Text.Trim(), khoa, MessageBoxButtons.OK);
                    Program.sqlcmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = txbMaLop.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@tenlop", SqlDbType.VarChar).Value = txbTenlop.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@maKH", SqlDbType.VarChar).Value = khoa;
               
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret1.Equals("1"))
                    {
                        MessageBox.Show("Thông tin bị trùng!!!", "Thông báo");
                        txbMaLop.Enabled = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "thông báo");
                        txbMaLop.Text = "";
                        txbMaLop.Enabled = true;
                        txbTenlop.Text = "";
                        txbTenlop.Enabled = true;
                        ketnoicsdl();
                        updateGridView();                        
                        btnThemlop.Enabled = btnChinhsualop.Enabled = btnXoalop.Enabled = true;
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                
                btnThemlop.Enabled = btnChinhsualop.Enabled = btnXoalop.Enabled  = true;

            }else if (check == 2 && checkText())
            {
                checkText();
                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "sp_HieuChinhLop";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    string khoa = "";
                    if (comboBox1.SelectedIndex == 1)
                    {
                        khoa = "VT";
                    }
                    else
                    {
                        khoa = "CNTT";
                    }
                    MessageBox.Show(txbMaLop.Text.Trim(), khoa, MessageBoxButtons.OK);
                    Program.sqlcmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = txbMaLop.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@tenlop", SqlDbType.VarChar).Value = txbTenlop.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@maKHoa", SqlDbType.VarChar).Value = khoa;

                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret1.Equals("0"))
                    {
                        MessageBox.Show("Thông tin bị trùng!!!", "Thông báo");
                        txbMaLop.Enabled = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công", "thông báo");
                        txbMaLop.Text = "";
                        txbMaLop.Enabled = true;
                        txbTenlop.Text = "";
                        txbTenlop.Enabled = true;
                        ketnoicsdl();
                        updateGridView();
                        btnThemlop.Enabled = btnChinhsualop.Enabled = btnXoalop.Enabled = true;
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }else if (check == 3 && txbMaLop.Text != "")
            {
                txbTenlop.Enabled = false;
                txbMaLop.Enabled = false;
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh1 = "dbo.sp_KiemTraLopTonTaiSinhVien";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh1;
                Program.sqlcmd.Parameters.Add("@malop", SqlDbType.NChar).Value = txbMaLop.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret.Equals("1"))
                {
                    MessageBox.Show("Lớp đã tồn tại sinh viên! Không thể xóa!!", "Thông báo");
                    return;
                }


                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.sp_XoaThemLop";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@malop", SqlDbType.NChar).Value = txbMaLop.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret1.Equals("1"))
                {
                    MessageBox.Show("Xóa lớp thành công!!", "Thông báo");
                    txbMaLop.Text = "";
                    txbMaLop.Enabled = true;
                    txbTenlop.Text = "";
                    txbTenlop.Enabled = true;
                    ketnoicsdl();
                    updateGridView();
                    btnThemlop.Enabled = btnChinhsualop.Enabled = btnXoalop.Enabled = true;
                    return;
                }else
                {
                    MessageBox.Show("Xóa lớp thất bại! Vui lòng thử lại!", "Thông báo");
                    return;
                }

            }
        }

        private bool kiemTraMaLop(String maLop)
        {
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.sp_TIMLOP ";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@MALOP", SqlDbType.Text).Value = maLop;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            return (Ret != "1");
        }

        private bool kiemTraTenLop(String tenLop)
        {
            try
            {

                String sql = "exec sp_KiemTraTenLop N'" + tenLop + "'";
                DataTable tb = Program.ExecSqlDataTable(sql);
                return (tb.Columns.Count == 0);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbMaLop.Enabled = true;
            txbTenlop.Enabled = true;
            txbMaLop.Text = "";
            txbTenlop.Text = "";
            check = 0;
            btnChinhsualop.Enabled = btnThemlop.Enabled = btnXoalop.Enabled = true;
        }

        private void btnChinhsualop_Click(object sender, EventArgs e)
        {
            check = 2;
            btnThemlop.Enabled = btnXoalop.Enabled = false;
        }

        private void btnXoalop_Click(object sender, EventArgs e)
        {
            check = 3;
            btnThemlop.Enabled = btnChinhsualop.Enabled = false;
        }
    }
}