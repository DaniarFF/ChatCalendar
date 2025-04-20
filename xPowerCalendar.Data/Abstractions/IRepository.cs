namespace xPowerCalendar.Data;

public interface IRepository<T, TKey>  where T : class
{
  /// <summary>
  ///  Добавить сущность.
  /// </summary>
  /// <param name="entity"></param>
  /// <returns></returns>
  Task<T> Add(T entity);
  
  /// <summary>
  ///   Получить cущность по идентификатору.
  /// </summary>
  /// <param name="Id"></param>
  /// <returns></returns>
  Task<List<User>> Get (TKey id);
  
  /// <summary>
  ///   Получить все сущности.
  /// </summary>
  /// <returns></returns>
  Task<List<T>> GetAll();
  
  /// <summary>
  ///   Обновить сущность.
  /// </summary>
  /// <param name="entity"></param>
  /// <returns></returns>
  Task<T> Update(T entity);
  
  /// <summary>
  ///   Удалить сущность.
  /// </summary>
  /// <param name="entity"></param>
  /// <returns></returns>
  Task<T> Delete(T entity);
}