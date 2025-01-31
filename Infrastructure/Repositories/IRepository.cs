namespace StudentManagement.Infrastructure.Repositories;


public interface IRepository<T>
{
    public Task<T> Add(T entity);
    public Task<T> Get(string name);
    public Task<List<T>> GetAll();
    public Task<T> Update(T entity, Dictionary<string, string> NewValue);
}