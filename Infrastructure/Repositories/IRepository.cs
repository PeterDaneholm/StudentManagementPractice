namespace StudentManagement.Infrastructure.Repositories;


public interface IRepository<T>
{
    public Task Add(T entity);
    public Task Get(T entity);
    public Task GetAll();
    public Task Update(T entity, Dictionary<string, string> NewValue);
}