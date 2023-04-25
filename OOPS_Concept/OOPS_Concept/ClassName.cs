using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class ClassName: InterfaceType
    {
        // Non-parametised method
        public void PrintName()
        {
            Console.WriteLine("Nikhlesh");
        }
        //parameterised method
        public void GetName(string name)
        {
            Console.WriteLine(name);
        }

        public void withoutImplementionMethod()
        {
            Console.WriteLine("This is classname");
            //throw new NotImplementedException();
        }
    }
}

