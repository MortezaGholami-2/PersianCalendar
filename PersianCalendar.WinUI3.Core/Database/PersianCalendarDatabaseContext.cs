using Microsoft.EntityFrameworkCore;
using PersianCalendar.WinUI3.Database.Models;

namespace PersianCalendar.WinUI3.Core.Database;
public partial class PersianCalendarDatabaseContext : DbContext
{
    private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=True;";

    public virtual DbSet<Shift> Shifts
    {
        get; set;
    }

    public string DatabasePath
    {
        get; set;
    }

    public PersianCalendarDatabaseContext(string databasePath)
    {
        DatabasePath = databasePath;
    }

    //public PersianCalendarContext(DbContextOptions<PersianCalendarContext> options)
    //        : base(options)
    //{
    //}

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (options.IsConfigured)
        {
            //options.UseSqlite($"Data Source={DatabasePath}");
            options.UseSqlite("Data Source=CustomerDB.db;");
            //options.UseSqlite(connectionString);
        }
    }



    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Shift>(entity =>
    //    {
    //        entity.HasNoKey();

    //        entity.ToTable("galleries_images");

    //        entity.HasIndex(e => e.GalleryId, "index_galleries_images_on_gallery_id");

    //        entity.HasIndex(e => e.ImageId, "index_galleries_images_on_image_id");

    //        entity.Property(e => e.GalleryId)
    //            .HasColumnType("integer")
    //            .HasColumnName("gallery_id");

    //        entity.Property(e => e.ImageId)
    //            .HasColumnType("integer")
    //            .HasColumnName("image_id");

    //        entity.HasOne(d => d.Gallery)
    //            .WithMany()
    //            .HasForeignKey(d => d.GalleryId)
    //            .OnDelete(DeleteBehavior.Cascade);

    //        entity.HasOne(d => d.Image)
    //            .WithMany()
    //            .HasForeignKey(d => d.ImageId)
    //            .OnDelete(DeleteBehavior.Cascade);
    //    });
    //    OnModelCreatingPartial(modelBuilder);
    //}
    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
