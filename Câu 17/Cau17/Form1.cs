using System;
using System.Windows.Forms;

namespace Cau14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                //đưa con nháy vào ô txtTen
                txtTen.Focus();
            }
            else
            {
                //truyền dữ liệu vào list box
                string strDuLieu = txtTen.Text;
                lstLopA.Items.Add(strDuLieu);
                //xóa nội dung trong ô txtTen và đưa con nháy vào ô này
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            // ĐÃ SỬA: Đổi lstLopA thành lstLopB
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn không?", "Thông Báo",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu không?", "Thông Báo",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopA.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn không?", "Thông Báo",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DialogResult hoiChuyen;
            if (lstLopB.Items.Count > 0)
            {
                hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu không?", "Thông Báo",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i))
                {
                    string strDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(strDuLieu);
                    lst1.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0)
            {
                string strDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(strDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        private void btnDeleteA_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            if (lstLopA.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void btnDeleteB_Click(object sender, EventArgs e)
        {
            DialogResult hoiXoa;
            // ĐÃ SỬA: Đổi lstLopA thành lstLopB
            if (lstLopB.Items.Count > 0)
            {
                hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt") + " Designed by Tuấn Hưng";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn1_Click(sender, e);
        }

        private void cậpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus();
            }
            else
            {
                lstLopB.Items.Add(txtTen.Text);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void chuyểnHếtDsSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn4_Click(sender, e);
        }

        private void chuyểnHếtDsSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void xóaDanhSáchLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteA_Click(sender, e);
        }

        private void xóaDanhSáchLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDeleteB_Click(sender, e);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình Quản lý Sinh viên 2 Lớp\nNgười thiết kế: Tuấn Hưng",
                    "Thông Tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}