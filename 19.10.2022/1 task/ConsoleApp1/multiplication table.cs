using System;

namespace task1
{
    class Task
    {
        static void Main()
        {
            int num;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    num = i * j; 
                    if  (num >= 10)
                    {
                        Console.Write(num + "  ");
                    }
                    else
                    {
                        Console.Write(num + "   ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}