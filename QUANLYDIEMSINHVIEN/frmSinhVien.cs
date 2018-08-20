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
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        int check = 0;
        // phai 1: nam, 0: nữ
        // nghỉ học: 1: có, 0: không

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetCmbLop.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSetCmbLop.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLDSVDataSet.V_DS_PHANMANH);
            cmbKhoa.DataSource = new BindingSource(Program.bds_dspm, null);  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;

            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            else
                cmbKhoa.Enabled = false;

            ketnoicsdl();
            dieukhienTextBox(false);
            setupCmbLop();
            setupCmb();
            
            pickerNgaySinh.Value = DateTime.Parse("01-01-2018");
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-OBANFPJ;Initial Catalog=QLDSV;Persist Security Info=True;User ID=sa;Password=1");
        private void ketnoicsdl()
        {
            cnn.Open();
            string khoa = "";
            string TEMP = "select  HO  ,TEN , MASV, LOP.MALOP,(CASE WHEN PHAI='true' THEN 'Nam' ELSE N'Nữ' END) AS PHAI, NGAYSINH, NOISINH, DIACHI, GHICHU, (CASE WHEN NGHIHOC ='false' THEN 'Không' ELSE 'Có' END) as NGHIHOC FROM dbo.SINHVIEN JOIN LOP ON SINHVIEN.MALOP = LOP.MALOP JOIN KHOA ON LOP.MAKH = KHOA.MAKH WHERE KHOA.MAKH = ";
            string sql = "";
            if (cmbKhoa.SelectedIndex == 1)
            {
                sql = TEMP + "'vt'";
            }
            else
            {
                sql = TEMP + "'CNTT'";
            }
            //string sql = "select LOP.MALOP, LOP.TENLOP from LOP where MAKH = " + khoa;  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridViewSinhVien.DataSource = dt; //đổ dữ liệu vào datagridview

          }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ketnoicsdl();
            setupCmbLop();
        }

        private void btnThemSv_Click(object sender, EventArgs e)
        {
            check = 1;
            btnChinhSuaSV.Enabled = btnXoaSv.Enabled = false;
            dieukhienTextBox(true);
        }

        private void dieukhienTextBox(bool dk)
        {
            txbHo.Enabled = TxbTen.Enabled = txbNoiSinh.Enabled = txbMaSV.Enabled = txbGhiChu.Enabled = txbDiaChi.Enabled = cmbPhai.Enabled = cmbNghiHoc.Enabled = pickerNgaySinh.Enabled = cmbLop.Enabled =dk; 
        }

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

        private void setupCmb()
        {
            cmbPhai.Items.Add("");
            cmbPhai.Items.Add("Nam");
            cmbPhai.Items.Add("Nữ");
            cmbNghiHoc.Items.Add("");
            cmbNghiHoc.Items.Add("Không");
            cmbNghiHoc.Items.Add("Có");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txbMaSV.Text = txbHo.Text = TxbTen.Text = cmbLop.Text = txbNoiSinh.Text = txbDiaChi.Text = txbGhiChu.Text = "";
            cmbPhai.SelectedIndex = cmbNghiHoc.SelectedIndex = 0;
            pickerNgaySinh.Value = DateTime.Parse("01-01-2018");
            btnThemSv.Enabled = btnChinhSuaSV.Enabled = btnXoaSv.Enabled = true;
            dieukhienTextBox(false);
        }

        private void clear()
        {
            txbMaSV.Text = txbHo.Text = TxbTen.Text = cmbLop.Text = txbNoiSinh.Text = txbDiaChi.Text = txbGhiChu.Text = "";
            cmbPhai.SelectedIndex = cmbNghiHoc.SelectedIndex = 0;
            pickerNgaySinh.Value = DateTime.Parse("01-01-2018");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ngaysinh = "";
            ngaysinh = pickerNgaySinh.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(ngaysinh, "Thông báo", MessageBoxButtons.OK);
            dieukhienTextBox(false);

            if (check == 1 && checkText())
            {
                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.sp_insert_Sinhvien";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@masv", SqlDbType.NChar).Value = txbMaSV.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@ho", SqlDbType.NVarChar).Value = txbHo.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = TxbTen.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@malop", SqlDbType.NVarChar).Value = cmbLop.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@phai", SqlDbType.Bit).Value = getPhai(cmbPhai.Text);
                    Program.sqlcmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = txbGhiChu.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = Program.convertStringToDateTime(ngaysinh);
                    Program.sqlcmd.Parameters.Add("@noisinh", SqlDbType.NVarChar).Value = txbNoiSinh.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txbDiaChi.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@nghihoc", SqlDbType.Bit).Value = getNghiHoc(cmbNghiHoc.Text);

                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret1.Equals("0"))
                    {
                        MessageBox.Show("Không thể thêm thông tin !!!", "Thông báo");
                        clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công", "thông báo");
                        clear();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

                clear();
            }

            if (check == 2 && checkText())
            {
                txbMaSV.Enabled = false;
                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.sp_chinhsuathongtinSinhVien";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;
                    Program.sqlcmd.Parameters.Add("@masv", SqlDbType.NChar).Value = txbMaSV.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@ho", SqlDbType.NVarChar).Value = txbHo.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = TxbTen.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@malop", SqlDbType.NVarChar).Value = cmbLop.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@phai", SqlDbType.Bit).Value = getPhai(cmbPhai.Text);
                    Program.sqlcmd.Parameters.Add("@ghichu", SqlDbType.NVarChar).Value = txbGhiChu.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
                    Program.sqlcmd.Parameters.Add("@noisinh", SqlDbType.NVarChar).Value = txbNoiSinh.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txbDiaChi.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@nghihoc", SqlDbType.Bit).Value = getNghiHoc(cmbNghiHoc.Text);

                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret1.Equals("0"))
                    {
                        MessageBox.Show("Không thể thêm thông tin !!!", "Thông báo");
                        clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thành công", "thông báo");
                        clear();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

                clear();
            }

            if (check == 3 && checkText())
            {
 
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh1 = "dbo.sp_KiemTraSVDaCoDiem";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh1;
                Program.sqlcmd.Parameters.Add("@masv", SqlDbType.NVarChar).Value = txbMaSV.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret.Equals("1"))
                {
                    MessageBox.Show("Sinh viên đã có điểm! Không thể xóa!!", "Thông báo");
                    return;
                }


                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.sp_DanhSachSinhVienTheoLop_Delete";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@masv", SqlDbType.NChar).Value = txbMaSV.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                if (Ret1.Equals("1"))
                {
                    MessageBox.Show("Xóa sinh viên thành công!!", "Thông báo");
                    clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại! Vui lòng thử lại!", "Thông báo");
                    return;
                }
            }
        }

        private bool checkText()
        {
            if (txbMaSV.Text == "" || txbHo.Text == "" || TxbTen.Text == "" || cmbLop.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin sinh viên", "Thông báo", MessageBoxButtons.OK);
                clear();
                return false;
            }
            
            if (check == 1 && !kiemTraMaSVTrung(txbMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên bị trùng !");
                clear();
                return false;
            }

            return true;
        }

        private bool kiemTraMaSVTrung(String masv)
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String sql = "dbo.sp_KiemTraMaSV ";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = sql;
                Program.sqlcmd.Parameters.Add("@MAsv", SqlDbType.Text).Value = masv;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                return (Ret != "1");

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return false;
        }

        private bool getPhai(string phai)
        {
            if (phai == "Nam")
            {
                return true;
            }else
            {
                return false;
            }
        }

        private bool getNghiHoc(string hoc)
        {
            if (hoc == "Có")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnChinhSuaSV_Click(object sender, EventArgs e)
        {
            check = 2;
            btnThemSv.Enabled = btnXoaSv.Enabled = false;
            dieukhienTextBox(true);
        }

        private void dataGridViewSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (check == 2 || check == 3)
            {
                int rowindex = dataGridViewSinhVien.CurrentCell.RowIndex;
                int columnindex = dataGridViewSinhVien.CurrentCell.ColumnIndex;

                txbMaSV.Text = dataGridViewSinhVien.Rows[rowindex].Cells[2].Value.ToString();
                txbHo.Text = dataGridViewSinhVien.Rows[rowindex].Cells[0].Value.ToString();
                TxbTen.Text = dataGridViewSinhVien.Rows[rowindex].Cells[1].Value.ToString();
                cmbLop.Text = dataGridViewSinhVien.Rows[rowindex].Cells[3].Value.ToString();
                cmbPhai.Text = dataGridViewSinhVien.Rows[rowindex].Cells[4].Value.ToString();


                string ngay = dataGridViewSinhVien.Rows[rowindex].Cells[5].Value.ToString();
                pickerNgaySinh.Value = DateTime.Parse(ngay);

                txbNoiSinh.Text = dataGridViewSinhVien.Rows[rowindex].Cells[6].Value.ToString();
                txbDiaChi.Text = dataGridViewSinhVien.Rows[rowindex].Cells[7].Value.ToString();
                txbGhiChu.Text = dataGridViewSinhVien.Rows[rowindex].Cells[8].Value.ToString();

                cmbNghiHoc.Text = dataGridViewSinhVien.Rows[rowindex].Cells[9].Value.ToString();
                txbMaSV.Enabled = false;
            }
        }

        private void btnXoaSv_Click(object sender, EventArgs e)
        {
            check = 3;
            btnChinhSuaSV.Enabled = btnThemSv.Enabled = false;
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            setupCmbLop();
        }
    }
}