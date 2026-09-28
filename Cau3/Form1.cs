using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cau3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();

            // 1. Cấu hình TabIndex chuẩn theo yêu cầu đề bài
            txtMaHS.TabIndex = 0;
            txtHoTen.TabIndex = 1;
            txtToan.TabIndex = 2;
            txtVan.TabIndex = 3;
            txtAnh.TabIndex = 4;
            button1.TabIndex = 5; // Nút Lưu
            button2.TabIndex = 6; // Nút Xóa Trắng

            // Đặt TabStop = false cho tất cả Label
            TatTabStopCacLabel(this);

            // 2. Đăng ký phím Enter chuyển field
            DangKyEnterChuyenField();

            // 3. Đăng ký sự kiện Enter (nhận focus) để bôi xanh toàn bộ chữ
            txtToan.Enter += TextBoxDiem_Enter;
            txtVan.Enter += TextBoxDiem_Enter;
            txtAnh.Enter += TextBoxDiem_Enter;

            // Gắn sự kiện Click cho nút Lưu (button1)
            button1.Click += btnLuu_Click;
        }

        // Khử lỗi các sự kiện đã lỡ đăng ký trong Designer
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        // Tắt TabStop cho tất cả Label trên Form
        private void TatTabStopCacLabel(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label)
                {
                    c.TabStop = false;
                }
                if (c.HasChildren)
                {
                    TatTabStopCacLabel(c);
                }
            }
        }

        // 2. Hàm DangKyEnterChuyenField(): duyệt các TextBox, bấm Enter để chuyển field
        private void DangKyEnterChuyenField()
        {
            TextBox[] danhSachTextBox = { txtMaHS, txtHoTen, txtToan, txtVan, txtAnh };

            foreach (TextBox tb in danhSachTextBox)
            {
                tb.KeyPress += (sender, e) =>
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        e.Handled = true; // Ngăn tiếng bip mặc định của Windows

                        Control ctrl = (Control)sender;
                        if (ctrl == txtAnh)
                        {
                            // txtAnh khi Enter -> gọi nút Lưu thực thi
                            button1.PerformClick();
                        }
                        else
                        {
                            // Chuyển focus sang control tiếp theo theo TabIndex
                            this.SelectNextControl(ctrl, true, true, true, true);
                        }
                    }
                };
            }
        }

        // 3. Sự kiện Enter (nhận focus) cho các ô điểm: bôi đen/xanh toàn bộ chữ để gõ đè
        private void TextBoxDiem_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.SelectAll();
            }
        }

        // 4. Sự kiện nút Lưu (button1)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hopLe = true;
            errorProvider1.Clear();

            // Kiểm tra rỗng Mã HS và Họ tên
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Mã học sinh không được để trống!");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                hopLe = false;
            }

            // Kiểm tra 3 điểm số từ 0.0 đến 10.0 bằng decimal.TryParse
            decimal diemToan, diemVan, diemAnh;

            if (!decimal.TryParse(txtToan.Text.Trim(), out diemToan) || diemToan < 0 || diemToan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán phải là số từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!decimal.TryParse(txtVan.Text.Trim(), out diemVan) || diemVan < 0 || diemVan > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn phải là số từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!decimal.TryParse(txtAnh.Text.Trim(), out diemAnh) || diemAnh < 0 || diemAnh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh phải là số từ 0.0 đến 10.0!");
                hopLe = false;
            }

            // Nếu dữ liệu không hợp lệ thì dừng lại
            if (!hopLe)
            {
                return;
            }

            // Hợp lệ: Thêm dòng vào ListBox định dạng "[MaHS] | [HoTen] | T:[Toan] V:[Van] A:[Anh]"
            string dongThongTin = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{diemToan} V:{diemVan} A:{diemAnh}";
            listBox1.Items.Add(dongThongTin);

            // Xóa trắng form và đưa focus về txtMaHS
            XoaTrangForm();
        }

        // Sự kiện nút Xóa Trắng (button2) - đã được nối với button2.Click trong Designer
        private void button2_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
        }

        // Hàm xóa trắng toàn bộ Form
        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();
            txtMaHS.Focus();
        }
    }
}