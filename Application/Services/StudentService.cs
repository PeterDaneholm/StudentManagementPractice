namespace StudentManagement.Application.Services;

using StudentManagement.Infrastructure.Repositories;
using StudentManagement.Domain.Models;
using StudentManagement.Domain.Dto;

public class StudentService
{
    private StudentRepository _studentRepository;
    private CourseRepository _courseRepository;

    public StudentService(StudentRepository studentRepository, CourseRepository courseRepository)
    {
        _studentRepository = studentRepository;
        _courseRepository = courseRepository;
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

    public async Task<string> EnrollStudent(string studentName, string courseName)
    {
        Course newCourse = await _courseRepository.Get(courseName);
        Student student = await _studentRepository.Get(studentName);
        bool canEnroll = newCourse.IsInClass(studentName, newCourse);
        if (canEnroll)
        {
            var enrolledCourses = student.currentClasses.Append(newCourse).ToList();
            var newInfo = new Dictionary<string, object> { { "newCourses", enrolledCourses } };
            try
            {
                await _courseRepository.Update(newCourse,
                    new Dictionary<string, object>
                    {
                        { "updatedStudents", newCourse.attendingStudents.Append(student) }
                    });
                await _studentRepository.Update(student, newInfo);
                return $"Student {studentName} enrolled in course ${newCourse.courseName}";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        else
        {
            return "Cannot enroll in course";
        }
    }
}