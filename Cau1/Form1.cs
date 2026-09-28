using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tự động gắn sự kiện Click cho 2 nút bấm
            this.btnDangKy.Click += new EventHandler(this.btnDangKy_Click);
            this.btnHuy.Click += new EventHandler(this.btnHuy_Click);

            // Cấu hình biểu tượng lỗi dấu X đỏ và chế độ nhấp nháy
            errorProvider1.Icon = SystemIcons.Error;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
        }

        // 2. Viết hàm bool KiemTraHopLe()
        private bool KiemTraHopLe()
        {
            bool isValid = true;

            // (1) txtHoTen: không để trống và tối thiểu 3 ký tự
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                isValid = false;
            }
            else if (hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có tối thiểu 3 ký tự!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // (2) txtSDT: đúng 10 chữ số, bắt đầu bằng "0"
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !long.TryParse(sdt, out _))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm 10 chữ số và bắt đầu bằng số 0!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // (3) txtEmail: chứa "@" và "." phía sau "@"
            string email = txtEmail.Text.Trim();
            int atIndex = email.IndexOf('@');
            if (atIndex == -1 || email.IndexOf('.', atIndex) == -1)
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ (phải chứa '@' và dấu '.' phía sau '@')!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // (4) txtMatKhau: tối thiểu 6 ký tự
            string matKhau = txtMatKhau.Text;
            if (matKhau.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // (5) txtXacNhanMK: phải khớp với txtMatKhau
            string xacNhanMK = txtXacNhanMK.Text;
            if (string.IsNullOrEmpty(xacNhanMK) || xacNhanMK != matKhau)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return isValid;
        }

        // 3. Sự kiện btnDangKy_Click
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text.Trim(),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // 4. Sự kiện btnHuy_Click
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}