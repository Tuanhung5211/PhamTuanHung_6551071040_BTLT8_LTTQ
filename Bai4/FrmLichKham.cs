using Bai4.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai4;

// Dòng hiển thị trên DataGridView
public class LichKhamRow
{
    public int MaLich { get; set; }
    public string TenBenhNhan { get; set; }
    public string SDT { get; set; }
    public DateTime? NgayKham { get; set; }
    public string GioKham { get; set; }
    public string TenBacSi { get; set; }
    public string ChuyenKhoa { get; set; }
    public string TrangThai { get; set; }
    // dữ liệu thô (không hiện trên lưới)
    public TimeSpan? Gio { get; set; }
    public int? MaBS { get; set; }
}

public partial class FrmLichKham : Form
{
    private bool _binding;
    private int _currentId;
    private DateTime? _originalDate;   // ngày khám gốc của lịch đang chọn (dùng khi Sửa)

    private static readonly string[] TrangThais = { "Chờ khám", "Đã khám", "Đã hủy" };

    public FrmLichKham()
    {
        InitializeComponent();
    }

    private async void FrmLichKham_Load(object sender, EventArgs e)
    {
        SetupGrid();
        cboTrangThai.Items.AddRange(TrangThais);
        dtpTu.Value = DateTime.Today.AddMonths(-1);
        dtpDen.Value = DateTime.Today.AddMonths(1);
        await LoadBacSiAsync();
        await LoadDataAsync();
    }

    private void SetupGrid()
    {
        dgvLich.Columns.Clear();
        void Add(string prop, string header, int width, string format = null)
        {
            var col = new DataGridViewTextBoxColumn { Name = prop, DataPropertyName = prop, HeaderText = header, Width = width };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvLich.Columns.Add(col);
        }
        Add("MaLich", "Mã lịch", 65);
        Add("TenBenhNhan", "Tên bệnh nhân", 150);
        Add("SDT", "SĐT", 100);
        Add("NgayKham", "Ngày khám", 95, "dd/MM/yyyy");
        Add("GioKham", "Giờ khám", 70);
        Add("TenBacSi", "Bác sĩ", 170);
        Add("ChuyenKhoa", "Chuyên khoa", 120);
        Add("TrangThai", "Trạng thái", 90);
    }

    // Nạp ComboBox bác sĩ (form nhập + bộ lọc) bằng LINQ
    private async Task LoadBacSiAsync()
    {
        using var db = new AnKhangContext();
        var ds = await db.BacSis.AsNoTracking().OrderBy(x => x.HoTen).ToListAsync();

        cboBacSi.DataSource = null;
        cboBacSi.DisplayMember = "HienThi";
        cboBacSi.ValueMember = "MaBS";
        cboBacSi.DataSource = ds.ToList();
        cboBacSi.SelectedIndex = -1;

        var loc = new List<BacSi> { new BacSi { MaBS = 0, HoTen = "-- Tất cả bác sĩ --" } };
        loc.AddRange(ds);
        cboLocBS.DataSource = null;
        cboLocBS.DisplayMember = "HienThi";
        cboLocBS.ValueMember = "MaBS";
        cboLocBS.DataSource = loc;
        cboLocBS.SelectedIndex = 0;
    }

    // Include(MaBSNavigation) + Where theo khoảng ngày (>=, <=) && bác sĩ (==)
    private async Task LoadDataAsync()
    {
        DateTime tu = dtpTu.Value.Date;
        DateTime den = dtpDen.Value.Date;
        if (tu > den)
        {
            MessageBox.Show("\"Từ ngày\" không được lớn hơn \"Đến ngày\".", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var db = new AnKhangContext();
        var query = db.LichKhams.AsNoTracking()
            .Include(x => x.MaBSNavigation)
            .Where(x => x.NgayKham >= tu && x.NgayKham <= den);

        if (cboLocBS.SelectedValue is int maBS && maBS > 0)
            query = query.Where(x => x.MaBS == maBS);

        var list = await query.OrderBy(x => x.NgayKham).ThenBy(x => x.GioKham).ToListAsync();

        var rows = list.Select(x => new LichKhamRow
        {
            MaLich = x.MaLich,
            TenBenhNhan = x.TenBenhNhan,
            SDT = x.SDT,
            NgayKham = x.NgayKham,
            GioKham = x.GioKham.HasValue ? x.GioKham.Value.ToString(@"hh\:mm") : "",
            Gio = x.GioKham,
            TenBacSi = x.MaBSNavigation != null ? "BS. " + x.MaBSNavigation.HoTen : "",   // tránh NullReferenceException
            ChuyenKhoa = x.MaBSNavigation?.ChuyenKhoa,
            MaBS = x.MaBS,
            TrangThai = x.TrangThai
        }).ToList();

        _binding = true;
        dgvLich.DataSource = rows;
        dgvLich.ClearSelection();
        _binding = false;
        ClearInputs();
    }

    private void ClearInputs()
    {
        _currentId = 0;
        _originalDate = null;
        txtTenBN.Clear();
        txtSDT.Clear();
        dtpNgayKham.Value = DateTime.Today;
        dtpGioKham.Value = DateTime.Today.AddHours(8);
        cboBacSi.SelectedIndex = -1;
        cboTrangThai.SelectedIndex = 0;
    }

    private void dgvLich_SelectionChanged(object sender, EventArgs e)
    {
        if (_binding || dgvLich.SelectedRows.Count == 0) return;
        if (dgvLich.SelectedRows[0].DataBoundItem is not LichKhamRow r) return;

        _currentId = r.MaLich;
        _originalDate = r.NgayKham?.Date;
        txtTenBN.Text = r.TenBenhNhan;
        txtSDT.Text = r.SDT;

        var ngay = r.NgayKham ?? DateTime.Today;
        if (ngay < dtpNgayKham.MinDate) ngay = dtpNgayKham.MinDate;
        dtpNgayKham.Value = ngay;
        dtpGioKham.Value = DateTime.Today + (r.Gio ?? TimeSpan.Zero);

        if (r.MaBS.HasValue) cboBacSi.SelectedValue = r.MaBS.Value; else cboBacSi.SelectedIndex = -1;
        cboTrangThai.SelectedIndex = cboTrangThai.FindStringExact(r.TrangThai ?? "");
    }

    private async void btnQLBacSi_Click(object sender, EventArgs e)
    {
        using var f = new FrmBacSi();
        f.ShowDialog(this);
        await LoadBacSiAsync();
        await LoadDataAsync();
    }

    // ---------- Validate ----------
    private bool ValidateInput(bool isEdit)
    {
        if (string.IsNullOrWhiteSpace(txtTenBN.Text))
            return Fail("Tên bệnh nhân không được để trống.", txtTenBN);

        string sdt = txtSDT.Text.Trim();
        if (sdt != "" && !sdt.All(c => c >= '0' && c <= '9'))
            return Fail("Số điện thoại chỉ được chứa chữ số.", txtSDT);

        if (cboBacSi.SelectedValue == null)
            return Fail("Vui lòng chọn bác sĩ.", cboBacSi);

        if (cboTrangThai.SelectedIndex < 0)
            return Fail("Vui lòng chọn trạng thái.", cboTrangThai);

        DateTime ngay = dtpNgayKham.Value.Date;
        // Không cho đặt lịch vào quá khứ (khi sửa mà không đổi ngày thì bỏ qua kiểm tra này)
        bool doiNgay = !isEdit || _originalDate != ngay;
        if (doiNgay && ngay < DateTime.Today)
            return Fail("Không thể đặt lịch khám vào ngày trong quá khứ.", dtpNgayKham);

        return true;
    }

    private static bool Fail(string message, Control focus)
    {
        MessageBox.Show(message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        focus.Focus();
        return false;
    }

    private void FillEntity(LichKham lk)
    {
        lk.TenBenhNhan = txtTenBN.Text.Trim();
        lk.SDT = txtSDT.Text.Trim();
        lk.NgayKham = dtpNgayKham.Value.Date;
        lk.GioKham = dtpGioKham.Value.TimeOfDay;
        lk.MaBS = (int)cboBacSi.SelectedValue;
        lk.TrangThai = cboTrangThai.SelectedItem.ToString();
    }

    // ---------- CRUD ----------
    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!ValidateInput(false)) return;
        try
        {
            using var db = new AnKhangContext();
            var lk = new LichKham();
            FillEntity(lk);
            db.Add(lk);
            await db.SaveChangesAsync();
            MessageBox.Show("Thêm lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await ReloadAfterChangeAsync(lk.NgayKham);
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
            MessageBox.Show("Vui lòng chọn một lịch khám trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (!ValidateInput(true)) return;
        try
        {
            using var db = new AnKhangContext();
            var lk = await db.LichKhams.FindAsync(_currentId);
            if (lk == null) { await LoadDataAsync(); return; }
            FillEntity(lk);
            await db.SaveChangesAsync();
            MessageBox.Show("Cập nhật lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await ReloadAfterChangeAsync(lk.NgayKham);
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
            MessageBox.Show("Vui lòng chọn một lịch khám trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        // Bắt buộc xác nhận YesNo trước khi SaveChangesAsync()
        if (MessageBox.Show($"Bạn có chắc muốn xóa lịch khám của \"{txtTenBN.Text}\"?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            using var db = new AnKhangContext();
            var lk = await db.LichKhams.FindAsync(_currentId);
            if (lk != null)
            {
                db.LichKhams.Remove(lk);
                await db.SaveChangesAsync();
                MessageBox.Show("Đã xóa lịch khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            await LoadDataAsync();
        }
        catch (DbUpdateException ex)
        {
            MessageBox.Show("Không thể xóa lịch khám: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Sau khi thêm/sửa: mở rộng khoảng ngày lọc nếu lịch mới nằm ngoài, để lịch vừa lưu luôn hiện trên lưới
    private async Task ReloadAfterChangeAsync(DateTime? ngay)
    {
        if (ngay.HasValue)
        {
            if (ngay.Value.Date < dtpTu.Value.Date) dtpTu.Value = ngay.Value.Date;
            if (ngay.Value.Date > dtpDen.Value.Date) dtpDen.Value = ngay.Value.Date;
        }
        await LoadDataAsync();
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        dtpTu.Value = DateTime.Today.AddMonths(-1);
        dtpDen.Value = DateTime.Today.AddMonths(1);
        cboLocBS.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnTim_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }
}
