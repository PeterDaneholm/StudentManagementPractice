namespace StudentManagement.Domain.Models;

public class Grade
{
public enum GradeValue
{
    f = -3,
    e = 00,
    d = 02,
    c = 7,
    b = 10,
    a = 12,
}
    public Guid gradeId { get; set; }
    public Guid courseId { get; set; }
    public Guid studentId { get; set; }
    public GradeValue grade { get; set; }
}