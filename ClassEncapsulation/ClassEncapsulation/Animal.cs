using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    internal class Animal
    {
        public string Name;
        public string Breed;

        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            {
                if(value < 0)
                {
                    Console.WriteLine("yash 0-dan cox olmalidi.");
                }
                else
                { 
                _age = value;
                }
            }
        }

        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        
        public void getInfo()
        {
            Console.WriteLine($"This animal's breed is {Breed} , name is {Name} and age is {Age}");
        }

    }
}
