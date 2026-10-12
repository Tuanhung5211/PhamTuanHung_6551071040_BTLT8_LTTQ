namespace TiemTapHoa;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    private GroupBox grpThongTin, grpTimKiem;
    private TextBox txtTen, txtTim;
    private ComboBox cboLoai, cboDonVi, cboLoc;
    private NumericUpDown nudGia, nudTon;
    private DateTimePicker dtpNgay;
    private CheckBox chkKD, chkChiKD;
    private DataGridView dgv;
    private Button btnThem, btnSua, btnXoa, btnLamMoi, btnXemGia, btnXuatPdf, btnXuatLuoi, btnXuatTonKho;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblStatus;
    private System.Windows.Forms.Timer timerTim;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private static Label Lbl(string text, int x, int y) =>
        new Label { Text = text, Left = x, Top = y, AutoSize = true };

    private static Button Btn(string text, int x, int y, int w) =>
        new Button { Text = text, Left = x, Top = y, Width = w, Height = 30,
                     Anchor = AnchorStyles.Bottom | AnchorStyles.Left };

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        SuspendLayout();

        // ---- GroupBox thông tin ----
        grpThongTin = new GroupBox { Text = "Thông tin hàng hóa", Left = 10, Top = 8, Width = 560, Height = 140 };
        txtTen = new TextBox { Left = 90, Top = 20, Width = 450 };
        cboLoai = new ComboBox { Left = 90, Top = 52, Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
        cboDonVi = new ComboBox { Left = 90, Top = 82, Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
        nudGia = new NumericUpDown { Left = 90, Top = 110, Width = 150, Minimum = 0, Maximum = 1000000000,
                                     Increment = 500, ThousandsSeparator = true };
        nudTon = new NumericUpDown { Left = 360, Top = 52, Width = 110, Minimum = 0, Maximum = 1000000 };
        dtpNgay = new DateTimePicker { Left = 360, Top = 82, Width = 110, Format = DateTimePickerFormat.Custom,
                                       CustomFormat = "dd/MM/yyyy" };
        chkKD = new CheckBox { Left = 360, Top = 112, Text = "Còn kinh doanh", AutoSize = true, Checked = true };
        grpThongTin.Controls.AddRange(new Control[] {
            Lbl("Tên hàng:", 12, 24), txtTen,
            Lbl("Loại hàng:", 12, 56), cboLoai,
            Lbl("Đơn vị:", 12, 86), cboDonVi,
            Lbl("Giá bán:", 12, 114), nudGia,
            Lbl("Số lượng tồn:", 265, 56), nudTon,
            Lbl("Ngày nhập:", 265, 86), dtpNgay, chkKD });

        // ---- GroupBox tìm kiếm ----
        grpTimKiem = new GroupBox { Text = "Tìm kiếm", Left = 580, Top = 8, Width = 310, Height = 140 };
        txtTim = new TextBox { Left = 12, Top = 22, Width = 285, PlaceholderText = "Tìm theo tên hàng..." };
        cboLoc = new ComboBox { Left = 12, Top = 54, Width = 285, DropDownStyle = ComboBoxStyle.DropDownList };
        chkChiKD = new CheckBox { Left = 12, Top = 88, Text = "Chỉ hiện hàng còn kinh doanh", AutoSize = true };
        grpTimKiem.Controls.AddRange(new Control[] { txtTim, cboLoc, chkChiKD });

        // ---- DataGridView ----
        dgv = new DataGridView
        {
            Left = 10, Top = 156, Width = 880, Height = 360,
            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            AutoGenerateColumns = false, AllowUserToAddRows = false, AllowUserToDeleteRows = false,
            ReadOnly = true, MultiSelect = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            BackgroundColor = SystemColors.AppWorkspace
        };
        var right = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight };
        dgv.Columns.AddRange(new DataGridViewColumn[] {
            new DataGridViewTextBoxColumn { HeaderText = "Mã", DataPropertyName = "MaHang", Width = 50 },
            new DataGridViewTextBoxColumn { HeaderText = "Tên hàng", DataPropertyName = "TenHang", Width = 250 },
            new DataGridViewTextBoxColumn { HeaderText = "Loại hàng", DataPropertyName = "LoaiHang", Width = 110 },
            new DataGridViewTextBoxColumn { HeaderText = "Đơn vị", DataPropertyName = "DonVi", Width = 80 },
            new DataGridViewTextBoxColumn { HeaderText = "Giá bán", DataPropertyName = "GiaBan", Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } },
            new DataGridViewTextBoxColumn { HeaderText = "Tồn", DataPropertyName = "SoLuongTon", Width = 60,
                DefaultCellStyle = right },
            new DataGridViewTextBoxColumn { HeaderText = "Ngày nhập", DataPropertyName = "NgayNhap", Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy", Alignment = DataGridViewContentAlignment.MiddleRight } },
            new DataGridViewCheckBoxColumn { HeaderText = "Kinh doanh", DataPropertyName = "ConKinhDoanh", Width = 85 } });

        // ---- Buttons ----
        btnThem = Btn("Thêm", 10, 524, 80);
        btnSua = Btn("Sửa", 98, 524, 80);
        btnXoa = Btn("Xóa", 186, 524, 80);
        btnLamMoi = Btn("Làm mới", 274, 524, 80);
        btnXemGia = Btn("Xem bảng giá", 400, 524, 110);
        btnXuatPdf = Btn("Xuất PDF", 518, 524, 90);
        btnXuatLuoi = Btn("Xuất Excel (lưới)", 616, 524, 130);
        btnXuatTonKho = Btn("Xuất Excel tồn kho", 754, 524, 136);

        // ---- Status ----
        statusStrip1 = new StatusStrip();
        lblStatus = new ToolStripStatusLabel { Text = "Sẵn sàng" };
        statusStrip1.Items.Add(lblStatus);

        timerTim = new System.Windows.Forms.Timer(components) { Interval = 350 };

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(900, 592);
        MinimumSize = new Size(916, 560);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Quản lý hàng hóa - Tạp hóa UTC2";
        Controls.AddRange(new Control[] { grpThongTin, grpTimKiem, dgv, btnThem, btnSua, btnXoa, btnLamMoi,
            btnXemGia, btnXuatPdf, btnXuatLuoi, btnXuatTonKho, statusStrip1 });
        ResumeLayout(false);
        PerformLayout();
    }
}
