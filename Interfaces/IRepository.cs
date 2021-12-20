namespace gunstore.Interfaces
{
    public interface IRepository<T>
    {
         List<T> List();
         T GetById(int id);
         void Create(T entity);
         void Delete(int id, T entity);
         void Put(int id, T entity);
         int NextId();
    }
}