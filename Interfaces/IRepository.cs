namespace gunstore.Interfaces
{
    public interface IRepository<T>
    {
         List<T> List();
         T GetById();
         void Put(T entity);
         void Delete(int id, T entity);
         void Put(int id, T entity);
         int NextId();
    }
}