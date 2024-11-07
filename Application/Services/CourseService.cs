namespace StudentManagement.Application.Services;
using StudentManagement.Domain.Models;
using StudentManagement.Infrastructure.Repositories;

public class CourseService
{

    public bool IsOnWaitlist(string studentName, Course newCourse)
    {
        bool isEnrolled = false;
        
        foreach (var student in newCourse.waitList)
        {
            if (student.name == studentName)
            {
                isEnrolled = true;
                break;
            }
        }

        return isEnrolled;
    }
}