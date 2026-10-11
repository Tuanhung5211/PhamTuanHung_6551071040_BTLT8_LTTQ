using Bai4.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai4;

public partial class FrmBacSi : Form
{
    private bool _binding;
    private int _currentId;

    public FrmBacSi()
    {
        InitializeComponent();
    }

    private async void FrmBacSi_Load(object sender, EventArgs e)
    {
        dgvBacSi.Columns.Clear();
        dgvBacSi.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaBS", DataPropertyName = "MaBS", HeaderText = "Mã BS", Width = 70 });
        dgvBacSi.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoTen", DataPropertyName = "HoTen", HeaderText = "Họ tên", Width = 220 });
        dgvBacSi.Columns.Add(new DataGridViewTextBoxColumn { Name = "ChuyenKhoa", DataPropertyName = "ChuyenKhoa", HeaderText = "Chuyên khoa", Width = 200 });
        dgvBacSi.Columns.Add(new DataGridViewTextBoxColumn { Name = "SDT", DataPropertyName = "SDT", HeaderText = "SĐT", Width = 150 });
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        using var db = new AnKhangContext();
        var query = db.BacSis.AsNoTracking().AsQueryable();
        string key = txtTim.Text.Trim();
        if (key != "") query = query.Where(x => x.HoTen.Contains(key));
        var list = await query.OrderBy(x => x.MaBS).ToListAsync();

        _binding = true;
        dgvBacSi.DataSource = list;
        dgvBacSi.ClearSelection();
        _binding = false;
        ClearInputs();
    }

    private void ClearInputs()
    {
        _currentId = 0;
        txtMaBS.Clear();
        txtHoTen.Clear();
        txtChuyenKhoa.Clear();
        txtSDT.Clear();
    }

    private void dgvBacSi_SelectionChanged(object sender, EventArgs e)
    {
        if (_binding || dgvBacSi.SelectedRows.Count == 0) return;
        if (dgvBacSi.SelectedRows[0].DataBoundItem is not BacSi r) return;
        _currentId = r.MaBS;
        txtMaBS.Text = r.MaBS.ToString();
        txtHoTen.Text = r.HoTen;
        txtChuyenKhoa.Text = r.ChuyenKhoa;
        txtSDT.Text = r.SDT;
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtHoTen.Text))
        {
            MessageBox.Show("Họ tên bác sĩ không được để trống.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return false;
        }
        string sdt = txtSDT.Text.Trim();
        if (sdt != "" && !sdt.All(c => c >= '0' && c <= '9'))
        {
            MessageBox.Show("Số điện thoại chỉ được chứa chữ số.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSDT.Focus();
            return false;
        }
        return true;
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;
        try
        {
            using var db = new AnKhangContext();
            db.Add(new BacSi { HoTen = txtHoTen.Text.Trim(), ChuyenKhoa = txtChuyenKhoa.Text.Trim(), SDT = txtSDT.Text.Trim() });
            await db.SaveChangesAsync();
            MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Vui lòng chọn một bác sĩ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (!ValidateInput()) return;
        try
        {
            using var db = new AnKhangContext();
            var bs = await db.BacSis.FindAsync(_currentId);
            if (bs == null) { await LoadDataAsync(); return; }
            bs.HoTen = txtHoTen.Text.Trim();
            bs.ChuyenKhoa = txtChuyenKhoa.Text.Trim();
            bs.SDT = txtSDT.Text.Trim();
            await db.SaveChangesAsync();
            MessageBox.Show("Cập nhật bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Vui lòng chọn một bác sĩ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (MessageBox.Show($"Bạn có chắc muốn xóa bác sĩ \"{txtHoTen.Text}\"?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            using var db = new AnKhangContext();
            var bs = await db.BacSis.FindAsync(_currentId);
            if (bs != null)
            {
                db.BacSis.Remove(bs);
                await db.SaveChangesAsync();
                MessageBox.Show("Đã xóa bác sĩ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            await LoadDataAsync();
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Không thể xóa: bác sĩ này đang có lịch khám.", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
