using System;

public class Program
{
    public static void ModifyValue(ref int number)
    {
        number = 100;
    }

    public static void Main()
    {
        int myNumber = 0;
        ModifyValue(ref myNumber);
        Console.WriteLine(myNumber);
    }
}