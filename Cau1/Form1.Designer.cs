namespace Cau1
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


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            btnHuy = new Button();
            btnDangKy = new Button();
            txtXacNhanMK = new TextBox();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 39F, FontStyle.Bold);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 70);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 119);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 169);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "SDT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 220);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "Email :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 274);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu :";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(244, 116);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(336, 23);
            txtHoTen.TabIndex = 5;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(244, 166);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(336, 23);
            txtSDT.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(244, 271);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(336, 23);
            txtMatKhau.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 217);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(336, 23);
            txtEmail.TabIndex = 8;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(162, 378);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 9;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(454, 378);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(75, 23);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(244, 324);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(336, 23);
            txtXacNhanMK.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 327);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 12;
            label6.Text = "Nhập lại mật khẩu :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtXacNhanMK);
            Controls.Add(btnDangKy);
            Controls.Add(btnHuy);
            Controls.Add(txtEmail);
            Controls.Add(txtMatKhau);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private Button btnHuy;
        private Button btnDangKy;
        private TextBox txtXacNhanMK;
        private Label label6;
        private ErrorProvider errorProvider1;
    }
}
