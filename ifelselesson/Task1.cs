using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelselesson
{

    class Task1
    {
        public static void Tone()
        {
            string name;
            
            Console.WriteLine("Enter your name: ");
            name = "Dasha";
            Console.WriteLine("Ваше имя по буквам");
            foreach(var i in name)
            {
                Console.Write(i+" ");
            }
        }

        public static void Ttwo()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int count = 0;
            foreach(var i in arr)
            {
                count += i;
            }
            Console.WriteLine("Sum: "+count);
        }

        public static void Tthree()
        {
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach(var num in array)
            {
                foreach(var item in num)
                {
                    Console.WriteLine(item+" ");
                }
            }
        }

        public static void Tfour()
        {
            int[] arr = { 1, -9, 4, 6, 8, -23, -8, 4 };
            int count = 0;
            foreach(var i in arr)
            {
                if (i < 0)
                    count += 1;
            }
            Console.WriteLine("Колличество отрицательных чисел: "+count);
        }

        public static void Tsix()
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int count = 0;
            foreach (var i in arr)
            {
                if (i > 0)
                    count += 1;
            }
            Console.WriteLine("Колличество положительных чисел: " + count);

        }

        public static void Tseven()
        {
            
        }
    }
}
