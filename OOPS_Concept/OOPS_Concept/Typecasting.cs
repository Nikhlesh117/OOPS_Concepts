using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    // TypeCasting is used to assign a value of one datatype to another datatype.
    //There are two types of casting implicit and explicit.
    //Implicit : implicitily mean automatically convert a small type to a large type.
    //char => int => long => float => double.
    //Explicit: Explicit casting is should be manually.
    //double => float => long => int => char.
    public class Typecasting
    {
        public void Typecast()
        {
            int valueOne = 10;
            double valueTwo = valueOne;
            //long add = valueOne + valueTwo;
            Console.WriteLine(valueOne);
            Console.WriteLine(valueTwo);
            double valueThree = 10.8;
            int valueFour = (int)valueThree;
            Console.WriteLine(valueFour);

        }
    }
}
