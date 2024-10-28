using StudentManagement.Domain.Models;

class Student
{
    public Guid studentId { get; }
    public string name { get; set; }
    public List<string> currentClasses { get; set; }
    public List<string> passedClasses { get; set; }
    public List<Grade> grades { get; set; }
}