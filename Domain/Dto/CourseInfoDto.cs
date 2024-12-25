namespace StudentManagement.Domain.Dto;
using StudentManagement.Domain.Models;

public class CourseInfoDto
{
    public string profName { get; set; }
    public string courseName { get; set; }
    public List<string> enrolledStudents { get; set; }
}