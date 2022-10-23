using System;

namespace task4
{
    class Task
    {
        static void Main()
        {
            Console.WriteLine("Enter your card number: ");
            string card_number = Console.ReadLine();
            int[] arr_card_number = new int[card_number.Length];
            int sum = 0;
            int n = card_number.Length;

            if (n > 19 || n < 13)
            {
                Console.WriteLine("Such a card doesn't exist.");
            }
            else
            {   // Converting card number into the array of its digits
                for (int i = 0; i < n; i++)
                {
                    arr_card_number[i] = card_number[i] - '0';
                }

                // Checking the payment system
                if (arr_card_number[0] == 3)
                {
                    Console.WriteLine("American Express");
                } 
                else if (arr_card_number[0] == 4)
                {
                    Console.WriteLine("Visa");
                }
                else if (arr_card_number[0] == 5)
                {
                    Console.WriteLine("Mastercard");
                }
                else if (arr_card_number[0] == 9)
                {
                    Console.WriteLine("Prostir");
                } 
                else
                {
                    Console.WriteLine("Unknown payment system.");
                }


                // Luhn Algorithm
                for (int i = n - 2; i >= 0; i-=2)
                {
                    arr_card_number[i] *= 2;
                    if (arr_card_number[i] > 9)
                    {
                        arr_card_number[i] -= 9;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    sum += arr_card_number[i];
                }
                
                if (sum % 10 == 0)
                {
                    Console.WriteLine("Your card is valid.");
                } 
                else
                {
                    Console.WriteLine("Your card is invalid");
                }
            }
        }
    }
}