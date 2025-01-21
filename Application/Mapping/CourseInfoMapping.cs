namespace StudentManagement.Application.Mapping;
using StudentManagement.Domain.Dto;
using StudentManagement.Domain.Models;

public class CourseInfoMapping
{
    public static CourseInfoDto MapCourseInfo(Course course)
    {
        CourseInfoDto newInfo = new CourseInfoDto
        {
            profName = course.professor.profName,
            courseName = course.courseName,
            enrolledStudents = course.attendingStudents.Select(c => c.name).ToList(),
            currentWaitlist = course.waitList.Select(s => s.name).ToList()
        };
        return newInfo;
    }
}