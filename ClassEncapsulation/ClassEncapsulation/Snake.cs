using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    internal class Snake : Animal
    {
        public Snake(string Name, int Age) : base(Name, Age)
        {
        }
        private bool _isPoisonous;

        public bool Poison
        {
            get { return _isPoisonous; }
            set 
            { 
                if(value==true) 
                {
                    Console.WriteLine("Zeherli ilan qebul olunmur.");
                }
                else
                {
                    _isPoisonous = value;
                }
            }
        }

        public void getInfoSnake()
        {
            Console.WriteLine($"This animal's breed is {Breed} , name is {Name} and age is {Age} " );
        }
    }
}
