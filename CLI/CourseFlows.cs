using StudentManagement.Domain.Dto;
using StudentManagement.Domain.Dto;
using StudentManagement.Infrastructure.Repositories;

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
}