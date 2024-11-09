using System.Runtime.InteropServices.JavaScript;
using StudentManagement.Domain.Models;
using StudentManagement.Domain.Enums;

public class ExamAttempt
{
    public Grade grade;
    public int attempt;
}
public class Course
{
    public Guid courseId { get; set; }
    public string courseName { get; set; }
    public int maxAttendees { get; set; }
    public List<Student> attendingStudents { get; set; }
    public List<Student> waitList { get; set; }
    public DateOnly final { get; set; }
    public DateOnly midTerm { get; set; }
    public Semester semester { get; set; }
    public Year year { get; set; }
    public int examAttempt { get; set; }
    public List<ExamAttempt> examAttempts { get; set; }

    public bool ExamAttempsNumber()
    {
        bool maxAttemptsUsed = this.examAttempt >= 3 ? true : false; 
        
        return maxAttemptsUsed;
    }
}