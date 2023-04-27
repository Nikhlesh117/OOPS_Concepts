using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //AccessModifiers in C# are the keywords used to Specify the accessability or scope of Variable of function
    public class Modifiers
    {
        // public access modifier can be access in same asseblt or in different assembley
        public int a = 10;
        //private we cant access anywhere outside the class it access only within current class
        private void PrivateMethod()
        {
            Console.WriteLine("PrivateMethod");
        }
        // It allow code in same class or derive class
        protected string str = "hello";
        // The access is limited to the current class or
        protected internal double val = 2.4;
    }
}
