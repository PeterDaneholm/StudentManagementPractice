namespace StudentManagement.Application.Services;
using StudentManagement.Domain.Models;
using StudentManagement.Infrastructure.Repositories;

public class CourseService
{
    public string EnrollStudent(Student student, Course course)
    {
        bool canEnroll = false;
        bool onWaitlist = false;
        bool isInClass = course.IsInClass(student.name, course);
        if (!isInClass)
        {
            onWaitlist = course.IsOnWaitlist(student.name, course);
        }
        if (!onWaitlist)
        {
            int currentStudents = course.attendingStudents.Count();
            canEnroll = currentStudents >= course.maxAttendees ? true : false;
        }

        if (canEnroll)
        {
            course.attendingStudents.Add(student);
            return "Student added";
        }
        else if (onWaitlist)
        {
            course.waitList.Add(student);
            return "Course is full, added to waitlist";
        }
        else
        {
            return "Cannot enroll student";
        }
    }

    public string IsCoursePassed(Student student, Course course)
    {
        
        return "Nah";
    }
}