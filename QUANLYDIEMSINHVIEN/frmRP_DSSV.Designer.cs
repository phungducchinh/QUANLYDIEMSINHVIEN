namespace QUANLYDIEMSINHVIEN
{
    partial class frmRP_DSSV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.vDSPHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new QUANLYDIEMSINHVIEN.QLDSVDataSet();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSetCmbLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSetCmbLop = new QUANLYDIEMSINHVIEN.QLDSVDataSetCmbLop();
            this.qLDSVDataSet2 = new QUANLYDIEMSINHVIEN.QLDSVDataSet2();
            this.qLDSVDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSet2TableAdapters.DIEMTableAdapter();
            this.qLDSVDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QUANLYDIEMSINHVIEN.QLDSVDataSetCmbLopTableAdapters.LOPTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn lớp";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.vDSPHANMANHBindingSource;
            this.cmbKhoa.DisplayMember = "TENKHOA";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(140, 78);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(180, 27);
            this.cmbKhoa.TabIndex = 7;
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // vDSPHANMANHBindingSource
            // 
            this.vDSPHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.vDSPHANMANHBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lOPBindingSource;
            this.cmbLop.DisplayMember = "MALOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(140, 125);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(155, 27);
            this.cmbLop.TabIndex = 9;
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
            // qLDSVDataSet2
            // 
            this.qLDSVDataSet2.DataSetName = "QLDSVDataSet2";
            this.qLDSVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLDSVDataSet2BindingSource
            // 
            this.qLDSVDataSet2BindingSource.DataSource = this.qLDSVDataSet2;
            this.qLDSVDataSet2BindingSource.Position = 0;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.qLDSVDataSet2BindingSource;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // qLDSVDataSet2BindingSource1
            // 
            this.qLDSVDataSet2BindingSource1.DataSource = this.qLDSVDataSet2;
            this.qLDSVDataSet2BindingSource1.Position = 0;
            // 
            // qLDSVDataSet2BindingSource2
            // 
            this.qLDSVDataSet2BindingSource2.DataSource = this.qLDSVDataSet2;
            this.qLDSVDataSet2BindingSource2.Position = 0;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(604, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(430, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "In DSSV";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmRP_DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbLop);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRP_DSSV";
            this.Text = "frmRP_DSSV";
            this.Load += new System.EventHandler(this.frmRP_DSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vDSPHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetCmbLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet2BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbLop;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource vDSPHANMANHBindingSource;
        private System.Windows.Forms.BindingSource qLDSVDataSet2BindingSource;
        private QLDSVDataSet2 qLDSVDataSet2;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private QLDSVDataSet2TableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource qLDSVDataSetCmbLopBindingSource;
        private QLDSVDataSetCmbLop qLDSVDataSetCmbLop;
        private System.Windows.Forms.BindingSource qLDSVDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource qLDSVDataSet2BindingSource2;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetCmbLopTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}