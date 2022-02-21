using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicalProgramsPractice
{
    internal class OOPSdemo
    {
        public string name="DogParent";
        //public int Id;
        
        public void inheritanceCode()
        {
            Console.WriteLine("tutt ,tutt");
        }
        
    }
    class Dog: OOPSdemo
    {
        public string name1 = "Dogchild";
        public void DogSound()
        {
            
            Console.WriteLine("Dog is barking");
        }
    }
}
