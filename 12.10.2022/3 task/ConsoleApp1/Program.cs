using System;

namespace task3
{
    class Task
    {
        static void Main()
        {
            Console.Write("Input the odd number of elements: \t");
            int num_of_el = int.Parse(Console.ReadLine());
            int[] arr = new int[num_of_el];

            if (num_of_el % 2 == 0)
            {
                Console.WriteLine("The number is even");
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Input the {i+1} number: \t");
                arr[i] = int.Parse(Console.ReadLine());
            }

            if (arr[0] == arr[1])
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[0] != arr[i])
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            else
            {
                if (arr[1] == arr[2])
                {
                    Console.WriteLine(arr[0]);
                }
                else
                {
                    Console.WriteLine(arr[1]);
                }
            }

        }
    }
}

