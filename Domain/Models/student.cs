

class Student
{
    public Guid studentId { get; }
    public string name { get; set; }
    public List<string> currentClasses { get; set; }
    public List<string> passedClasses { get; set; }
    public List<int> grades { get; set; }
}