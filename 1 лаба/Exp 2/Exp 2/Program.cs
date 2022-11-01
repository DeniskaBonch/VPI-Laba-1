using System;
using System.Collections.Generic;

namespace Exp_2
{
    internal class Program
    {
        static void Main()
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < 5; i += 1)
                arr.Add(i);
            foreach (int el in arr)
                Console.WriteLine(el);
            for (int i = 3; i >0; i-= 2)
                arr.RemoveAt(i);
            // arr.RemoveAt(3)
            // arr.RemoveAt(1)
            Console.WriteLine("-----------");
            foreach (int el in arr)
                Console.WriteLine(el);

        }

    }
}
