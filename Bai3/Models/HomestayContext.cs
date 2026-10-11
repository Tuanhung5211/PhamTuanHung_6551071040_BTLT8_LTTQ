    using Microsoft.EntityFrameworkCore;

    namespace Bai3.Models;

    public partial class HomestayContext : DbContext
    {
    public const string ConnectionString =
        "Server=localhost;Database=SunriseHomestayDB;Trusted_Connection=True;TrustServerCertificate=True;";

    public HomestayContext() { }

        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiPhong>(entity =>
            {
                entity.ToTable("LoaiPhong");
                entity.HasKey(e => e.MaLoai);
                entity.Property(e => e.TenLoai).IsRequired().HasMaxLength(100);
                entity.Property(e => e.GiaMoiDem).HasColumnType("decimal(18, 2)");
                entity.Property(e => e.MoTa).HasMaxLength(255);
            });

            modelBuilder.Entity<Phong>(entity =>
            {
                entity.ToTable("Phong");
                entity.HasKey(e => e.MaPhong);
                entity.Property(e => e.SoPhong).IsRequired().HasMaxLength(10).IsUnicode(false);
                entity.Property(e => e.TinhTrang).HasMaxLength(20);
                entity.Property(e => e.HinhAnh).HasMaxLength(255);

                entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.Phongs)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Phong_LoaiPhong");
            });
        }
    }
