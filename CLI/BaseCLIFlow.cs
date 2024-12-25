namespace StudentManagement.CLI;
using System.Net.Mime;

public class BaseCLIFlow
{
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
                CreateUserFlow();
                break;
            case "2":
                CreateCourseFlow();
                break;
            case "3":
                ViewInfoFlow();
                break;
            default:
                Console.WriteLine("Not Valid input, try again:");
                input = Console.ReadLine();
                break;
        };
    }

    public void CreateUserFlow()
    {
        
    }

    public void CreateCourseFlow()
    {
        
    }

    public void ViewInfoFlow()
    {
        
    }
}