using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{
    class Class2
    {
        static void Main()
        {
            MyMath c1 = new MyMath();

            c1.x = 1;
            c1.y = 2;

            Console.WriteLine(c1.Add());
        }
    }
}
