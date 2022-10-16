using System;

namespace task1
{
    class Number
    {
        public static void Main()
        {
            int sum = 0;

            Console.Write("Enter the number:\t");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }

            }
            Console.WriteLine(sum);
        }

    }
}