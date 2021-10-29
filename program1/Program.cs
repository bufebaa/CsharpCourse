using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Dasha";
            byte MyAge = 18;
            bool HaveIApet = true;
            double MyShoeSize = 38;
            Console.WriteLine("My name is "+ MyName);
            Console.WriteLine("My age is "+ MyAge);
            Console.WriteLine("Do I have a pet? : "+ HaveIApet);
            Console.WriteLine("My shoe size is "+ MyShoeSize);
            Console.WriteLine("\u0003");
            Console.ReadKey();
        }
    }
}
