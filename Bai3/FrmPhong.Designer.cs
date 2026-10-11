namespace Bai3
{
    partial class FrmPhong
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
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.numTang = new System.Windows.Forms.NumericUpDown();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnLoaiPhong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboLocLoai = new System.Windows.Forms.ComboBox();
            this.cboLocTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numTang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // lblSoPhong
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(20, 15);
            this.lblSoPhong.Text = "Số phòng";
            this.lblSoPhong.TabIndex = 0;
            // txtSoPhong
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Location = new System.Drawing.Point(20, 35);
            this.txtSoPhong.Size = new System.Drawing.Size(150, 23);
            this.txtSoPhong.MaxLength = 10;
            this.txtSoPhong.TabIndex = 1;
            // lblTang
            this.lblTang.Name = "lblTang";
            this.lblTang.AutoSize = true;
            this.lblTang.Location = new System.Drawing.Point(190, 15);
            this.lblTang.Text = "Tầng số";
            this.lblTang.TabIndex = 2;
            // numTang
            this.numTang.Name = "numTang";
            this.numTang.Location = new System.Drawing.Point(190, 35);
            this.numTang.Size = new System.Drawing.Size(70, 23);
            this.numTang.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numTang.TabIndex = 3;
            // lblLoaiPhong
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(280, 15);
            this.lblLoaiPhong.Text = "Loại phòng";
            this.lblLoaiPhong.TabIndex = 4;
            // cboLoaiPhong
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Location = new System.Drawing.Point(280, 35);
            this.cboLoaiPhong.Size = new System.Drawing.Size(150, 23);
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.TabIndex = 5;
            // lblTinhTrang
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(450, 15);
            this.lblTinhTrang.Text = "Tình trạng";
            this.lblTinhTrang.TabIndex = 6;
            // cboTinhTrang
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Location = new System.Drawing.Point(450, 35);
            this.cboTinhTrang.Size = new System.Drawing.Size(130, 23);
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.TabIndex = 7;
            // picAnh
            this.picAnh.Name = "picAnh";
            this.picAnh.Location = new System.Drawing.Point(600, 15);
            this.picAnh.Size = new System.Drawing.Size(110, 80);
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 8;
            // btnChonAnh
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Location = new System.Drawing.Point(600, 100);
            this.btnChonAnh.Size = new System.Drawing.Size(110, 28);
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.TabIndex = 9;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // btnLoaiPhong
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.Location = new System.Drawing.Point(20, 75);
            this.btnLoaiPhong.Size = new System.Drawing.Size(160, 30);
            this.btnLoaiPhong.Text = "Quản lý loại phòng";
            this.btnLoaiPhong.UseVisualStyleBackColor = true;
            this.btnLoaiPhong.TabIndex = 10;
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            // btnThem
            this.btnThem.Name = "btnThem";
            this.btnThem.Location = new System.Drawing.Point(740, 15);
            this.btnThem.Size = new System.Drawing.Size(160, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.TabIndex = 11;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // btnSua
            this.btnSua.Name = "btnSua";
            this.btnSua.Location = new System.Drawing.Point(740, 51);
            this.btnSua.Size = new System.Drawing.Size(160, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.TabIndex = 12;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // btnXoa
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Location = new System.Drawing.Point(740, 87);
            this.btnXoa.Size = new System.Drawing.Size(160, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // btnLamMoi
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Location = new System.Drawing.Point(740, 123);
            this.btnLamMoi.Size = new System.Drawing.Size(160, 30);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // cboLocLoai
            this.cboLocLoai.Name = "cboLocLoai";
            this.cboLocLoai.Location = new System.Drawing.Point(20, 145);
            this.cboLocLoai.Size = new System.Drawing.Size(170, 23);
            this.cboLocLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoai.FormattingEnabled = true;
            this.cboLocLoai.TabIndex = 15;
            // cboLocTinhTrang
            this.cboLocTinhTrang.Name = "cboLocTinhTrang";
            this.cboLocTinhTrang.Location = new System.Drawing.Point(200, 145);
            this.cboLocTinhTrang.Size = new System.Drawing.Size(150, 23);
            this.cboLocTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTinhTrang.FormattingEnabled = true;
            this.cboLocTinhTrang.TabIndex = 16;
            // btnTim
            this.btnTim.Name = "btnTim";
            this.btnTim.Location = new System.Drawing.Point(360, 141);
            this.btnTim.Size = new System.Drawing.Size(90, 30);
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.TabIndex = 17;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // dgvPhong
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Location = new System.Drawing.Point(20, 185);
            this.dgvPhong.Size = new System.Drawing.Size(880, 375);
            this.dgvPhong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhong.AutoGenerateColumns = false;
            this.dgvPhong.TabIndex = 18;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.lblTang);
            this.Controls.Add(this.numTang);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnLoaiPhong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cboLocLoai);
            this.Controls.Add(this.cboLocTinhTrang);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvPhong);
            // form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 580);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng - Sunrise Homestay";
            this.Name = "FrmPhong";
            this.Load += new System.EventHandler(this.FrmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.NumericUpDown numTang;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cboLocLoai;
        private System.Windows.Forms.ComboBox cboLocTinhTrang;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvPhong;
    }
}
