namespace Cau18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild f = new frmChild();
            f.MdiParent = this; // Xác định Form chính là cha
            f.Text = "New Document " + (this.MdiChildren.Length); // Đặt tiêu đề cho form con
            f.Show();
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
