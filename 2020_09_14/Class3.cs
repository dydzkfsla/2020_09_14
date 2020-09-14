using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{
    class Person {
        public string name;

        public Person()
        {
            name = "홍길동";
        }

        public Person(string _name)
        {
            name = _name;
        }
    
    }


    class Class3
    {
        static void Main()
        {
            Person p1 = new Person();
            Console.WriteLine(p1.name);


            Person p2 = new Person("류현진");
            Console.WriteLine(p2.name);
        }
    }
}
