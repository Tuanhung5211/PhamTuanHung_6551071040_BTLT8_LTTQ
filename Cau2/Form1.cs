using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace Cau2
{
    public partial class FormDatPhong : Form
    {
        private ErrorProvider errorProviderHopLe = new ErrorProvider();

        public FormDatPhong()
        {
            InitializeComponent();

            // Cho phép chuyển ô và đóng Form tự do kể cả khi đang có ô bị lỗi
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            // Cấu hình ErrorProvider báo lỗi
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Cấu hình ErrorProvider báo hợp lệ (icon dấu tích xanh)
            errorProviderHopLe.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProviderHopLe.Icon = TaoIconDauTichXanh();

            // Đăng ký sự kiện Validating cho từng ô
            this.txtHoTen.Validating += new CancelEventHandler(this.txtHoTen_Validating);
            this.txtCCCD.Validating += new CancelEventHandler(this.txtCCCD_Validating);
            this.txtNgayNhan.Validating += new CancelEventHandler(this.txtNgayNhan_Validating);
            this.txtNgayTra.Validating += new CancelEventHandler(this.txtNgayTra_Validating);
            this.txtSoNguoiLon.Validating += new CancelEventHandler(this.txtSoNguoiLon_Validating);
            this.txtSoTreEm.Validating += new CancelEventHandler(this.txtSoTreEm_Validating);

            // Gắn sự kiện nút Đặt phòng
            this.btnDatPhong.Click += new EventHandler(this.btnDatPhong_Click);
        }

        // Tạo icon tích xanh động kích thước 16x16
        private Icon TaoIconDauTichXanh()
        {
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.ForestGreen, 2.5f))
                {
                    g.DrawLine(pen, 2, 8, 6, 13);
                    g.DrawLine(pen, 6, 13, 13, 3);
                }
            }
            return Icon.FromHandle(bmp.GetHicon());
        }

        #region Các hàm phụ trợ cập nhật trạng thái hiển thị

        // Báo lỗi: Đổi nền đỏ nhạt + hiện icon lỗi đỏ + tắt dấu tích xanh (KHÔNG giữ focus)
        private void BaoLoi(Control control, string noiDungLoi)
        {
            errorProviderHopLe.SetError(control, "");
            errorProvider1.SetError(control, noiDungLoi);
            control.BackColor = Color.MistyRose;
        }

        // Báo hợp lệ: Đổi nền xanh nhạt + hiện icon tích xanh + tắt lỗi đỏ
        private void BaoHopLe(Control control)
        {
            errorProvider1.SetError(control, "");
            errorProviderHopLe.SetError(control, "Hợp lệ");
            control.BackColor = Color.Honeydew;
        }

        #endregion

        #region 2. Sự kiện Validating cho từng TextBox

        // (1) Họ tên: không để trống
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                BaoLoi(txtHoTen, "Họ tên không được để trống!");
            }
            else
            {
                BaoHopLe(txtHoTen);
            }
        }

        // (2) Số CCCD: đúng 12 chữ số
        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (cccd.Length != 12 || !long.TryParse(cccd, out _))
            {
                BaoLoi(txtCCCD, "Số CCCD phải gồm đúng 12 chữ số!");
            }
            else
            {
                BaoHopLe(txtCCCD);
            }
        }

        // (3) Ngày nhận phòng: dd/MM/yyyy và >= hôm nay
        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayNhan;
            bool hopLe = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            if (!hopLe || ngayNhan.Date < DateTime.Today)
            {
                BaoLoi(txtNgayNhan, "Ngày nhận phòng phải theo định dạng dd/MM/yyyy và từ hôm nay trở đi!");
            }
            else
            {
                BaoHopLe(txtNgayNhan);
            }
        }

        // (4) Ngày trả phòng: dd/MM/yyyy và sau ngày nhận
        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngayTra;
            DateTime ngayNhan;

            bool hopLeTra = DateTime.TryParseExact(
                txtNgayTra.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayTra
            );

            bool hopLeNhan = DateTime.TryParseExact(
                txtNgayNhan.Text.Trim(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out ngayNhan
            );

            if (!hopLeTra || !hopLeNhan || ngayTra.Date <= ngayNhan.Date)
            {
                BaoLoi(txtNgayTra, "Ngày trả phải sau ngày nhận");
            }
            else
            {
                BaoHopLe(txtNgayTra);
            }
        }

        // (5) Số người lớn: số nguyên 1-4
        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            int soNguoiLon;
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                BaoLoi(txtSoNguoiLon, "Số người lớn phải từ 1 đến 4!");
            }
            else
            {
                BaoHopLe(txtSoNguoiLon);
            }
        }

        // (6) Số trẻ em: số nguyên 0-3
        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            int soTreEm;
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                BaoLoi(txtSoTreEm, "Số trẻ em phải từ 0 đến 3!");
            }
            else
            {
                BaoHopLe(txtSoTreEm);
            }
        }

        #endregion

        #region 4. Sự kiện btnDatPhong_Click

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Buộc kích hoạt validation cho toàn bộ các control
            this.ValidateChildren();

            // Nếu còn bất kỳ ô nào có thông báo lỗi thì dừng lại
            if (!string.IsNullOrEmpty(errorProvider1.GetError(txtHoTen)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtCCCD)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtNgayNhan)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtNgayTra)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtSoNguoiLon)) ||
                !string.IsNullOrEmpty(errorProvider1.GetError(txtSoTreEm)))
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int soDem = (ngayTra.Date - ngayNhan.Date).Days;

            string thongBao = $"Đặt phòng thành công!\n\n" +
                              $"- Tên khách hàng: {txtHoTen.Text.Trim()}\n" +
                              $"- Số đêm: {soDem} đêm\n" +
                              $"- Số người lớn: {txtSoNguoiLon.Text.Trim()}\n" +
                              $"- Số trẻ em: {txtSoTreEm.Text.Trim()}";

            MessageBox.Show(thongBao, "Thông tin đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}