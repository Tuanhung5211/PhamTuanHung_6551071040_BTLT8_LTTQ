using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Bai1.Models;

namespace Bai1
{
    public partial class Form1 : Form
    {
        private QuanLyNhaSachContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new QuanLyNhaSachContext();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // 1. Không cho phép người dùng thêm/sửa/xóa trực tiếp trên ô
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AllowUserToDeleteRows = false;
            dgvTheLoai.ReadOnly = true;

            // 2. Khóa cố định chiều cao và vị trí tiêu đề cột
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // 3. Tự động giãn đều độ rộng các cột cho vừa khít toàn bộ bảng (không bị khoảng xám thừa bên phải)
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 4. Chọn nguyên dòng
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.MultiSelect = false;

            // Các sự kiện và load dữ liệu giữ nguyên...
            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnTimKiem.Click += btnTimKiem_Click;

            await LoadDataAsync();
        }

        // Tải danh sách thể loại lên DataGridView
        private async Task LoadDataAsync()
        {
            try
            {
                var list = await _context.TheLoaiSaches
                    .AsNoTracking()
                    .ToListAsync();

                // 1. Gán nguồn dữ liệu trước để DataGridView tự sinh các cột
                dgvTheLoai.DataSource = list;

                // 2. Sau khi đã có cột mới tiến hành đổi tiêu đề hiển thị
                if (dgvTheLoai.Columns["MaTl"] != null)
                    dgvTheLoai.Columns["MaTl"].HeaderText = "Mã TL";

                if (dgvTheLoai.Columns["TenTheLoai"] != null)
                    dgvTheLoai.Columns["TenTheLoai"].HeaderText = "Tên thể loại";

                if (dgvTheLoai.Columns["MoTa"] != null)
                    dgvTheLoai.Columns["MoTa"].HeaderText = "Mô tả";

                if (dgvTheLoai.Columns["SoLuongSach"] != null)
                    dgvTheLoai.Columns["SoLuongSach"].HeaderText = "Số lượng sách";

                if (dgvTheLoai.Columns["NgayTao"] != null)
                    dgvTheLoai.Columns["NgayTao"].HeaderText = "Ngày tạo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa trắng form nhập liệu
        private void ClearInputs()
        {
            txtMaTL.Clear();
            txtTenTL.Clear();
            txtMoTa.Clear();
            lblNgayTao.Text = string.Empty;
            dgvTheLoai.ClearSelection();
        }

        // 3. Đổ dữ liệu dòng đang chọn lên các control
        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow != null && dgvTheLoai.CurrentRow.DataBoundItem is TheLoaiSach tl)
            {
                txtMaTL.Text = tl.MaTl.ToString(); // MaTl theo model EF Core sinh ra
                txtTenTL.Text = tl.TenTheLoai;
                txtMoTa.Text = tl.MoTa;
                lblNgayTao.Text = tl.NgayTao?.ToString("yyyy/MM/dd HH:mm:ss") ?? "";
            }
        }

        // 4 & 7. Chức năng Thêm mới
        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenTL = txtTenTL.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenTL))
            {
                MessageBox.Show("Tên thể loại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTL.Focus();
                return;
            }

            bool isDuplicate = await _context.TheLoaiSaches.AnyAsync(x => x.TenTheLoai.ToLower() == tenTL.ToLower());
            if (isDuplicate)
            {
                MessageBox.Show("Tên thể loại đã tồn tại trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTL.Focus();
                return;
            }

            var item = new TheLoaiSach
            {
                TenTheLoai = tenTL,
                MoTa = txtMoTa.Text.Trim(),
                SoLuongSach = 0,
                NgayTao = DateTime.Now
            };

            try
            {
                await _context.TheLoaiSaches.AddAsync(item);
                await _context.SaveChangesAsync();

                MessageBox.Show("Thêm mới thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm mới thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4 & 7. Chức năng Cập nhật (Sửa)
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show("Vui lòng chọn thể loại cần cập nhật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTL = txtTenTL.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenTL))
            {
                MessageBox.Show("Tên thể loại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTL.Focus();
                return;
            }

            bool isDuplicate = await _context.TheLoaiSaches.AnyAsync(x => x.MaTl != maTL && x.TenTheLoai.ToLower() == tenTL.ToLower());
            if (isDuplicate)
            {
                MessageBox.Show("Tên thể loại đã bị trùng với một thể loại khác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTL.Focus();
                return;
            }

            var item = await _context.TheLoaiSaches.FindAsync(maTL);
            if (item == null)
            {
                MessageBox.Show("Không tìm thấy thể loại cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.TenTheLoai = tenTL;
            item.MoTa = txtMoTa.Text.Trim();

            try
            {
                await _context.SaveChangesAsync();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Chức năng Xóa với xử lý ngoại lệ DbUpdateException
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa thể loại này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialog != DialogResult.Yes) return;

            var item = await _context.TheLoaiSaches.FindAsync(maTL);
            if (item == null)
            {
                MessageBox.Show("Thể loại không tồn tại hoặc đã bị xóa trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _context.TheLoaiSaches.Remove(item);
                await _context.SaveChangesAsync();

                MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDataAsync();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Không thể xóa do thể loại này đang được sách khác tham chiếu!", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _context.Entry(item).State = EntityState.Detached;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6. Tìm kiếm LINQ (Where + Contains)
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            try
            {
                var query = _context.TheLoaiSaches.AsNoTracking().AsQueryable();

                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(x => x.TenTheLoai.ToLower().Contains(keyword));
                }

                dgvTheLoai.DataSource = await query.ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Làm mới
        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            ClearInputs();
            await LoadDataAsync();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}