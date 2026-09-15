namespace Cau19
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNew = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            sep1 = new ToolStripSeparator();
            btnCut = new ToolStripButton();
            btnCopy = new ToolStripButton();
            btnPaste = new ToolStripButton();
            rtbDoc = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(57, 20);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNew, btnOpen, btnSave, sep1, btnCut, btnCopy, btnPaste });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(35, 22);
            btnNew.Text = "New";
            // 
            // btnOpen
            // 
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(40, 22);
            btnOpen.Text = "Open";
            // 
            // btnSave
            // 
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(35, 22);
            btnSave.Text = "Save";
            // 
            // sep1
            // 
            sep1.Name = "sep1";
            sep1.Size = new Size(6, 25);
            // 
            // btnCut
            // 
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(30, 22);
            btnCut.Text = "Cut";
            // 
            // btnCopy
            // 
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(39, 22);
            btnCopy.Text = "Copy";
            // 
            // btnPaste
            // 
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(39, 22);
            btnPaste.Text = "Paste";
            // 
            // rtbDoc
            // 
            rtbDoc.Dock = DockStyle.Fill;
            rtbDoc.Location = new Point(0, 49);
            rtbDoc.Name = "rtbDoc";
            rtbDoc.Size = new Size(800, 401);
            rtbDoc.TabIndex = 2;
            rtbDoc.Text = "";
            rtbDoc.TextChanged += rtbDoc_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus, lblDate, lblTime });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.BorderStyle = Border3DStyle.Sunken;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(785, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblDate
            // 
            lblDate.BorderStyle = Border3DStyle.Sunken;
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 17);
            // 
            // lblTime
            // 
            lblTime.BorderStyle = Border3DStyle.Sunken;
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 17);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(rtbDoc);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNew;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripSeparator sep1;
        private ToolStripButton btnCut;
        private ToolStripButton btnCopy;
        private ToolStripButton btnPaste;
        private RichTextBox rtbDoc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblDate;
        private ToolStripStatusLabel lblTime;
    }
}
