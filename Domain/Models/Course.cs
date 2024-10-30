

public class Course
{
    public Guid courseId { get; set; }
    public string courseName { get; set; }
    public int maxAttendees { get; set; }
    public List<Student> attendingStudents { get; set; }
    public List<Student> waitList { get; set; }
    public DateOnly final { get; set; }
    public DateOnly midTerm { get; set; }
}