using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;
using System.Data;


namespace QUANLYDIEMSINHVIEN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlCommand sqlcmd = new SqlCommand();

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLDSV";
        public static String remotelogin = "HOTROKETNOI";
        public static String remotepassword = "1";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mKhoa = 0;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static frmMain frmMain;

        public const int THEM = 0;
        public const int HIEU_CHINH = 1;
        public const int XOA = 2;


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            // Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static DataTable ExecSqlQuery(String cmd)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            return dt1;
        }

        public static DateTime convertStringToDateTime(String s)
        {
            DateTime date = DateTime.Now;
            try
            {
                date = DateTime.ParseExact(s, "MM/dd/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                try
                {
                    date = DateTime.ParseExact(s, "MM/d/yyyy",
                                      System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception ex1)
                {
                    try
                    {
                        date = DateTime.ParseExact(s, "M/d/yyyy",
                                      System.Globalization.CultureInfo.InvariantCulture);
                    }
                    catch (Exception ex2)
                    {
                        try
                        {
                            date = DateTime.ParseExact(s, "M/dd/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
                        }
                        catch (Exception ex3)
                        {
                            MessageBox.Show("Cannot convert String to date time", "", MessageBoxButtons.OK);
                        }
                    }

                }

            }
            return date;
        }
        public class ObjectUndo
        {
            public int type;
            public Object obj;

            public ObjectUndo(int type, Object obj)
            {
                this.type = type;
                this.obj = obj;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            //  UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            frmMain = new frmMain();
            Application.Run(frmMain);
        }
    }
}
