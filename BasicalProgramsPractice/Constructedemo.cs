using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicalProgramsPractice
{
    internal class Constructedemo
    {
        public string name;
        public int age;
        public int Id;
        //parameterised constructor
        public Constructedemo(string name1, int age1,int id1)
        {
            name = name1;
            age = age1;
            Id = id1;
        }
        //non parameterised constructer
        public Constructedemo()
        {
            name = "jaan";
            age = 10;
            Id = 21324;
        }
    }
}
