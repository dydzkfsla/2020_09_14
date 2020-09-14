using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{
    class MyMath
    {
        public int x;
        public int y;

        public MyMath(int x, int y)
        {
            Console.WriteLine("생성자 호출");
            this.x = x;
            this.y = y;
        }

        public MyMath()
        {
            Console.WriteLine("생성자 호출");
            x = 10;
            y = 10;
        }

        public int Add()
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }
       
        public int Minus(int x, int y)
        {
            return x - y;
        }
    
        public int Divide(int x, int y)
        {
            if(y == 0)
                return -999;
            return x / y;
            
        }


        public static MyMath operator +(MyMath myMath)
        {
            return myMath;
        }

    }

    class Class2
    {
        static void Main()
        {
            MyMath c1 = new MyMath();

            MyMath p1 = new MyMath(30, 50);

            c1.x = 1;
            c1.y = 2;

            Console.WriteLine(c1.Add());
            Console.WriteLine(p1.Add());
        }
    }
}
