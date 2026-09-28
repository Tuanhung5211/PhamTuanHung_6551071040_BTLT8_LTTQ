namespace B6Buoi6
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            menuMoGhiChu = new ToolStripMenuItem();
            sắpXếpCửaSổToolStripMenuItem = new ToolStripMenuItem();
            menuThoat = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            menuXepTang = new ToolStripMenuItem();
            menuXepNgang = new ToolStripMenuItem();
            menuXepDoc = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuMoGhiChu, sắpXếpCửaSổToolStripMenuItem, menuThoat });
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(48, 24);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // menuMoGhiChu
            // 
            menuMoGhiChu.Name = "menuMoGhiChu";
            menuMoGhiChu.Size = new Size(224, 26);
            menuMoGhiChu.Text = "Mở ghi chú mới";
            menuMoGhiChu.Click += menuMoGhiChu_Click;
            // 
            // sắpXếpCửaSổToolStripMenuItem
            // 
            sắpXếpCửaSổToolStripMenuItem.Name = "sắpXếpCửaSổToolStripMenuItem";
            sắpXếpCửaSổToolStripMenuItem.Size = new Size(224, 26);
            sắpXếpCửaSổToolStripMenuItem.Text = "Sắp xếp cửa sổ";
            // 
            // menuThoat
            // 
            menuThoat.Name = "menuThoat";
            menuThoat.Size = new Size(224, 26);
            menuThoat.Text = "Thoát";
            menuThoat.Click += menuThoat_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuXepTang, menuXepNgang, menuXepDoc });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // menuXepTang
            // 
            menuXepTang.Name = "menuXepTang";
            menuXepTang.Size = new Size(224, 26);
            menuXepTang.Text = "Xếp tầng";
            menuXepTang.Click += menuXepTang_Click;
            // 
            // menuXepNgang
            // 
            menuXepNgang.Name = "menuXepNgang";
            menuXepNgang.Size = new Size(224, 26);
            menuXepNgang.Text = "Xếp ngang";
            menuXepNgang.Click += menuXepNgang_Click;
            // 
            // menuXepDoc
            // 
            menuXepDoc.Name = "menuXepDoc";
            menuXepDoc.Size = new Size(224, 26);
            menuXepDoc.Text = "Xếp dọc";
            menuXepDoc.Click += menuXepDoc_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 16);
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            Text = "FormChinh";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem menuMoGhiChu;
        private ToolStripMenuItem sắpXếpCửaSổToolStripMenuItem;
        private ToolStripMenuItem menuThoat;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem menuXepTang;
        private ToolStripMenuItem menuXepNgang;
        private ToolStripMenuItem menuXepDoc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
    }
}
