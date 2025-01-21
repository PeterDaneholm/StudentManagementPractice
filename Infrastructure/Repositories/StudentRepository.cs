namespace StudentManagement.Infrastructure.Repositories;
using Domain.Models;
using Utility;
using System.Threading.Tasks;

public class StudentRepository: IRepository<Student>
{
    private Database _database;
    public StudentRepository(Database database)
    {
        _database = database;
    }

    public async Task<Student> Add(Student entity)
    {
        _database.OpenConnection();
        try
        {
            using (var connection = _database.GetConnection())
            {
                var query = "INSERT INTO Student (studentId) VALUES (@entity.studentId)";
                
            }       
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            _database.CloseConnection();
        }

        return entity;
    }

    public async Task<Student> Get(string name)
    {
        Student foundStudent = new Student();
        return foundStudent;
    }

    public async Task<Student> GetAll()
    {
        Student foundStudent = new Student();
        return foundStudent;
    }

    public async Task<Student> Update(Student student, Dictionary<string, string> newInfo)
    {
        Student foundStudent = new Student();
        return foundStudent;
    }
}