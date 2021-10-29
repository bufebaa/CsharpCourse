using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Code1
    {
        public static void Task1()
        {
            const string MyName = "Dasha";
            byte MyAge = 18;
            bool HaveIApet = true;
            double MyShoeSize = 38;
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? : " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);
            Console.WriteLine("\u0003");
            Console.ReadKey();
        }
    }
}
