using System;

namespace task1
{
    class Task
    {
        public static void Main()
        {
            Console.Write("Enter the number of rows:\t");
            int number = int.Parse(Console.ReadLine());
            int i, j, k;
            for (i = 1; i <= number; i++)
            {
                for (k = 0; k < number - i; k++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j < i*2; j++)
                {
                    if (j == i - 1)
                    {
                        Console.Write("# ");
                    } else 
                    {
                        Console.Write("#");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}