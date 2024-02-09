using System;

class Program
{
    public static void Main()
    {
        int age = 29;

        PrintToConsole("Hello, Dolapo");
        VariablesAndDataTypes(age);
    }

    static void PrintToConsole(string parameter)
    {
        Console.WriteLine($"{parameter}");
    }

    static void VariablesAndDataTypes(int age)
    {
        Console.WriteLine($"{age}");
    }
}