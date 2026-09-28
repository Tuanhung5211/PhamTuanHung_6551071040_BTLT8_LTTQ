namespace Cau3
{
    partial class FormNhapDiem
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
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtAnh = new TextBox();
            txtVan = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            listBox1 = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(145, 9);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(393, 9);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(503, 9);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 3;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(604, 9);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 4;
            label5.Text = "Điểm Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(29, 49);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(100, 23);
            txtMaHS.TabIndex = 0;
            txtMaHS.TextChanged += textBox1_TextChanged;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(145, 49);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(234, 23);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(397, 49);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(90, 23);
            txtToan.TabIndex = 2;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(604, 49);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(90, 23);
            txtAnh.TabIndex = 4;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(503, 49);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(90, 23);
            txtVan.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Lime;
            btnLuu.Font = new Font("Segoe UI", 12F);
            btnLuu.Location = new Point(29, 92);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 33);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Font = new Font("Segoe UI", 12F);
            btnXoaTrang.Location = new Point(141, 92);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(93, 33);
            btnXoaTrang.TabIndex = 11;
            btnXoaTrang.Text = "Xoá Trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(29, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(665, 289);
            listBox1.TabIndex = 12;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtVan);
            Controls.Add(txtAnh);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhapDiem";
            Text = "Nhập điểm học sinh";
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
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtAnh;
        private TextBox txtVan;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox listBox1;
        private ErrorProvider errorProvider1;
    }
}
