using System;

class Program
{
    public static void Main()
    {
        int age = 29;
        double interest = 5.53;
        char val = 'A';
        string name = "Johnny";
        int value1 = 5;
        int value2 = 10;
        int value3 = 0;

        PrintToConsole($"Hello, {name}");
        VariablesAndDataTypes(age, interest);

        try
        {
            DivisionFunction(value1, value2);
            DivisionFunction(value1, value3);
        } catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + " Error dividing by zero");
        }
    }

    static void PrintToConsole(string parameter)
    {
        Console.WriteLine($"{parameter}");
    }

    static void VariablesAndDataTypes(int age, double interestRate)
    {
        Console.WriteLine($"How old are you? {age}?");
        Console.WriteLine($"Today's interest rate is {interestRate}.");
    }

    static void DivisionFunction(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException();
        }

        Console.WriteLine((double)num1 / num2);
    }
}