using System;

namespace task3
{
    class Task
    {
        static void Main()
        {
            Console.WriteLine("Enter the PIN: ");
            var pin = Console.ReadLine().ToCharArray();
            if (pin.Length == 4 || pin.Length == 6)
            {
                for (int i = 0; i < pin.Length; i++)
                {
                    if (pin.All(char.IsDigit))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                    break;
                }

            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}