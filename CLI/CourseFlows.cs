using StudentManagement.Domain.Models;
using StudentManagement.Domain.Dto;
using StudentManagement.Domain.Enums;
using StudentManagement.Infrastructure.Repositories;
using StudentManagement.Utility;

namespace StudentManagement.CLI;
using StudentManagement.Application.Services;

public class CourseFlows
{
    private CourseService _courseService;
    
    public CourseFlows()
    {
        _courseService = new CourseService();
    }
    
    public async void ViewCourseInfo(string courseName)
    {
        Console.WriteLine($"Finding course info for {courseName}");

        CourseInfoDto courseInfo = await _courseService.GetCourseInfo(courseName);
        
        Console.WriteLine($"Info: {courseInfo}");
    }

    public async void RegisterNewCourse()
    {
        Course newCourse = new Course();
        
        Console.WriteLine("Start creating new course \n" +
                          "Start by assigning a name");
        newCourse.courseName = Console.ReadLine();
        Console.WriteLine("Let's add which year and semester it'll be schedueled for. \n" +
                          "Enter a valid response for year: \n" +
                          "First \n" +
                          "Second \n" +
                          "Third");

        Console.WriteLine("Enter the professor who will teach the course");
        string professor = Console.ReadLine();
        //Need to query for professor and assign if found
        
        Console.WriteLine("When should the final be?");
        newCourse.final = DateOnly.Parse(Console.ReadLine());
        
        Console.WriteLine("Which year?");
        string year = Console.ReadLine();
        Enum.TryParse(year, out Year parsedYear);
        newCourse.year = parsedYear;

        Console.WriteLine("And what semester?");
        string semester = Console.ReadLine();
        Enum.TryParse(semester, out Semester parsedSemester);
        newCourse.semester = parsedSemester;
    }
}