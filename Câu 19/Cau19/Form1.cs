using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cau19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo danh sách các nút cho thanh công cụ ToolStrip
            ToolStripButton btnNew = new ToolStripButton("New");
            ToolStripButton btnOpen = new ToolStripButton("Open");
            ToolStripButton btnSave = new ToolStripButton("Save");
            ToolStripSeparator sep1 = new ToolStripSeparator();
            ToolStripButton btnCut = new ToolStripButton("Cut");
            ToolStripButton btnCopy = new ToolStripButton("Copy");
            ToolStripButton btnPaste = new ToolStripButton("Paste");

            // Gắn sự kiện rê chuột hiển thị thông báo trạng thái
            btnNew.MouseEnter += (s, ev) => lblStatus.Text = "Tạo văn bản mới";
            btnOpen.MouseEnter += (s, ev) => lblStatus.Text = "Mở tập tin";
            btnSave.MouseEnter += (s, ev) => lblStatus.Text = "Lưu tập tin";
            btnCut.MouseEnter += (s, ev) => lblStatus.Text = "Cắt đoạn văn bản";
            btnCopy.MouseEnter += (s, ev) => lblStatus.Text = "Sao chép đoạn văn bản";
            btnPaste.MouseEnter += (s, ev) => lblStatus.Text = "Dán đoạn văn bản";

            // Sự kiện khi chuột rời khỏi nút
            btnNew.MouseLeave += (s, ev) => lblStatus.Text = "Ready";
            btnOpen.MouseLeave += (s, ev) => lblStatus.Text = "Ready";
            btnSave.MouseLeave += (s, ev) => lblStatus.Text = "Ready";
            btnCut.MouseLeave += (s, ev) => lblStatus.Text = "Ready";
            btnCopy.MouseLeave += (s, ev) => lblStatus.Text = "Ready";
            btnPaste.MouseLeave += (s, ev) => lblStatus.Text = "Ready";

            // Gắn thao tác soạn thảo
            btnCut.Click += (s, ev) => rtbDoc.Cut();
            btnCopy.Click += (s, ev) => rtbDoc.Copy();
            btnPaste.Click += (s, ev) => rtbDoc.Paste();

            // Đưa tất cả các nút lên thanh ToolStrip
            toolStrip1.Items.AddRange(new ToolStripItem[] {
                btnNew, btnOpen, btnSave, sep1, btnCut, btnCopy, btnPaste
            });

            // Cập nhật trạng thái và hiển thị đồng hồ ban đầu
            lblStatus.Text = "Ready";
            CapNhatThoiGian();
        }

        // Cập nhật ngày giờ theo từng giây nhờ Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGian();
        }

        void CapNhatThoiGian()
        {
            // Hiển thị ngày theo định dạng: Sunday, June 09, 2002
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            // Hiển thị giờ theo định dạng: 9:56 PM
            lblTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void rtbDoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}