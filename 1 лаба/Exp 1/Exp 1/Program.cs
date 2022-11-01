using System;

namespace project
{
     class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            int d = 10;

            ThePoint point1 = new ThePoint(a, b);
            ThePoint point2 = new ThePoint(c, d);
            ThePoint point3 = new ThePoint(point1);
            ThePoint point4 = point2.Clone();

            Console.WriteLine(point1.Position);
            Console.WriteLine(point2.Position);
            Console.WriteLine(point3.Position);
            Console.WriteLine(point4.Position);
        }

    }
}