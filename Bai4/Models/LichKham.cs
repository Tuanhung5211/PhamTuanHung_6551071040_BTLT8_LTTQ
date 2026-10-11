namespace Bai4.Models;

public partial class LichKham
{
    public int MaLich { get; set; }
    public string TenBenhNhan { get; set; }
    public string SDT { get; set; }
    public DateTime? NgayKham { get; set; }
    public TimeSpan? GioKham { get; set; }     // cột kiểu time
    public int? MaBS { get; set; }
    public string TrangThai { get; set; }      // Chờ khám / Đã khám / Đã hủy

    public virtual BacSi MaBSNavigation { get; set; }
}
