namespace Cau14
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
            components = new System.ComponentModel.Container();
            txtTen = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            button1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btnDeleteB = new Button();
            btnDeleteA = new Button();
            btnEnd = new Button();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpAToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            xóaDanhSáchLớpAToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpBToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(187, 71);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(296, 23);
            txtTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(65, 66);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên SV:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ButtonFace;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.Location = new Point(524, 69);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btn1_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(65, 124);
            lstLopA.Name = "lstLopA";
            lstLopA.Size = new Size(244, 229);
            lstLopA.TabIndex = 3;
            lstLopA.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(457, 124);
            lstLopB.Name = "lstLopB";
            lstLopB.Size = new Size(244, 229);
            lstLopB.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(353, 124);
            button1.Name = "button1";
            button1.Size = new Size(61, 47);
            button1.TabIndex = 5;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn2.Location = new Point(353, 177);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 47);
            btn2.TabIndex = 6;
            btn2.Text = ">>";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn3.Location = new Point(353, 253);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 47);
            btn3.TabIndex = 7;
            btn3.Text = "<";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn4.Location = new Point(353, 306);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 47);
            btn4.TabIndex = 8;
            btn4.Text = "<<";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnDeleteB
            // 
            btnDeleteB.BackColor = SystemColors.ButtonFace;
            btnDeleteB.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteB.Location = new Point(509, 375);
            btnDeleteB.Name = "btnDeleteB";
            btnDeleteB.Size = new Size(161, 45);
            btnDeleteB.TabIndex = 11;
            btnDeleteB.Text = "Xoá Lớp B";
            btnDeleteB.UseVisualStyleBackColor = false;
            btnDeleteB.Click += btnDeleteB_Click;
            // 
            // btnDeleteA
            // 
            btnDeleteA.BackColor = SystemColors.ButtonFace;
            btnDeleteA.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteA.Location = new Point(86, 375);
            btnDeleteA.Name = "btnDeleteA";
            btnDeleteA.Size = new Size(161, 45);
            btnDeleteA.TabIndex = 12;
            btnDeleteA.Text = "Xoá Lớp A";
            btnDeleteA.UseVisualStyleBackColor = false;
            btnDeleteA.Click += btnDeleteA_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = SystemColors.ButtonFace;
            btnEnd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEnd.Location = new Point(299, 375);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(161, 45);
            btnEnd.TabIndex = 13;
            btnEnd.Text = "Kết Thúc";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Highlight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtLớpAToolStripMenuItem, cậpNhậtLớpBToolStripMenuItem, chuyểnPhầnTửChọnSangLớpAToolStripMenuItem, chuyểnPhầnTửChọnSangLớpBToolStripMenuItem, chuyểnHếtDsSangLớpAToolStripMenuItem, chuyểnHếtDsSangLớpBToolStripMenuItem, toolStripMenuItem1, xóaDanhSáchLớpAToolStripMenuItem, xóaDanhSáchLớpBToolStripMenuItem });
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(69, 20);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            cậpNhậtLớpAToolStripMenuItem.Size = new Size(256, 22);
            cậpNhậtLớpAToolStripMenuItem.Text = "Cập Nhật Lớp A";
            cậpNhậtLớpAToolStripMenuItem.Click += cậpNhậtLớpAToolStripMenuItem_Click;
            // 
            // cậpNhậtLớpBToolStripMenuItem
            // 
            cậpNhậtLớpBToolStripMenuItem.Name = "cậpNhậtLớpBToolStripMenuItem";
            cậpNhậtLớpBToolStripMenuItem.Size = new Size(256, 22);
            cậpNhậtLớpBToolStripMenuItem.Text = "Cập Nhật Lớp B";
            cậpNhậtLớpBToolStripMenuItem.Click += cậpNhậtLớpBToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửChọnSangLớpAToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpAToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Size = new Size(256, 22);
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp A";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửChọnSangLớpBToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpBToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Size = new Size(256, 22);
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click;
            // 
            // chuyểnHếtDsSangLớpAToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpAToolStripMenuItem.Name = "chuyểnHếtDsSangLớpAToolStripMenuItem";
            chuyểnHếtDsSangLớpAToolStripMenuItem.Size = new Size(256, 22);
            chuyểnHếtDsSangLớpAToolStripMenuItem.Text = "Chuyển Hết ds sang Lớp A";
            chuyểnHếtDsSangLớpAToolStripMenuItem.Click += chuyểnHếtDsSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnHếtDsSangLớpBToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpBToolStripMenuItem.Name = "chuyểnHếtDsSangLớpBToolStripMenuItem";
            chuyểnHếtDsSangLớpBToolStripMenuItem.Size = new Size(256, 22);
            chuyểnHếtDsSangLớpBToolStripMenuItem.Text = "Chuyển Hết ds Sang Lớp B";
            chuyểnHếtDsSangLớpBToolStripMenuItem.Click += chuyểnHếtDsSangLớpBToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(253, 6);
            // 
            // xóaDanhSáchLớpAToolStripMenuItem
            // 
            xóaDanhSáchLớpAToolStripMenuItem.Name = "xóaDanhSáchLớpAToolStripMenuItem";
            xóaDanhSáchLớpAToolStripMenuItem.Size = new Size(256, 22);
            xóaDanhSáchLớpAToolStripMenuItem.Text = "Xóa Danh Sách Lớp A";
            xóaDanhSáchLớpAToolStripMenuItem.Click += xóaDanhSáchLớpAToolStripMenuItem_Click;
            // 
            // xóaDanhSáchLớpBToolStripMenuItem
            // 
            xóaDanhSáchLớpBToolStripMenuItem.Name = "xóaDanhSáchLớpBToolStripMenuItem";
            xóaDanhSáchLớpBToolStripMenuItem.Size = new Size(256, 22);
            xóaDanhSáchLớpBToolStripMenuItem.Text = "Xóa Danh Sách Lớp B";
            xóaDanhSáchLớpBToolStripMenuItem.Click += xóaDanhSáchLớpBToolStripMenuItem_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, kếtThúcToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(72, 20);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            hệThốngToolStripMenuItem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(129, 22);
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // kếtThúcToolStripMenuItem
            // 
            kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            kếtThúcToolStripMenuItem.Size = new Size(129, 22);
            kếtThúcToolStripMenuItem.Text = "Kết Thúc";
            kếtThúcToolStripMenuItem.Click += kếtThúcToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Highlight;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(btnEnd);
            Controls.Add(btnDeleteA);
            Controls.Add(btnDeleteB);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(button1);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form Cập Nhật 2 ListBox";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private Label label1;
        private Button btnUpdate;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button button1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btnDeleteB;
        private Button btnDeleteA;
        private Button btnEnd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsSangLớpBToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem xóaDanhSáchLớpAToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpBToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
    }
}
