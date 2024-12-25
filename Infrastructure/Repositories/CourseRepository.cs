namespace StudentManagement.Infrastructure.Repositories;

public class CourseRepository : IRepository<Course>
{
    public async Task<Course> Add(Course entity)
    {
        throw new NotImplementedException();
    }

    public async Task<Course> Get(string name)
    {
        throw new NotImplementedException();
    }

    public async Task<Course> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Course> Update(Course entity, Dictionary<string, string> NewValue)
    {
        throw new NotImplementedException();
    }
}