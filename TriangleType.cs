using System;

class TriangleType
{
    static void Main()
    {
        int side1 = Convert.ToInt32(Console.ReadLine());
        int side2 = Convert.ToInt32(Console.ReadLine());
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("this is an equilateral triangle");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("this is an isoceles triangle");
        }
        else
        {
            Console.WriteLine("this is a scalene triangle");
        }
    }

}