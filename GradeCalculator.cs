using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter grade");
        int userGrade = Convert.ToInt32(Console.ReadLine());

        if (userGrade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (userGrade >= 80 && userGrade <= 89)
        {
            Console.WriteLine("B");
        }
        else if (userGrade >= 70 && userGrade <= 79)
        {
            Console.WriteLine("C");
        }
        else if (userGrade >= 60 && userGrade <= 69)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
