using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B6Buoi6
{
    public partial class FormGhiChu : Form
    {
        private bool _daThayDoi = false;
        private Color _mauGocNut;
        public FormGhiChu()
        {
            InitializeComponent();

            _mauGocNut = btnLuuGhiChu.BackColor;

            if (cboMucDoUuTien.Items.Count > 1)
            {
                cboMucDoUuTien.SelectedIndex = 1;
            }
        }
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            _daThayDoi = true;
        }
        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (_daThayDoi)
                {
                    DialogResult ketQua = MessageBox.Show(
                        "Nội dung ghi chú đã bị thay đổi. Bạn có chắc muốn đóng không?",
                        "Xác nhận đóng",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (ketQua == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }
        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && txtNoiDung.Text.Length >= 500)
            {
                e.Handled = true;
            }
        }
        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }
        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightSkyBlue;
        }
        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = _mauGocNut;
        }
        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();

            if (string.IsNullOrEmpty(tieuDe))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (tieuDe.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được vượt quá 50 ký tự!");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtTieuDe, "");
            }
        }
        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }
        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            Text = txtTieuDe.Text.Trim();
            _daThayDoi = false;
            MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
