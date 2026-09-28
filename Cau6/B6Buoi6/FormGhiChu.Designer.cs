namespace B6Buoi6
{
    partial class FormGhiChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtTieuDe = new TextBox();
            txtNoiDung = new TextBox();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            lblTieuDeForm = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtTieuDe
            // 
            txtTieuDe.Font = new Font("Segoe UI", 12F);
            txtTieuDe.Location = new Point(133, 45);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(621, 34);
            txtTieuDe.TabIndex = 0;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Font = new Font("Segoe UI", 12F);
            txtNoiDung.Location = new Point(39, 123);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(715, 191);
            txtNoiDung.TabIndex = 1;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.Font = new Font("Segoe UI", 12F);
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp ", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(39, 351);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(151, 36);
            cboMucDoUuTien.TabIndex = 2;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Font = new Font("Segoe UI", 12F);
            btnLuuGhiChu.Location = new Point(594, 351);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(160, 36);
            btnLuuGhiChu.TabIndex = 3;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.AutoSize = true;
            lblTieuDeForm.Font = new Font("Segoe UI", 12F);
            lblTieuDeForm.Location = new Point(40, 45);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new Size(75, 28);
            lblTieuDeForm.TabIndex = 4;
            lblTieuDeForm.Text = "Tiêu đề";
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(39, 82);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 5;
            label2.Text = "Nội dung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(39, 317);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 6;
            label3.Text = "Priority";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTieuDeForm);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(txtTieuDe);
            KeyPreview = true;
            Name = "FormGhiChu";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTieuDe;
        private TextBox txtNoiDung;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private Label lblTieuDeForm;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}