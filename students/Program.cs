using System;
using students;  // Import the students namespace

class Program
{
    static void Main()
    {
        Student student = new Student();
        Student student2 = new Student();

        student.Name = "Josef";
        student.Age = 25;
        student.StudentProgram = "Math";
        student.StudentID = 6969;

        student2.Name = "Maria";
        student2.Age = 26;
        student2.StudentProgram = "Applied Mathemathics";
        student2.StudentID = 2007;

        Class classe = new Class();
        Class classe2 = new Class();

        classe.ClassName = "Science";
        classe.Points = 27;
        classe.ClassCode = 69;

        classe2.ClassName = "Computer Science";
        classe2.Points = 25;
        classe2.ClassCode = 07;

        Grades grade = new Grades();
        Grades grade2 = new Grades();
        {
            grade.Student = student;
            grade.Class = classe;
            grade.Grade = 'A';

            grade2.Student = student;
            grade2.Class = classe;
            grade2.Grade = 'B';
        }
        
        student.ShowInfo();
        Console.WriteLine();
        classe.ShowInfo();
        grade.ShowInfo();

        Console.WriteLine();
        student2.ShowInfo();
        Console.WriteLine();
        classe2.ShowInfo();
        grade2.ShowInfo();
    }
}