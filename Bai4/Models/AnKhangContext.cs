using Microsoft.EntityFrameworkCore;

namespace Bai4.Models;

public partial class AnKhangContext : DbContext
{
    public const string ConnectionString =
        "Server=localhost;Database=AnKhangClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public AnKhangContext() { }

    public virtual DbSet<BacSi> BacSis { get; set; }
    public virtual DbSet<LichKham> LichKhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BacSi>(entity =>
        {
            entity.ToTable("BacSi");
            entity.HasKey(e => e.MaBS);
            entity.Property(e => e.HoTen).IsRequired().HasMaxLength(100);
            entity.Property(e => e.ChuyenKhoa).HasMaxLength(100);
            entity.Property(e => e.SDT).HasMaxLength(15).IsUnicode(false);
            entity.Ignore(e => e.HienThi);
        });

        modelBuilder.Entity<LichKham>(entity =>
        {
            entity.ToTable("LichKham");
            entity.HasKey(e => e.MaLich);
            entity.Property(e => e.TenBenhNhan).IsRequired().HasMaxLength(100);
            entity.Property(e => e.SDT).HasMaxLength(15).IsUnicode(false);
            entity.Property(e => e.NgayKham).HasColumnType("date");
            entity.Property(e => e.GioKham).HasColumnType("time");
            entity.Property(e => e.TrangThai).HasMaxLength(20);

            entity.HasOne(d => d.MaBSNavigation).WithMany(p => p.LichKhams)
                .HasForeignKey(d => d.MaBS)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LichKham_BacSi");
        });
    }
}
