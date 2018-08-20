namespace QUANLYDIEMSINHVIEN
{
    partial class frmDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qldsvDataSet1 = new QUANLYDIEMSINHVIEN.QLDSVDataSet();
            this.cmbMonhoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet11 = new QUANLYDIEMSINHVIEN.QLDSVDataSet1();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSetCmbLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSetCmbLop = new QUANLYDIEMSINHVIEN.QLDSVDataSetCmbLop();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLanThi = new System.Windows.Forms.TextBox();
            this.v_DS_PHANMANHTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.mONHOCTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSet1TableAdapters.MONHOCTableAdapter();
            this.lOPTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSetCmbLopTableAdapters.LOPTableAdapter();
            this.qLDSVDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2 = new QUANLYDIEMSINHVIEN.QLDSVDataSet2();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gridControlDiemSV = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLDSVDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiemSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm sinh viên";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(879, 73);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khoa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Môn học";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.vDSPHANMANHBindingSource;
            this.cmbKhoa.DisplayMember = "TENKHOA";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(80, 56);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(180, 27);
            this.cmbKhoa.TabIndex = 6;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qldsvDataSet1;
            // 
            // qldsvDataSet1
            // 
            this.qldsvDataSet1.DataSetName = "QLDSVDataSet";
            this.qldsvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMonhoc
            // 
            this.cmbMonhoc.DataSource = this.mONHOCBindingSource;
            this.cmbMonhoc.DisplayMember = "MAMH";
            this.cmbMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonhoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonhoc.FormattingEnabled = true;
            this.cmbMonhoc.Location = new System.Drawing.Point(80, 98);
            this.cmbMonhoc.Name = "cmbMonhoc";
            this.cmbMonhoc.Size = new System.Drawing.Size(180, 27);
            this.cmbMonhoc.TabIndex = 7;
            this.cmbMonhoc.ValueMember = "TENMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet11;
            // 
            // qLDSVDataSet11
            // 
            this.qLDSVDataSet11.DataSetName = "QLDSVDataSet1";
            this.qLDSVDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lOPBindingSource;
            this.cmbLop.DisplayMember = "MALOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(391, 54);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(155, 27);
            this.cmbLop.TabIndex = 8;
            this.cmbLop.ValueMember = "TENLOP";
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLop_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSetCmbLopBindingSource;
            // 
            // qLDSVDataSetCmbLopBindingSource
            // 
            this.qLDSVDataSetCmbLopBindingSource.DataSource = this.qLDSVDataSetCmbLop;
            this.qLDSVDataSetCmbLopBindingSource.Position = 0;
            // 
            // qLDSVDataSetCmbLop
            // 
            this.qLDSVDataSetCmbLop.DataSetName = "QLDSVDataSetCmbLop";
            this.qLDSVDataSetCmbLop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDau.Location = new System.Drawing.Point(590, 73);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(75, 37);
            this.btnBatDau.TabIndex = 10;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lần";
            // 
            // txbLanThi
            // 
            this.txbLanThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLanThi.Location = new System.Drawing.Point(391, 102);
            this.txbLanThi.Name = "txbLanThi";
            this.txbLanThi.Size = new System.Drawing.Size(155, 26);
            this.txbLanThi.TabIndex = 14;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // qLDSVDataSet2BindingSource
            // 
            this.qLDSVDataSet2BindingSource.DataSource = this.qLDSVDataSet2;
            this.qLDSVDataSet2BindingSource.Position = 0;
            // 
            // qLDSVDataSet2
            // 
            this.qLDSVDataSet2.DataSetName = "QLDSVDataSet2";
            this.qLDSVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(773, 73);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 37);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridControlDiemSV
            // 
            this.gridControlDiemSV.AutoGenerateColumns = false;
            this.gridControlDiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControlDiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HOTEN,
            this.DIEM});
            this.gridControlDiemSV.DataSource = this.qLDSVDataSet2BindingSource1;
            this.gridControlDiemSV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.gridControlDiemSV.Location = new System.Drawing.Point(163, 166);
            this.gridControlDiemSV.Name = "gridControlDiemSV";
            this.gridControlDiemSV.Size = new System.Drawing.Size(556, 218);
            this.gridControlDiemSV.TabIndex = 17;
            this.gridControlDiemSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridControlDiemSV_CellContentClick);
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã sinh viên";
            this.MASV.Name = "MASV";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ và tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "Điểm thi";
            this.DIEM.Name = "DIEM";
            // 
            // qLDSVDataSet2BindingSource1
            // 
            this.qLDSVDataSet2BindingSource1.DataSource = this.qLDSVDataSet2;
            this.qLDSVDataSet2BindingSource1.Position = 0;
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 430);
            this.Controls.Add(this.gridControlDiemSV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txbLanThi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBatDau);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbMonhoc);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDiemSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbMonhoc;
        private System.Windows.Forms.ComboBox cmbLop;
        private QLDSVDataSet qldsvDataSet1;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbLanThi;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private QLDSVDataSet1 qLDSVDataSet11;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource qLDSVDataSetCmbLopBindingSource;
        private QLDSVDataSetCmbLop qLDSVDataSetCmbLop;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetCmbLopTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource qLDSVDataSet2BindingSource;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
        private System.Windows.Forms.BindingSource qLDSVDataSet2BindingSource1;
        private System.Windows.Forms.DataGridView gridControlDiemSV;
    }
}