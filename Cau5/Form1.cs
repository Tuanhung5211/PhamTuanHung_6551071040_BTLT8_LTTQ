using System;
using System.Windows.Forms;

namespace Cau5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu mẫu cho ComboBox
            cboPhim.Items.AddRange(new string[] { "Chiến binh cuối cùng", "Doraemon", "Oppenheimer" });
            cboSuatChieu.Items.AddRange(new string[] { "09:00", "13:30", "16:00", "19:00", "21:30" });

            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;
            if (cboSuatChieu.Items.Count > 0) cboSuatChieu.SelectedIndex = 0;
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            // Mở dialog bằng ShowDialog() trong khối using theo yêu cầu đề bài
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text.Trim()))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedItem == null || cboSuatChieu.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và suất chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng bấm 'Chọn ghế' để chọn vị trí ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongTin = $"Tên khách: {txtTenKhach.Text.Trim()}\n" +
                              $"Phim: {cboPhim.SelectedItem}\n" +
                              $"Suất: {cboSuatChieu.SelectedItem}\n" +
                              $"Ghế: {txtGheDaChon.Text.Trim()}\n" +
                              $"Giá: 75.000đ/vé";

            MessageBox.Show(thongTin, "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            txtGheDaChon.Clear();
            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;
            if (cboSuatChieu.Items.Count > 0) cboSuatChieu.SelectedIndex = 0;
            txtTenKhach.Focus();
        }
    }
}