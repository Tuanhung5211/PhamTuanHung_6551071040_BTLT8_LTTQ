using System.Data;
using System.Diagnostics;
using ClosedXML.Excel;
using FastReport.Export.Pdf;
using Microsoft.EntityFrameworkCore;
using TiemTapHoa.Models;
using FReport = FastReport.Report;

namespace TiemTapHoa;

public partial class MainForm : Form
{
    private static readonly string[] DsLoai = { "Đồ uống", "Thực phẩm khô", "Gia vị", "Đồ gia dụng" };
    private static readonly string[] DsDonVi = { "Chai", "Gói", "Hộp", "Túi" };

    private List<HangHoa> _all = new();
    private bool _loading;

    private HangHoa? Hien => dgv.CurrentRow?.DataBoundItem as HangHoa;

    public MainForm()
    {
        InitializeComponent();

        cboLoai.Items.AddRange(DsLoai);
        cboDonVi.Items.AddRange(DsDonVi);
        cboLoc.Items.Add("Tất cả");
        cboLoc.Items.AddRange(DsLoai);
        cboLoc.SelectedIndex = 0;

        Load += async (_, _) => await TaiDuLieuAsync();
        dgv.SelectionChanged += (_, _) => { if (!_loading) HienLenForm(Hien); };

        // Tìm kiếm: chờ 350 ms sau khi ngừng gõ
        txtTim.TextChanged += (_, _) => { timerTim.Stop(); timerTim.Start(); };
        timerTim.Tick += (_, _) => { timerTim.Stop(); ApplyFilter(); };
        cboLoc.SelectedIndexChanged += (_, _) => ApplyFilter();
        chkChiKD.CheckedChanged += (_, _) => ApplyFilter();

        btnThem.Click += BtnThem_Click;
        btnSua.Click += BtnSua_Click;
        btnXoa.Click += BtnXoa_Click;
        btnLamMoi.Click += BtnLamMoi_Click;
        btnXemGia.Click += BtnXemGia_Click;
        btnXuatPdf.Click += BtnXuatPdf_Click;
        btnXuatLuoi.Click += BtnXuatLuoi_Click;
        btnXuatTonKho.Click += BtnXuatTonKho_Click;
    }

    // ===================== Tiện ích thông báo =====================
    private static void Canh(string msg) =>
        MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

    private static void Loi(string msg, Exception ex) =>
        MessageBox.Show($"{msg}:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

    private static void HoiMoFile(string path)
    {
        if (MessageBox.Show("Đã lưu file. Bạn có muốn mở file không?", "Hoàn tất",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
    }

    // ===================== Tải dữ liệu + lọc =====================
    private async Task TaiDuLieuAsync(int? chon = null)
    {
        try
        {
            await using var db = new TiemTapHoaContext();
            _all = await db.HangHoas.AsNoTracking().OrderBy(h => h.MaHang).ToListAsync();
            ApplyFilter(chon);
        }
        catch (Exception ex) { Loi("Không tải được dữ liệu", ex); }
    }

    private void ApplyFilter(int? chon = null)
    {
        int? giu = chon ?? Hien?.MaHang;
        string kw = txtTim.Text.Trim();

        IEnumerable<HangHoa> q = _all;
        if (kw.Length > 0)
            q = q.Where(h => h.TenHang.Contains(kw, StringComparison.CurrentCultureIgnoreCase));
        if (cboLoc.SelectedIndex > 0)
        {
            string loai = (string)cboLoc.SelectedItem!;
            q = q.Where(h => h.LoaiHang == loai);
        }
        if (chkChiKD.Checked) q = q.Where(h => h.ConKinhDoanh);
        var list = q.ToList();

        _loading = true;
        dgv.DataSource = list;
        dgv.ClearSelection();
        DataGridViewRow? pick = null;
        if (giu.HasValue)
            pick = dgv.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => ((HangHoa)r.DataBoundItem).MaHang == giu);
        pick ??= dgv.Rows.Count > 0 ? dgv.Rows[0] : null;
        if (pick != null) { pick.Selected = true; dgv.CurrentCell = pick.Cells[0]; }
        _loading = false;

        if (pick != null) HienLenForm(pick.DataBoundItem as HangHoa);
        lblStatus.Text = $"Tìm thấy {list.Count} mặt hàng";
    }

    // ===================== Form <-> dữ liệu =====================
    private void HienLenForm(HangHoa? h)
    {
        if (h == null) return;
        txtTen.Text = h.TenHang;
        cboLoai.SelectedItem = h.LoaiHang;
        cboDonVi.SelectedItem = h.DonVi;
        nudGia.Value = Math.Min(h.GiaBan, nudGia.Maximum);
        nudTon.Value = Math.Min(h.SoLuongTon, nudTon.Maximum);
        dtpNgay.Value = h.NgayNhap < dtpNgay.MinDate ? dtpNgay.MinDate : h.NgayNhap;
        chkKD.Checked = h.ConKinhDoanh;
    }

    private void XoaForm()
    {
        txtTen.Clear();
        cboLoai.SelectedIndex = -1;
        cboDonVi.SelectedIndex = -1;
        nudGia.Value = 0;
        nudTon.Value = 0;
        dtpNgay.Value = DateTime.Today;
        chkKD.Checked = true;
        txtTen.Focus();
    }

    private HangHoa? DocForm()
    {
        string ten = txtTen.Text.Trim();
        if (ten.Length == 0) { Canh("Tên hàng không được để trống."); txtTen.Focus(); return null; }
        if (nudGia.Value <= 0) { Canh("Giá bán phải lớn hơn 0."); nudGia.Focus(); return null; }
        return new HangHoa
        {
            TenHang = ten,
            LoaiHang = cboLoai.SelectedItem as string,
            DonVi = cboDonVi.SelectedItem as string,
            GiaBan = nudGia.Value,
            SoLuongTon = (int)nudTon.Value,
            NgayNhap = dtpNgay.Value,
            ConKinhDoanh = chkKD.Checked
        };
    }

    // ===================== Thêm - Sửa - Xóa =====================
    private async void BtnThem_Click(object? s, EventArgs e)
    {
        var h = DocForm();
        if (h == null) return;
        try
        {
            await using var db = new TiemTapHoaContext();
            db.HangHoas.Add(h);
            await db.SaveChangesAsync();
            await TaiDuLieuAsync(h.MaHang);
        }
        catch (Exception ex) { Loi("Không thêm được hàng hóa", ex); }
    }

    private async void BtnSua_Click(object? s, EventArgs e)
    {
        var cur = Hien;
        if (cur == null) { Canh("Vui lòng chọn một mặt hàng trên lưới."); return; }
        var moi = DocForm();
        if (moi == null) return;
        try
        {
            await using var db = new TiemTapHoaContext();
            var h = await db.HangHoas.FindAsync(cur.MaHang);
            if (h == null) { Canh("Mặt hàng này không còn tồn tại."); await TaiDuLieuAsync(); return; }
            h.TenHang = moi.TenHang; h.LoaiHang = moi.LoaiHang; h.DonVi = moi.DonVi;
            h.GiaBan = moi.GiaBan; h.SoLuongTon = moi.SoLuongTon;
            h.NgayNhap = moi.NgayNhap; h.ConKinhDoanh = moi.ConKinhDoanh;
            await db.SaveChangesAsync();
            await TaiDuLieuAsync(h.MaHang);
        }
        catch (Exception ex) { Loi("Không sửa được hàng hóa", ex); }
    }

    private async void BtnXoa_Click(object? s, EventArgs e)
    {
        var cur = Hien;
        if (cur == null) { Canh("Vui lòng chọn một mặt hàng trên lưới."); return; }
        if (MessageBox.Show($"Xóa mặt hàng \"{cur.TenHang}\"?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            await using var db = new TiemTapHoaContext();
            await db.HangHoas.Where(h => h.MaHang == cur.MaHang).ExecuteDeleteAsync();
            await TaiDuLieuAsync();
        }
        catch (Exception ex) { Loi("Không xóa được hàng hóa", ex); }
    }

    private async void BtnLamMoi_Click(object? s, EventArgs e)
    {
        txtTim.Clear();
        cboLoc.SelectedIndex = 0;
        chkChiKD.Checked = false;
        await TaiDuLieuAsync();
        dgv.CurrentCell = null;
        dgv.ClearSelection();
        XoaForm();
    }

    // ===================== FastReport =====================
    private async Task<DataTable> LayBangGiaAsync()
    {
        await using var db = new TiemTapHoaContext();
        var ds = await db.HangHoas.AsNoTracking().Where(h => h.ConKinhDoanh).OrderBy(h => h.MaHang).ToListAsync();
        var dt = new DataTable("HangHoa");
        dt.Columns.Add("MaHang", typeof(int));
        dt.Columns.Add("TenHang", typeof(string));
        dt.Columns.Add("DonVi", typeof(string));
        dt.Columns.Add("GiaBan", typeof(decimal));
        foreach (var h in ds) dt.Rows.Add(h.MaHang, h.TenHang, h.DonVi ?? "", h.GiaBan);
        return dt;
    }

    private async Task<FReport> TaoReportAsync()
    {
        string path = Path.Combine(AppContext.BaseDirectory, "Reports", "BangGia.frx");
        if (!File.Exists(path)) throw new FileNotFoundException("Không tìm thấy file mẫu report.", path);

        var dt = await LayBangGiaAsync();
        var rpt = new FReport();
        rpt.Load(path);
        rpt.RegisterData(dt, "HangHoa");
        rpt.GetDataSource("HangHoa").Enabled = true;
        rpt.SetParameterValue("NgayIn", DateTime.Now.ToString("dd/MM/yyyy"));
        rpt.DoublePass = true; // để [TotalPages#] hoạt động
        return rpt;
    }

    private async void BtnXemGia_Click(object? s, EventArgs e)
    {
        try
        {
            using var rpt = await TaoReportAsync();
            rpt.Show(true);
        }
        catch (Exception ex) { Loi("Không xem được bảng giá", ex); }
    }

    private async void BtnXuatPdf_Click(object? s, EventArgs e)
    {
        using var dlg = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "BangGia.pdf" };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        try
        {
            using var rpt = await TaoReportAsync();
            rpt.Prepare();
            rpt.Export(new PDFExport(), dlg.FileName);
            HoiMoFile(dlg.FileName);
        }
        catch (IOException)
        {
            MessageBox.Show("Không ghi được file PDF. Có thể file đang được mở bởi chương trình khác.\nHãy đóng file rồi thử lại.",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex) { Loi("Không xuất được PDF", ex); }
    }

    // ===================== Excel (ClosedXML) =====================
    private static bool LuuExcel(XLWorkbook wb, string path)
    {
        try { wb.SaveAs(path); return true; }
        catch (IOException)
        {
            MessageBox.Show("Không ghi được file Excel. Có thể file đang được mở trong Excel.\nHãy đóng file rồi thử lại.",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // Cách 1: từ DataGridView (đúng các dòng đang hiển thị)
    private void BtnXuatLuoi_Click(object? s, EventArgs e)
    {
        if (dgv.Rows.Count == 0) { Canh("Không có dữ liệu để xuất."); return; }
        using var dlg = new SaveFileDialog { Filter = "Excel (*.xlsx)|*.xlsx", FileName = "HangHoa_Luoi.xlsx" };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        try
        {
            using var wb = new XLWorkbook();
            var ws = wb.AddWorksheet("HangHoa");
            var cols = dgv.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();

            for (int c = 0; c < cols.Count; c++)
            {
                var cell = ws.Cell(1, c + 1);
                cell.Value = cols[c].HeaderText;
                cell.Style.Font.Bold = true;
            }
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                for (int c = 0; c < cols.Count; c++)
                {
                    object? v = dgv.Rows[r].Cells[cols[c].Index].Value;
                    var cell = ws.Cell(r + 2, c + 1);
                    switch (v)
                    {
                        case bool b: cell.Value = b ? "Còn bán" : "Ngừng bán"; break;
                        case null: break;
                        default: cell.Value = XLCellValue.FromObject(v); break;
                    }
                    if (v is decimal) cell.Style.NumberFormat.Format = "#,##0";
                    else if (v is DateTime) cell.Style.NumberFormat.Format = "dd/MM/yyyy";
                }
            }
            ws.Columns().AdjustToContents();
            if (LuuExcel(wb, dlg.FileName)) HoiMoFile(dlg.FileName);
        }
        catch (Exception ex) { Loi("Không xuất được Excel", ex); }
    }

    // Cách 2: truy vấn EF Core, có công thức
    private async void BtnXuatTonKho_Click(object? s, EventArgs e)
    {
        using var dlg = new SaveFileDialog { Filter = "Excel (*.xlsx)|*.xlsx", FileName = "TonKho.xlsx" };
        if (dlg.ShowDialog() != DialogResult.OK) return;
        try
        {
            List<HangHoa> ds;
            await using (var db = new TiemTapHoaContext())
                ds = await db.HangHoas.AsNoTracking().Where(h => h.ConKinhDoanh).OrderBy(h => h.MaHang).ToListAsync();
            if (ds.Count == 0) { Canh("Không có hàng còn kinh doanh để xuất."); return; }

            using var wb = new XLWorkbook();
            var ws = wb.AddWorksheet("TonKho");
            string[] heads = { "Mã hàng", "Tên hàng", "Loại hàng", "Đơn vị", "Giá bán", "Số lượng tồn", "Ngày nhập", "Giá trị tồn" };
            for (int c = 0; c < heads.Length; c++) ws.Cell(1, c + 1).Value = heads[c];
            ws.Range(1, 1, 1, heads.Length).Style.Font.Bold = true;

            int r = 2;
            foreach (var h in ds)
            {
                ws.Cell(r, 1).Value = h.MaHang;
                ws.Cell(r, 2).Value = h.TenHang;
                ws.Cell(r, 3).Value = h.LoaiHang ?? "";
                ws.Cell(r, 4).Value = h.DonVi ?? "";
                ws.Cell(r, 5).Value = h.GiaBan;
                ws.Cell(r, 6).Value = h.SoLuongTon;
                ws.Cell(r, 7).Value = h.NgayNhap;
                ws.Cell(r, 8).FormulaA1 = $"E{r}*F{r}";
                r++;
            }
            int last = r - 1;
            ws.Cell(r, 1).Value = "Tổng";
            ws.Cell(r, 8).FormulaA1 = $"SUM(H2:H{last})";
            ws.Range(r, 1, r, heads.Length).Style.Font.Bold = true;

            ws.Range(2, 5, r, 5).Style.NumberFormat.Format = "#,##0";
            ws.Range(2, 6, r, 6).Style.NumberFormat.Format = "#,##0";
            ws.Range(2, 8, r, 8).Style.NumberFormat.Format = "#,##0";
            ws.Range(2, 7, last, 7).Style.NumberFormat.Format = "dd/MM/yyyy";

            ws.Range(1, 1, last, heads.Length).SetAutoFilter();
            ws.SheetView.FreezeRows(1);
            ws.Columns().AdjustToContents();

            if (LuuExcel(wb, dlg.FileName)) HoiMoFile(dlg.FileName);
        }
        catch (Exception ex) { Loi("Không xuất được Excel tồn kho", ex); }
    }
}
