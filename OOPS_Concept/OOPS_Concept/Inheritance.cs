using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    // Inheritance is totally depent on deriverd class and bse class / child  or parent class
    // we are using colon :
    public class Parentclass : Baseclass
    {
        public Parentclass()
        {
            Console.WriteLine("This is a parent class ");
        }
        public void Class()
        {
            Console.WriteLine("this is method in parent class");
        }
    }
    public class Baseclass
    {
        public string name;
        public void TestName()
        {
            Console.WriteLine("This is a base class");
        }
    }
}
