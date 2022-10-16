using System;

namespace task2
{
    class Task2
    {
        static void Main()
        {
            //I need to convert the number into thr array of its digits to rearrange them.

            Console.Write("input the number\t");
            var input_number = Console.ReadLine().ToCharArray();
            int[] numbers = new int[input_number.Length];
            int t;
            int value = 0;

            // converting into {}
            for (int i = 0; i < input_number.Length; i++)
            {
                numbers[i] = input_number[i] - '0';
            }

            // rearranging
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        t = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = t;
                    }
                }
            }

            // converting into int
            for (int i = 0; i < numbers.Length; i++)
            {
                value *= 10;
                value += numbers[i];
            }

            Console.WriteLine(value);

        }
    }
}