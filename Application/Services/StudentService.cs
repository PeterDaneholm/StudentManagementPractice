namespace StudentManagement.Application.Services;
using StudentManagement.Infrastructure.Repositories;
using StudentManagement.Domain.Models;
using StudentManagement.Domain.Dto;

public class StudentService
{
    private StudentRepository _studentRepository;

    public StudentService(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<Student> GetStudent(string studentName)
    {
        try
        {
            Student foundStudent = await _studentRepository.Get(studentName);
            return foundStudent;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<Student>> GetStudents()
    {
        try
        {
            List<Student> allStudents = await _studentRepository.GetAll();
            Console.WriteLine("Found students, returning with them");
            return allStudents;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}