namespace Cau2
{
    partial class FormDatPhong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayNhan = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtSoTreEm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(164, 27);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(396, 23);
            txtHoTen.TabIndex = 0;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(164, 95);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(396, 23);
            txtCCCD.TabIndex = 1;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(164, 161);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(396, 23);
            txtNgayNhan.TabIndex = 2;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(164, 225);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(396, 23);
            txtNgayTra.TabIndex = 3;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(164, 292);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(396, 23);
            txtSoNguoiLon.TabIndex = 4;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(164, 360);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(396, 23);
            txtSoTreEm.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Họ tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 77);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Số CCCD :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 143);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 8;
            label3.Text = "Ngày nhận phòng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 274);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 9;
            label4.Text = "Số người lớn :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 207);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 10;
            label5.Text = "Ngày trả phòng :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(164, 342);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 11;
            label6.Text = "Số trẻ em :";
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.DodgerBlue;
            btnDatPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDatPhong.ForeColor = SystemColors.ButtonHighlight;
            btnDatPhong.Location = new Point(164, 402);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(396, 36);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatPhong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Name = "FormDatPhong";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayNhan;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtSoTreEm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
