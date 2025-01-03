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
        
    }

    public async Task<Student> Get(Student student)
    {
        
    }

    public async Task<Student> GetAll()
    {
        
    }

    public async Task<Student> Update(Student student, Dictionary<string, string> newInfo)
    {
        
    }
}