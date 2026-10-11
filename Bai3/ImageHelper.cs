namespace Bai3;

// Xử lý ảnh: copy vào thư mục Images của ứng dụng, chỉ lưu TÊN FILE vào CSDL
public static class ImageHelper
{
    public static readonly string ImagesDir = Path.Combine(AppContext.BaseDirectory, "Images");

    // Copy file ảnh vào thư mục Images, trả về tên file đã lưu
    public static string CopyToImages(string sourcePath)
    {
        Directory.CreateDirectory(ImagesDir);
        string fileName = Path.GetFileName(sourcePath);
        string dest = Path.Combine(ImagesDir, fileName);

        if (File.Exists(dest))
        {
            // cùng đường dẫn thì không cần copy; trùng tên nhưng khác file thì đổi tên
            if (string.Equals(Path.GetFullPath(sourcePath), Path.GetFullPath(dest), StringComparison.OrdinalIgnoreCase))
                return fileName;
            fileName = $"{Path.GetFileNameWithoutExtension(fileName)}_{DateTime.Now:yyyyMMddHHmmssfff}{Path.GetExtension(fileName)}";
            dest = Path.Combine(ImagesDir, fileName);
        }
        File.Copy(sourcePath, dest);
        return fileName;
    }

    // Đọc ảnh từ thư mục Images (không khóa file). Trả về null nếu không có/lỗi.
    public static Image Load(string fileName, int? thumbW = null, int? thumbH = null)
    {
        if (string.IsNullOrWhiteSpace(fileName)) return null;
        try
        {
            string path = Path.Combine(ImagesDir, fileName);
            if (!File.Exists(path)) return null;
            byte[] bytes = File.ReadAllBytes(path);
            using var ms = new MemoryStream(bytes);
            using var original = Image.FromStream(ms);
            return thumbW.HasValue && thumbH.HasValue
                ? new Bitmap(original, new Size(thumbW.Value, thumbH.Value))
                : new Bitmap(original);
        }
        catch
        {
            return null;
        }
    }
}
