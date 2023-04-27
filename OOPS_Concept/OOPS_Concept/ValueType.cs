using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    //In Value Type two types are there 1) build in type 2)user-difined type
    //built-in : int, long, Float, double, byte, decimal, short, char, bool
    //user-defined : struct and enum
    //it will store in a stack memory.
    public class ValueType
    {
        public void MethodValueType() 
        {
            //numOne and numTwo varibles are the value types.
            int numOne = 12;
            int numTwo = numOne;
            numTwo = 10;
            Console.WriteLine(numOne);
            Console.WriteLine(numTwo);

        }
    }
}
