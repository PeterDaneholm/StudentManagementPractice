namespace StudentManagement.Infrastructure.Repositories;


public interface IRepository<T>
{
    public void Add(T entity);
    public void Get(T entity);
    public void GetAll();
    public void Update(T entity, Dictionary<string, string> NewValue);
}