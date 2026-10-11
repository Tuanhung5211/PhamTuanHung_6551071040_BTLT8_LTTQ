namespace Bai4
{
    partial class FrmLichKham
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
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.lblGio = new System.Windows.Forms.Label();
            this.dtpGioKham = new System.Windows.Forms.DateTimePicker();
            this.lblBS = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblTT = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnQLBacSi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.lblLocBS = new System.Windows.Forms.Label();
            this.cboLocBS = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvLich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).BeginInit();
            this.SuspendLayout();
            // lblTen
            this.lblTen.Name = "lblTen";
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(20, 23);
            this.lblTen.Text = "Tên bệnh nhân";
            this.lblTen.TabIndex = 0;
            // txtTenBN
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Location = new System.Drawing.Point(120, 20);
            this.txtTenBN.Size = new System.Drawing.Size(230, 23);
            this.txtTenBN.MaxLength = 100;
            this.txtTenBN.TabIndex = 1;
            // lblSDT
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(20, 58);
            this.lblSDT.Text = "Số điện thoại";
            this.lblSDT.TabIndex = 2;
            // txtSDT
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Location = new System.Drawing.Point(120, 55);
            this.txtSDT.Size = new System.Drawing.Size(150, 23);
            this.txtSDT.MaxLength = 15;
            this.txtSDT.TabIndex = 3;
            // lblNgay
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(20, 93);
            this.lblNgay.Text = "Ngày khám";
            this.lblNgay.TabIndex = 4;
            // dtpNgayKham
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Location = new System.Drawing.Point(120, 90);
            this.dtpNgayKham.Size = new System.Drawing.Size(150, 23);
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKham.TabIndex = 5;
            // lblGio
            this.lblGio.Name = "lblGio";
            this.lblGio.AutoSize = true;
            this.lblGio.Location = new System.Drawing.Point(290, 58);
            this.lblGio.Text = "Giờ khám";
            this.lblGio.TabIndex = 6;
            // dtpGioKham
            this.dtpGioKham.Name = "dtpGioKham";
            this.dtpGioKham.Location = new System.Drawing.Point(360, 55);
            this.dtpGioKham.Size = new System.Drawing.Size(100, 23);
            this.dtpGioKham.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioKham.ShowUpDown = true;
            this.dtpGioKham.TabIndex = 7;
            // lblBS
            this.lblBS.Name = "lblBS";
            this.lblBS.AutoSize = true;
            this.lblBS.Location = new System.Drawing.Point(480, 23);
            this.lblBS.Text = "Bác sĩ";
            this.lblBS.TabIndex = 8;
            // cboBacSi
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Location = new System.Drawing.Point(480, 45);
            this.cboBacSi.Size = new System.Drawing.Size(280, 23);
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.TabIndex = 9;
            // lblTT
            this.lblTT.Name = "lblTT";
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(780, 23);
            this.lblTT.Text = "Trạng thái";
            this.lblTT.TabIndex = 10;
            // cboTrangThai
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Location = new System.Drawing.Point(780, 45);
            this.cboTrangThai.Size = new System.Drawing.Size(110, 23);
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.TabIndex = 11;
            // btnQLBacSi
            this.btnQLBacSi.Name = "btnQLBacSi";
            this.btnQLBacSi.Location = new System.Drawing.Point(480, 85);
            this.btnQLBacSi.Size = new System.Drawing.Size(140, 30);
            this.btnQLBacSi.Text = "Quản lý bác sĩ";
            this.btnQLBacSi.UseVisualStyleBackColor = true;
            this.btnQLBacSi.TabIndex = 12;
            this.btnQLBacSi.Click += new System.EventHandler(this.btnQLBacSi_Click);
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(20, 135);
            this.btnThem.Size = new System.Drawing.Size(100, 32);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.TabIndex = 13;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(130, 135);
            this.btnSua.Size = new System.Drawing.Size(100, 32);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.TabIndex = 14;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(240, 135);
            this.btnXoa.Size = new System.Drawing.Size(100, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnLamMoi
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(350, 135);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // lblTu
            this.lblTu.Name = "lblTu";
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(20, 192);
            this.lblTu.Text = "Từ ngày";
            this.lblTu.TabIndex = 17;
            // dtpTu
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Location = new System.Drawing.Point(80, 188);
            this.dtpTu.Size = new System.Drawing.Size(120, 23);
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTu.TabIndex = 18;
            // lblDen
            this.lblDen.Name = "lblDen";
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(215, 192);
            this.lblDen.Text = "Đến ngày";
            this.lblDen.TabIndex = 19;
            // dtpDen
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Location = new System.Drawing.Point(280, 188);
            this.dtpDen.Size = new System.Drawing.Size(120, 23);
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDen.TabIndex = 20;
            // lblLocBS
            this.lblLocBS.Name = "lblLocBS";
            this.lblLocBS.AutoSize = true;
            this.lblLocBS.Location = new System.Drawing.Point(420, 192);
            this.lblLocBS.Text = "Bác sĩ";
            this.lblLocBS.TabIndex = 21;
            // cboLocBS
            this.cboLocBS.Name = "cboLocBS";
            this.cboLocBS.Location = new System.Drawing.Point(470, 188);
            this.cboLocBS.Size = new System.Drawing.Size(280, 23);
            this.cboLocBS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocBS.FormattingEnabled = true;
            this.cboLocBS.TabIndex = 22;
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(765, 185);
            this.btnTim.Size = new System.Drawing.Size(100, 30);
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.TabIndex = 23;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // dgvLich
            this.dgvLich.Name = "dgvLich";
            this.dgvLich.Location = new System.Drawing.Point(20, 230);
            this.dgvLich.Size = new System.Drawing.Size(860, 320);
            this.dgvLich.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvLich.AllowUserToAddRows = false;
            this.dgvLich.AllowUserToDeleteRows = false;
            this.dgvLich.ReadOnly = true;
            this.dgvLich.MultiSelect = false;
            this.dgvLich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLich.RowHeadersVisible = false;
            this.dgvLich.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLich.AutoGenerateColumns = false;
            this.dgvLich.TabIndex = 24;
            this.dgvLich.SelectionChanged += new System.EventHandler(this.dgvLich_SelectionChanged);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTenBN);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.lblGio);
            this.Controls.Add(this.dtpGioKham);
            this.Controls.Add(this.lblBS);
            this.Controls.Add(this.cboBacSi);
            this.Controls.Add(this.lblTT);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.btnQLBacSi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblTu);
            this.Controls.Add(this.dtpTu);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtpDen);
            this.Controls.Add(this.lblLocBS);
            this.Controls.Add(this.cboLocBS);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvLich);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 570);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lịch Khám Bệnh - An Khang Clinic";
            this.Name = "FrmLichKham";
            this.Load += new System.EventHandler(this.FrmLichKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.DateTimePicker dtpGioKham;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnQLBacSi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.Windows.Forms.Label lblLocBS;
        private System.Windows.Forms.ComboBox cboLocBS;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvLich;
    }
}
