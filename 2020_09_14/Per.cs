using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_14
{
    class Student 
    {
        private string name;
        private int age;
        private double height {
            get { return height; } 
            set 
            {
                if (value >= 50)
                    height = value;
                    
            } 
         }
        private double weight;
    }


    class Per
    {
        static void Main() {
            Student stu1 = new Student();
            //stu1.height = -150;
            
        
        }

    }
}
