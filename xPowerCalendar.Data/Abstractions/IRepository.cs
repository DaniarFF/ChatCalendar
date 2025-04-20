namespace xPowerCalendar.Data;

public interface IRepository<T> where T : class
{
  /// <summary>
  ///   Добавить сущность.
  /// </summary>
  /// <param name="entity"></param>
  /// <returns></returns>
  Task Add(T entity);

  /// <summary>
  ///   Получить все сущности.
  /// </summary>
  /// <returns></returns>
  IQueryable<User> GetAll();

  /// <summary>
  ///   Обновить сущность.
  /// </summary>
  /// <param name="entity"></param>
  /// <returns></returns>
  Task Update(T entity);

  /// <summary>
  ///   Удалить сущность.
  /// </summary>
  /// <param name="entity"></param>
  /// <returns></returns>
  Task Delete(T entity);
}