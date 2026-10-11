using Bai2.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai2;

// Dòng hiển thị trên DataGridView
public class HoiVienRow
{
    public int MaHV { get; set; }
    public string HoTen { get; set; }
    public string GioiTinhText { get; set; }
    public DateTime? NgaySinh { get; set; }
    public string SDT { get; set; }
    public string Email { get; set; }
    public string HangThanhVien { get; set; }
    public string TrangThaiText { get; set; }
    // dữ liệu thô để đổ lên control (không hiện trên lưới)
    public bool GioiTinh { get; set; }
    public bool TrangThai { get; set; }
}

public partial class FrmHoiVien : Form
{
    private bool _binding;   // chặn SelectionChanged khi đang nạp dữ liệu
    private int _currentId;  // MaHV đang chọn (0 = chưa chọn)

    public FrmHoiVien()
    {
        InitializeComponent();
    }

    private async void FrmHoiVien_Load(object sender, EventArgs e)
    {
        SetupGrid();
        cboHang.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
        cboLocHang.Items.AddRange(new object[] { "Tất cả", "Basic", "VIP", "Premium" });
        cboLocHang.SelectedIndex = 0;
        dtpNgaySinh.MaxDate = DateTime.Today;
        ClearInputs();
        await LoadDataAsync();
    }

    // ---------- Lưới ----------
    private void SetupGrid()
    {
        dgvHoiVien.Columns.Clear();
        void Add(string prop, string header, int width, string format = null)
        {
            var col = new DataGridViewTextBoxColumn { Name = prop, DataPropertyName = prop, HeaderText = header, Width = width };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvHoiVien.Columns.Add(col);
        }
        Add("MaHV", "Mã HV", 60);
        Add("HoTen", "Họ tên", 170);
        Add("GioiTinhText", "Giới tính", 70);
        Add("NgaySinh", "Ngày sinh", 100, "dd/MM/yyyy");
        Add("SDT", "SĐT", 110);
        Add("Email", "Email", 150);
        Add("HangThanhVien", "Hạng thành viên", 110);
        Add("TrangThaiText", "Trạng thái", 100);
    }

    // Nạp dữ liệu + lọc đa điều kiện: Họ tên (Contains) && Hạng thành viên
    private async Task LoadDataAsync()
    {
        using var db = new FitZoneContext();
        var query = db.HoiViens.AsNoTracking().AsQueryable();

        string ten = txtTim.Text.Trim();
        if (ten != "")
            query = query.Where(x => x.HoTen.Contains(ten));

        if (cboLocHang.SelectedIndex > 0)
        {
            string hang = cboLocHang.SelectedItem.ToString();
            query = query.Where(x => x.HangThanhVien == hang);
        }

        var list = await query.OrderBy(x => x.MaHV).Select(x => new HoiVienRow
        {
            MaHV = x.MaHV,
            HoTen = x.HoTen,
            GioiTinh = x.GioiTinh,
            GioiTinhText = x.GioiTinh ? "Nam" : "Nữ",
            NgaySinh = x.NgaySinh,
            SDT = x.SDT,
            Email = x.Email,
            HangThanhVien = x.HangThanhVien,
            TrangThai = x.TrangThai,
            TrangThaiText = x.TrangThai ? "Đang hoạt động" : "Tạm ngưng"
        }).ToListAsync();

        _binding = true;
        dgvHoiVien.DataSource = list;
        dgvHoiVien.ClearSelection();
        _binding = false;
        ClearInputs();
    }

    // Chọn dòng -> đổ dữ liệu lên toàn bộ control
    private void dgvHoiVien_SelectionChanged(object sender, EventArgs e)
    {
        if (_binding || dgvHoiVien.SelectedRows.Count == 0) return;
        if (dgvHoiVien.SelectedRows[0].DataBoundItem is not HoiVienRow r) return;

        _currentId = r.MaHV;
        txtMaHV.Text = r.MaHV.ToString();
        txtHoTen.Text = r.HoTen;
        txtSDT.Text = r.SDT;
        txtEmail.Text = r.Email;
        rdoNam.Checked = r.GioiTinh;
        rdoNu.Checked = !r.GioiTinh;

        var ns = r.NgaySinh ?? new DateTime(2000, 1, 1);
        if (ns < dtpNgaySinh.MinDate) ns = dtpNgaySinh.MinDate;
        if (ns > dtpNgaySinh.MaxDate) ns = dtpNgaySinh.MaxDate;
        dtpNgaySinh.Value = ns;

        int idx = cboHang.FindStringExact(r.HangThanhVien ?? "");
        cboHang.SelectedIndex = idx; // -1 nếu không khớp
        chkTrangThai.Checked = r.TrangThai;
    }

    private void ClearInputs()
    {
        _currentId = 0;
        txtMaHV.Clear();
        txtHoTen.Clear();
        txtSDT.Clear();
        txtEmail.Clear();
        rdoNam.Checked = true;
        dtpNgaySinh.Value = new DateTime(2000, 1, 1);
        cboHang.SelectedIndex = 0;
        chkTrangThai.Checked = true;
    }

    // ---------- Validate (mỗi lỗi một thông báo riêng) ----------
    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            return Fail("Họ tên không được để trống.", txtHoTen);

        string sdt = txtSDT.Text.Trim();
        if (sdt == "")
            return Fail("Số điện thoại không được để trống.", txtSDT);
        if (!sdt.All(c => c >= '0' && c <= '9'))
            return Fail("Số điện thoại chỉ được chứa chữ số.", txtSDT);
        if (sdt.Length < 9 || sdt.Length > 11)
            return Fail("Số điện thoại phải có từ 9 đến 11 chữ số.", txtSDT);

        string email = txtEmail.Text.Trim();
        if (email == "")
            return Fail("Email không được để trống.", txtEmail);
        if (!email.Contains('@'))
            return Fail("Email phải chứa ký tự '@'.", txtEmail);

        DateTime dob = dtpNgaySinh.Value.Date;
        int tuoi = DateTime.Today.Year - dob.Year;
        if (dob > DateTime.Today.AddYears(-tuoi)) tuoi--;
        if (tuoi < 15)
            return Fail($"Hội viên phải từ 15 tuổi trở lên (hiện {tuoi} tuổi).", dtpNgaySinh);

        if (cboHang.SelectedIndex < 0)
            return Fail("Vui lòng chọn hạng thành viên.", cboHang);

        return true;
    }

    private static bool Fail(string message, Control focus)
    {
        MessageBox.Show(message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        focus.Focus();
        return false;
    }

    private void FillEntity(HoiVien hv)
    {
        hv.HoTen = txtHoTen.Text.Trim();
        hv.GioiTinh = rdoNam.Checked;
        hv.NgaySinh = dtpNgaySinh.Value.Date;
        hv.SDT = txtSDT.Text.Trim();
        hv.Email = txtEmail.Text.Trim();
        hv.HangThanhVien = cboHang.SelectedItem.ToString();
        hv.TrangThai = chkTrangThai.Checked;
    }

    // ---------- CRUD ----------
    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;
        try
        {
            using var db = new FitZoneContext();
            var hv = new HoiVien { NgayDangKy = DateTime.Now };
            FillEntity(hv);
            db.Add(hv);
            await db.SaveChangesAsync();
            MessageBox.Show("Thêm hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Vui lòng chọn một hội viên trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (!ValidateInput()) return;
        try
        {
            using var db = new FitZoneContext();
            var hv = await db.HoiViens.FindAsync(_currentId);
            if (hv == null)
            {
                MessageBox.Show("Hội viên không còn tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await LoadDataAsync();
                return;
            }
            FillEntity(hv);
            await db.SaveChangesAsync();
            MessageBox.Show("Cập nhật hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Vui lòng chọn một hội viên trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        var confirm = MessageBox.Show($"Bạn có chắc muốn xóa hội viên \"{txtHoTen.Text}\" không?",
            "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirm != DialogResult.Yes) return;

        try
        {
            using var db = new FitZoneContext();
            var hv = await db.HoiViens.FindAsync(_currentId);
            if (hv == null)
            {
                MessageBox.Show("Hội viên không còn tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                db.HoiViens.Remove(hv);
                int n = await db.SaveChangesAsync();
                MessageBox.Show(n > 0 ? "Đã xóa hội viên thành công!" : "Không có dữ liệu nào bị xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            await LoadDataAsync();
        }
        catch (DbUpdateException ex)
        {
            MessageBox.Show("Không thể xóa hội viên này: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        txtTim.Clear();
        cboLocHang.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnTim_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }
}
