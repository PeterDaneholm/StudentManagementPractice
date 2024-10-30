using StudentManagement.Domain.Models;

public class Student
{
    public Guid studentId { get; }
    public string name { get; set; }
    public List<Course> currentClasses { get; set; }
    public List<Course> passedClasses { get; set; }
    public List<Grade> grades { get; set; }
}