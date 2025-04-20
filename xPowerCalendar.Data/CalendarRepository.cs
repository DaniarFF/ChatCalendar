namespace xPowerCalendar.Data;

public class CalendarRepository
{
  private readonly AppDbContext context;

  public CalendarRepository(AppDbContext context)
  {
    this.context = context;
  }

  public async Task Add(CalendarEntity entity)
  {
    if (entity == null) return;

    context.Add(entity);
    await context.SaveChangesAsync();
  }
  
  public IQueryable<CalendarEntity> GetAll()
  {
    var query = context.Calendars.AsQueryable();

    return query;
  }

  public async Task Update(CalendarEntity entity)
  {
    if (entity == null) return;

    context.Calendars.Update(entity);
    await context.SaveChangesAsync();
  }

  public async Task Delete(CalendarEntity entity)
  {
    var entityToDelete = await context.Calendars.FindAsync(entity.Id);
    if (entity == null) return;

    context.Calendars.Remove(entity);
    await context.SaveChangesAsync();
  }
}