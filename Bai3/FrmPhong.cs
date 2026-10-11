using Bai3.Models;
using Microsoft.EntityFrameworkCore;

namespace Bai3;

// Dòng hiển thị trên DataGridView
public class PhongRow
{
    public int MaPhong { get; set; }
    public Image Anh { get; set; }
    public string SoPhong { get; set; }
    public int? TangSo { get; set; }
    public string TenLoai { get; set; }
    public decimal? GiaMoiDem { get; set; }
    public string TinhTrang { get; set; }
    // dữ liệu thô (không hiện trên lưới)
    public int? MaLoai { get; set; }
    public string HinhAnh { get; set; }
}

public partial class FrmPhong : Form
{
    private bool _binding;
    private int _currentId;
    private string _hinhAnh;                       // tên file ảnh đang chọn
    private readonly List<Image> _gridImages = new();

    private static readonly string[] TinhTrangs = { "Trống", "Đang ở", "Đang dọn" };

    public FrmPhong()
    {
        InitializeComponent();
    }

    private async void FrmPhong_Load(object sender, EventArgs e)
    {
        SetupGrid();
        cboTinhTrang.Items.AddRange(TinhTrangs);
        cboLocTinhTrang.Items.Add("-- Tất cả tình trạng --");
        cboLocTinhTrang.Items.AddRange(TinhTrangs);
        cboLocTinhTrang.SelectedIndex = 0;
        await LoadLoaiPhongAsync();
        await LoadDataAsync();
    }

    private void SetupGrid()
    {
        dgvPhong.RowTemplate.Height = 60;
        dgvPhong.Columns.Clear();
        dgvPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaPhong", DataPropertyName = "MaPhong", HeaderText = "Mã phòng", Width = 80 });
        var anh = new DataGridViewImageColumn
        {
            Name = "Anh", DataPropertyName = "Anh", HeaderText = "Ảnh", Width = 110,
            ImageLayout = DataGridViewImageCellLayout.Zoom
        };
        anh.DefaultCellStyle.NullValue = null;   // không hiện dấu X đỏ khi chưa có ảnh
        dgvPhong.Columns.Add(anh);
        dgvPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoPhong", DataPropertyName = "SoPhong", HeaderText = "Số phòng", Width = 90 });
        dgvPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "TangSo", DataPropertyName = "TangSo", HeaderText = "Tầng", Width = 60 });
        dgvPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenLoai", DataPropertyName = "TenLoai", HeaderText = "Loại phòng", Width = 150 });
        var gia = new DataGridViewTextBoxColumn { Name = "GiaMoiDem", DataPropertyName = "GiaMoiDem", HeaderText = "Giá/đêm", Width = 110 };
        gia.DefaultCellStyle.Format = "N0";
        dgvPhong.Columns.Add(gia);
        dgvPhong.Columns.Add(new DataGridViewTextBoxColumn { Name = "TinhTrang", DataPropertyName = "TinhTrang", HeaderText = "Tình trạng", Width = 110 });
    }

    // Nạp dữ liệu cho 2 ComboBox Loại phòng (form nhập + bộ lọc) bằng LINQ
    private async Task LoadLoaiPhongAsync()
    {
        using var db = new HomestayContext();
        var loais = await db.LoaiPhongs.AsNoTracking().OrderBy(x => x.TenLoai).ToListAsync();

        cboLoaiPhong.DataSource = null;
        cboLoaiPhong.DisplayMember = "TenLoai";
        cboLoaiPhong.ValueMember = "MaLoai";
        cboLoaiPhong.DataSource = loais.ToList();
        cboLoaiPhong.SelectedIndex = -1;

        var locList = new List<LoaiPhong> { new LoaiPhong { MaLoai = 0, TenLoai = "-- Tất cả loại phòng --" } };
        locList.AddRange(loais);
        cboLocLoai.DataSource = null;
        cboLocLoai.DisplayMember = "TenLoai";
        cboLocLoai.ValueMember = "MaLoai";
        cboLocLoai.DataSource = locList;
        cboLocLoai.SelectedIndex = 0;
    }

    // Tìm kiếm kết hợp Include + Where (Loại phòng && Tình trạng)
    private async Task LoadDataAsync()
    {
        using var db = new HomestayContext();
        var query = db.Phongs.AsNoTracking().Include(x => x.MaLoaiNavigation).AsQueryable();

        if (cboLocLoai.SelectedValue is int maLoai && maLoai > 0)
            query = query.Where(x => x.MaLoai == maLoai);

        if (cboLocTinhTrang.SelectedIndex > 0)
        {
            string tt = cboLocTinhTrang.SelectedItem.ToString();
            query = query.Where(x => x.TinhTrang == tt);
        }

        var phongs = await query.OrderBy(x => x.MaPhong).ToListAsync();

        var oldImages = _gridImages.ToList();
        _gridImages.Clear();
        var rows = phongs.Select(p =>
        {
            var img = ImageHelper.Load(p.HinhAnh, 100, 60);
            if (img != null) _gridImages.Add(img);
            return new PhongRow
            {
                MaPhong = p.MaPhong,
                Anh = img,
                SoPhong = p.SoPhong,
                TangSo = p.TangSo,
                TenLoai = p.MaLoaiNavigation?.TenLoai,
                GiaMoiDem = p.MaLoaiNavigation?.GiaMoiDem,
                TinhTrang = p.TinhTrang,
                MaLoai = p.MaLoai,
                HinhAnh = p.HinhAnh
            };
        }).ToList();

        _binding = true;
        dgvPhong.DataSource = rows;
        dgvPhong.ClearSelection();
        _binding = false;
        foreach (var img in oldImages) img.Dispose();
        ClearInputs();
    }

    private void ClearInputs()
    {
        _currentId = 0;
        _hinhAnh = null;
        txtSoPhong.Clear();
        numTang.Value = 0;
        if (cboLoaiPhong.Items.Count > 0) cboLoaiPhong.SelectedIndex = 0;
        cboTinhTrang.SelectedIndex = 0;
        SetPicture(null);
    }

    private void SetPicture(Image img)
    {
        var old = picAnh.Image;
        picAnh.Image = img;
        old?.Dispose();
    }

    private void dgvPhong_SelectionChanged(object sender, EventArgs e)
    {
        if (_binding || dgvPhong.SelectedRows.Count == 0) return;
        if (dgvPhong.SelectedRows[0].DataBoundItem is not PhongRow r) return;

        _currentId = r.MaPhong;
        txtSoPhong.Text = r.SoPhong;
        numTang.Value = Math.Clamp(r.TangSo ?? 0, (int)numTang.Minimum, (int)numTang.Maximum);
        if (r.MaLoai.HasValue) cboLoaiPhong.SelectedValue = r.MaLoai.Value; else cboLoaiPhong.SelectedIndex = -1;
        cboTinhTrang.SelectedIndex = cboTinhTrang.FindStringExact(r.TinhTrang ?? "");
        _hinhAnh = r.HinhAnh;
        SetPicture(ImageHelper.Load(r.HinhAnh));
    }

    // Chọn ảnh: copy vào thư mục Images, chỉ lưu tên file
    private void btnChonAnh_Click(object sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog
        {
            Title = "Chọn ảnh phòng",
            Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        };
        if (ofd.ShowDialog() != DialogResult.OK) return;
        try
        {
            _hinhAnh = ImageHelper.CopyToImages(ofd.FileName);
            SetPicture(ImageHelper.Load(_hinhAnh));
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không thể sao chép ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLoaiPhong_Click(object sender, EventArgs e)
    {
        using var f = new FrmLoaiPhong();
        f.ShowDialog(this);
        await LoadLoaiPhongAsync();   // nạp lại ComboBox sau khi quản lý loại phòng
        await LoadDataAsync();
    }

    private async Task<bool> ValidateInputAsync()
    {
        string so = txtSoPhong.Text.Trim();
        if (so == "")
            return Fail("Số phòng không được để trống.", txtSoPhong);
        if (cboLoaiPhong.SelectedValue == null)
            return Fail("Vui lòng chọn loại phòng.", cboLoaiPhong);
        if (cboTinhTrang.SelectedIndex < 0)
            return Fail("Vui lòng chọn tình trạng phòng.", cboTinhTrang);

        using var db = new HomestayContext();
        if (await db.Phongs.AnyAsync(x => x.SoPhong == so && x.MaPhong != _currentId))
            return Fail($"Số phòng \"{so}\" đã tồn tại.", txtSoPhong);
        return true;
    }

    private static bool Fail(string message, Control focus)
    {
        MessageBox.Show(message, "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        focus.Focus();
        return false;
    }

    private void FillEntity(Phong p)
    {
        p.SoPhong = txtSoPhong.Text.Trim();
        p.TangSo = (int)numTang.Value;
        p.MaLoai = (int)cboLoaiPhong.SelectedValue;
        p.TinhTrang = cboTinhTrang.SelectedItem.ToString();
        p.HinhAnh = _hinhAnh;
    }

    private async void btnThem_Click(object sender, EventArgs e)
    {
        if (!await ValidateInputAsync()) return;
        try
        {
            using var db = new HomestayContext();
            var p = new Phong();
            FillEntity(p);
            db.Add(p);
            await db.SaveChangesAsync();
            MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Vui lòng chọn một phòng trong danh sách để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (!await ValidateInputAsync()) return;
        try
        {
            using var db = new HomestayContext();
            var p = await db.Phongs.FindAsync(_currentId);
            if (p == null) { await LoadDataAsync(); return; }
            FillEntity(p);
            await db.SaveChangesAsync();
            MessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Vui lòng chọn một phòng trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (MessageBox.Show($"Bạn có chắc muốn xóa phòng {txtSoPhong.Text}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            using var db = new HomestayContext();
            var p = await db.Phongs.FindAsync(_currentId);
            if (p != null)
            {
                db.Phongs.Remove(p);
                await db.SaveChangesAsync();
                MessageBox.Show("Đã xóa phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            await LoadDataAsync();
        }
        catch (DbUpdateException ex)
        {
            MessageBox.Show("Không thể xóa phòng: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnLamMoi_Click(object sender, EventArgs e)
    {
        cboLocLoai.SelectedIndex = 0;
        cboLocTinhTrang.SelectedIndex = 0;
        await LoadDataAsync();
    }

    private async void btnTim_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }
}
