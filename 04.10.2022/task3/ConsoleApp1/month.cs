using System;

namespace task_three
{
    class Month
    {
        static void Main()
        {
            Console.Write("Enter the number of current month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 1 || month == 2 || month == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (month > 2 && month < 6)
            {
                Console.WriteLine("Spring");
            }
            else if (month > 5 && month < 9)
            {
                Console.WriteLine("Summer");
            }
            else if (month > 8 && month < 12)
            {
                Console.WriteLine("Autumn");
            }

        }
    }
}