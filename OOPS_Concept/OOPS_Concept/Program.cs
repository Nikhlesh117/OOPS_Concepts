using System.Security.Cryptography.X509Certificates;

namespace OOPS_Concept
{
    class Program: Abstraction
    {
        public static void Main(string[] args)
        {
            //This is Interface
            //ClassName name = new ClassName();
            //name.withoutImplementionMethod();
            //Constrctor par = new Constrctor();
            //par.withoutImplementionMethod();

            //This is Enum
            //Console.WriteLine(Project.Nikhlesh);
            //int count = (int)Project.Nikhlesh;
            //Console.WriteLine(count);

            // This is Inheritance
            //Parentclass parent = new Parentclass();
            //Console.WriteLine(parent.name = "Nikh");
            //parent.TestName();
            //parent.Class();

            //This is abstract method
            //Program program = new Program();
            //program.NonAbstractMethod();
            //program.AbstractMethod();

            //Typecasting
            //Typecasting obj = new Typecasting();
            //obj.Typecast();

            //ValueType
            //ValueType obj = new ValueType();
            //obj.MethodValueType();

            //ReferenceType
            //ReferenceType ob = new ReferenceType();
            //int value = 5;
            //Console.WriteLine(value);
            //ob.MethodreferenceType(ref value);
            //Console.WriteLine(value);

            //Encapsulation
            Encapsulation encapsulation = new Encapsulation();
            Console.WriteLine(encapsulation.Name);
            encapsulation.Name = "Shiva";
            Console.WriteLine(encapsulation.Name);
            Console.WriteLine(encapsulation.RollNo = 8);

            //Polymorphism
            //OverLoading obj = new OverLoading();
            //obj.MethodOne();
            //obj.MethodOne(5);
            //obj.MethodOne(6,"hello");




            //name.PrintName();
            //name.GetName("Nk");
            //Console.ReadKey();
            //Constrctor h = new Constrctor();

            //Constrctor construct = new Constrctor("NK");


            /* // Create a default Animal object
             Animal myAnimal1 = new Animal();

             // Call the non-parameterized MakeSound method
             myAnimal1.MakeSound();

             // Call the parameterized Describe method
             myAnimal1.Describe();

             // Create an Animal object with a name of "Fluffy", a species of "cat", and an age of 5
             Animal myAnimal2 = new Animal("Fluffy", "cat");

             // Call the non-parameterized MakeSound method
             myAnimal2.MakeSound();

             // Call the parameterized Describe method
             myAnimal2.Describe();*/

            // Creating objects using both constructors
            //Addition obj1 = new Addition(5, 10);
            //Addition obj2 = new Addition();

            //// Calling the Sum method on the objects
            //Console.WriteLine("Sum of obj1: " + obj1.Sum());
            //Console.WriteLine("Sum of obj2: " + obj2.Sum());

            //Console.WriteLine("Substraction of obj2: " + obj2.Sub(4,2));


            //It will Override keyword the base class method in the derived class.
            Console.ReadLine();

        }
        //This is abstract method
        //It will override keyword the base class method in derived class.
        public override void AbstractMethod()
        {
            Console.WriteLine("This is override/implemented abstract method");
        }
    }
}