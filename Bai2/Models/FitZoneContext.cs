using Microsoft.EntityFrameworkCore;

namespace Bai2.Models;

public partial class FitZoneContext : DbContext
{
    public const string ConnectionString =
        "Server=localhost;Database=FitZoneDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public FitZoneContext() { }

    public virtual DbSet<HoiVien> HoiViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HoiVien>(entity =>
        {
            entity.ToTable("HoiVien");
            entity.HasKey(e => e.MaHV);
            entity.Property(e => e.HoTen).IsRequired().HasMaxLength(100);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.SDT).HasMaxLength(15).IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.HangThanhVien).HasMaxLength(20);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
        });
    }
}
