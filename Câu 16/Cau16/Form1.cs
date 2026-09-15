using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cau16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập các thuộc tính cho RichTextBox
            rtbText.Font = new Font("Arial", 12);
            rtbText.ForeColor = Color.Black;
            rtbText.BackColor = Color.White;
        }
        // --- 1. NHÁNH MENU FILE ---

        // File -> New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        // File -> Open...
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpenFile.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                if (dlgOpenFile.FileName.EndsWith(".rtf"))
                    rtbText.LoadFile(dlgOpenFile.FileName, RichTextBoxStreamType.RichText);
                else
                    rtbText.LoadFile(dlgOpenFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        // File -> Save As...
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSaveFile.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                if (dlgSaveFile.FileName.EndsWith(".rtf"))
                    rtbText.SaveFile(dlgSaveFile.FileName, RichTextBoxStreamType.RichText);
                else
                    rtbText.SaveFile(dlgSaveFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        // File -> Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- 2. NHÁNH MENU FORMAT ---

        // Format -> Font...
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
            {
                rtbText.SelectionFont = dlgFont.Font;
            }
        }

        // Format -> Color...
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                rtbText.SelectionColor = dlgColor.Color;
            }
        }

        // --- 3. CONTEXT MENU (Menu chuột phải trên RichTextBox) ---

        // Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        // Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        // Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        // --- 4. NHÁNH MENU HELP ---

        // Help -> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình Text Editor - Bài 16\nNgười thực hiện: Tuấn Hưng",
                            "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}