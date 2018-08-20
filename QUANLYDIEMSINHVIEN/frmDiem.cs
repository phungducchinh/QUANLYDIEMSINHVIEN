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
    public partial class frmDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int lanthi = 0;

        private void frmDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetCmbLop.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSVDataSetCmbLop.LOP);
            // TODO: This line of code loads data into the 'qLDSVDataSet11.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSVDataSet11.MONHOC);
            // TODO: This line of code loads data into the 'qldsvDataSet1.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qldsvDataSet1.V_DS_PHANMANH);
            cmbKhoa.DataSource = new BindingSource(Program.bds_dspm, null);  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mKhoa;
            setupCmbLop();
            cmbMonhoc.Text = "";
           // ketnoicsdl();
            gridControlDiemSV.Visible = false;
            if (Program.mGroup == "PGV")
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
            else
                cmbKhoa.Enabled = false;
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

        private void ketnoicsdl()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.sp_Laythongtindiemsinhvien '" + cmbLop.Text.Trim() +"' , '" + cmbMonhoc.Text.Trim() + "'";
                //Program.sqlcmd = Program.conn.CreateCommand();
                //Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                //Program.sqlcmd.CommandText = strLenh;

                //MessageBox.Show(cmbLop.Text.Trim(), "", MessageBoxButtons.OK);
                //Program.sqlcmd.Parameters.Add("@malop", SqlDbType.NVarChar).Value = cmbLop.Text.Trim();
                DataTable tb = Program.ExecSqlDataTable(strLenh);
                string a = tb.Rows.Count.ToString();
                MessageBox.Show("Vui  " + a, "số sinh viên!", MessageBoxButtons.OK);
                if (a.Equals("0"))
                {
                    MessageBox.Show("Vui lòng chọn lớp khác!", "Lớp không có sinh viên!", MessageBoxButtons.OK);
                    gridControlDiemSV.Visible = false;
                    return ;
                }
                else
                {
                    gridControlDiemSV.Visible = true;
                    gridControlDiemSV.DataSource = tb;
                }
                
                Program.conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi điểm.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private bool checkDiem(string malop, string mamh, string lan)
        {
            
            if( int.TryParse(lan, out lanthi))
            {
                lanthi = int.Parse(lan);
            }
            String strLenh = "dbo.sp_KiemtradiemSinhvien '" + cmbLop.Text.Trim() + "', '" + cmbMonhoc.Text.Trim() + "', '" + lanthi + "'";
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable(strLenh);
            string dong = dt.Rows.Count.ToString();
           
            if (dong.Equals("0"))
            {
                return false;
                gridControlDiemSV.Visible = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp khác!" , "Lớp đã nhập điểm!", MessageBoxButtons.OK);
                gridControlDiemSV.Visible = false;
                return true;
            }
            
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupCmbLop();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (cmbKhoa.Text == "" || cmbLop.Text == "" || cmbMonhoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần nhập! Vui lòng nhập lại", "Thông báo");
                return;
            }
            
            if (!txbLanThi.Text.Equals("1") && !txbLanThi.Text.Equals("2"))
            {
                MessageBox.Show("Lần thi bắt buộc là 1 hoặc 2! Vui lòng nhập lại", "Thông báo!");
                return;
            }

            if (!checkDiem(cmbLop.Text, cmbMonhoc.Text, txbLanThi.Text))
            {
                ketnoicsdl();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {


            int a = gridControlDiemSV.RowCount;
            MessageBox.Show("Tong so dong du lieu: " + (a - 1), "Thông báo");
            float n;

            float diemthi = 0.00f;

            for (int i = 0; i < a - 1; i++)
            {
                string diem = gridControlDiemSV.Rows[i].Cells[2].Value.ToString();
                if (float.TryParse(diem, out n))
                {

                    diem = diem.Replace(",", ".");
                    diemthi = float.Parse(diem);
                    MessageBox.Show("lan 1" + diemthi, "Thông báo", MessageBoxButtons.OK);
                    if (diem == "")
                    {
                        MessageBox.Show("Điểm không được để trống! Vui lòng nhập lại ", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    if (diem.Length > 1)
                    {
                       

                        string[] chuoi_cat = diem.Split(' ');
                        string text = chuoi_cat[0].Substring(0, 1);
                        if (text == "-")
                        {
                            MessageBox.Show("Điểm không được là số âm! Vui lòng nhập lại ", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }

                        MessageBox.Show("" + diemthi, "Thông báo", MessageBoxButtons.OK);

                        if (diemthi > 10)
                        {
                            MessageBox.Show("Điểm không được lớn hơn 10! Vui lòng nhập lại ", "Thông báo", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
             }
            for (int i = 0; i < a - 1; i++)
            {
                string diem = gridControlDiemSV.Rows[i].Cells[2].Value.ToString();
                diem = diem.Replace(",", ".");
                diemthi = float.Parse(diem);

                double y = new double();
                    y = Math.Round(diemthi, 1);
                
                
              
                string masv = gridControlDiemSV.Rows[i].Cells[0].Value.ToString();
                // sp nhap diem mon hoc
                try
                {
                    if (Program.conn.State == ConnectionState.Closed)
                        Program.conn.Open();
                    String strLenh = "dbo.sp_InsertDiemthi";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh;

                    Program.sqlcmd.Parameters.Add("@mamh", SqlDbType.VarChar).Value = cmbMonhoc.Text.Trim();
                    Program.sqlcmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = masv;
                    Program.sqlcmd.Parameters.Add("@lan", SqlDbType.SmallInt).Value = lanthi;
                    Program.sqlcmd.Parameters.Add("@diem", SqlDbType.Float).Value = y;
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    String Ret1 = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                    if (Ret1.Equals("0"))
                    {
                        MessageBox.Show("Không thể thêm điểm thi!!!", "Thông báo");

                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi diểm thi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

            }
            
            MessageBox.Show("Ghi điểm thành công!");
            gridControlDiemSV.Visible = false;
        }

        private void gridControlDiemSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            /*
            
            for (int i = 0; i < a; i++)
            {
                float n = 0;
                string s = gridControlDiemSV.Rows[i].Cells[2].Value.ToString();

                if (float.TryParse(s, out n))
                {
                    MessageBox.Show("dung la so nguyen");
                }
                else MessageBox.Show("khong phai so nguyen");
            }*/
        }
    }
}