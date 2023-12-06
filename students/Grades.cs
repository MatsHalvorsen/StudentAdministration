namespace students;

public class Grades
{
    public Student Student {get; set;}
    public Class Class {get; set;}
    public char Grade {get; set;}

    public void ShowInfo() 
    {
        Console.WriteLine($"Grade: {Grade}");
    }
}
