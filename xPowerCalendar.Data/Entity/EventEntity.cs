namespace xPowerCalendar.Data;

public class EventEntity
{
  public Guid Id { get; set; }
  public  DateTime Start { get; set; }
  public DateTime End { get; set; }
  public string Title { get; set; }
  public string Description{ get; set; }
}