namespace QUANLYDIEMSINHVIEN
{
    partial class frm_INDSTHM
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
            this.cmbMonhoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet1 = new QUANLYDIEMSINHVIEN.QLDSVDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInBangDiem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSetCmbLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSetCmbLop = new QUANLYDIEMSINHVIEN.QLDSVDataSetCmbLop();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLDSVDataSet = new QUANLYDIEMSINHVIEN.QLDSVDataSet();
            this.lOPTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSetCmbLopTableAdapters.LOPTableAdapter();
            this.mONHOCTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSet1TableAdapters.MONHOCTableAdapter();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.qLDSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vDSPHANMANHBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMonhoc
            // 
            this.cmbMonhoc.DataSource = this.mONHOCBindingSource;
            this.cmbMonhoc.DisplayMember = "MAMH";
            this.cmbMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonhoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonhoc.FormattingEnabled = true;
            this.cmbMonhoc.Location = new System.Drawing.Point(455, 85);
            this.cmbMonhoc.Name = "cmbMonhoc";
            this.cmbMonhoc.Size = new System.Drawing.Size(180, 27);
            this.cmbMonhoc.TabIndex = 31;
            this.cmbMonhoc.ValueMember = "TENMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet1;
            // 
            // qLDSVDataSet1
            // 
            this.qLDSVDataSet1.DataSetName = "QLDSVDataSet1";
            this.qLDSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Môn học";
            // 
            // btnInBangDiem
            // 
            this.btnInBangDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBangDiem.Location = new System.Drawing.Point(455, 131);
            this.btnInBangDiem.Name = "btnInBangDiem";
            this.btnInBangDiem.Size = new System.Drawing.Size(75, 37);
            this.btnInBangDiem.TabIndex = 29;
            this.btnInBangDiem.Text = "IN";
            this.btnInBangDiem.UseVisualStyleBackColor = true;
            this.btnInBangDiem.Click += new System.EventHandler(this.btnInBangDiem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(579, 134);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lOPBindingSource;
            this.cmbLop.DisplayMember = "MALOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(133, 137);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(155, 27);
            this.cmbLop.TabIndex = 27;
            this.cmbLop.ValueMember = "TENLOP";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Chọn lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chọn khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "IN DANH SÁCH THI HẾT MÔN";
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.vDSPHANMANHBindingSource1;
            this.cmbKhoa.DisplayMember = "TENKHOA";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(133, 90);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(155, 27);
            this.cmbKhoa.TabIndex = 32;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged_1);
            // 
            // qLDSVDataSetBindingSource
            // 
            this.qLDSVDataSetBindingSource.DataSource = this.qLDSVDataSet;
            this.qLDSVDataSetBindingSource.Position = 0;
            // 
            // vDSPHANMANHBindingSource1
            // 
            this.vDSPHANMANHBindingSource1.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource1.DataSource = this.qLDSVDataSetBindingSource;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // frm_INDSTHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 526);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.cmbMonhoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInBangDiem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_INDSTHM";
            this.Text = "frm_INDSTHM";
            this.Load += new System.EventHandler(this.frm_INDSTHM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMonhoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInBangDiem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
    //    private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.BindingSource qLDSVDataSetCmbLopBindingSource;
        private QLDSVDataSetCmbLop qLDSVDataSetCmbLop;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetCmbLopTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVDataSet1 qLDSVDataSet1;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.BindingSource qLDSVDataSetBindingSource;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource1;
        private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}