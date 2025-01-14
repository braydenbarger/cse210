using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        int percentage = int.Parse(input);
        string grade;

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your letter grade is: {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Try again and you'll get it!");
        }
    }
}
