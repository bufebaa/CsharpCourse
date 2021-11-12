using System;

namespace ifelselesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1.Tone();
            //Task1.Ttwo();
            //Task1.Tthree();
            //Task1.Tfour();
            //Task1.Tsix();
            int k = 0;
            while (k < 3)
            {
                (string Name, string[] Dishes) User;
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
               
                User.Dishes = new string[5];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.Dishes.Length; i++)
                {
                    User.Dishes[i] = Console.ReadLine();
                }
                Console.WriteLine("\n\n");
                k++;
            }

        }
    }
}
