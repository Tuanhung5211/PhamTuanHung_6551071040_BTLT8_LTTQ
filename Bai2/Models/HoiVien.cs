namespace Bai2.Models;

// Model tương đương kết quả scaffold (Database First) của bảng HoiVien
public partial class HoiVien
{
    public int MaHV { get; set; }
    public string HoTen { get; set; }
    public bool GioiTinh { get; set; }          // 1 = Nam, 0 = Nữ
    public DateTime? NgaySinh { get; set; }
    public string SDT { get; set; }
    public string Email { get; set; }
    public string HangThanhVien { get; set; }   // Basic / VIP / Premium
    public DateTime? NgayDangKy { get; set; }
    public bool TrangThai { get; set; }         // 1 = Đang hoạt động, 0 = Tạm ngưng
}
