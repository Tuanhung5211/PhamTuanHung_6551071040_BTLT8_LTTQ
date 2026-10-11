namespace Bai2
{
    partial class FrmHoiVien
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblHang = new System.Windows.Forms.Label();
            this.cboHang = new System.Windows.Forms.ComboBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblLoc = new System.Windows.Forms.Label();
            this.cboLocHang = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvHoiVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).BeginInit();
            this.SuspendLayout();
            // lblHoTen
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(20, 23);
            this.lblHoTen.Text = "Họ tên";
            this.lblHoTen.TabIndex = 0;
            // txtHoTen
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Location = new System.Drawing.Point(130, 20);
            this.txtHoTen.Size = new System.Drawing.Size(200, 23);
            this.txtHoTen.TabIndex = 1;
            // lblMa
            this.lblMa.Name = "lblMa";
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 58);
            this.lblMa.Text = "Mã hội viên";
            this.lblMa.TabIndex = 2;
            // txtMaHV
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Location = new System.Drawing.Point(130, 55);
            this.txtMaHV.Size = new System.Drawing.Size(200, 23);
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.TabIndex = 3;
            // lblSDT
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(20, 93);
            this.lblSDT.Text = "Số điện thoại";
            this.lblSDT.TabIndex = 4;
            // txtSDT
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Location = new System.Drawing.Point(130, 90);
            this.txtSDT.Size = new System.Drawing.Size(200, 23);
            this.txtSDT.MaxLength = 15;
            this.txtSDT.TabIndex = 5;
            // lblEmail
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 128);
            this.lblEmail.Text = "Email";
            this.lblEmail.TabIndex = 6;
            // txtEmail
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Location = new System.Drawing.Point(130, 125);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.TabIndex = 7;
            // lblNgaySinh
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 163);
            this.lblNgaySinh.Text = "Ngày sinh";
            this.lblNgaySinh.TabIndex = 8;
            // dtpNgaySinh
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Location = new System.Drawing.Point(130, 160);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 23);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.TabIndex = 9;
            // lblHang
            this.lblHang.Name = "lblHang";
            this.lblHang.AutoSize = true;
            this.lblHang.Location = new System.Drawing.Point(20, 198);
            this.lblHang.Text = "Hạng thành viên";
            this.lblHang.TabIndex = 10;
            // cboHang
            this.cboHang.Name = "cboHang";
            this.cboHang.Location = new System.Drawing.Point(130, 195);
            this.cboHang.Size = new System.Drawing.Size(200, 23);
            this.cboHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHang.FormattingEnabled = true;
            this.cboHang.TabIndex = 11;
            // chkTrangThai
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.Location = new System.Drawing.Point(130, 230);
            this.chkTrangThai.Text = "Đang hoạt động";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            this.chkTrangThai.TabIndex = 12;
            // grpGioiTinh
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Location = new System.Drawing.Point(370, 15);
            this.grpGioiTinh.Size = new System.Drawing.Size(250, 65);
            this.grpGioiTinh.Text = "Giới tính";
            this.grpGioiTinh.TabIndex = 13;
            // rdoNam
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(30, 28);
            this.rdoNam.Text = "Nam";
            this.rdoNam.TabStop = true;
            this.rdoNam.UseVisualStyleBackColor = true;
            this.rdoNam.TabIndex = 14;
            // rdoNu
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(130, 28);
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            this.rdoNu.TabIndex = 15;
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(700, 15);
            this.btnThem.Size = new System.Drawing.Size(150, 34);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.TabIndex = 16;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(700, 57);
            this.btnSua.Size = new System.Drawing.Size(150, 34);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.TabIndex = 17;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(700, 99);
            this.btnXoa.Size = new System.Drawing.Size(150, 34);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnLamMoi
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(700, 141);
            this.btnLamMoi.Size = new System.Drawing.Size(150, 34);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // txtTim
            this.txtTim.Name = "txtTim";
            this.txtTim.Location = new System.Drawing.Point(20, 275);
            this.txtTim.Size = new System.Drawing.Size(230, 23);
            this.txtTim.PlaceholderText = "Tìm theo họ tên...";
            this.txtTim.TabIndex = 20;
            // lblLoc
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(275, 279);
            this.lblLoc.Text = "Hạng thành viên";
            this.lblLoc.TabIndex = 21;
            // cboLocHang
            this.cboLocHang.Name = "cboLocHang";
            this.cboLocHang.Location = new System.Drawing.Point(375, 275);
            this.cboLocHang.Size = new System.Drawing.Size(130, 23);
            this.cboLocHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocHang.FormattingEnabled = true;
            this.cboLocHang.TabIndex = 22;
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(525, 272);
            this.btnTim.Size = new System.Drawing.Size(100, 30);
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.TabIndex = 23;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // dgvHoiVien
            this.dgvHoiVien.Name = "dgvHoiVien";
            this.dgvHoiVien.Location = new System.Drawing.Point(20, 315);
            this.dgvHoiVien.Size = new System.Drawing.Size(840, 235);
            this.dgvHoiVien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvHoiVien.AllowUserToAddRows = false;
            this.dgvHoiVien.AllowUserToDeleteRows = false;
            this.dgvHoiVien.ReadOnly = true;
            this.dgvHoiVien.MultiSelect = false;
            this.dgvHoiVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoiVien.RowHeadersVisible = false;
            this.dgvHoiVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoiVien.AutoGenerateColumns = false;
            this.dgvHoiVien.TabIndex = 24;
            this.dgvHoiVien.SelectionChanged += new System.EventHandler(this.dgvHoiVien_SelectionChanged);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblHang);
            this.Controls.Add(this.cboHang);
            this.Controls.Add(this.chkTrangThai);
            this.Controls.Add(this.grpGioiTinh);
            this.grpGioiTinh.Controls.Add(this.rdoNam);
            this.grpGioiTinh.Controls.Add(this.rdoNu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.cboLocHang);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvHoiVien);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 570);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hội Viên Phòng Gym FitZone";
            this.Name = "FrmHoiVien";
            this.Load += new System.EventHandler(this.FrmHoiVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.ComboBox cboHang;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.ComboBox cboLocHang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvHoiVien;
    }
}
