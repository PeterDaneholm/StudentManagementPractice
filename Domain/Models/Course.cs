using System.Runtime.InteropServices.JavaScript;
using StudentManagement.Domain.Models;
using StudentManagement.Domain.Enums;

public class ExamAttempt
{
    public Grade grade;
    public int attempt = 0;
}

public class Course
{
    public Guid courseId { get; set; }
    public string courseName { get; set; }
    public Professor professor { get; set; }
    public int maxAttendees { get; set; }
    public List<Student> attendingStudents { get; set; }
    public List<Student> waitList { get; set; } //check ordering of waitlist for which position in queue
    public DateOnly final { get; set; }
    public DateOnly midTerm { get; set; }
    public Semester semester { get; set; }
    public Year year { get; set; }
    public int examAttempt { get; set; }
    public List<ExamAttempt> examAttempts { get; set; }

    public int CurrentAttempt()
    {
        return this.examAttempts.Count;
    }
    public bool ExamAttempsNumber()
    {
        bool maxAttemptsUsed = this.examAttempts.Count >= 3 ? true : false;

        return maxAttemptsUsed;
    }

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

    public bool IsExamAttemptPassed(Grade grade, ExamAttempt exam)
    {
        if (grade.grade != Grade.GradeValue.f || grade.grade != Grade.GradeValue.e)
        {
            int currentAttempt = CurrentAttempt();
            this.examAttempts.Add(new ExamAttempt
                {
                    attempt = currentAttempt + 1,
                    grade = grade
                }
            );
            return true;
        }
        else
        {
            return false;
        }
    }
}