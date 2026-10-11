namespace Bai1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaTL = new TextBox();
            txtTenTL = new TextBox();
            txtMoTa = new TextBox();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnTimKiem = new Button();
            lblNgayTao = new Label();
            dgvTheLoai = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên thể loại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 2;
            label3.Text = "Mô tả";
            // 
            // txtMaTL
            // 
            txtMaTL.Location = new Point(105, 9);
            txtMaTL.Name = "txtMaTL";
            txtMaTL.ReadOnly = true;
            txtMaTL.Size = new Size(265, 23);
            txtMaTL.TabIndex = 3;
            // 
            // txtTenTL
            // 
            txtTenTL.Location = new Point(106, 52);
            txtTenTL.Name = "txtTenTL";
            txtTenTL.Size = new Size(264, 23);
            txtTenTL.TabIndex = 4;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(105, 93);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(265, 112);
            txtMoTa.TabIndex = 5;
            txtMoTa.TextChanged += textBox1_TextChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(12, 228);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(358, 23);
            txtTimKiem.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(407, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(497, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(592, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(682, 12);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 23);
            btnLamMoi.TabIndex = 10;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(407, 227);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(96, 23);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(605, 333);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(0, 15);
            lblNgayTao.TabIndex = 13;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AllowUserToDeleteRows = false;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Location = new Point(12, 266);
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.Size = new Size(745, 172);
            dgvTheLoai.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(dgvTheLoai);
            Controls.Add(lblNgayTao);
            Controls.Add(btnTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTimKiem);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenTL);
            Controls.Add(txtMaTL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản Lý Thể Loại Sách - Tri Thức Books";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaTL;
        private TextBox txtTenTL;
        private TextBox txtMoTa;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnTimKiem;
        private Label lblNgayTao;
        private DataGridView dgvTheLoai;
    }
}
