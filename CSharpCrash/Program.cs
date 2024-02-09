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
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + " Error dividing by zero");
        } 
        
        try
        {
            ConditionalOperator(4);
            ConditionalOperator(9);
        }
        catch (InvalidDataException ex) {
            Console.WriteLine(ex.Message + " Invalid data");
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

    static void ConditionalOperator (int dayOfTheWeek)
    {
        string day = dayOfTheWeek switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => throw new InvalidDataException("Invalid day"),
        };
        Console.WriteLine($"The day specified is {day}");
    }
}