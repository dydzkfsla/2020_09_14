using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{

    class MyMath {
        public int x;
        public int y;
        
        public MyMath()
        {
            Console.WriteLine("생성자 호출");

        }


        public int Add()
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }


        public int Min()
        {
            return x - y;
        }

        public static MyMath operator +(MyMath myMath)
        {
            return myMath;
        }

    }


    class Class1
    {
        static void Main()
        {
            MyCalc c1 = new MyCalc();

            Console.WriteLine(c1.Square(5, 3));
            Console.WriteLine(c1.Square(15, 13));

            int i = 5;
            int k = 3;

            int s = i * k;
            Console.WriteLine($"가로: {i} 세로: {k}, 넓이: {s}");

            int i2 = 15;
            int k2 = 13;

            int s2 = i2 * k2;

            Console.WriteLine($"가로: {i2} 세로: {k2}, 넓이: {s2}");
        }
    }
}
