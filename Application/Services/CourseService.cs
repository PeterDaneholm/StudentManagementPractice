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

    public bool IsInClass(string studentName, Course actualCourse)
    {
        bool isEnrolled = false;
        foreach (var student in actualCourse.attendingStudents)
        {
            if (student.name == studentName)
                return isEnrolled = true;
        }

        return isEnrolled;
    }
    

}