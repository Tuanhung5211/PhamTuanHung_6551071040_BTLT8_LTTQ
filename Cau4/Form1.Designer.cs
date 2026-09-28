namespace Cau4
{
    partial class FormDanhBa
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
            lstLienHe = new ListBox();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnThem = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(12, 12);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(396, 424);
            lstLienHe.TabIndex = 0;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(425, 40);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(363, 23);
            txtTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(425, 110);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(363, 23);
            txtSDT.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(425, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 3;
            label1.Text = "Tên :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(425, 77);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 4;
            label2.Text = "Số điện thoại :";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(644, 169);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 40);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(644, 396);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(144, 40);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(644, 292);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 40);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(644, 230);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 40);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lstLienHe);
            Name = "FormDanhBa";
            Text = "Quản lý danh bạ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;
        private TextBox txtTen;
        private TextBox txtSDT;
        private Label label1;
        private Label label2;
        private Button btnThem;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
    }
}
