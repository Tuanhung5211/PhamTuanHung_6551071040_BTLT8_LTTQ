namespace Bai4
{
    partial class FrmBacSi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblCK = new System.Windows.Forms.Label();
            this.txtChuyenKhoa = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvBacSi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).BeginInit();
            this.SuspendLayout();
            // lblMa
            this.lblMa.Name = "lblMa";
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 23);
            this.lblMa.Text = "Mã bác sĩ";
            this.lblMa.TabIndex = 0;
            // txtMaBS
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Location = new System.Drawing.Point(120, 20);
            this.txtMaBS.Size = new System.Drawing.Size(150, 23);
            this.txtMaBS.ReadOnly = true;
            this.txtMaBS.TabIndex = 1;
            // lblTen
            this.lblTen.Name = "lblTen";
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(20, 58);
            this.lblTen.Text = "Họ tên";
            this.lblTen.TabIndex = 2;
            // txtHoTen
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Location = new System.Drawing.Point(120, 55);
            this.txtHoTen.Size = new System.Drawing.Size(250, 23);
            this.txtHoTen.MaxLength = 100;
            this.txtHoTen.TabIndex = 3;
            // lblCK
            this.lblCK.Name = "lblCK";
            this.lblCK.AutoSize = true;
            this.lblCK.Location = new System.Drawing.Point(20, 93);
            this.lblCK.Text = "Chuyên khoa";
            this.lblCK.TabIndex = 4;
            // txtChuyenKhoa
            this.txtChuyenKhoa.Name = "txtChuyenKhoa";
            this.txtChuyenKhoa.Location = new System.Drawing.Point(120, 90);
            this.txtChuyenKhoa.Size = new System.Drawing.Size(250, 23);
            this.txtChuyenKhoa.MaxLength = 100;
            this.txtChuyenKhoa.TabIndex = 5;
            // lblSDT
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(20, 128);
            this.lblSDT.Text = "SĐT";
            this.lblSDT.TabIndex = 6;
            // txtSDT
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Location = new System.Drawing.Point(120, 125);
            this.txtSDT.Size = new System.Drawing.Size(250, 23);
            this.txtSDT.MaxLength = 15;
            this.txtSDT.TabIndex = 7;
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(560, 15);
            this.btnThem.Size = new System.Drawing.Size(150, 34);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.TabIndex = 8;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(560, 57);
            this.btnSua.Size = new System.Drawing.Size(150, 34);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.TabIndex = 9;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(560, 99);
            this.btnXoa.Size = new System.Drawing.Size(150, 34);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnLamMoi
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(560, 141);
            this.btnLamMoi.Size = new System.Drawing.Size(150, 34);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // txtTim
            this.txtTim.Name = "txtTim";
            this.txtTim.Location = new System.Drawing.Point(20, 175);
            this.txtTim.Size = new System.Drawing.Size(250, 23);
            this.txtTim.PlaceholderText = "Tìm theo họ tên bác sĩ...";
            this.txtTim.TabIndex = 12;
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(280, 172);
            this.btnTim.Size = new System.Drawing.Size(90, 30);
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.TabIndex = 13;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // dgvBacSi
            this.dgvBacSi.Name = "dgvBacSi";
            this.dgvBacSi.Location = new System.Drawing.Point(20, 215);
            this.dgvBacSi.Size = new System.Drawing.Size(720, 285);
            this.dgvBacSi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvBacSi.AllowUserToAddRows = false;
            this.dgvBacSi.AllowUserToDeleteRows = false;
            this.dgvBacSi.ReadOnly = true;
            this.dgvBacSi.MultiSelect = false;
            this.dgvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBacSi.RowHeadersVisible = false;
            this.dgvBacSi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvBacSi.AutoGenerateColumns = false;
            this.dgvBacSi.TabIndex = 14;
            this.dgvBacSi.SelectionChanged += new System.EventHandler(this.dgvBacSi_SelectionChanged);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMaBS);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblCK);
            this.Controls.Add(this.txtChuyenKhoa);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvBacSi);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Bác sĩ - An Khang Clinic";
            this.Name = "FrmBacSi";
            this.Load += new System.EventHandler(this.FrmBacSi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBacSi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblCK;
        private System.Windows.Forms.TextBox txtChuyenKhoa;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvBacSi;
    }
}
