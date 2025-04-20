namespace xPowerCalendar.Data;

public class UserRepository : IRepository<User>
{
  private readonly AppDbContext context;

  public UserRepository(AppDbContext context)
  {
    this.context = context;
  }

  public async Task Add(User entity)
  {
    if (entity == null) return;

    context.Add(entity);
    await context.SaveChangesAsync();
  }

  public IQueryable<User> GetAll()
  {
    var query = context.Users.AsQueryable();

    return query;
  }

  public async Task Update(User entity)
  {
    if (entity == null) return;

    context.Users.Update(entity);
    await context.SaveChangesAsync();
  }

  public async Task Delete(User entity)
  {
    var entityToDelete = await context.Users.FindAsync(entity.TelegramId);
    if (entity == null) return;

    context.Users.Remove(entity);
    await context.SaveChangesAsync();
  }
}