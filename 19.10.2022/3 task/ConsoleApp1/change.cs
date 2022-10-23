using System;

namespace task2
{
    class Task
    {
        public static void Main()
        {
            Console.Write("Your change?\t ");
            double change = double.Parse(Console.ReadLine());
            double change_number = Math.Round(change * 100);
            int c25 = 0, c10 = 0, c5 = 0, c1 = 0;
            Console.WriteLine(change_number);

            while (change_number >= 25)
            {
                c25++;
                change_number -= 25;
            } 

            while (change_number >= 10)
            {
                c10++;
                change_number -= 10;    
            }

            while (change_number >= 5)
            {
                c5++;
                change_number -= 5;
            }

            while (change_number >= 1)
            {
                c1++;
                change_number -= 1;
            }

            Console.WriteLine($"Used:\t{c25} * 25 cents, {c10} * 10 cents, {c5} * 5 cents, {c1} * 1 cent");
        }
    }
}