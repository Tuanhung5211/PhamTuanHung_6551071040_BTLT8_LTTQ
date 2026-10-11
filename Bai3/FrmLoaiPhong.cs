using Bai3.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai3;

public partial class FrmLoaiPhong : Form
{
    private bool _binding;
    private int _currentId;

    public FrmLoaiPhong()
    {
        InitializeComponent();
    }

    private async void FrmLoaiPhong_Load(object sender, EventArgs e)
    {
        dgvLoai.Columns.Clear();
        dgvLoai.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaLoai", DataPropertyName = "MaLoai", HeaderText = "Mã loại", Width = 70 });
        dgvLoai.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenLoai", DataPropertyName = "TenLoai", HeaderText = "Tên loại phòng", Width = 180 });
        var gia = new DataGridViewTextBoxColumn { Name = "GiaMoiDem", DataPropertyName = "GiaMoiDem", HeaderText = "Giá/đêm", Width = 110 };
        gia.DefaultCellStyle.Format = "N0";
        dgvLoai.Columns.Add(gia);
        dgvLoai.Columns.Add(new DataGridViewTextBoxColumn { Name = "MoTa", DataPropertyName = "MoTa", HeaderText = "Mô tả", Width = 320 });
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        using var db = new HomestayContext();
        var query = db.LoaiPhongs.AsNoTracking().AsQueryable();
        string key = txtTim.Text.Trim();
        if (key != "") query = query.Where(x => x.TenLoai.Contains(key));
        var list = await query.OrderBy(x => x.MaLoai).ToListAsync();

        _binding = true;
        dgvLoai.DataSource = list;
        dgvLoai.ClearSelection();
        _binding = false;
        ClearInputs();
    }

    private void ClearInputs()
    {
        _currentId = 0;
        txtMaLoai.Clear();
        txtTenLoai.Clear();
        numGia.Value = 0;
        txtMoTa.Clear();
    }

    private void dgvLoai_SelectionChanged(object sender, EventArgs e)
    {
        if (_binding || dgvLoai.SelectedRows.Count == 0) return;
        if (dgvLoai.SelectedRows[0].DataBoundItem is not LoaiPhong r) return;
        _currentId = r.MaLoai;
        txtMaLoai.Text = r.MaLoai.ToString();
        txtTenLoai.Text = r.TenLoai;
        numGia.Value = Math.Min(numGia.Maximum, r.GiaMoiDem ?? 0);
        txtMoTa.Text = r.MoTa;
    }

    private async Task<bool> ValidateInputAsync()
    {
        string ten = txtTenLoai.Text.Trim();
        if (ten == "")
        {
            MessageBox.Show("Tên loại phòng không được để trống.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenLoai.Focus();
            return false;
        }
        using var db = new HomestayContext();
        bool trung = await db.LoaiPhongs.AnyAsync(x => x.TenLoai == ten && x.MaLoai != _currentId);
        if (trung)
        {
            MessageBox.Show($"Loại phòng \"{ten}\" đã tồn tại.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenLoai.Focus();
            return false;
        }
        return true;
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!await ValidateInputAsync()) return;
        try
        {
            using var db = new HomestayContext();
            db.Add(new LoaiPhong { TenLoai = txtTenLoai.Text.Trim(), GiaMoiDem = numGia.Value, MoTa = txtMoTa.Text.Trim() });
            await db.SaveChangesAsync();
            MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi thêm: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnSua_Click(object sender, EventArgs e)
    {
        if (_currentId == 0)
        {
            MessageBox.Show("Vui lòng chọn một loại phòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (!await ValidateInputAsync()) return;
        try
        {
            using var db = new HomestayContext();
            var lp = await db.LoaiPhongs.FindAsync(_currentId);
            if (lp == null) { await LoadDataAsync(); return; }
            lp.TenLoai = txtTenLoai.Text.Trim();
            lp.GiaMoiDem = numGia.Value;
            lp.MoTa = txtMoTa.Text.Trim();
            await db.SaveChangesAsync();
            MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await LoadDataAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi sửa: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnXoa_Click(object sender, EventArgs e)
    {
        if (_currentId == 0)
        {
            MessageBox.Show("Vui lòng chọn một loại phòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (MessageBox.Show($"Bạn có chắc muốn xóa loại phòng \"{txtTenLoai.Text}\"?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            using var db = new HomestayContext();
            var lp = await db.LoaiPhongs.FindAsync(_currentId);
            if (lp != null)
            {
                db.LoaiPhongs.Remove(lp);
                await db.SaveChangesAsync();
                MessageBox.Show("Đã xóa loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa: loại phòng này đang được các phòng khác sử dụng.", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtTim.Clear();
        await LoadDataAsync();
    }

    private async void btnTim_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }
}
