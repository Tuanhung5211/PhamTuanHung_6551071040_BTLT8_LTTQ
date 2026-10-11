namespace Bai4.Models;

public partial class BacSi
{
    public int MaBS { get; set; }
    public string HoTen { get; set; }
    public string ChuyenKhoa { get; set; }
    public string SDT { get; set; }

    public virtual ICollection<LichKham> LichKhams { get; set; } = new List<LichKham>();

    // Hiển thị trên ComboBox: "BS. Nguyễn Văn A - Nội tổng quát"
    public string HienThi => string.IsNullOrWhiteSpace(ChuyenKhoa) ? $"BS. {HoTen}" : $"BS. {HoTen} - {ChuyenKhoa}";
}
