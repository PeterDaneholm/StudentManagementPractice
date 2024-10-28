namespace StudentManagement.Domain.Models;

public class Grade
{
    public Guid gradeId { get; set; }
    public Guid courseId { get; set; }
    public Guid studentId { get; set; }
    public int grade { get; set; }
}