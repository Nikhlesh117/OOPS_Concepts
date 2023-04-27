using System.Security.Cryptography.X509Certificates;

namespace AccessModifiers
{
    public class Program: Modifiers
    {
        public static void Main(string[] args)
        {
            Modifiers obj= new Modifiers();
            //public
            Console.WriteLine(obj.a);
            //private
            //obj.PrivateMethod();
            //protected
            Program program= new Program();
            Console.WriteLine(program.str);
            //protected internal
            Console.WriteLine(program.val);
        }
    }
}