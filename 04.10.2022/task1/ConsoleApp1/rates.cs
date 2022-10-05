using System;

namespace task_one
{
    class Energy
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введіть значення лічильника на початку місяця: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть теперішнє значення лічильника: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result = secondNumber - firstNumber;
            double rate = 0;
            
            if (result <= 250)
            {
                rate = result * 1.44;
            }
            else if (result > 250) 
            {
                rate = (result - 250) * 1.68 + 250 * 1.44;
            }

            Console.WriteLine(rate);
        }
    }
}
