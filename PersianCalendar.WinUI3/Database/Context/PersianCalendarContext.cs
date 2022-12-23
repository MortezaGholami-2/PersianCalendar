using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
using PersianCalendar.WinUI3.Database.Models;

namespace PersianCalendar.WinUI3.Database.Context;
public partial class PersianCalendarContext : DbContext
{
    public virtual DbSet<Shift> Shifts
    {
        get; set;
    }

    public string DatabasePath
    {
        get; set;
    }

    public PersianCalendarContext(string databasePath)
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
            options.UseSqlite($"Data Source={DatabasePath}");
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
