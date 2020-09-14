using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{
    class Book
    {
        public string title { get; set; }
        public int PageNum { get; set; }
        public string Author { get; set; }

    }

    class Cat 
    { 
        public int age { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string gender { get; set; }
        public double kg { get; set; }

        public Cat()
        {

        }

        public Cat(string _name)
        {
            name = _name;
        }

        public Cat(string _name, string _color)
        {
            name = _name;
            color = _color;

        }

        public void Sound()
        {
            Console.WriteLine($"{color}색 {name} 고양이가 야~~~옹");
        }

        public void Scratch()
        {
            Console.WriteLine("찍~~~~~");
        }
    

        public void eat()
        {
            kg += 0.5;
            Console.WriteLine($"고양이가 밥을 ㅁ");
        }
    }


    class Program
    {


        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.name = "키티";
            cat1.color = "하얀색";
            cat1.Sound();
            cat1.Scratch();

            Cat cat2 = new Cat();
            cat2.name = "네로";
            cat2.color = "검은색";
            cat2.Sound();
            cat2.Scratch();

            Cat cc = new Cat();
            cc = new Cat("네로", "Black");


        }
    }
}
