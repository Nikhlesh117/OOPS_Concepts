using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Addition
    {
        private int num1;
        private int num2;

        // Parameterized constructor
        public Addition(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }

        // Non-parameterized constructor
        public Addition()
        {
            num1 = 4;
            num2 = 4;
        }

        // Non-parameterize method
        public int Sum()
        {
            return num1 + num2;
        }
        //Parameterized method
        public int Sub(int a, int b)
        {
            return a- b;
        }
    }
}
