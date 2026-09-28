using System;
using System.Windows.Forms;

namespace Cau4
{
    public partial class FormDanhBa : Form
    {
        // Biến theo dõi index của item đang được chọn sửa (-1 là đang ở chế độ thêm mới)
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();

            // Đăng ký sự kiện Click cho 4 nút bấm
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;

            // Đăng ký sự kiện FormClosing
            this.FormClosing += FormDanhBa_FormClosing;
        }

        // Xử lý sự kiện Load đã khai báo trong Designer
        private void Form1_Load(object sender, EventArgs e) { }

        // 2. Sự kiện btnThem_Click: Thêm mới hoặc cập nhật liên hệ
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra txtTen, txtSDT không rỗng
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ Tên và Số điện thoại!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string noiDungLienHe = $"{ten} - {sdt}";

            if (_indexDangSua != -1)
            {
                // Cập nhật lại item đang sửa
                lstLienHe.Items[_indexDangSua] = noiDungLienHe;
                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Trả về trạng thái thêm mới
                _indexDangSua = -1;
                btnThem.Text = "Thêm";
            }
            else
            {
                // Thêm mới vào ListBox
                lstLienHe.Items.Add(noiDungLienHe);
                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            // Xóa trắng TextBox và trả focus về txtTen
            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        // 3. Sự kiện btnXoa_Click: Xác nhận xóa liên hệ
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra chưa chọn item
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string dongDangChon = lstLienHe.SelectedItem.ToString();
            // Lấy tên trước ký tự " - "
            string ten = dongDangChon.Split(new string[] { " - " }, StringSplitOptions.None)[0];

            // Hộp thoại xác nhận Question Yes/No
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ [{ten}]? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show(
                    "Xóa thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Nếu đang sửa đúng item vừa xóa thì reset trạng thái
                _indexDangSua = -1;
                btnThem.Text = "Thêm";
                txtTen.Clear();
                txtSDT.Clear();
            }
        }

        // 4. Sự kiện btnSua_Click: Đưa thông tin lên 2 TextBox để sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string dongDangChon = lstLienHe.SelectedItem.ToString();
            string[] phanTach = dongDangChon.Split(new string[] { " - " }, StringSplitOptions.None);

            if (phanTach.Length >= 2)
            {
                txtTen.Text = phanTach[0].Trim();
                txtSDT.Text = phanTach[1].Trim();
            }
            else
            {
                txtTen.Text = dongDangChon;
                txtSDT.Text = "";
            }

            btnThem.Text = "Cập nhật";
            txtTen.Focus();
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 5. Sự kiện FormClosing: Kiểm tra dữ liệu chưa lưu trước khi đóng form
        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (ketQua == DialogResult.Yes)
                {
                    // Cho phép thoát
                }
                else if (ketQua == DialogResult.No)
                {
                    // Xóa TextBox rồi thoát
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (ketQua == DialogResult.Cancel)
                {
                    // Hủy thao tác đóng form
                    e.Cancel = true;
                }
            }
        }
    }
}