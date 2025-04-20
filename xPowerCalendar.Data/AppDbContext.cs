using Microsoft.EntityFrameworkCore;

namespace xPowerCalendar.Data;

public class AppDbContext : DbContext
{
  public DbSet<CalendarEntity> Calendars { get; set; }
  public DbSet<EventEntity> Events { get; set; }
  public DbSet<User> Users { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<CalendarEntity>()
      .HasMany(c => c.Events)
      .WithOne(e => e.Calendar)
      .HasForeignKey(e => e.CalendarId)
      .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<User>()
      .HasMany(e => e.Calendars)
      .WithOne(c => c.Owner)
      .HasForeignKey(e => e.UserId);
  }
  
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    // Дашь креды, Ярик? 
    optionsBuilder.UseNpgsql(" .... ");
  }
}