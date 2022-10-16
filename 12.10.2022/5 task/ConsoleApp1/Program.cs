using System;

namespace task5{
    class Task
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            int beg = int.Parse(Console.ReadLine());
            Console.Write("Enter the last number: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Enter the step: ");
            int step = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = beg;

            if (beg > end)
            {
                Console.WriteLine("0");
            }
            else if (beg == end)
            {
                Console.WriteLine(beg);
            }
            else
            {
                do
                {
                    sum += number;
                    number += step;
                } while (number <= end);
                Console.WriteLine(sum);
            }
        }
    }
}