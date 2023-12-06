using System;
using students;  // Import the students namespace

class Program
{
    static void Main()
    {
        Student student = new Student();
        Classes classe = new Classes();

        student.Name = "Josef";
        student.Age = 25;
        student.StudentProgram = "Math";
        student.StudentID = 6969;

        classe.ClassCode = 69;
        classe.ClassName = "Science";
        classe.Points = 27;

        student.ShowInfo();
        Console.WriteLine();
        classe.ShowInfo();
    }
}