using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    
    public class Constrctor
    {
        public string name;
        // Constructor dont have any return type
        // Name should be same as the class name

        //Non-Paramter
        public Constrctor() 
        {
            Console.WriteLine("Helloworld");
        }

        //Parameter
        public Constrctor(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }

        public void withoutImplementionMethod()
        {
            Console.WriteLine("Hi There");
        }
    }    
}
