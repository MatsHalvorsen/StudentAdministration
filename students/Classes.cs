﻿namespace students;

public class Class
{
    public int ClassCode {get; set;}
    public string ClassName {get; set;}
    public int Points {get; set;}

    public void ShowInfo() 
    {
        Console.WriteLine($"Code: {ClassCode}\nClass Name: {ClassName}\nPoints: {Points}");
    }
}
