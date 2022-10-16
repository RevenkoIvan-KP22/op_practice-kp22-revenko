using System;

namespace task4
{
    class Task
    {
        static void Main()
        {
            Console.Write("Введіть число елементів масиву: \t");
            int num_of_el = int.Parse(Console.ReadLine());
            int[] arr = new int[num_of_el];
            int sum = 0;

            if (num_of_el == 0)
            {
                Console.WriteLine("Парне.");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"Input the {i + 1} number: \t");
                    arr[i] = int.Parse(Console.ReadLine());
                    sum += arr[i];
                }
                if (sum % 2 == 0)
                {
                    Console.WriteLine("Парне.");
                }
                else
                {
                    Console.WriteLine("Непарне.");
                }
            }

        }
    }
}