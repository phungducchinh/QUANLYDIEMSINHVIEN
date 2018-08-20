using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QUANLYDIEMSINHVIEN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FrmDangNhap f = new FrmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dieukhienButton(false);
        }

        private void dieukhienButton(bool dk)
        {
            btnThemTaiKhoan.Enabled =  btnSinhVien.Enabled = btnLop.Enabled = btnDiem.Enabled = btnMonHoc.Enabled = btnInDSSV.Enabled = btnINBDMH.Enabled = btnInDiemSV.Enabled = btnInDSTHM.Enabled = dk;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        /*
        private void btnTaotaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }*/

        private void btnLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLop));
            if (frm != null) frm.Activate();
            else
            {
                frmLop f = new frmLop();                
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSinhVien));
            if (frm != null) frm.Activate();
            else
            {
                frmSinhVien f = new frmSinhVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                frmMonHoc f = new frmMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDiem));
            if (frm != null) frm.Activate();
            else
            {
                frmDiem f = new frmDiem();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        public void HienThiMenu()
        {
            stripMaGV.Text = "Mã Giảng Viên : " + Program.username;
            stripten.Text = "Tên Giảng Viên : " + Program.mHoten;
            stripQuyen.Text = "Nhóm : " + Program.mGroup;
            dieukhienButton(true);
            if (Program.mGroup == "USER")
            {
                btnThemTaiKhoan.Enabled = false;
            }else {
                btnThemTaiKhoan.Enabled = true;
            }

            // Phân quyền
        }

        private void btnThemTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoTaiKhoan f = new frmTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDSSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRP_DSSV));
            if (frm != null) frm.Activate();
            else
            {
                frmRP_DSSV f = new frmRP_DSSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnINBDMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRP_INBANGDIEM));
            if (frm != null) frm.Activate();
            else
            {
                frmRP_INBANGDIEM f = new frmRP_INBANGDIEM();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDiemSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_RP_INDIEMSV));
            if (frm != null) frm.Activate();
            else
            {
                frm_RP_INDIEMSV f = new frm_RP_INDIEMSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInDSTHM_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frm_INDSTHM));
            if (frm != null) frm.Activate();
            else
            {
                frm_INDSTHM f = new frm_INDSTHM();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}