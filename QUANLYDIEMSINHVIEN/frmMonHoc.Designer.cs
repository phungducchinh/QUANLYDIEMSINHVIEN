namespace QUANLYDIEMSINHVIEN
{
    partial class frmMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaMonHoc = new System.Windows.Forms.TextBox();
            this.txbTenMonHoc = new System.Windows.Forms.TextBox();
            this.btnThemMonHoc = new System.Windows.Forms.Button();
            this.btnChinhsuaMonhoc = new System.Windows.Forms.Button();
            this.btnXoamonHoc = new System.Windows.Forms.Button();
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập môn học";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(718, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên môn học";
            // 
            // txbMaMonHoc
            // 
            this.txbMaMonHoc.Location = new System.Drawing.Point(213, 330);
            this.txbMaMonHoc.Name = "txbMaMonHoc";
            this.txbMaMonHoc.Size = new System.Drawing.Size(151, 21);
            this.txbMaMonHoc.TabIndex = 4;
            // 
            // txbTenMonHoc
            // 
            this.txbTenMonHoc.Location = new System.Drawing.Point(511, 330);
            this.txbTenMonHoc.Name = "txbTenMonHoc";
            this.txbTenMonHoc.Size = new System.Drawing.Size(151, 21);
            this.txbTenMonHoc.TabIndex = 5;
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMonHoc.Location = new System.Drawing.Point(32, 393);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(105, 30);
            this.btnThemMonHoc.TabIndex = 6;
            this.btnThemMonHoc.Text = "Thêm môn học";
            this.btnThemMonHoc.UseVisualStyleBackColor = true;
            this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
            // 
            // btnChinhsuaMonhoc
            // 
            this.btnChinhsuaMonhoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhsuaMonhoc.Location = new System.Drawing.Point(159, 391);
            this.btnChinhsuaMonhoc.Name = "btnChinhsuaMonhoc";
            this.btnChinhsuaMonhoc.Size = new System.Drawing.Size(135, 30);
            this.btnChinhsuaMonhoc.TabIndex = 7;
            this.btnChinhsuaMonhoc.Text = "Chỉnh sửa môn học";
            this.btnChinhsuaMonhoc.UseVisualStyleBackColor = true;
            this.btnChinhsuaMonhoc.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoamonHoc
            // 
            this.btnXoamonHoc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoamonHoc.Location = new System.Drawing.Point(322, 393);
            this.btnXoamonHoc.Name = "btnXoamonHoc";
            this.btnXoamonHoc.Size = new System.Drawing.Size(105, 30);
            this.btnXoamonHoc.TabIndex = 8;
            this.btnXoamonHoc.Text = "Xóa môn học";
            this.btnXoamonHoc.UseVisualStyleBackColor = true;
            this.btnXoamonHoc.Click += new System.EventHandler(this.btnXoamonHoc_Click);
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMH,
            this.TENMH});
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(182, 106);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(431, 150);
            this.dataGridViewMonHoc.TabIndex = 9;
            this.dataGridViewMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonHoc_CellContentClick);
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "Mã môn học";
            this.MAMH.Name = "MAMH";
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "Tên môn học";
            this.TENMH.Name = "TENMH";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(470, 393);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 30);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Thực hiện";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(590, 393);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 30);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dataGridViewMonHoc);
            this.Controls.Add(this.btnXoamonHoc);
            this.Controls.Add(this.btnChinhsuaMonhoc);
            this.Controls.Add(this.btnThemMonHoc);
            this.Controls.Add(this.txbTenMonHoc);
            this.Controls.Add(this.txbMaMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaMonHoc;
        private System.Windows.Forms.TextBox txbTenMonHoc;
        private System.Windows.Forms.Button btnThemMonHoc;
        private System.Windows.Forms.Button btnChinhsuaMonhoc;
        private System.Windows.Forms.Button btnXoamonHoc;
        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}