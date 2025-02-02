namespace StudentManagement.CLI;
using System.Net.Mime;

//https://www.loginradius.com/blog/engineering/enum-csharp/

public class BaseCLIFlow
{
    private CourseFlows _courseFlows = new CourseFlows();
    public void StartFlow()
    {
        Console.WriteLine("Welcome to the Student Management Programme");
        Console.WriteLine("What would you like to do?\n" +
                          "1 - Create new User \n" +
                          "2 - Create new Course \n" +
                          "3 - View existing User or Course\n");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                break;
            case "2":
                _courseFlows.RegisterNewCourse();
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Not Valid input, try again:");
                StartFlow();
                break;
        };
    }
}