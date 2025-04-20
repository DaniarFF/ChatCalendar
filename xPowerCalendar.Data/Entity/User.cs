namespace xPowerCalendar.Data;

public class User
{
  /// <summary>
  ///   Телеграм айди пользователя.
  /// </summary>
  public long TelegramId { get; set; }
  
  /// <summary>
  ///   Имя пользователя.
  /// </summary>
  public string Name { get; set; }
  
  /// <summary>
  ///   Список календарей пользователя.
  /// </summary>
  public List<CalendarEntity> Calendars { get; set; }
}