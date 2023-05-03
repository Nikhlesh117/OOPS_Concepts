using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    class Animal
    {
        // Fields
        private string name;
        private string species;

        // Non-parameterized constructor
        public Animal()
        {
            name = "Tom";
            species = "Dog";
        }

        // Parameterized constructor
        public Animal(string name, string species)
        {
            this.name = name;
            this.species = species;
        }

        // Non-parameterized method
        public void MakeSound()
        {
            Console.WriteLine("This animal makes a sound!");
        }

        // Parameterized method
        public void Describe()
        {
            Console.WriteLine("This animal is a " + species + ", named " + name );
        }
    }
}
