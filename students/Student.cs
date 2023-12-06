using System;

public class Student
{
    public string Name {get; set;}
    public int Age {get; set;}
    public string StudentProgram {get; set;}
    public int StudentID {get; set;}

    public void ShowInfo()
    {
        Console.WriteLine($"Student: {Name}\nAge: {Age}\nProgram: {StudentProgram}\nStudentID: {StudentID} "); 
    }

}
