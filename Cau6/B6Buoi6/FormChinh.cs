namespace B6Buoi6
{
    public partial class FormChinh : Form
    {
        private int _soThuTuGhiChu = 1;
        public FormChinh()
        {
            InitializeComponent();

            IsMdiContainer = true;

            foreach (Control ctl in Controls)
            {
                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.FromArgb(240, 240, 240);
                    break;
                }
            }
            CapNhatStatusStrip();
        }
        private void menuMoGhiChu_Click(object sender, EventArgs e)
        {
            FormGhiChu f = new FormGhiChu();
            f.MdiParent = this;
            f.Text = $"Ghi chú {_soThuTuGhiChu++}";

            f.FormClosed += FormCon_FormClosed;

            f.Show();
            CapNhatStatusStrip();
        }
        private void FormCon_FormClosed(object sender, FormClosedEventArgs e)
        {
            CapNhatStatusStrip();
        }
        private void CapNhatStatusStrip()
        {
            lblTrangThai.Text = $"Số ghi chú đang mở: {MdiChildren.Length}";
        }
        private void menuXepTang_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void menuXepNgang_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void menuXepDoc_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void menuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
