using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    // IT will show the essentail features and hide the complex data from user.
    //IT will achieve with the help of abstract class and abstract method.
    public  abstract class Abstraction
    {
        // Firstly use abstract keyword to create the abstract class.
        //we cannot create the object for the abstract class.
        //Abstract and Non-Abstract methods are present in the abstract class.
        public abstract void AbstractMethod(); // This is abstract method and does not contain any body.
        public void NonAbstractMethod() //This is the regular method/non-abstract method. 
        {
            Console.WriteLine("This is non abstract method");
        }
    }
}
