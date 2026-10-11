namespace Bai3
{
    partial class FrmLoaiPhong
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
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.SuspendLayout();
            // lblMa
            this.lblMa.Name = "lblMa";
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 23);
            this.lblMa.Text = "Mã loại";
            this.lblMa.TabIndex = 0;
            // txtMaLoai
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Location = new System.Drawing.Point(120, 20);
            this.txtMaLoai.Size = new System.Drawing.Size(150, 23);
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.TabIndex = 1;
            // lblTen
            this.lblTen.Name = "lblTen";
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(20, 58);
            this.lblTen.Text = "Tên loại phòng";
            this.lblTen.TabIndex = 2;
            // txtTenLoai
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Location = new System.Drawing.Point(120, 55);
            this.txtTenLoai.Size = new System.Drawing.Size(250, 23);
            this.txtTenLoai.MaxLength = 100;
            this.txtTenLoai.TabIndex = 3;
            // lblGia
            this.lblGia.Name = "lblGia";
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(20, 93);
            this.lblGia.Text = "Giá mỗi đêm";
            this.lblGia.TabIndex = 4;
            // numGia
            this.numGia.Name = "numGia";
            this.numGia.Location = new System.Drawing.Point(120, 90);
            this.numGia.Size = new System.Drawing.Size(150, 23);
            this.numGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numGia.ThousandsSeparator = true;
            this.numGia.TabIndex = 5;
            // lblMoTa
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(20, 128);
            this.lblMoTa.Text = "Mô tả";
            this.lblMoTa.TabIndex = 6;
            // txtMoTa
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Location = new System.Drawing.Point(120, 125);
            this.txtMoTa.Size = new System.Drawing.Size(250, 60);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.MaxLength = 255;
            this.txtMoTa.TabIndex = 7;
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
            this.txtTim.Location = new System.Drawing.Point(20, 205);
            this.txtTim.Size = new System.Drawing.Size(250, 23);
            this.txtTim.PlaceholderText = "Tìm theo tên loại phòng...";
            this.txtTim.TabIndex = 12;
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(280, 202);
            this.btnTim.Size = new System.Drawing.Size(90, 30);
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.TabIndex = 13;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // dgvLoai
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.Location = new System.Drawing.Point(20, 245);
            this.dgvLoai.Size = new System.Drawing.Size(720, 255);
            this.dgvLoai.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AllowUserToDeleteRows = false;
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.MultiSelect = false;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.RowHeadersVisible = false;
            this.dgvLoai.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLoai.AutoGenerateColumns = false;
            this.dgvLoai.TabIndex = 14;
            this.dgvLoai.SelectionChanged += new System.EventHandler(this.dgvLoai_SelectionChanged);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.numGia);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvLoai);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 520);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Loại phòng - Sunrise Homestay";
            this.Name = "FrmLoaiPhong";
            this.Load += new System.EventHandler(this.FrmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvLoai;
    }
}
