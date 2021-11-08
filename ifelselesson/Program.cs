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
                (string Name, string LName, string Login, int LoginLength, bool Haspet, double Age, string[] favcolors) User;
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.LName = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var result = Console.ReadLine();
                if (result == "Yes")
                    User.Haspet = true;
                else
                    User.Haspet = false;
                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());
                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
                Console.WriteLine("\n\n");
                k++;
            }

        }
    }
}
