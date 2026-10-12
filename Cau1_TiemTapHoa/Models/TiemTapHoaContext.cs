using Microsoft.EntityFrameworkCore;

namespace TiemTapHoa.Models;

// Tương đương lớp do "dotnet ef dbcontext scaffold" sinh ra (xem README).
public partial class TiemTapHoaContext : DbContext
{
    public const string ConnectionString =
        @"Server=(localdb)\MSSQLLocalDB;Database=TiemTapHoa;Trusted_Connection=True;TrustServerCertificate=True";

    public TiemTapHoaContext() { }
    public TiemTapHoaContext(DbContextOptions<TiemTapHoaContext> options) : base(options) { }

    public virtual DbSet<HangHoa> HangHoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HangHoa>(e =>
        {
            e.ToTable("HangHoa");
            e.HasKey(x => x.MaHang);
            e.Property(x => x.TenHang).HasMaxLength(100);
            e.Property(x => x.LoaiHang).HasMaxLength(50);
            e.Property(x => x.DonVi).HasMaxLength(20);
            e.Property(x => x.GiaBan).HasColumnType("decimal(18, 0)");
            e.Property(x => x.NgayNhap).HasColumnType("datetime");
        });
    }
}
