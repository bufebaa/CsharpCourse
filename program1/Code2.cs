using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Code2
    {
        enum DaysOfWeeks : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Semaphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }

        public static void Task_with_enums()
        {
            DayOfWeek MyFavDay;
            MyFavDay = DayOfWeek.Friday;
            Console.WriteLine(MyFavDay);

            Semaphore Lighcolor;
            Lighcolor = Semaphore.Green;
            Console.WriteLine(Lighcolor);
        }

    }
}
