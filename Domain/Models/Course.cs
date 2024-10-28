

class Course
{
    public Guid courseId { get; set; }
    public string courseName { get; set; }
    public int maxAttendees { get; set; }
    public List<Student> attendingStudents { get; set; }
}