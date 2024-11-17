using StudentManagement.Domain.Models;
using StudentManagement.Domain.Enums;

public class Student
{
    public Guid studentId { get; }
    public string name { get; set; }
    public List<Course> currentClasses { get; set; }
    public List<Course> passedClasses { get; set; }
    public List<Grade> grades { get; set; }
    public Year year { get; set; }
    public List<Sport> sports { get; set; }
    public List<ExtraActivity> extraCorricularActivities { get; set; }
    
    
    //Should not be able to join sport/activity if grade average below threshold
}