using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class ReferenceType
    {
        public void MethodreferenceType(ref int num) 
        {
            num = num * num;
            Console.WriteLine(num);
        }
    }
}
