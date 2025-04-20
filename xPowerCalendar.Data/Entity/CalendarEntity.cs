namespace xPowerCalendar.Data;

public class CalendarEntity
{
  /// <summary>
  ///   Идентификатор календаря
  /// </summary>
  public int Id { get; set; }

  /// <summary>
  ///   Название календаря.
  /// </summary>
  public string Name { get; set; }
  
  /// <summary>
  ///  Владелец календаря. Внешний ключ
  /// </summary>
  public long UserId { get; set; }
  
  /// <summary>
  ///   Владелец календаря.
  /// </summary>
  public User Owner { get; set; }

  /// <summary>
  ///   События в календаре.
  /// </summary>
  public List<EventEntity> Events { get; set; }
  
  /// <summary>
  ///   Публичность календаря.
  /// </summary>
  public bool IsPrivate { get; set; }
  
  /// <summary>
  ///   Признак основного календаря.
  /// </summary>
  public bool IsItMainCalendar { get; set; }
}