using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = GetInformation();
            Show(info);
        }

        static void Show((string Name, string Surname, int Age, bool ispet, string[] pet_names, string[] fav_colors) User)
        {
            Console.WriteLine($"Name is {User.Name}");
            Console.WriteLine($"Surname is {User.Surname}");
            Console.WriteLine($"Age is {User.Age}");
            Console.WriteLine($"have a pet {User.ispet}");
            for(int i = 0; i<User.pet_names.Length;i++)
                Console.WriteLine($"Pet name is {User.pet_names[i]}");
            for (int i = 0; i < User.fav_colors.Length; i++)
                Console.WriteLine($"Favorite color is {User.fav_colors[i]}");

        }
        static (string, string, int, bool, string[], string[]) GetInformation()
        {
            bool flag = true;
            int numofpets, numofcolors;
            (string Name, string Surname, int Age, bool ispet, string[] pet_names, string[] fav_colors) User;
            Console.WriteLine("Enter your name: ");
            User.Name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            User.Surname = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            User.Age = Convert.ToInt32(Console.ReadLine());

            while(!CheckNumbers(User.Age))
            {
                Console.WriteLine("Enter your age:(>0) ");
                User.Age = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Do you have a pet(enter yes or no):");
            if(Console.ReadLine()=="yes")
            {
                User.ispet = true;
                Console.WriteLine("Enter the number of your pets: ");
                numofpets = Convert.ToInt32(Console.ReadLine());
                while (!CheckNumbers(numofpets))
                {
                    Console.WriteLine("Enter the number of pets(>0): ");
                    numofpets = Convert.ToInt32(Console.ReadLine());
                }
                User.pet_names = SetPetNames(numofpets);
            }
            else
            {
                User.ispet = false;
                User.pet_names = new string[0];
            }
            Console.WriteLine("Enter number of your favorite colors: ");
            numofcolors = Convert.ToInt32(Console.ReadLine());
            while (!CheckNumbers(numofcolors))
            {
                Console.WriteLine("Enter the number of colors(>0): ");
                numofcolors = Convert.ToInt32(Console.ReadLine());
            }
            User.fav_colors = new string[numofcolors];
            User.fav_colors = SetFavColors(numofcolors);
            return User;
        }

        static string[] SetPetNames(int count)
        {
            var Names = new string[count];
            for(int i=0; i<count; i++)
            {
                Console.WriteLine($"Enter the name of a {0} pet", i+1);
                Names[i] = Console.ReadLine();
            }
            return Names;
        }

        static string[] SetFavColors(int count)
        {
            var Colors = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter the color ");
                Colors[i] = Console.ReadLine();
            }
            return Colors;
        }

        static bool CheckNumbers(int number)
        {
            if (number <= 0)
                return false;
            else
                return true;
        }
    }
}
