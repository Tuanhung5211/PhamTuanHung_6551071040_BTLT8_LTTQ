using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;

namespace Cau5
{
    partial class FormBanVe
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
            label4 = new Label();
            txtTenKhach = new TextBox();
            txtGheDaChon = new TextBox();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox(); // Đã sửa thành ComboBox
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(20, 38);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(380, 23);
            txtTenKhach.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 2;
            label2.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(20, 98);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(380, 23);
            cboPhim.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(20, 135);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 4;
            label3.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(20, 158);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(380, 23);
            cboSuatChieu.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(20, 195);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 6;
            label4.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(20, 218);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true; // Yêu cầu ReadOnly của đề
            txtGheDaChon.Size = new Size(380, 23);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(20, 265);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(115, 35);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(152, 265);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(115, 35);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(285, 265);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(115, 35);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 325);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(label4);
            Controls.Add(cboSuatChieu);
            Controls.Add(label3);
            Controls.Add(cboPhim);
            Controls.Add(label2);
            Controls.Add(txtTenKhach);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenKhach;
        private TextBox txtGheDaChon;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private Button btnChonGhe;
        private Button btnHuy;
        private Button btnDatVe;
    }
}