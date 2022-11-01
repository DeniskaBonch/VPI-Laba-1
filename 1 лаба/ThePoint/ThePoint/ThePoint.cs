using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class ThePoint
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;
        public void MoveBy(int dx, int dy, int dz)
        {
            x = x + dx;
            y = y + dy;
            z = z + dz;
        }
        public void Printer()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }

    }
}
