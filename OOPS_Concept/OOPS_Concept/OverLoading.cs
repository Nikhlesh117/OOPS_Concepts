using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    //Polymorphism mean many form and there are two types of polymorphism
    // 1. Run time Polymorphism --> Method OverRiding
    // 2. Compile Type Polymorphism --> Method Overloading
    public class OverLoading
    {

        public virtual void MethodOne()
        {
            Console.WriteLine("this is base class");
        }
        public void MethodOne(int num) 
        {
            Console.WriteLine("with one parameter");
        }
        public void MethodOne(int num,string str)
        {
            Console.WriteLine("with two parameter");
        }
    }
}
