using System.Globalization;

namespace xPowerCalendar.Data;

public class EventEntity
{
  /// <summary>
  ///   Идентификатор события календаря.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  ///   Идентификатор календаря.
  /// </summary>
  public int CalendarId { get; set; }
  
  /// <summary>
  ///   Календарь.
  /// </summary>
  public CalendarEntity Calendar { get; set; }

  /// <summary>
  ///   Дата начала события.
  /// </summary>
  public DateTime Start { get; set; }

  /// <summary>
  ///   Дата окончания события.
  /// </summary>
  public DateTime End { get; set; }

  /// <summary>
  ///   Название события.
  /// </summary>
  public string Title { get; set; }

  /// <summary>
  ///   Описание события.
  /// </summary>
  public string Description { get; set; }
}