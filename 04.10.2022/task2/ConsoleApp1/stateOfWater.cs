using System;

namespace task_two
{
    class Water
    {
        static void Main()
        {
            Console.Write("Enter the temperature of the water: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 100)
            {
                Console.WriteLine("Gaseous state");
            }
            else if (temp < 100 && temp > 0) 
            {
                Console.WriteLine("Liqiud state");
            }
            else if (temp <= 0)
            {
                Console.WriteLine("Solid state");
            }
        }

    }
}