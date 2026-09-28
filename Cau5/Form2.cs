using System;
using System.Windows.Forms;

namespace Cau5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; }

        public FormChonGhe(string gheHienTai = "")
        {
            InitializeComponent();
            KhoiTaoDanhSachGhe();

            if (!string.IsNullOrEmpty(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
        }

        private void KhoiTaoDanhSachGhe()
        {
            lstGhe.Items.Clear();

            for (int col = 1; col <= 5; col++)
            {
                lstGhe.Items.Add($"A{col}");
                lstGhe.Items.Add($"B{col}");
                lstGhe.Items.Add($"C{col}");
            }
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = $"Đang chọn: {lstGhe.SelectedItem}";
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế trước khi xác nhận!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}