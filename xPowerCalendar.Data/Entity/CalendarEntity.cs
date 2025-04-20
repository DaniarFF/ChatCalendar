namespace xPowerCalendar.Data;

public class Calendar
{
  public Guid Id { get; set; }
  public string Name { get; set; }
  
  public List<Event> Events { get; set; }
  public List<User> SharedWith { get; set; }
  public bool IsChatCalendar { get; set; }
 }