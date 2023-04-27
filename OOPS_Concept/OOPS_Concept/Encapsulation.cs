using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Encapsulation
    {
        //It will hide sensitive data from the user
        // Declare feild or variable should be private
        // Property: get: Is read-Only and set : It is used to set data
        private string name = "Nk"; // Defined field is in private
        public string Name // property
        {
            get { return name; }
            set { name = value; }// name  = value: It will set or assign value to the name
        }
        public int RollNo 
        {
            get; set;
        }
    }
}
