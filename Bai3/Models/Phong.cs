namespace Bai3.Models;

public partial class Phong
{
    public int MaPhong { get; set; }
    public string SoPhong { get; set; }
    public int? TangSo { get; set; }
    public string TinhTrang { get; set; }   // Trống / Đang ở / Đang dọn
    public string HinhAnh { get; set; }     // chỉ lưu TÊN FILE ảnh
    public int? MaLoai { get; set; }

    public virtual LoaiPhong MaLoaiNavigation { get; set; }
}
