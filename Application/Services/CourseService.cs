namespace StudentManagement.Application.Services;
using StudentManagement.Domain.Models;
using StudentManagement.Domain.Dto;
using StudentManagement.Infrastructure.Repositories;

public class CourseService
{
    private CourseRepository _courseRepository;

    public CourseService(
        CourseRepository courseRepository
    )
    {
        _courseRepository = courseRepository;
    }

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
        //Check if examAttempts are more than three
        //If not, use model function to determine passed status
        return "Nah";
    }

    public async Task<CourseInfoDto> GetCourseInfo(Course course)
    {
        Course foundCourse = await _courseRepository.Get(course);

        CourseInfoDto courseInfo = new CourseInfoDto();

        return courseInfo;
    }
}