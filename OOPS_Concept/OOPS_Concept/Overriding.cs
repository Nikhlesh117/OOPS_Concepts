using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Overriding : OverLoading
    {
        //virtual keyword used to modify a method or override a method in derived class.
        // Override is used to extend or modify the virtual implemented of a inherited method.
        public override void MethodOne()
        {
            Console.WriteLine("this is child class");
        }
    }
}
