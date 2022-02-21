using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicalProgramsPractice
{
    abstract class Animal
    {
        public abstract void AnimalSound();
        public void sleep()
        {
            Console.WriteLine("zzzzzz");
        }
    }
    class Koila: Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("koila will make this sound:"+" "+"kuhhhh,kuhhhhh");
        }
    }
}
